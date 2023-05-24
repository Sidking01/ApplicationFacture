using System;
using static System.Console;
using static AppliFacturation.Produit;
namespace AppliFacturation
{
	public class CreationFacture
	{
        //liste pour recuperer les produits achetes
        List<Produit> lesProduits = new List<Produit>();

        public void Create()
		{
			WriteLine("Veuillez saisir le nom de l'entreprise :");
			string ent = ReadLine()!;

            WriteLine("Veuillez saisir le nom du client :");
            string clt = ReadLine()!;

            WriteLine("Veuillez saisir le nombre de produits achetes :");
            int qnt = Convert.ToInt32(ReadLine()!);
			WriteLine("Saisissez les noms des produits :");

			for (int i=0; i<qnt;i++)
			{
				string pNom = ReadLine()!;
				double pPrix = Convert.ToInt32(ReadLine()!);
				Produit p=new(pNom, pPrix);
				lesProduits.Add(p);
			}
        }
	}
}

