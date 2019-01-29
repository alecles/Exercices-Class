using System;
using System.Collections.Generic;
using System.Text;

namespace Reconstruction
{
    public enum TypeBatiment {Residance,Commercial,Musee};
    class Batiment
    {
        

        private int nbPieces;
        private string nom;
        private int prixConstruction;
        private int largeur;
        private int longueur;
        private TypeBatiment typeBatiment;

        public void Initialiser(string _nom,int _nbPieces, int _prixConstruction, int _largeur, int _longueur, TypeBatiment _typeBatiment)
        {
            nom = _nom;
            nbPieces = _nbPieces;
            prixConstruction = _prixConstruction;
            largeur = _largeur;
            longueur = _longueur;
            typeBatiment = _typeBatiment;
        }

        public void Afficher()
        {
            Console.WriteLine(nom + " / " + nbPieces + " pieces/ "+prixConstruction+" $/ "+CalculerSurface()+" m2/ "+typeBatiment);
        }

        public string GetNom()
        {
            return nom;
        }

        public int GetNbPieces()
        {
            return nbPieces;
        }

        public int GetPrixConstruction()
        {
            return prixConstruction;
        }

        public int GetLongueur()
        {
            return longueur;
        }

        public int GetLargeur()
        {
            return largeur;
        }

        public TypeBatiment GetTypeBatiment()
        {
            return typeBatiment;
        }

        public int CalculerSurface()
        {
            return longueur * largeur;
        }




        



    }
}
