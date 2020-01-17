using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using NeuralWebApi.Data;
using NeuralWebApi.Singleton;

namespace NeuralWebApi.Controllers
{
    [Route("api/[action]")]
    [ApiController]
    public class ApiController : ControllerBase
    {
        private readonly IDataService _data;
        public ApiController(IDataService data) {
            this._data = data;
        }
        [HttpGet]
        public string Get() {
            return "OK";
        }

        [HttpPost]
        public string Learn(List<TrainData> data) {
            return $"[Train]:\n{_data.Train(data)}\n[EndTrain]\n[Evaluate]:\n{_data.Evaluate()}\n[EndEvaluate]";
        }

        [HttpPost]
        public string Test(List<TrainData> data) {
            return _data.Test(data);
        }
    }
}