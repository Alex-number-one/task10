int num = Convert.ToInt32(Console.ReadLine());
Console.Write (num + " -> ");
if (num > 999999999) 
{
Console.WriteLine ("Please write an affordable number");
}
else if (num < 100)
{
    Console.WriteLine ("There is no third number");
}
while (num >=1000)
{
num = num / 10;
}
int num1 = num % 100;
  int num2 = num1 % 10;
  Console.Write (num2);
