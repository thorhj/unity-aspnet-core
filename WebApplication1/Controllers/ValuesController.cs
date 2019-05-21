using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Services;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IDataService _dataService;

        public ValuesController(IDataService dataService)
        {
            _dataService = dataService;
        }

        [HttpGet]
        [Route("set/{key}")]
        public async Task SetValue(string key)
        {
            await _dataService.SetValue(key, "a");
        }

        [HttpGet]
        [Route("get/{key}")]
        public async Task<string> GetValue(string key)
        {
            return await _dataService.GetValue(key);
        }
    }
}
