/*
//Задача 64: Задайте значения M и N. Напишите программу, которая выведет
// все натуральные числа в промежутке от M до N.
//M = 1; N = 5. -> ""1, 2, 3, 4, 5""
//M = 4; N = 8. -> ""4, 6, 7, 8""
void ShowNambers(int n, int m)
{
    if(m!=n)
    {
        if(n>m)
        {
            ShowNambers(n-1,m);
            Console.Write(n +" ");
        }
        else
        {
            ShowNambers(m-1,n);
            Console.Write(m +" ");
        }
    }
    else
        Console.Write(m +" ");
}
ShowNambers(5,10);
*/        

/*
//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт 
//сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30


Console.Clear();
Console.WriteLine($"Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N");
int m=InputNumbers("Введите m: ");
int n=InputNumbers("Введите n: ");
int temp=m;

if(m>n) 
{
  m=n; 
  n=temp;
}

PrintSumm(m, n, temp=0);

void PrintSumm(int m, int n, int summ)
{
  summ=summ+n;
  if(n<=m)
  {
    Console.Write($"Сумма элементов= {summ}");
    return;
  }
  PrintSumm(m, n-1, summ);
}

int InputNumbers(string input) 
{
  Console.Write(input);
  int output=Convert.ToInt32(Console.ReadLine());
  return output;
}
*/
/*
//Задача 68: Напишите программу вычисления функции Аккермана с помощью 
//рекурсии. Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 29
Console.Clear();
Console.WriteLine($"Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.");
int m=InputNumbers("Введите m: ");
int n=InputNumbers("Введите n: ");

int functionAkkerman=Ack(m, n);

Console.Write($"Функция Аккермана = {functionAkkerman}");

int Ack(int m, int n)
{
  if(m==0) return n+1;
  else if(n==0) return Ack(m-1, 1);
  else return Ack(m-1, Ack(m, n-1));
}

int InputNumbers(string input) 
{
  Console.Write(input);
  int output=Convert.ToInt32(Console.ReadLine());
  return output;
} 
*/