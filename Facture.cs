using System;
using static AppliFacturation.Client;

namespace AppliFacturation
{
	public class Facture
	{
		//Declaration des attributs
        private static int Idcounter = 0;
        private int numeroFacture { get; set; }

        public int NumeroFacture
        {
            get
            {
                return NumeroFacture;
            }
        }
        
		private string nomEntreprise { get; set; }
		public string NomEntreprise
		{
			get
			{
				return nomEntreprise;
			}
		}

		private string produit { get; set; }
        public string Produit
        {
            get
            {
                return produit;
            }
        }

        private int quantite { get; set;}
        public int Quantite
        {
            get
            {
                return quantite;
            }
        }

        private double prixProduit { get; set; }
        public double PrixProduit
        {
            get
            {
                return prixProduit;
            }
        }

        private DateOnly dateCreation { get; set; }
        public DateOnly DateCreation
        {
            get
            {
                return dateCreation;
            }
            set
            {
                dateCreation = DateOnly.FromDateTime(DateTime.Today);
            }
        }

        private double montantTotal;
        public double getMontantTotal()
        {
            return montantTotal;
        }

        //permet d'attribuer le montant total total de la facture apres calcule
        public void setMontantTotal(double total)
        {
            montantTotal = total;
        }
		public Facture(string lentreprise, string leproduit,int laquantite,double leprix)
		{
            numeroFacture = Idcounter++;
            nomEntreprise = lentreprise;
            //nomDuClient = leclient;
            produit = leproduit;
            quantite = laquantite;
            prixProduit = leprix;
		}
	}
}

