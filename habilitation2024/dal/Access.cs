using habilitation2024.bddManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace habilitation2024.dal
{
    public class Access
    {
        // chaine de connexion à la bdd
        private static readonly string connectionString ="server=localhost; database=habilitation; user=habilitations; password=motdepasseuser;";
        // instance unique de la classe
        private static Access instance = null;
        // objet d'accès aux données
        public BddManager Manager { get; }

        private Access() 
        {
            try
            {
                Manager = BddManager.GetInstance(connectionString);
            }
            catch (Exception)
            {
                Environment.Exit(0);
            }
        }
        public static Access GetInstance()
        {
            if (instance == null)
            {
                instance = new Access();
            }
            return instance;
        }
    }
}
