// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
Console.Clear();

Console.WriteLine("Введите размер массива");
int size = int.Parse(Console.ReadLine());
double[] numbers = new double[size];
FillArrayRandomNumbers(numbers);
Console.WriteLine("Массив: ");
PrintArray(numbers);

double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int b = 0; b < numbers.Length; b++)
{
    if (numbers[b] > max)
        {
            max = numbers[b];
        }
    if (numbers[b] < min)
        {
            min = numbers[b];
        }
}
double result = max - min;
double itog = Math.Round(result, 2);

Console.WriteLine($"Всего {numbers.Length} чисел. Максимальное значение = {max}, минимальное значение = {min}");
Console.WriteLine($"Разница между максимальным и минимальным значением = {itog}");

void FillArrayRandomNumbers(double[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
    }
}

void PrintArray(double[] numbers)
{
    Console.Write("[ ");
    for (int i = 0; i < numbers.Length; i++)
    {
       Console.Write(numbers[i] + "; ");
    }
    
    Console.Write("]");
    Console.WriteLine();
}
