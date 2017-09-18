using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Console_practice
{
	// Main
    class main
    {
		static void Main(string[] args)
		{

			Sort_test.Sort_test1();
			Console.ReadKey();
		}
    }
	// 配列の中身を表示
	class Display
	{
		public static void Display_array(int[] ar)
		{
			foreach (int data in ar)
			{
				Console.WriteLine(data);
			}
			Console.WriteLine("\n");
		}
	}

	// ソート
	class Sort_test
	{
		public static void Sort_test1()
		{
			int n = 100;

			//初期配列
			int[] data1 = new int[n];

			for (var i = 0; i < n; i++)
			{
				data1[i] = i + 1;
			}
			Display.Display_array(data1);

			var ran = new Random();

			for (var i = 0; i < n; i++)
			{
				int r = ran.Next(0, n - 1);
				int t = 0;

				t = data1[i];
				data1[i] = data1[r];
				data1[r] = t;

			}

			Display.Display_array(data1);

		}

	}
}


