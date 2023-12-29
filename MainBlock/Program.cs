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

	}
}
