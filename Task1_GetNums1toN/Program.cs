// Вывести через рекурсию все числа от 1
// до N, который запрашиваем у пользователя

Console.WriteLine("Введите число N");
int numN = Convert.ToInt32(Console.ReadLine());

string PrintSequenceNumbers(int start, int end)
{
  if(start == end) return(start.ToString());

  return(start + ", " + PrintSequenceNumbers(start + 1, end));
}

Console.WriteLine(PrintSequenceNumbers(1, numN));