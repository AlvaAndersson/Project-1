using System;

namespace Project_1
{
    class Program
    {
        static void Main(string[] args)
        {
           

            Console.WriteLine("Välkommen till 21:an!");
            int min = 1;
            int max = 11;


            Random random = new Random();

            string senasteVinnaren = "ingen har vunnit än";

            string menyVal = "0";
            while (menyVal != "4")

            //Meny
            {



                Console.WriteLine("Välj ett av alternativen");
                Console.WriteLine("1. Spela 21:an");
                Console.WriteLine("2. Visa senaste vinnaren");
                Console.WriteLine("3. Spelets regler");
                Console.WriteLine("4. Avsluta programmmet");

                menyVal = Console.ReadLine();

                switch (menyVal)
                {
                    //Spelet
                    case "1":
                        //Bådas poäng sätts till 0
                        int spelaresPoäng = 0;
                        int datorsPoäng = 0;

                        //Två kort per spelare
                        Console.WriteLine("Båda får 2 kort");
                        datorsPoäng += random.Next(min, max);
                        datorsPoäng += random.Next(min, max);
                        spelaresPoäng += random.Next(min, max);
                        spelaresPoäng += random.Next(min, max);

                        //Spelaren får välja om hen vill dra ett till kort
                        String tillKort = " ";
                        while (tillKort != "ja" && spelaresPoäng <= 21)
                        {
                            Console.WriteLine($"Ditt poäng är {spelaresPoäng} och datorns är {datorsPoäng}");
                            Console.WriteLine("Vill du dra ett nytt kort?");
                            Console.WriteLine("Svara ja eller nej.");
                            tillKort = Console.ReadLine();

                            switch (tillKort)
                            {
                                case "ja":
                                    int nyPoäng = random.Next(min, max);
                                    spelaresPoäng += nyPoäng;
                                    Console.WriteLine($"Ditt kort var {nyPoäng}");
                                    Console.WriteLine($"ditt nya poäng är {spelaresPoäng}");
                                    break;

                                case "nej":
                                   
                                    break;

                                default:
                                    Console.WriteLine($"Ditt svar är inte giltigt");
                                    break;

                            }
                        }

                        if (spelaresPoäng > 21)
                        {
                            Console.WriteLine("Du har mer än 21 poäng och har förlorat");
                            Console.WriteLine("Bättre lycka nästa gång");
                            Console.WriteLine();
                            break;
                        }

                        while (datorsPoäng < spelaresPoäng && datorsPoäng <= 21)
                        {
                            int datorsNyaPoäng = random.Next(min, max);
                            datorsPoäng += datorsNyaPoäng;
                            Console.WriteLine($"Datorn drog kortet {datorsNyaPoäng}");
                        }

                        Console.WriteLine($"Din poäng är: {spelaresPoäng}");
                        Console.WriteLine($"Datorns poäng är: {datorsPoäng}");

                        if (datorsPoäng > 21)
                        {
                            Console.WriteLine("Grattis du har vunnit");
                            Console.WriteLine("Skriv in ditt namn");
                            senasteVinnaren = Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("Datorn har vunnit");
                            senasteVinnaren = "Datorn";
                        }
                        break;

                    //Senaste vinnaren
                    case "2":
                        Console.WriteLine($"senaste vinnaren är : {senasteVinnaren}");
                        break;

                    //Regler
                    case "3":
                        Console.WriteLine("Ditt mål är att tvinga datorn att få mer än 21 poämg.");
                        Console.WriteLine("Du får poäng genom att dra kort, varje kort är värt 1-10 poäng.");
                        Console.WriteLine("Den som får mer än 21 poäng förlorar.");
                        Console.WriteLine("Spelet startar med att du och datorn får dra två kort i början.");
                        Console.WriteLine("Därefter får du dra kort tills du är nöjd eller eller får över 21");
                        Console.WriteLine("När du är färdig drar datorn kort tills den har");
                        Console.WriteLine("mer poäng än dig eller över 21.");
                        break;

                    //Avsluta
                    case "4":

                        Console.WriteLine();
                        break; 
                    
                        

                
                       

                    

                }
            }



        }
    }
}
