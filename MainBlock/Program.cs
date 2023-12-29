using System;
using System.Linq;

namespace MainBlock
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int count = 0;
			string[] arr1;
			do
			{
				arr1 = createArray(reader());
				count = arr1.Count();
				if(count < 6)
				{
					Console.WriteLine("Ошибка, вы ввели меньше 6 слов.");
				}
			}
			while (count < 6);

			string[] arr2 = newArray(arr1);

			print(arr1, arr2);

			Console.ReadLine();
		}
		/// <summary>
		/// Получаем строку из 6 слов от пользователя
		/// </summary>
		/// <returns>Возвращается строка</returns>
		private static string reader()
		{
			string input;
			do
			{
				Console.Write("Введите 6 любых слов через пробел: ");
				input = Console.ReadLine();
			}
			while (string.IsNullOrEmpty(input));

			return input;
		}
		/// <summary>
		/// Метод создает массив из строки
		/// </summary>
		/// <param name="str">Строка полученная от пользователя</param>
		/// <returns>Массив из строки</returns>
		private static string[] createArray(string str)
		{
			return str.Split(' ');
		}
		/// <summary>
		/// Метод создает новый массив размером меньше предыдущего
		/// </summary>
		/// <param name="arr"></param>
		/// <returns></returns>
		private static string[] newArray(string[] arr)
		{
			string[] array = new string[3];
			var r = new Random();
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = arr[r.Next(0, arr.Length - 1)];
			}
			return array;
		}
		/// <summary>
		/// Выводим все массивы на экран
		/// </summary>
		/// <param name="arr1"></param>
		/// <param name="arr2"></param>
		private static void print(string[] arr1, string[] arr2)
		{
			Console.WriteLine("Первый массив:");
			foreach (string str in arr1)
			{
				Console.WriteLine(str);
			}

			Console.WriteLine("----------------");

			Console.WriteLine("Второй массив:");
			foreach (string str in arr2)
			{
				Console.WriteLine(str);
			}
		}
	}
}
