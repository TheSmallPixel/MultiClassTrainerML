using NeuralWebApi.Data;
using System.Collections.Generic;

namespace NeuralWebApi.Singleton
{
    public interface IDataService
    {
        string Train(List<TrainData> data);

        string Test(List<TrainData> data);
        string Evaluate();
    }
}