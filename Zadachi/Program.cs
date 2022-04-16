//Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа кратные 3-ём в промежутке от M до N.Рекурсия

Console.WriteLine ("Задача 64");
int z = 2;
int q = 18;
string s = string.Empty;

if ( z<=0 || q<= 0)

{
    Console.WriteLine ("Вы ввели ненатуральные числа. Попробуйте еще раз.");
}

else
{
    Recursion(z,q);
}

   void Recursion ( int x, int y)
  {
   if (x>y) return;

   {if ( x % 3 == 0)
     {
       s= s + x +  " ";
     } 
   }
  Recursion(x+1,y);

}
Console.Write (s);
Console.WriteLine(  ); 

//Задача 66. Рекурсия.Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
 Console.WriteLine ("Задача 66");
int m = 2;
int n = 18;
int sum = 0;

if ( n<=0 || m<= 0)

{
    Console.WriteLine ("Вы ввели ненатуральные числа. Попробуйте еще раз.");
}

else
{
    Recursion2 (m,n);
}


void Recursion2(int c, int d)

{
    {if ( c>d) return;
    }
   if ( c> 0)
   {
       sum= sum + c;
   }
   Recursion2(c+1, d);
   
}
Console.WriteLine (sum);


Console.WriteLine ("Задача 68");

int a = 3;
int b = 4;

 int Recursion3 ( int m, int n)
{

if (m == 0)

   return n + 1;

 else if ( n == 0)

  return Recursion3 ( m-1, 1);

else 

return Recursion3 ( m-1, Recursion3 ( m, n-1));

}

 Console.WriteLine ("Функция Аккермана принимает значение " + Recursion3 ( a, b));



