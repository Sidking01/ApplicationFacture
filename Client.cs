using System;
namespace AppliFacturation
{
	public class Client
	{
        private static int Idcounter = 0;
        private int idClient { get; set; }

        public int IdClient
        {
            get
            {
                return idClient;
            }
        }

        private string nomClient { get; set; }
        public string getNomClient()
        {
            return nomClient;
        }

        public string setNomClient(string nom)
        {
            nomClient = nom;
            return nom;
        }

        private string mail { get; set; }
        public string Mail
        {
            get
            {
                return mail;
            }
        }

        public Client(string leNomClient, string leMail)
		{
            setNomClient(leNomClient);
            mail = leMail;
		}

        public Client() { }
	}
}

