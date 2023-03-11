using System;

class Program {
    static void Main(string[] args) {
        Console.Write("Введите элементы массива через запятую: ");
        string inputString = Console.ReadLine();
        string[] inputArray = inputString.Split(',');
        string[] outputArray = FilterShortStrings(inputArray);
        Console.WriteLine("Входной массив:");
        PrintArray(inputArray);
        Console.WriteLine("Выходной массив:");
        PrintArray(outputArray);
    }

    static string[] FilterShortStrings(string[] inputArray) {
        int count = 0;
        for (int i = 0; i < inputArray.Length; i++) {
            if (inputArray[i].Length <= 3) {
                count++;
            }
        }
        string[] outputArray = new string[count];
        int index = 0;
        for (int i = 0; i < inputArray.Length; i++) {
            if (inputArray[i].Length <= 3) {
                outputArray[index] = inputArray[i];
                index++;
            }
        }
        return outputArray;
    }

    static void PrintArray(string[] array) {
        foreach (string str in array) {
            Console.Write(str + " ");
        }
        Console.WriteLine();
    }
}