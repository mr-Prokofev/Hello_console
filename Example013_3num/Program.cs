Console.WriteLine("Введите число: ");
int num = Math.Abs(Convert.ToInt32(Console.ReadLine()));
int count = 0;
int secondDigit = -1;
while (num >= 100) 
    {
        secondDigit = num % 10;
        num/=10;
        count++; 
    }
Console.WriteLine(secondDigit == -1 ? "No":secondDigit);
