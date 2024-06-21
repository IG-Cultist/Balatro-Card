using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Balatro
{
    internal class InputNumber
    {
        //---------------------------
        // フィールド
        //---------------------------
        //ランク代入配列
        int[] numbers = new int[4];

        int result = 0;

        //---------------------------
        // メソッド
        //---------------------------
        public int InputNum(int[] number)
        {
            //数値を配列分入力
            for (int i = 0; i < numbers.Length; i++)
            {
                bool loop = true;

                while (loop == true)
                {        
                    string numStr;
                    Console.Write((i + 1) + "枚目の数値[1～13]:");
                    numStr = Console.ReadLine();
                    //数値以外または範囲外の文字列を入力した際、再入力
                    if (int.TryParse(numStr, out numbers[i])
                        && (numbers[i] >= 1 && numbers[i] <= 13)) loop = false;
                    else
                    {
                        Console.WriteLine("対応した数値を入力してください");
                        Console.ReadLine();
                    }
                }
                number[i] = numbers[i];
            }

            //フォーカード
            if ((number[0] == number[1]) && (number[0] == number[2]) && (number[0] == number[3]))
            {
                return  4;
            } 
            
            int count = 0;
            for (int i = 0; i < number.Count() - 1; i++)
            {
                for (int j = i + 1; j < number.Count(); j++)
                {
                    if ((number[i] & 0xF) == (number[j] & 0xF))
                    {
                        count++;
                    }
                }
            }

            // 成立した役を返す
            switch (count)
            {
                case 1: return 1;
                case 2: return 2;
                case 3: return 3;
            }
            return result;
        }
    }
}
