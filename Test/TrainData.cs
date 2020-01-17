using Microsoft.ML;
using Microsoft.ML.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Test.Models;
namespace Test
{
    public class TrainData
    {
        public uint Label { get; set; }

        [VectorType(20)]
        public float[] Features { get; set; }

    }
}