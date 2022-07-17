using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Data
{
    public class FormationMemoryRepository : IFormationRepository
    {

        private List<Formation> _formations = new List<Formation>();

        public FormationMemoryRepository()
        {
            _formations.Add(new Formation { Id = 1, Nom = "Créer votre site web avec spring boot et angular", NomSeo = "spring-angular", Description = "Devenez pro et créer votre site web avec spring boot et angular" });
            _formations.Add(new Formation { Id = 2, Nom = "Créer votre application mobile avec flutter", NomSeo = "flutter", Description = "Créer votre application mobile avec flutter étape par étape" });
            _formations.Add(new Formation { Id = 3, Nom = "Apprendre le clean code", NomSeo = "clean-code", Description = "comment faire du code propre" });
            _formations.Add(new Formation { Id = 4, Nom = "Devenez pro gestion de base de donnée", NomSeo = "base-de-donnee", Description = "gérer votre base de donnée" });
        }

        public List<Formation> GetFormations(int nombre)
        {

            return _formations.OrderBy(qu => Guid.NewGuid()).Take(nombre).ToList();

        }

        public List<Formation> GetAllFormations()
        {
            return _formations;
        }

        public Formation GetFormationById(int iIdFormation)
        {
          return _formations.Where(f => f.Id == iIdFormation).FirstOrDefault();
        }

        public Formation GetFormationByNomSeo(string nomSeo)
        {
            return null;
        }
    }
}
