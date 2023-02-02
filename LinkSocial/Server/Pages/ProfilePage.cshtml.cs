using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LinkSocial.Server.Data;
using LinkSocial.Shared.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LinkSocial.Server.Pages
{
    public class ProfilePageModel : PageModel
    {

        [BindProperty(SupportsGet = true)]
        public string PageName { get; set; }
        private readonly ISettingsData _settingsData;
        private readonly ILinkData _linkData;
        public IEnumerable<Link> Links { get; set; }
        public Settings PageSettings { get; set; }
        public ProfilePageModel(ILinkData linkData, ISettingsData settingsData)
        {
            _linkData = linkData;
            _settingsData = settingsData;
        }
        

        public void OnGet()
        {
            Links = _linkData.GetActiveLinks(PageName);
            PageSettings = _settingsData.GetSettings(PageName);
            if(PageSettings == null)
            {
                PageSettings = new Settings
                {
                    PageName = "",
                    ProfilePictureName = "",
                    PageTitle = "",
                    IntroText = "",
                    HideIntroText = false,
                    HideProfilePic = false,
                    HideTitle = false,
                    ID = 1,
                    Theme = 0
                };
            }
        }
    }
}
