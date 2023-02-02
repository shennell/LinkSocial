using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkSocial.Shared.Models
{
    public class Link
    {
        public int ID { get; set; }
        public string PageName { get; set; }

        [MaxLength(100, ErrorMessage = "Title must be 100 characters or less.")]
        public string Title { get; set; }
        [MaxLength(300, ErrorMessage = "URL must be 300 characters or less.")]
        public string URL { get; set; }
        public int Position { get; set; }
        public bool Active { get; set; } = true;
    }
}
