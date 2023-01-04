// Вывести через рекурсию все числа по возрастанию в 
// промежутке от M до N, которые запрашиваем у пользователя

Console.WriteLine("Введите число M");
int numM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N");
int numN = Convert.ToInt32(Console.ReadLine());

int start1 = numM + 1;
int end1 = numN - 1;

if(numM > numN) 
  {
    start1 = numN + 1;
    end1 = numM - 1;
  }

string PrintSequenceNumbers(int start, int end)
{
  
  if(start == end) return start.ToString();

  return(start + ", " + PrintSequenceNumbers(start + 1, end));
}

Console.WriteLine(PrintSequenceNumbers(start1, end1));
