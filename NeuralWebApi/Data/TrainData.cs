using Microsoft.ML.Data;

namespace NeuralWebApi.Data
{
    public class TrainData
    {
        public uint Label { get; set; }
        [VectorType(20)]
        public float[] Features { get; set; }
    }
}
