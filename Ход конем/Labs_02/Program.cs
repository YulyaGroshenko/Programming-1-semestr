using Microsoft.VisualBasic.CompilerServices;
using System;


namespace Labs_02
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string start_coo = Console.ReadLine();
            string finish_coo = Console.ReadLine();

            char start_letter = start_coo[0];
            char start_figure = start_coo[1];
            char finish_letter = finish_coo[0];
            char finish_figure = finish_coo[1];

            char x1 = Convert.ToChar((int)start_letter + 1);
            char x2 = Convert.ToChar((int)start_letter + 2);
            char x3 = Convert.ToChar((int)start_figure + 1);
            char x4 = Convert.ToChar((int)start_figure + 2);
            char x5 = Convert.ToChar((int)start_letter - 1);
            char x6 = Convert.ToChar((int)start_letter - 2);
            char x7 = Convert.ToChar((int)start_figure - 1);
            char x8 = Convert.ToChar((int)start_figure - 2);

            if ((x1 == finish_letter && x4 == finish_figure|| x2 == finish_letter && x3 == finish_figure || 
                x2 == finish_letter && x7 == finish_figure || x1 == finish_letter && x8 == finish_figure|| 
                x5 == finish_letter && x8 == finish_figure || x6 == finish_letter && x7 == finish_figure || 
                x6 == finish_letter && x3 == finish_figure || x5 == finish_letter && x4 == finish_figure) &&

                (start_figure >= 49 && start_figure <= 56 && finish_figure >= 49 && finish_figure <= 56 &&

                start_letter >= 97 && start_letter <= 104 && finish_letter >= 97 && finish_letter <= 104 || 
                start_letter >=65 && start_letter <=72 && finish_letter >=65 && finish_letter <= 72))

                Console.WriteLine("Верно");

            else
                Console.WriteLine("Не верно");


            


        


            

            



          
     
        }
    }
}