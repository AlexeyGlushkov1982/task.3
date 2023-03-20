// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

int ReadInt(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}
double endResult(int ax, int ay, int az, int bx, int by, int bz)
{
    return Math.Sqrt(Math.Pow(bx - ax, 2) + Math.Pow(by - ay, 2) + Math.Pow(bz - az, 2));
}
int[] tochka1 = new int[3];
int[] tochka2 = new int[3];

tochka1[0] = ReadInt("введите х1 = ");
tochka1[1] = ReadInt("введите y1 = ");
tochka1[2] = ReadInt("введите z1 = ");
tochka2[0] = ReadInt("введите х2 = ");
tochka2[1] = ReadInt("введите y2 = ");
tochka2[2] = ReadInt("введите z2 = ");

double result = endResult(tochka1[0], tochka1[1], tochka1[2], tochka2[0], tochka2[1], tochka2[2]);
Console.Write($"расстояние между двумя точками A - > B в трехмерном пространстве = {result}");
