// Возвести с помощью рекурсии чмсло A в целую 
// степень числа B, которые задаёт пользователь

Console.WriteLine("Введите целое число A, для возведения его в степень");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целое число B, для возведения на него в степень");
int numB = Convert.ToInt32(Console.ReadLine());

int RaiseDegree(int foundation, int degree)
{
  if(degree == 0) return (1);
  return(foundation * RaiseDegree(foundation, degree - 1));
}

Console.WriteLine(RaiseDegree(numA, numB));
