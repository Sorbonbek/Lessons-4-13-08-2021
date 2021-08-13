using System;

namespace ДЗ_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task 1.1
            Console.WriteLine("Task 1.1");
            int A1 = int.Parse(Console.ReadLine());
            int B1 = int.Parse(Console.ReadLine());
            int Results1 = 0;
            for(int i = A1; i < B1; i++)
            {
                Results1 += i;
            }
            Console.WriteLine($"Results: {Results1}\n");
            //END
            
            //Task 1.2
            Console.WriteLine("Task 1.2");
            int A2 = int.Parse(Console.ReadLine());
            int B2 = int.Parse(Console.ReadLine());
            for(int i = A2 + 1; i < B2; i++)
            {
                if(i % 2 == 1)
                {
                    Console.WriteLine($"\t-{i}");
                }
            }
            
            
            //ТАСК 2
            
            
            Console.WriteLine("Task 2\n");
            Console.WriteLine("Прямоугольник");
            for (int j = 0; j < 7; j++)
            {
                for (int i = 0; i < 40; i++)
                {
                    if (j == 0 || j == 7 - 1) 
                        Console.Write("*");
                    else if (i == 0 || i == 40 - 1) 
                        Console.Write("*");
                    else 
                        Console.Write(" ");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("\n");

            Console.WriteLine("Прямоугольный треугольник");
            for (int i1 = 1; i1 <= 10; i1++)  
            {  
                for (int j1 = 1; j1 <= i1; j1++)  
                {  
                    Console.Write("");  
                }  
                
                for (int k = 1; k <= i1; k++)  
                {     
                    Console.Write("*");  
                } 
                Console.WriteLine("");
            } 

            Console.WriteLine("Равносторонний треугольник");
            for(int i2=1; i2<=7; i2++)      
            {          
                for(int j2=1; j2<=7-i2; j2++)      
                {      
                    Console.Write(" ");      
                }      
                for(int k1=1;k1<=i2;k1++)      
                {      
                    Console.Write("*");      
                }      
                for(int l=i2-1;l>=1;l--)      
                {      
                    Console.Write("*");      
                }      
                Console.Write("\n");      
            }   

            Console.WriteLine("Ромб");
            for(int a = 1; a <= 5; a++) 
            { 
                for (int b = a; b <= 5; b++) 
                { 
                    Console.Write("  "); 
                } 
                for(int c = 1; c <= 2 * a - 1; c++) 
                { 
                    Console.Write("* "); 
                } 
                Console.WriteLine(); 
            } 

            for (int d = 5; d >= 1; d--) 
            { 
                for (int e = d; e <= 5; e++) 
                { 
                    Console.Write("  "); 
                } 
                for (int f = 1; f <= 2 * d - 1; f++) 
                { 
                    Console.Write("* "); 
                } 
                Console.WriteLine(); 
            }    
            
            //ТАСК 3
            
            Console.WriteLine("Task 3...");
            float P = float.Parse(Console.ReadLine().ToString().Replace(".", ","));
            float m = 1000.0f;
            int counter = 0;
            float i = 0;
            if(P > 0 && P < 25)
            {
                for(i = m; i <= 1100.0f; i+=i*P/100)
                {
                    counter++;
                }
                
                Console.WriteLine($"Кол-во месяцев: {counter}, итоговый размер вклада {i}");
            }
        }
    }
}