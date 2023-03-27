// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
Console.WriteLine("Для того, чтобы вывести на экран значение функции Аккермана(A(m,n))");
int numberM = UserInput("Введите m: ");
int numberN = UserInput("Введите n: ");
if (NotNegative(numberN, numberM))
{
    Console.WriteLine("Для вычисления функции Аккермана значения должны быть не отрицательными целыми числами");
}
else
{
    Console.WriteLine($"Значение функции A({numberM},{numberN}) = {Ack(numberM, numberN)}");
}
int Ack(int numM, int numN)
{
    if (numM == 0)
        return numN + 1;
    else if (numN == 0)
        return checked(Ack(numM - 1, 1));
    else
        return checked(Ack(numM - 1, Ack(numM, numN - 1)));
}
bool NotNegative(int numN, int numM)
{
    if (numM < 0 && numM < 0)
    {
        return true;
    }
    return false;
}
int UserInput(string massage)
{
    Console.Write(massage);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}
