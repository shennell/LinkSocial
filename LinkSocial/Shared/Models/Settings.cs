using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkSocial.Shared.Models
{
    public class Settings
    {
        public int ID { get; set; }
        public string PageName { get; set; }
        public string ProfilePictureName { get; set; }
        [MaxLength(100, ErrorMessage = "Title must be 100 characters or less.")]
        public string PageTitle { get; set; }
        [MaxLength(500, ErrorMessage = "Introduction must be 500 characters or less.")]
        public string IntroText { get; set; }
        public bool HideProfilePic { get; set; } = false;
        public bool HideTitle { get; set; } = false;

        public bool HideIntroText { get; set; } = false;
        public int Theme { get; set; }
    }
}
