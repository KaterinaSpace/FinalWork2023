// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из
// строк, длина которых меньше, либо равна 3 символам. Первоначальный массив
// можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись
// исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []


string[] arr1 = new string[4] {"1234", "1567", "-2", "computer science"};

string[] NewSecondArray(string[] arr1)
{
		int count = 0;
		for (int i = 0; i < arr1.Length; i++)
		{
		if(arr1[i].Length <= 3)
				{
				count++;
				}
		}
		string[] arr2 = new string[count];
		count = 0;
		for (int i = 0; i < arr1.Length; i++)
		{
		if(arr1[i].Length <= 3)
				{
				arr2[count] = arr1[i];
				count++;
				}
		}
		return arr2;
}
void PrintArray(string[] array)
{
	Console.Write("[");
		for (int i = 0; i < array.Length-1; i++)
		{
				Console.Write($"“{array[i]}”, ");
		}		
			 Console.Write($"“{array[^1]}”"  + "]"  );
}

PrintArray(arr1);
string[] arr2 = NewSecondArray(arr1);

Console.Write("→ ");
PrintArray(arr2);
