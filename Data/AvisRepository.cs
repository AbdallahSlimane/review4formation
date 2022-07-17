using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Data
{
    public class AvisRepository : IAvisRepository
    {

        MonDbContext _context;

        public AvisRepository(MonDbContext context)
        {
            _context = context;
        }

        public void SaveAvis(string commentaire, string nom, string idFormation, string notes)
        {

            int iIdFormation = -1;
            if (!Int32.TryParse(idFormation, out iIdFormation))
            {
                return;
            }

            double dNotes = -1;
            if (!Double.TryParse(notes,NumberStyles.Any,CultureInfo.InvariantCulture, out dNotes))
            {
                return;
            }

            var avis = new Avis();
            avis.Commentaire = commentaire;
            avis.NomUtilisateur = nom;
            avis.FormationId = iIdFormation;
            avis.Notes = dNotes;


            _context.Avis.Add(avis);
            _context.SaveChanges();
        }
    }
}
