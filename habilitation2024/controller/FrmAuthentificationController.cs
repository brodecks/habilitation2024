using habilitation2024.dal;
using habilitation2024.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace habilitation2024.controller
{
    public class FrmAuthentificationController
    {
        // objet d'accès aux opérations possibles sur Developpeur
        private readonly DeveloppeurAccess developpeurAccess;
        // Récupère les acces aux données
        public FrmAuthentificationController()
        {
            developpeurAccess = new DeveloppeurAccess();
        }
        public Boolean ControleAuthentification(Admin admin)
        {
            return developpeurAccess.controleAuthentification(admin);
        }
    }
}
