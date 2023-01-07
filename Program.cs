using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    internal class Program
    {
        public static StringBuilder epito123 = new StringBuilder(" 1 | 2 | 3 ");
        public static StringBuilder epito456 = new StringBuilder(" 4 | 5 | 6 ");
        public static StringBuilder epito789 = new StringBuilder(" 7 | 8 | 9 ");
        public static List<int> FelulirtSzamok = new List<int>();
        public static List<int> xTarolt = new List<int>();
        public static List<int> oTarolt = new List<int>();
        
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

            Console.WriteLine("Írd be egy mező számát");

            //eltárolni melyik játékos hova rakott, mind a 8 lehetőséget megadni (switch) (azok a számok mind x vagy o)


                Console.WriteLine(" 1 | 2 | 3 ");
                Console.WriteLine("___|___|___");
                Console.WriteLine(" 4 | 5 | 6 ");
                Console.WriteLine("___|___|___");
                Console.WriteLine(" 7 | 8 | 9 ");
                Console.WriteLine("   |   |   ");
                Console.WriteLine("");
            


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
                    //if (epito123[1] == 'x' || epito123[1] == 'o') hibas ertek, ujra a program
                    epito123[1] = cserekarakter;
                    FelulirtSzamok.Add(beolvasas);
                    break;
                case 2:
                    epito123[5] = cserekarakter;
                    FelulirtSzamok.Add(beolvasas);
                    break;
                case 3:
                    epito123[9] = cserekarakter;
                    FelulirtSzamok.Add(beolvasas);
                    break;
                case 4:
                    epito456[1] = cserekarakter;
                    FelulirtSzamok.Add(beolvasas);
                    break;
                case 5:
                    epito456[5] = cserekarakter;
                    FelulirtSzamok.Add(beolvasas);
                    break;
                case 6:
                    epito456[9] = cserekarakter;
                    FelulirtSzamok.Add(beolvasas);
                    break;
                case 7:
                    epito789[1] = cserekarakter;
                    FelulirtSzamok.Add(beolvasas);
                    break;
                case 8:
                    epito789[5] = cserekarakter;
                    FelulirtSzamok.Add(beolvasas);
                    break;
                case 9:
                    epito789[9] = cserekarakter;
                    FelulirtSzamok.Add(beolvasas);
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

            bool foglalt = ErtekVizsgalo('x',beolvasas);
            if (!foglalt)
            { 
                Cserelo(beolvasas, 'x');
                Kiir();
                Nyeres(beolvasas, 'x');
            }

        }
        static void OjatekosKore()
        {
            string read = Console.ReadLine();
            int beolvasas = Int32.Parse(read);

            bool foglalt = ErtekVizsgalo('o', beolvasas);
            if (!foglalt)
            {
                Cserelo(beolvasas, 'o');
                Kiir();
                Nyeres(beolvasas, 'o');

            }
            
            
        }

        static bool ErtekVizsgalo(char jatekos, int beolvasas)
        {
            //ugyanaz a jatekos jon megint ha olyan karaktert ir be ami mar megvolt
            bool foglalt = false;

            if (FelulirtSzamok.Contains(beolvasas))
            {
                foglalt = true;
                Console.WriteLine("Ez a mező már foglalt!");
                if (jatekos == 'x')
                {
                    XjatekosKore();
                    
                    
                }
                else
                {
                    OjatekosKore();
                }
                
            }
            return foglalt;
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

        static void Nyeres(int beolvasas, char jatekos)
        {
            bool jatekosnyert = false;
            List<int> jatekosTarolt;
            if (jatekos == 'x')
            {
                jatekosTarolt = xTarolt;
            }
            else
            {
                jatekosTarolt = oTarolt;
            }

            switch (beolvasas)
            {
                //123 = x akkor x jatekos nyer xJatekos.Add(x)
                case 1:
                    if (jatekosTarolt.Contains(2) && jatekosTarolt.Contains(3))
                    {
                        jatekosnyert = true;
                    }
                    else if (jatekosTarolt.Contains(4) && jatekosTarolt.Contains(7))
                    {
                        jatekosnyert = true;
                    }
                    else if (jatekosTarolt.Contains(5) && jatekosTarolt.Contains(9))
                    {
                        jatekosnyert = true;
                    }
                    break;

                case 2:
                    if (jatekosTarolt.Contains(1) && jatekosTarolt.Contains(3))
                    {
                        jatekosnyert = true;
                    }
                    else if (jatekosTarolt.Contains(5) && jatekosTarolt.Contains(8))
                    {
                        jatekosnyert = true;
                    }
                    break;

                case 3:
                    if (jatekosTarolt.Contains(1) && jatekosTarolt.Contains(2))
                    {
                        jatekosnyert = true;
                    }
                    else if (jatekosTarolt.Contains(5) && jatekosTarolt.Contains(7))
                    {
                        jatekosnyert = true;
                    }
                    else if (jatekosTarolt.Contains(6) && jatekosTarolt.Contains(9))
                    {
                        jatekosnyert = true;
                    }
                    break;

                case 4:
                    if (jatekosTarolt.Contains(5) && jatekosTarolt.Contains(6))
                    {
                        jatekosnyert = true;
                    }
                    else if (jatekosTarolt.Contains(1) && jatekosTarolt.Contains(7))
                    {
                        jatekosnyert = true;
                    }
                    break;

                case 5:
                    if (jatekosTarolt.Contains(1) && jatekosTarolt.Contains(9))
                    {
                        jatekosnyert = true;
                    }
                    else if (jatekosTarolt.Contains(7) && jatekosTarolt.Contains(3))
                    {
                        jatekosnyert = true;
                    }
                    else if (jatekosTarolt.Contains(4) && jatekosTarolt.Contains(6))
                    {
                        jatekosnyert = true;
                    }
                    else if (jatekosTarolt.Contains(2) && jatekosTarolt.Contains(8))
                    {
                        jatekosnyert = true;
                    }
                      break;

                case 6:
                    if (jatekosTarolt.Contains(4) && jatekosTarolt.Contains(5))
                    {
                        jatekosnyert = true;
                    }
                    else if (jatekosTarolt.Contains(9) && jatekosTarolt.Contains(3))
                    {
                        jatekosnyert = true;
                    }
                    break;

                case 7:
                    if (jatekosTarolt.Contains(1) && jatekosTarolt.Contains(4))
                    {
                        jatekosnyert = true;
                    }
                    else if (jatekosTarolt.Contains(8) && jatekosTarolt.Contains(9))
                    {
                        jatekosnyert = true;
                    }
                    else if (jatekosTarolt.Contains(5) && jatekosTarolt.Contains(3))
                    {
                        jatekosnyert = true;
                    }
                    break;

                case 8:
                    if (jatekosTarolt.Contains(2) && jatekosTarolt.Contains(5))
                    {
                        jatekosnyert = true;
                    }
                    else if (jatekosTarolt.Contains(7) && jatekosTarolt.Contains(9))
                    {
                        jatekosnyert = true;
                    }
                    break;

                case 9:
                    if (jatekosTarolt.Contains(1) && jatekosTarolt.Contains(5))
                    {
                        jatekosnyert = true;
                    }
                    if (jatekosTarolt.Contains(6) && jatekosTarolt.Contains(3))
                    {
                        jatekosnyert = true;
                    }
                    if (jatekosTarolt.Contains(7) && jatekosTarolt.Contains(8))
                    {
                        jatekosnyert = true;
                    }
                    break;
            }
            jatekosTarolt.Add(beolvasas);
            if (jatekosnyert)
            {
                Console.WriteLine(jatekos + " játékos nyert");
            }
            
        } 
    }
}
