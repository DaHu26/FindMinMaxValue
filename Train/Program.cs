int[] numbers = GeneraitRandomArray();
Console.Write("Выберите действие 1 - Найти высшее значение 2 - Найти низшее значение. Ваш выбор: ");
var userSolutionId = Convert.ToInt32(Console.ReadLine());

if (userSolutionId == 1)
{
    var maxValue = FindMaxValue(numbers);
    Console.WriteLine(maxValue);
}
else if (userSolutionId == 2)
{
    var minValue = FindMinValue(numbers);
    Console.WriteLine(minValue);
}

 int FindMinValue(int[] numbers)
{
    var minValue = numbers[0];
    for (int i = 1; i < numbers.Length; i++)
    {
        if (minValue > numbers[i])
        {
            minValue = numbers[i];
        }
    }
    return minValue;
}

int FindMaxValue(int[] numbers)
{
    var maxValue1 = numbers[0];
    for (int i = 1; i < numbers.Length; i++)
    {
        if (maxValue1 < numbers[i])
        {
            maxValue1 = numbers[i];
        }
    }
    return maxValue1;
}

int[] GeneraitRandomArray()
{
    var numbers = new int[5];
    var rand = new Random();

    for (var i = 0; i < numbers.Length; i++)
    {
        numbers[i] = rand.Next(-50, 50);
        Console.WriteLine(numbers[i]);
    }

    return numbers;
}