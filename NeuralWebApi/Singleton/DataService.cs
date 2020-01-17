using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.ML;
using Microsoft.ML.Data;
using NeuralWebApi.Data;
using NeuralWebApi.Extension;
using Newtonsoft.Json;
using static Microsoft.ML.DataOperationsCatalog;


namespace NeuralWebApi.Singleton
{
    public class DataService : IDataService
    {
        MLContext mlContext;
        ITransformer model;
        IDataView splitDataView;
        public DataService() {

        }

        public string Train(List<TrainData> data) {
            try {
                mlContext = new MLContext();
                splitDataView = Metrics.Look(() => mlContext.LoadData(data));
                model = Metrics.Look(() => mlContext.BuildAndTrainModel(splitDataView));
                return "Ok";
            } catch(Exception e) {
                return e.StackTrace;
            }
        }

        public string Test(List<TrainData> data) {
            try {

                var testData = mlContext.Data.LoadFromEnumerable(data);

                // Run the model on test data set.
                var transformedTestData = model.Transform(testData);

                // Convert IDataView object to a list.
                var predictions = mlContext.Data.CreateEnumerable<ModelOutput>(transformedTestData,reuseRowObject: false).ToList();

                return JsonConvert.SerializeObject(predictions);
            } catch(Exception e) {
                return e.StackTrace;
            }
            
        }

        public string Evaluate() {
            try {
                return Metrics.Look(() => mlContext.Evaluate(model, splitDataView));
            } catch(Exception e) {
                return e.StackTrace;
            }
        }

    }
}
