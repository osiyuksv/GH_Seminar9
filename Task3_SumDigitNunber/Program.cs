// Вывести сумму цифр задаваемого
// пользователем числа N

Console.WriteLine("Введите число N");
int numN = Convert.ToInt32(Console.ReadLine());
int SumDigit = 0;

int SumDigitNunber(int number)
{
  if(number / 10 == 0) return (number % 10);

  else
  {
    SumDigit = number % 10;
    return(SumDigit + SumDigitNunber(number / 10));
  }
}

Console.WriteLine(SumDigitNunber(numN));
