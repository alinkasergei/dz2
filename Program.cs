// Задача 1 
// Напишите программу,которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.


Console.Write("Input a number: ");
int n = Convert.ToInt32(Console.ReadLine());
string number = n.ToString();
void ShowPolindrom(string number)
{
    if (number[0] == number[4] || number[1] == number[3])
    {
        Console.WriteLine("number is polindrom. ");
    }
    else Console.WriteLine("number isn't polindrom. ");
}

ShowPolindrom(number);


//Напишите программу, которая принимает на вход координаты двух точек 
//и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int x1 = Coordinate("x", "A");
int y1 = Coordinate("y", "A");
int z1 = Coordinate("z", "A");
int x2 = Coordinate("x", "B");
int y2 = Coordinate("y", "B");
int z2 = Coordinate("z", "B");

int Coordinate(string coorName, string pointName)
{
    Console.Write("Введите координату {coorName} точки {pointName}: ");
    return Convert.ToInt16(Console.ReadLine());
}
double GetDist(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double Xline = x2 - x1;
    double Yline = y2 - y1;
    double Zline = z2 - z1;

    double distQ = Xline * Xline + Yline * Yline + Zline * Zline;
    double result = Math.Sqrt(distQ);
    return result;
}

double result = GetDist(x1, y1, z1, x2, y2, z2);
Console.WriteLine(result);


//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Write("Input a number: ");
int n = Convert.ToInt32(Console.ReadLine());

void CubeTable(int n)
{
    for (int j = 1; j <= n; j++)
    {
        int res = (int)Math.Pow(j, 3);
        System.Console.WriteLine(res + " ");
    }
}

CubeTable(n);
