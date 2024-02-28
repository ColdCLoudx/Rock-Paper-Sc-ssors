using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rock_paper_scıssors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool cıkıs = true;
            while (true)
            {
                BASADON:
                Console.WriteLine("1-) Rock" + "\n" + "2-) Paper" + "\n" + "3-) Scissors");
                string secım=Console.ReadLine();

                for (int i = 0; i < secım.Length; i++)
                {
                    bool dogrumu = char.IsNumber(secım[i]);
                    if (dogrumu==true)
                    {
                        Console.WriteLine("gecersız karakter kullandınız");
                        goto BASADON;
                    }
                    
                   
                }
                 if (secım.Length < 4)
                {
                    Console.WriteLine("eksık yazım tanımlandı");
                    goto BASADON;
                }

                Console.Clear();


                Random rnd = new Random();

                int x=rnd.Next(1,4);
                string y = "";
                int oyuncuAdet = 0;
                int obılgısayarAdet = 0;
                int oyuncuAdetToplam = 0;
                int bılgısayarAdetToplam=0;

                if (x==1)
                {
                     y = x.ToString();
                    y = "Rock";
                }
                else if (x==2)
                {
                     y = x.ToString();
                    y = "Paper";
                }
                else if (x==3)
                {
                     y = x.ToString();
                    y = "Scissors";
                }

                Console.WriteLine("kullanıcnın secımı :  "  + secım);
                Console.WriteLine();
                Console.WriteLine("oyunun secımı      :"    +y);

                Console.WriteLine();
                Console.WriteLine();


                if (secım=="Rock" && y=="Rock")
                {
                    Console.WriteLine("--------DRAW----------");
                }
                else if (secım == "Rock" && y == "Paper")
                {
                    Console.WriteLine("--------PAPER WİN-------------");
                    
                   
                }
                else if (secım == "Rock" && y == "Scissors")
                {
                    Console.WriteLine("----------ROCK WİN-------------");

                    
                }

                //=======================================================


                if (secım == "Paper" && y == "Paper")
                {
                    Console.WriteLine("--------DRAW----------");
                }
                else if (secım == "Paper" && y == "Rock")
                {
                    Console.WriteLine("--------PAPER WİN-------------");

                   
                }
                else if (secım == "Paper" && y == "Scissors")
                {
                    Console.WriteLine("----------SCİSSORS WİN-------------");

                    
                }


                //=============================================================

                if (secım == "Scissors" && y == "Scissors")
                {
                    Console.WriteLine("--------DRAW----------");
                }
                else if (secım == "Scissors" && y == "Paper")
                {
                    Console.WriteLine("--------Scissors WİN-------------");

                   
                }
                else if (secım == "Scissors" && y == "Rock")
                {
                    Console.WriteLine("----------ROCK WİN-------------");

                    
                }


                Console.ReadLine();
               

                
               

                if (oyuncuAdet ==3)
                {
                    Console.WriteLine("OYUNU KAZANDIN , TEBRIKLER !!!");
                }
                else if (obılgısayarAdet==3)
                {
                    Console.WriteLine("OYUNU BILGISAYAR KAZANDI , KAYBETTINIZ");
                    cıkıs = false;
                    
                }
                
                Console.ReadLine ();
            }
                 

        }
    }
}
