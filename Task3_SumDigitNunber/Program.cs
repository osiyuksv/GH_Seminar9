// Вывести сумму цифр задаваемого
// пользователем числа N

Console.WriteLine("Введите число N");
int numN = Convert.ToInt32(Console.ReadLine());

int SumDigitNunber(int number)
{
  if(number == 0) return (0);
  return(number % 10 + SumDigitNunber(number / 10));
}

Console.WriteLine(SumDigitNunber(numN));
