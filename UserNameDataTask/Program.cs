using System;

namespace UserNameDataTask
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada eesnime;
            //programm küsib kasutajal sisestada numbrit 1-3
            //kui kasutaja sisetab '1', siis kuvatakse kasutaja eesnime tagurpidi
            //kui kasutaja valib '2', siis kuvatakse kasutaja eesnime esimest tähte
            //kui kasutaja valib '3', siis kuvatakse kasutaja eesnime pikkust

            Console.WriteLine("Sisesta enda eesnimi:");
            string userName = Console.ReadLine();
            Console.WriteLine("sisesta arv 1-3, et valida järgmised tegevused: (1 - sinu nimi tagurpidi, 2 - kuvatakse sinu nime esimene täht, 3 - kuvatakse sinu nime pikkust");
            int userNumber = Convert.ToInt32(Console.ReadLine());
            if (userNumber == 1)
            {
                UserNameReverse(userName);
            }
            else if (userNumber == 2)
            {
                UserNameFirstLetter(userName);
            }
            else if (userNumber == 3)
            {
                UserNameLength(userName);
            }
            else
            {
                Console.WriteLine("Kena päeva!");
            }


            

        }

        public static void UserNameReverse(string userInput)
        {
            for (int i = userInput.Length - 1; i >= 0; i--)
            {
                Console.Write(userInput[i]);
            }
        }

        public static void UserNameFirstLetter(string userInput)
        {
            Console.WriteLine($"Sinu eesnime esimene täht on {userInput[0]}");
        }

        public static void UserNameLength(string userInput)
        {
            Console.WriteLine($"Sinu nimi on {userInput.Length} sümbolit pikk.");
        }
    }
}
