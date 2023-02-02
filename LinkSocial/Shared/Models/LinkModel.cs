using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LinkSocial.Shared.Models
{
    public class LinkModel
    {
        /*[Required(ErrorMessage = "Title is required.")]*/
        /*[MaxLength(100, ErrorMessage = "Title must be 100 characters or less.")]*/
        public string Title { get; set; }
        /*[Required(ErrorMessage = "URL is required.")]*/
        /*[MaxLength(300, ErrorMessage = "URL must be 300 characters or less.")]*/
        public string URL { get; set; }
        public bool Active { get; set; } = true;
    }
}
