using System;
using System.Collections.Generic;
using System.Text;

namespace ExamModule1
{
    public static class CreaStampaESalvaLista
    {
  
        public static void InserisciProdottiInLista ()
            {
            Console.Write("Inserisci il numero di prodotti tra 1 e 10:");
            int Inserimento = InserisciNumero.LeggiNumeroDaConsole(1, 10);

            List<Product> prodotti = new List<Product>();

            for (int index = 0; index < Inserimento; index++)
            {
            AggiungiProdottoAListaInPosizione(prodotti);
            }
            

            StampaListaProdotti(prodotti);

            foreach (Product product in prodotti)
            {
                SalvaProdottoInFile(product);
            }

            InserisciNumero.Uscita();
        }
       public static void AggiungiProdottoAListaInPosizione(List <Product> prodotti)
    {
        Console.Write("Codice prodotto: ");
        var code = Console.ReadLine();
        Console.Write("Nome prodotto: ");
        var name = Console.ReadLine();

        Product product = new Product
        {
            Code = code,
            Name = name
        };

        prodotti.Add(product);

        

    }
    

                    
        private static void StampaListaProdotti(List<Product> prodotti)
        {
            Console.WriteLine("*** Visualizzazione contenuto lista prodotti***");
            for (var index = 0; index < prodotti.Count; index++)
            {
                Console.WriteLine($" => {prodotti[index].Code}, {prodotti[index].Name}");
            }
        }

        

        public static void SalvaProdottoInFile(Product product)
        {
            var archiveFolder = FunzioniFileSystem.AssicuratiCheEsistaCartellaDiArchivio();
            
            string datiDelProdottoInFormatoStringa = ConvertiProdottoInStringa(product);

            FunzioniFileSystem.AggiungiTestoAFileDatabase(datiDelProdottoInFormatoStringa, archiveFolder);
        }

        private static string ConvertiProdottoInStringa(Product product)
        {
            return $"{product.Code},{product.Name}";
        }


    }
}
