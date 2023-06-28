 /*int RandomNum = new Random().Next(10, 100);
int [] array = new int[10];
int num1 = RandomNum;
int num2 = RandomNum;
int num3 = RandomNum;
if(RandomNum > 99)
{
num1 = num1 / 100;
}
else
{
num1 = RandomNum / 10;
}
if (RandomNum > 99)
{
num2 = RandomNum % 100;
num2 = num2 / 10;
}
else 
{
num2 = RandomNum % 10;
}
if (RandomNum > 99)
{
num3 = RandomNum % 100;
num3 = num3 % 10;
}

if (RandomNum > 99)
{
if ((num1 * num2 * num3) % (num1 + num2 + num3) == 0)
{
array[0] = RandomNum;
}
}
else if (RandomNum <= 99)
{
if ((num1 * num2) % (num1 + num2) == 0)
{
array[0] = RandomNum;
}
}
Console.WriteLine(num1);
Console.WriteLine(num2);
Console.WriteLine(num3);
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine(array[0]);*/
 int weekday = Convert.ToInt16(Console.ReadLine());
if (weekday == 1 || weekday == 2 || weekday == 3 || weekday == 4 || weekday == 5 )
{
Console.WriteLine("No");
}
else if (weekday == 6 || weekday == 7)
{
Console.WriteLine("Yes");
}

else {
Console.WriteLine("Please write a number from 1 to 7");
}
