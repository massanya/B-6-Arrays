using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base.Lesson_6
{
	class Program
	{
		static void Main(string[] args)
		{
			//Pyatnashki();
			Console.ReadLine();
			Bubblesort();

		}

		public static void Pyatnashki()
		{
			int[,] mass = new int[3, 3];
			printmass(mass);
			initmass(mass);
			Console.WriteLine();
			printmass(mass);
			maxelem(mass);
		}

		private static void printmass(int[,] mass)
		{
			for (int i = 0; i < 3; i++)
			{
				for (int j = 0; j < 3; j++)
				{

					Console.Write($"{mass[i, j]} ");
				}
				Console.WriteLine();
			}

		}
		static Random r = new Random();
		private static void initmass(int[,] mass)
		{
			for (int i = 0; i < 3; i++)
			{

				for (int j = 0; j < 3; j++)
				{
					mass[i, j] = r.Next(100);

				}

			}

		}
		private static void maxelem(int[,] mass)
		{
			for (int i = 0; i < 3; i++)
			{
				int MaxZn = 0;
				for (int j = 0; j < 3; j++)
				{
					if (mass[i, j] > MaxZn)
					{
						MaxZn = mass[i, j];
					}

				}
				Console.Write($"Максимальное значение в  {i + 1} строке = {MaxZn}");
				Console.WriteLine();
			}
		}
		private static void Bubblesort()
		{
			int[] Data = new int[5];
			int k = 0;
			Console.WriteLine("Введите массив");
			while (k < 5)
			{

				Data[k] = int.Parse(Console.ReadLine());
				Console.WriteLine();
				k++;
			}

			for (int i = 0; i < Data.Length; i++)
			{
				for (int j = 0; j < Data.Length - 1; j++)
				{
					if (Data[j] > Data[j + 1])
					{
						int z = Data[j];
						Data[j] = Data[j + 1];
						Data[j + 1] = z;
					}
				}
			}
			Console.WriteLine($"Отсортированный массив");
			for (int l = 0; l < 5; l = l + 1)
				Console.WriteLine($"{Data[l]}");
			Console.ReadKey();
		}

		public static void PoemExample()
		{

		}
	}
}
