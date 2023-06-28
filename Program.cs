int RandomNum = new Random().Next(100, 1000);
int SecondNum = RandomNum % 100;
int result = SecondNum / 10;
Console.WriteLine($"{RandomNum} -> {result}");