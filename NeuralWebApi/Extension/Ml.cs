using Microsoft.ML;
using Microsoft.ML.Data;
using Microsoft.ML.Trainers;
using NeuralWebApi.Data;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Reflection;
using static Microsoft.ML.DataOperationsCatalog;

namespace NeuralWebApi.Extension
{
    public static class Ml
    {
        public static IDataView LoadData(this MLContext mlContext, List<TrainData> data) {
            IDataView dataView = mlContext.Data.LoadFromEnumerable(data);
            dataView = mlContext.Data.Cache(dataView);
            return dataView;
        }
        public static ITransformer BuildAndTrainModel(this MLContext mlContext, IDataView splitTrainSet) {
            var options = new SdcaMaximumEntropyMulticlassTrainer.Options {
                // Make the convergence tolerance tighter.
                ConvergenceTolerance = 0.05f,
                // Increase the maximum number of passes over training data.
                MaximumNumberOfIterations = 30,
            };

            var pipeline =
                mlContext.Transforms.Conversion.MapValueToKey("Label")
                .Append(mlContext.MulticlassClassification.Trainers
                .SdcaMaximumEntropy(options));

            var model = pipeline.Fit(splitTrainSet);

            return model;
        }
        public static string Evaluate(this MLContext mlContext, ITransformer model, IDataView splitTestSet) {

            var predictions = model.Transform(splitTestSet);
            var metrics = mlContext.MulticlassClassification.Evaluate(predictions);
            return JsonConvert.SerializeObject(metrics);

        }
        public static string[] getprop() {
            List<string> Prop = new List<string>();
            PropertyInfo[] props = typeof(TrainData).GetProperties();
            foreach (PropertyInfo prp in props) {
                if (prp.Name != "Label") {
                    Prop.Add(prp.Name);
                }
            }
            return Prop.ToArray();
        }
    }
}
