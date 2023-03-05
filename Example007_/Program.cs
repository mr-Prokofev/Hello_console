Console.Clear();
int xa = 20, ya = 1,
    xb = 1, yb = 15,
    xc = 40, yc = 15;

Console.SetCursorPosition(xa, ya);
Console.WriteLine("*");

Console.SetCursorPosition(xb, yb);
Console.WriteLine("*");

Console.SetCursorPosition(xc, yc);
Console.WriteLine("*");
int count = 0;
int x = xa, y = xb;
while (count < 15)
{
    int what = new Random().Next(0, 3);
    if (what == 0)
    {
       x = (xa + x)/2;
       y = (ya + y)/2; 
    }

    if (what == 1)
    {
       x = (xb + x)/2;
       y = (yb + y)/2; 
    }

    if (what == 2)
    {
       x = (xc + x)/2;
       y = (yc + y)/2; 
    }
    Console.SetCursorPosition(x, y);
    Console.WriteLine("*");
    count++;




}
