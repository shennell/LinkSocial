using LinkSocial.Server.Data;
using LinkSocial.Shared.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LinkSocial.Server.Controllers
{
    [ApiController]
    public class SettingsController : ControllerBase
    {
        private readonly ISettingsData _settingsData;

        public SettingsController(ISettingsData settingsData)
        {
            _settingsData = settingsData;
        }

        [HttpPost]
        [Route("api/Settings/Create")]
        public void Create([FromBody] Settings settings)
        {
            if (ModelState.IsValid)
                _settingsData.AddSettings(settings);
        }

        [HttpGet]
        [Route("api/Settings/{pageName}")]
        public Settings GetSettings(string pageName)
        {
            return _settingsData.GetSettings(pageName);
        }


        [HttpPost]
        [Route("api/Settings/UpdateSettings")]
        public void UpdateSettings([FromBody] Settings settings)
        {
            if (ModelState.IsValid)
                _settingsData.UpdateSettings(settings);
        }




    }
}
