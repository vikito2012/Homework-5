using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_4_5_5
{
    enum Colors
    {
        Red,
        Blue,
        White
    };
    class Program
    {
        public static Colors[] InsSort(Colors[] col)
        {
            for (int i = 0; i < col.Length; i++)
            {
                Colors value = col[i];
                int index = i;
                while (index > 0 && col[index - 1].ToString().Length >= value.ToString().Length)
                {
                    col[index] = col[index - 1];
                    index--;
                }
                col[index] = value;
            }
            return col;
        }
        static void Main(string[] args)
        {
            int n;
            string color;
            Console.Write("Vavedete broia na elementite na masiva:");
            n = int.Parse(Console.ReadLine());
            Colors[] tsviat = new Colors[n];
            Console.WriteLine("Vavedete edin ot slednite tsvetove:");
            Console.WriteLine("1. Red");
            Console.WriteLine("2. Blue");
            Console.WriteLine("3. White");
            for (int i = 0; i < tsviat.Length; i++)
            {
                color = Console.ReadLine();
                switch (color)
                {
                    case "Red":
                        tsviat[i] = (Colors)Enum.Parse(typeof(Colors), color);
                        break;
                    case "Blue":
                        tsviat[i] = (Colors)Enum.Parse(typeof(Colors), color);
                        break;
                    case "White":
                        tsviat[i] = (Colors)Enum.Parse(typeof(Colors), color);
                        break;
                    default:
                        Console.WriteLine("Vavedeniat tsvit ne e validen!");
                        --i;
                        break;
                }
            }
            tsviat = InsSort(tsviat);
            Console.WriteLine();
            for (int j = 0; j < tsviat.Length; j++)
            {
                Console.Write(tsviat[j].ToString());
                Console.Write(" ");
            }
            Console.ReadKey();
        }
    }
}
