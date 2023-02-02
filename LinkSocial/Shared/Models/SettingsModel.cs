using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkSocial.Shared.Models
{
    public class SettingsModel
    {
        public string PageTitle { get; set; }
        public string IntroText { get; set; }

        public bool HideProfilePic { get; set; } = false;
        public bool HideTitle { get; set; } = false;
        public bool HideIntroText { get; set; } = false;
        public int Theme { get; set; } = 0;
    }
}
