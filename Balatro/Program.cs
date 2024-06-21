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
            //ハンド予想変数
            int forecastNum = 0;

            //スコア
            int score = 0;
            int addScore;
            int combo = 0;
            while (true)
            {  
                //画面クリア
                Console.Clear();
                
                bool loop = true;
                int[] number = new int[4];
                int result = 0;

                //ハンド番号判定ループ
                while (loop == true)
                {
                    Console.Clear();

                    string numStr;
                    Console.WriteLine("==========================");
                    Console.WriteLine("ハンドを予想");
                    Console.WriteLine("==========================");
                    Console.WriteLine("ハイカード:0");
                    Console.WriteLine("ワンペア:1");
                    Console.WriteLine("ツーペア:2");
                    Console.WriteLine("スリーカード:3");
                    Console.WriteLine("フォーカード:4");
                    Console.WriteLine("==========================");

                    if (combo > 1)
                    {
                        Console.WriteLine(combo + "連勝中!");
                        Console.Write("[現在のスコア:" + score + "]> ");
                    }
                    else
                    {
                        Console.Write("[現在のスコア:" + score + "]> ");
                    }

                    numStr = Console.ReadLine();
                    //数値以外または範囲外の文字列を入力した際、再入力
                    if (int.TryParse(numStr, out forecastNum)
                        && (forecastNum >= 0 && forecastNum <= 4)) loop = false;
                    else
                    {
                        Console.WriteLine("対応した数値を入力してください");
                        Console.ReadLine();
                    }
                }

                InputNumber inputNumber = new InputNumber();
                result = inputNumber.InputNum(number);

                switch (result)
                {
                    case 1:
                        addScore = 10;
                        Console.WriteLine("ワンペア");
                        break;
                    case 2:
                        addScore = 20;
                        Console.WriteLine("ツーペア");
                        break;
                    case 3:
                        addScore = 50;
                        Console.WriteLine("スリーカード");
                        break;
                    case 4:
                        addScore = 100;
                        Console.WriteLine("フォーカード");
                        break;
                    default:
                        addScore = 5;
                        Console.WriteLine("ハイカード");
                        break;
                }
                Console.ReadLine();

                if (forecastNum == result)
                { //的中した場合
                    combo++;
                    score += (addScore + (combo*2)); //コンボ数*2の数値をボーナスとして加点
                    Console.WriteLine("的中！現在のスコア:" + score);
                    Console.ReadLine();
                }
                else
                {
                    combo = 0;
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