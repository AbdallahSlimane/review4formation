using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AvisFormationCore.Web.Models
{
    public class LaisserUnAvisModel
    {
        [StringLength(100, ErrorMessage = "Le texte dépasse la taille maximale")]
        public string Commentaire { get; set; }

        //[Required]
        //public string Nom { get; set; }

        [Required]
        public string Notes{ get; set; }

        [Required]
        public string IdFormation { get; set; }

        public string NomFormation{ get; set; }
    }
}
