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