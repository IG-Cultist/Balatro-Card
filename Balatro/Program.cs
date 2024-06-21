using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Balatro
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                int[] number = new int[4];
                int result = 0;
                InputNumber inputNumber = new InputNumber();
                result = inputNumber.InputNum(number);

                if (result == 1)
                {
                    Console.WriteLine("ワンペア");
                    Console.ReadLine();
                }
                else if (result == 2)
                {
                    Console.WriteLine("ツーペア");
                    Console.ReadLine();
                }
                else if (result == 3)
                {
                    Console.WriteLine("スリーカード");
                    Console.ReadLine();
                }
                else if (result == 4)
                {
                    Console.WriteLine("フォーカード");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("ハイカード");
                    Console.ReadLine();
                }

                int again;
                Console.Write("繰り返す？[Yes:1 No:2]:");
                string againStr =  Console.ReadLine();
                if (int.TryParse(againStr, out again))
                    if(again == 2) break;

            }
        }
    }
}