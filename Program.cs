using System;
namespace Caesar_Cipher
{
    class Program
    {
        static void Main()
        {
            do
            {
                bool hotovo = false;
                Console.WriteLine("Chcete zasifrovat alebo desifrovat text: (Napiste zakodovanie pre zakodovanie a desifrovanie pre desifrovanie)");
                string odpoved_ = Console.ReadLine();
                string odpoved = odpoved_.ToLower();

                if (odpoved == "zakodovanie")
                {
                    Console.WriteLine("Zadajte spravu na zakodovanie");
                    string sprava = Console.ReadLine();
                    Console.WriteLine(Zakodovanie(sprava));
                    hotovo = true;
                    break;
                }
                else if (odpoved == "desifrovanie")
                {
                    Console.WriteLine("Zadajte spravu na desifrovanie");
                    string sprava = Console.ReadLine();
                    Console.WriteLine(Desifrovanie(sprava));
                    hotovo = true;
                    break;
                }
                else Console.WriteLine("Napisali ste zle vstup");

            } while (true);

        }

        static string Zakodovanie(string sprava)
        {
                char[] abeceda = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
                char[] spravaChar = sprava.ToCharArray();
                char[] zakodovaneChar = new char[spravaChar.Length];

                    for (int i = 0; i<spravaChar.Length; i++)
                    {
                        
                        char pismeno = spravaChar[i];
                        int pismenoPozicia = Array.IndexOf(abeceda, pismeno);
                        int pismeno_nova_pozicia = (pismenoPozicia + 3) % 26;
                        zakodovaneChar[i] = abeceda[pismeno_nova_pozicia];
                    }
                string zakodovanaSprava = String.Join("", zakodovaneChar);
                return zakodovanaSprava;
        }

        static string Desifrovanie(string sprava)
        {
            char[] abeceda = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            char[] spravaChar = sprava.ToCharArray();
            char[] zakodovaneChar = new char[sprava.Length];
                for (int i = 0; i < sprava.Length; i++)
                {
                    char pismeno = spravaChar[i];
                    int pismenoPozicia = Array.IndexOf(abeceda,pismeno);
                    int pismeno_nova_pozicia = (pismenoPozicia - 3) % 26;
                    zakodovaneChar[i] = abeceda[pismeno_nova_pozicia];
                }

            string desifrovanaSprava = String.Join("", zakodovaneChar);
            return desifrovanaSprava;
        }
    }
}
