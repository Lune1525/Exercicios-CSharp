using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading;

namespace Jokenpo
{
    public static class Program 
    {         
        public static void Main()
        {
            Console.WriteLine("=======================JOKEPÔ=========================");
            Console.WriteLine("Opções: \n1 - Pedra \n2 - Papel \n3 - Tesoura: ");
            int player = Convert.ToInt32(Console.ReadLine());
            while(player <=0 || player >=4)
            {
            	Console.WriteLine("Número inválido!");
                player = Convert.ToInt32(Console.ReadLine());
            }
            
            Random numbers = new Random();
            int computer = numbers.Next(1,3);
            int time = 1000;
            Console.WriteLine("=================");
            Console.WriteLine("JO");
            Thread.Sleep(time);
            Console.WriteLine("KEN");
            Thread.Sleep(time);
            Console.WriteLine("PÔ");
            Thread.Sleep(time);
            Console.WriteLine("=================");
            
            switch(player)
            {
            	case 1:
            	  Console.WriteLine("Player: Pedra");
            	  break;
            	case 2:
            	  Console.WriteLine("Player: Papel");
            	  break;
            	case 3:
            	  Console.WriteLine("Player: Tesoura");
            	  break;
            }
            
            switch(computer)
            {
            	case 1:
            	  Console.WriteLine("Computer: Pedra");
            	  break;
            	case 2:
            	  Console.WriteLine("Computer: Papel");
            	  break;
            	case 3:
            	  Console.WriteLine("Computer: Tesoura");
            	  break;
            }
            
            Console.WriteLine("=================");
            
            if(computer == player) 
            {
            	Console.WriteLine("Empate!");
            }
            if(computer == 2 && player == 1)
            {
            	Console.WriteLine("Computer wins!");
            }
            if(computer == 1 && player == 2)
            {
            	Console.WriteLine("Player wins!");
            }
            if(computer == 3 && player == 2)
            {
            	Console.WriteLine("Computer wins!");
            }
            if(computer == 2 && player == 3)
            {

            	Console.WriteLine("Player wins!");
            }
            if(computer == 1 && player == 3)
            {
            	Console.WriteLine("Computer wins!");
            }
            if(computer == 3 && player == 1)
            {
            	Console.WriteLine("Player wins!");
            }
        }
    }
}