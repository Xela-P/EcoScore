using EcoScore.Modele;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace EcoScore
{
    public class Controleur
    {
        private static Modele unModele = new Modele("localhost", "eco_score", "root", "");

        public static void InsertClient(Client unClient)
        {
            unModele.InsertClient(unClient);
        }

        public static void UpdateClient(Client unClient)
        {
            unModele.UpdateClient(unClient);
        }

        public static Client SelectWhereClient(int idClient)
        {
            return unModele.SelectWhereClient(idClient);
        }
        public static List<Client> SelectAllClient()
        {
            return unModele.SelectAllClient();
        }


    }
}