int [] array = new int[10];

int index = 0;
while (index != 10)
{
int RandomNum = new Random().Next(10, 1000);
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
array[index] = RandomNum;
Console.Write(+array[index] + " " );
index +=1;

}
}
else if (RandomNum <= 99)
{
if ((num1 * num2) % (num1 + num2) == 0)
{
array[index] = RandomNum;
Console.Write(+array[index] + " " );
index +=1;

}
}

}

Console.WriteLine(array.Length);