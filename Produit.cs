using System;
namespace AppliFacturation
{
	public class Produit
	{
		private static int Idcounter = 0;
		private int identifiant { get; set; }
		public int Indentifiant
		{
			get
			{
				return identifiant;
			}
		}

		private string nomProduit { get; set; }
        public string NomProduit
        {
            get
            {
                return nomProduit;
            }
        }

        /*private int quantiteProduit { get; set; }
        public int QuantiteProduit
        {
            get
            {
                return quantiteProduit;
            }
        }*/

        private double prixProduit { get; set; }
        public double PrixProduit
        {
            get
            {
                return prixProduit;
            }
        }
        public Produit(string lenom,double lePrix)
		{
            identifiant = Idcounter++;
            nomProduit = lenom;
            prixProduit = lePrix;
		}
	}
}

