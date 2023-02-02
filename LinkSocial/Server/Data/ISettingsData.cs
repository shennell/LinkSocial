using LinkSocial.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LinkSocial.Server.Data
{
    public interface ISettingsData
    {
        Settings GetSettings(string pageName);
        void AddSettings(Settings settings);
        void UpdateSettings(Settings settings);

    }
}
