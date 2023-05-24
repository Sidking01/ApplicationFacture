using System;
using static AppliFacturation.Enums;
using static AppliFacturation.Facture;
namespace AppliFacturation
{
	public class Paiement
	{

		private DateOnly datePaiement { get; set; }
        public DateOnly DatePaiement
        {
            get
            {
                return datePaiement;
            }
            set
            {
                datePaiement = DateOnly.FromDateTime(DateTime.Today);
            }
        }

        private double montant { get; set; }
        public double Montant
        {
            get
            {
                return montant;
            }
        }

        private Paiement modePaiement { get; set; }
        public Paiement ModePaiement
        {
            get
            {
                return modePaiement;
            }
        }

        public Paiement(double leMontant,Paiement leMode)
		{
            montant = leMontant;
            modePaiement = leMode;
		}
	}
}

