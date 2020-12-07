using System;
using System.Collections.Generic;
using System.Text;

namespace Facturation.Shared
{
    public class Facture
    {

        private string nom;
        private string numero;
        private string dateEmission;
        private string dateAttendu;
        private double montantDu;
        private double montantRegle;

        public Facture(string nom, string numero, string dateEmission, string dateAttendu, double montantDu, double montantRegle)
        {
            this.nom = nom;
            this.numero = numero;
            this.dateEmission = dateEmission;
            this.dateAttendu = dateAttendu;
            this.montantDu = montantDu;
            this.montantRegle = montantRegle;
        }

        public string getNom()
        {
            return this.nom;
        }

        public string getNumero()
        {
            return this.numero;
        }

        public string getDateEmission()
        {
            return this.dateEmission;
        }

        public string getDateAttendu()
        {
            return this.dateAttendu;
        }

        public double getMontantDu()
        {
            return this.montantDu;
        }

        public double getMontantRegle()
        {
            return this.montantRegle;
        }


    }
}
