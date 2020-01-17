using Microsoft.ML.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NeuralWebApi.Data
{

    public class ModelOutput
    {
        // Original label.
        public uint Label { get; set; }
        // Predicted label from the trainer.
        public uint PredictedLabel { get; set; }

    }
}
