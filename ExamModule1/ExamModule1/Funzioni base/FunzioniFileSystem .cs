using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.IO;


namespace ExamModule1
{
          public static class FunzioniFileSystem
        {
            public static string AssicuratiCheEsistaCartellaDiArchivio()
            {
                var workingFolder = AppDomain.CurrentDomain.BaseDirectory;

                const string DataFolderName = "data";

                var folderPath = Path.Combine(workingFolder, DataFolderName);

                if (!Directory.Exists(folderPath))
                    Directory.CreateDirectory(folderPath);

                return folderPath;
            }

            private static string ComponiPercorsoFileDatabase(string archiveFolder)
            {
                const string DataBaseFileName = "database.txt";

                string databasePath = Path.Combine(archiveFolder, DataBaseFileName);

                return databasePath;
            }

            internal static void AggiungiTestoAFileDatabase(string testoDiProva, string archiveFolder)
            {
                var databasePath = ComponiPercorsoFileDatabase(archiveFolder);

                if (!File.Exists(databasePath))
                {
                    using (StreamWriter writer = File.CreateText(databasePath))

                    {
                        writer.WriteLine(testoDiProva);
                        writer.Close();
                    }
                }
                else
                {
                    using (StreamWriter writer = File.AppendText(databasePath))

                    {
                        writer.WriteLine(testoDiProva);
                        writer.Close();
                    }
                }
            }


            public static void CreaStrutturaPerConservazioneDati()
            {
                var workingFolder = AppDomain.CurrentDomain.BaseDirectory;

                const string DataFolderName = "data";
                const string DataBaseFileName = "database.txt";

                var folderPath = Path.Combine(workingFolder, DataFolderName);

                if (!Directory.Exists(folderPath))
                    Directory.CreateDirectory(folderPath);

                string databasePath = Path.Combine(folderPath, DataBaseFileName);
                Debug.WriteLine("databasePath:" + databasePath);

                if (!File.Exists(databasePath))
                {
                    using (StreamWriter writer = File.CreateText(databasePath))

                    {
                        writer.WriteLine("Questa è una prova di creazione!!!");
                        writer.Close();
                    }

                }
                else
                {
                    using (StreamWriter writer = File.AppendText(databasePath))

                    {
                        writer.WriteLine("Questa è una prova di modifica!!!");
                        writer.Close();
                    }
                }
            }

            
               
        }
    }

