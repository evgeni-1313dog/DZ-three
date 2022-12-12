//Задача 19

//Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом.

//14212 -> нет

//12821 -> да

//23432 -> да
/*
void Palindrom(int numb){

    int a = numb % 10;
    int b = (numb / 10000) % 10;
    if (numb < 10000)
    Console.WriteLine(" Не верно введено число");
    else if (numb > 99999)
    Console.WriteLine(" Не верно введено число");
    else if (a == b)
    Console.WriteLine("является палиндромом ");
    else 
    Console.WriteLine("не является палиндромом ");

}

Console.WriteLine($"Введите пятизначное число");
int numb = Convert.ToInt32(Console.ReadLine());
Palindrom (numb);
*/



//Задача 21

//Напишите программу, которая принимает на вход координаты двух точек и находит
 //расстояние между ними в 3D пространстве.

//A (3,6,8); B (2,1,-7), -> 15.84

//A (7,-5, 0); B (1,-1,9) -> 11.53
/*
Console.WriteLine("координату x1 - ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("координату y1 - ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("координату z1 - ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("координату x2 - ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("координату y2 - ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("координату z2 - ");
int z2 = Convert.ToInt32(Console.ReadLine());
 
 double Distance (int x1, int x2, int y1, int y2, int z1, int z2){
 double num = Math.Sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1)+(z2-z1)*(z2-z1));
 return num;
 }
 double distance = Distance (x1, x2, y1, y2, z1, z2);
Console.WriteLine($"расстояние между двух точек + {distance}");
*/

//Задача 23

//Напишите программу, которая принимает на вход число (N) и
// выдаёт таблицу кубов чисел от 1 до N.

//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125
 
/*
 void ShowTable(int num){
    for (int i = 1; i<=num; i++ ){
        int a = (i*i)*i;
        Console.WriteLine(a);
    }
}
Console.WriteLine("Введите число - ");
int number = Convert.ToInt32(Console.ReadLine());
ShowTable(number);

*/
