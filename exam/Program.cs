//Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.  //12321
/*
void Palidrom(int a)
{
    int first=a/10000;
    int second=a/1000%10;
    int fourth=a%100/10;
    int fifth=a%10;
    if(first==fifth && second==fourth)
        Console.WriteLine("Число является палиндромом");
    else
    {
        Console.WriteLine("Число не является палиндромом");
    }
}
Console.WriteLine("Введите пятизначное число ");
int n = Convert.ToInt32(Console.ReadLine());
if(n>=10000 && n<100000)
    Palidrom(n);
else
    Console.WriteLine("Необходимо ввести пятизначное число");

*/
//Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
/*
double Distance(double xA,double yA,double zA,double xB,double yB,double zB)
{
    double distance=Math.Sqrt(Math.Pow(xB-xA,2)+Math.Pow(yB-yA,2)+Math.Pow(zB-zA,2));
    return distance;
}

Console.WriteLine("Введите координаты точки х1 ");
int x1=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки y1 ");
int y1=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки z1 ");
int z1=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки х2 ");
int x2=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки y2 ");
int y2=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки z2 ");
int z2=Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Distance(x1,y1,z1,x2,y2,z2));
*/


// Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
/*
void Cubes(int n)
{
    int count=1;
    while (count<=n)
    {
        Console.Write($"{Math.Pow(count,3)} ");
        count++;    
    }
    
   
}
Console.WriteLine("Введите число ");
int a = Convert.ToInt32(Console.ReadLine());
Cubes(a);
*/

//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

/*
double Multi(double a, double b)
{
    double s=Math.Pow(a,b);
    return s;
}

Console.WriteLine("Введите первое число ");
int n=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int m=Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Multi(n,m));
*/

//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int SumDec(int a)  //1425  1420
{
   int sum=0;
   for(int n = a; n>10; sum+=n1)
   {
        int n1=a%10;
        n=a/10;
        

   }
   return sum;
}


Console.WriteLine("Введите число ");
int n=Convert.ToInt32(Console.ReadLine());
Console.WriteLine(SumDec(n));



// Задача 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран.
/*
int[] FindArray(int size)
{
    int[] newArray= new int[size];
    
    for(int i =0; i<size;i++)
        newArray[i]=new Random().Next();
    return newArray;
}

void ShowArray(int [] array )
{
    for(int i = 0; i< array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine("Введите кол-во элементов ");
int size= Convert.ToInt32(Console.ReadLine());
int [] myArray=FindArray(size);
ShowArray(myArray);
*/