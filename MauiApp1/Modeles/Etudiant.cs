using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Modeles
{
    internal class Etudiant
    {
        #region Attributs
        public static List<Etudiant> Collclasse = new List<Etudiant>();

        private string _nom;
        private string _prenom;
        private string _image;

        #endregion

        #region Constructeur
        public Etudiant(string nom, string prenom, string image)
        {
            _nom = nom;
            _prenom = prenom;
            _image = image;

            Etudiant.Collclasse.Add(this);
        }
        #endregion

        #region Getters/Setters

        public string Getnom()
        {
            return _nom;
        }
        public void Setnom(string nom)
        {
            _nom = nom;
        }
        public string Getprenom()
        {
            return _prenom;
        }
        public void Setprenom(string prenom)
        {
            _prenom = prenom;
        }
        public string Getimage()
        {
            return _image;
        }
        public void Setimage(string image)
        {
            _image = image;
        }

        #endregion

        #region Methodes
        #endregion
    }
}
