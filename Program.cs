using System;
using System.Text;

namespace TicTacToe
{
    internal class Program
    {
        public static StringBuilder epito123 = new StringBuilder(" 1 | 2 | 3 ");
        public static StringBuilder epito456 = new StringBuilder(" 4 | 5 | 6 ");
        public static StringBuilder epito789 = new StringBuilder(" 7 | 8 | 9 ");
        static void Main(string[] args)
        {
            TicTacToe();
            
        }

        static void TicTacToe()
        {
            //megmutatja a mezot
            //beolvasassa az egyik mezot
            //atirja a mezot
            //kovetkezo jatekos valaszt mezot
            //megnezni h valaki nyert-e, ha tele a tabla dontetlen


            /*  Console.WriteLine(" 1 | 2 | 3 ");
                Console.WriteLine("___|___|___");
                Console.WriteLine(" 4 | 5 | 6 ");
                Console.WriteLine("___|___|___");
                Console.WriteLine(" 7 | 8 | 9 ");
                Console.WriteLine("   |   |   ");
                Console.WriteLine("");
            */


            XjatekosKore();
            OjatekosKore();
            XjatekosKore();
            OjatekosKore();
            XjatekosKore();
            OjatekosKore();
            XjatekosKore();
            OjatekosKore();
            XjatekosKore();


        }
        static void Cserelo(int beolvasas, char cserekarakter)
        {
            switch (beolvasas)
            {
                case 1:
                    epito123[1] = cserekarakter;
                    break;
                case 2:
                    epito123[5] = cserekarakter;
                    break;
                case 3:
                    epito123[9] = cserekarakter;
                    break;
                case 4:
                    epito456[1] = cserekarakter;
                    break;
                case 5:
                    epito456[5] = cserekarakter;
                    break;
                case 6:
                    epito456[9] = cserekarakter;
                    break;
                case 7:
                    epito789[1] = cserekarakter;
                    break;
                case 8:
                    epito789[5] = cserekarakter;
                    break;
                case 9:
                    epito789[9] = cserekarakter;
                    break;
                default:
                    Console.WriteLine("Hibás szám");
                    break;
            }
        }
        static void XjatekosKore()
        {
            string read = Console.ReadLine();
            int beolvasas = Int32.Parse(read);

            Cserelo(beolvasas, 'x');
            Kiir();
        }
        static void OjatekosKore()
        {
            string read = Console.ReadLine();
            int beolvasas = Int32.Parse(read);

            Cserelo(beolvasas, 'o');
            Kiir();
        }

        static void Kiir()
        {
            
            Console.WriteLine(epito123);
            Console.WriteLine("___|___|___");
            Console.WriteLine(epito456);
            Console.WriteLine("___|___|___");
            Console.WriteLine(epito789);
            Console.WriteLine("   |   |   ");

            
        }
    }
}
