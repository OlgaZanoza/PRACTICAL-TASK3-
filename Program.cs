
/*
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

Console.WriteLine("Принимает на вход пятизначное число и проверяет, является ли оно полиндромом");
Console.Write("Ввести число: ");
string? number = Console.ReadLine();

void CheckingNumber(string number){
  if (number[0]==number[4] || number[1]==number[3]){
    Console.WriteLine($"Число: {number} - палиндром.");
  }
  else Console.WriteLine($"Число: {number} - НЕ палиндром.");
}

if (number!.Length == 5){
  CheckingNumber(number);
}
else Console.WriteLine($"Ввести правильное число");



/*
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

Console.WriteLine("Ввести координаты точки А: ");
Console.Write("X = ");
double x1 = Convert.ToDouble(Console.ReadLine()); 
Console.Write("Y = ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Z = ");
double z1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Ввести координаты точки B: ");
Console.Write("X = ");
double x2 = Convert.ToDouble(Console.ReadLine()); 
Console.Write("Y = ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Z = ");
double z2 = Convert.ToDouble(Console.ReadLine());

double result = Math.Sqrt(Math.Pow((x1 - x2), 2)
              + Math.Pow((y1 - y2), 2)
              + Math.Pow((z1 - z2), 2));

Console.WriteLine($"Расстояние между точками A и B = {result:F}");


/*
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

Console.WriteLine("Принимает на вход число, и выдает таблицу кубов от 1 до N");
Console.Write("Ввести число: ");
int cube = Convert.ToInt32(Console.ReadLine());

void Cube(int[] cube){
  int counter = 0;
  int length = cube.Length;
  while (counter <  length){
    cube[counter] = Convert.ToInt32(Math.Pow(counter, 3));
    counter++;
  }
}

void PrintArry(int[] coll){
  int count = coll.Length;
  int index = 0;
  while(index < count){
    Console.Write(coll[index]+ " ");
    index++;
  }
} 

int[] arry = new int[cube+1];
Cube(arry);
PrintArry(arry);




