using System;

namespace Project_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
           //P1.1
            Console.WriteLine("Välj ett nummer mellan 1 och 10");

            int answer = int.Parse(Console.ReadLine());

            Random randomgenerator = new Random();

            int randomtal = randomgenerator.Next(1, 11);



            Console.WriteLine($"Talet var {randomtal}");

            if (randomtal == answer)
            {
                Console.WriteLine("Grattis du valde rätt nummer!");
            }
            else
            {
                Console.WriteLine("Tyvärr du gissade fel");
            }
          
            Random random = new Random();
            Console.WriteLine("Välj hur många tärningar du vill kasta");

            int answer1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Välj hur många sidor tärningen ska ha");

            int sidor = int.Parse(Console.ReadLine());

            for (int i = 0; i < answer1; i++)
            {
                int kast = random.Next(1, sidor + 1);
                Console.WriteLine($"Summan av ditt kast blev {i + 1}: { kast}");
            }
            */

            Console.WriteLine("Välkommen till 21:an!");
            int min = 1;
            int max = 11;

            Random random = new Random();

            string senasteVinnaren = "ingen har vunnit än";

            String menyVal = "0";
            while (menyVal != "4")

            //Meny
            {



                Console.WriteLine("Välj ett av alternativen");
                Console.WriteLine("1. Spela 21:an");
                Console.WriteLine("2. Visa senaste vinnaren");
                Console.WriteLine("3. Spelets regler");
                Console.WriteLine("4. Avsluta programmmet");

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
                        String tillKort = "a";
                        while (tillKort != "a")
                        {
                            Console.WriteLine($"Ditt poäng är {spelaresPoäng} och datorns är {datorsPoäng}");
                            Console.WriteLine("Vill du dra ett nytt kort?");
                            tillKort = Console.ReadLine();


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
                        {
                            Console.WriteLine("Hejdå");
                        }
                        break;   

                    
:
                }
            }



        }
    }
}
