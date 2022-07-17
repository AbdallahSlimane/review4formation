using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AvisFormationCore.Web.Models
{
    public class EnvoieEmailModel
    {
        public string Nom { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [StringLength(2000)]
        public string Message { get; set; }
    }
}
