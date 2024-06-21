using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Balatro
{
    internal class InputNumber
    {
        public int InputNum(int[] number)
        {
            int[] numbers = new int[4];
            string numStr;
            int result = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                bool loop = true;

                while (loop == true)
                {
                    //Console.Clear();
                    Console.Write("1枚目の数値[1,2,3,4]:");
                    numStr = Console.ReadLine();
                    //数値以外または範囲外の文字列を入力した際、再入力
                    if (int.TryParse(numStr, out numbers[i])
                        && (numStr == "1" || numStr == "2" || numStr == "3" || numStr == "4")) loop = false;
                    else
                    {
                        Console.WriteLine("対応した数値を入力してください");
                        Console.ReadLine();
                    }
                }
                number[i] = numbers[i];
            }

            return result;
        }
    }
}
