using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace Sample.Netcore.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SettingsController : ControllerBase
    {
        public IConfiguration Configuration { get; }

        public SettingsController(IConfiguration configuration)
        {
            this.Configuration = configuration;
        }

        // GET: api/Settings
        [HttpGet]
        public string Get()
        {
            var result =  Configuration["SampleSetting"];
            return result;
        }

        // GET: api/Settings/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(string id)
        {
            var result = Configuration[id];
            return result;
        }
    }
}
