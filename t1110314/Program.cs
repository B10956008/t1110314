using System;

namespace t1110314
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             基數偶數判斷
             If  is odd, print Weird  
             If  is even and in the inclusive range of 2  to 5 , print Not Weird
             If  is even and in the inclusive range of 6 to 20 , print Weird 
             If  is even and greater than , print Not Weird
            */
            /*Console.WriteLine("ENTER：");
            string str1 = Console.ReadLine();
            int num1 = Convert.ToInt32(str1);
            if (num1%2!=0)
            {
                Console.WriteLine("Weird");
            }
            else
            {
                  if (num1 >= 2 || num1 <= 5)
                {
                        Console.WriteLine("Not Weird");
                }
                  else if (num1 >= 6 || num1 <= 20)
                {
                    Console.WriteLine("Weird");
                }
                  else if (num1 > 20)
                {
                    Console.WriteLine("Not Weird");
                }

            }*/
            /*switch (num1)
            {
                

            }*/
            /*int a = 0;
            for(int i=0;i<=10; i++)
            {
                a += i ;
               
            }            
            Console.WriteLine("結果:" +a);*/


            /*Console.WriteLine("ENTER：");//bug
            string str1 = Console.ReadLine();
            int a = Convert.ToInt32(str1);
            
            for (int i=1;i<=a;i++){
                
                for (int j = 0; j <= i - 1; j++)
                {
                    Console.WriteLine("*");
                   
                }
                Console.WriteLine();
            }
            */

            /*Console.Write("請輸入一個正整數：");

            int a = int.Parse(Console.ReadLine());

            

            int c = 0;
            for (int n = 1; n <= a; ++n)

            {

                c = a * n;
                Console.WriteLine(a+"x"+n+"="+c);
            }

            

            Console.ReadLine();*/


            /*for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    Console.Write(i + "*" + j + "=" + (i * j) + "\t");
                }
                Console.WriteLine();
            }*/
            int[] id = { 1, 2, 3, 4, 5 };
            string[] name = { "Jack", "Mary", "Tom", "Grace", "Alice" };
            int[] score_c = { 80, 60, 100, 98, 83 };
            int[] score_d = { 75, 67, 93, 25, 82 };
            int[] score_a = { 60, 62, 91, 50, 87 };

            while(true)
            {
                Console.WriteLine("輸入座號：");
                var input = Console.ReadLine();
                int idinput = int.Parse(input);
                int arrayindex = Array.IndexOf(id, idinput);
                if (arrayindex > -1)
                {
                    Console.WriteLine( "姓名："+id[arrayindex]);

                    Console.WriteLine("電腦概論：" + score_c[arrayindex]);
                    Console.WriteLine("程式設計：" + score_d[arrayindex]);
                    Console.WriteLine("動畫設計：" + score_a[arrayindex]);


                }
                else
                {
                    Console.WriteLine("沒有這個座號");
                }

            }
        }
    }
}
