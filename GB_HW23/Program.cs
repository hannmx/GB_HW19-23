Console.Write("Введите целое натуральное число: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine("Таблица кубов от 1 до " + num + " равна:");
double[] arr = new double[num];
int i = 0;
while(i < num)
{
    arr[i] = i + 1;
    arr[i] = Math.Pow(arr[i], 3); 
    Console.Write(arr[i] + " ");
    i++;
}