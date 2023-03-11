int SecondDigit(int number)
{
    int result = number >= 100 && number < 1000 ? number/10%10 : -1;
    return result;
}

int num = new Random().Next(100, 1000);
Console.WriteLine(num);
Console.WriteLine(SecondDigit(num) != -1 ? SecondDigit(num): "Проверьте условие");
