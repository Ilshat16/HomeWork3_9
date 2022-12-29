// Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumNumbers(int n1, int n2)
{
    if (n1 == n2) return n2;
    return n1 + SumNumbers(n1 + 1, n2);
}

int EnterData(string text)
{
    Console.Write(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int firstNumber = EnterData("Введите первое число последовательности: ");
int lastNumber = EnterData("Введите последнее число последовательности: ");
System.Console.WriteLine("Сумма натуральных элементов в промежутке " + 
                         "от M (" + firstNumber + ") до N (" + lastNumber + ") равна: " + 
                         SumNumbers(firstNumber, lastNumber)); 