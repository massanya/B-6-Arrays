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
			int[] massive = new int[5];
			//VvodMassiva(massive);
			//Bubblesort(massive);
			//Insertionsort(massive);
			//VivodMassiva(massive);
			//CutString();
			ReplaceInPoem();
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

		private static void VvodMassiva(int[] massive)
		{
			//int[] massive = new int[5];
			int k = 0;
			Console.WriteLine("Введите массив");
			while (k < 5)
			{

				massive[k] = int.Parse(Console.ReadLine());
				Console.WriteLine();
				k++;
			}
		}

		private static void Bubblesort(int[] massive)
		{
			for (int i = 0; i < massive.Length; i++)
			{
				for (int j = 0; j < massive.Length - 1; j++)
				{
					if (massive[j] > massive[j + 1])
					{
						int z = massive[j];
						massive[j] = massive[j + 1];
						massive[j + 1] = z;
					}
				}
			}
		}
		private static void VivodMassiva(int[] massive)
		{
			Console.WriteLine($"Отсортированный массив");
			for (int l = 0; l < 5; l = l + 1)
				Console.WriteLine($"{massive[l]}");
			Console.ReadKey();
		}
		private static void Insertionsort(int[] massive)
		{
			for (int i = 1; i < massive.Length; i++)
			{
				int j;
				int buf = massive[i];
				for (j = i - 1; j >= 0; j--)
				{
					if (massive[j] < buf)
						break;

					massive[j + 1] = massive[j];
				}
				massive[j + 1] = buf;
			}
		}

		public static void CutString()
		{
			Console.WriteLine("ВВедите предложение");
			string sentence = Console.ReadLine().ToString();
			string sentnew = "";
			if (sentence.Length > 13)
			{
				sentnew=sentence.Substring(0,13);
			}
			else
			{
				sentnew = sentence;
			}
			Console.WriteLine($"{sentnew.ToString()}");
			Console.ReadKey();
		}
		public static void ReplaceInPoem()
		{
			Console.WriteLine("ВВедите стихотворение");
			string poem = Console.ReadLine().ToString();
			string[] poemst=poem.Split(';');
			string[] poemnew=poemst;;
			for (int i = 0; i < poemst.Length; i++)
			{
				poemnew[i]=poemst[i].Replace("о","а").Replace("л","ль").Replace("т","ть");
				Console.WriteLine($"{poemnew[i].ToString()}");
			}
			
		}
	}
}
