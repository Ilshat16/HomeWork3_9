// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int AkkermanFuncCalculation(int number1, int number2)
{
    if (number1 == 0) return number2 + 1;
    else 
    {
        if (number2 == 0) return AkkermanFuncCalculation(number1 - 1, 1);
        else return AkkermanFuncCalculation(number1 - 1, AkkermanFuncCalculation(number1, number2 - 1));
    }
}

int EnterData(string text)
{
    Console.Write(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int number1 = EnterData("Введите первое число: ");
int number2 = EnterData("Введите второе число: ");
System.Console.WriteLine(AkkermanFuncCalculation(number1, number2));