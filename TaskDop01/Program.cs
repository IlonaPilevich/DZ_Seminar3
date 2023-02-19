// Дополнительная задача. Представим банк, в котором алгоритм начисления процентов по вкладу зависит от суммы вклада

Console.Write("Введите сумму вклада: ");
double N = Convert.ToInt32(Console.ReadLine());

if (N < 100)
{
    double i = N + N*5/100;
    Console.WriteLine("Общая сумма вклада с начисленными процентами - " + Math.Round(i, 2));
}
if (N >= 100 && N <=200)
{
    double i = N + N*7/100;
    Console.WriteLine("Общая сумма вклада с начисленными процентами - " + Math.Round(i, 2));  
}
if (N >= 200)
{
    double i = N + N*10/100;
    Console.WriteLine("Общая сумма вклада с начисленными процентами - " + Math.Round(i, 2));
}
