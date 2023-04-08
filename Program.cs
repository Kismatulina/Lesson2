// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
/* Домашняя работа:
 Задача 10: Напишите программу, которая принимает на вход трёхзначное число
и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1*/
/*Console.Write("Введите трехзначное число");
number = int.Parse(input ("Введите трехзначное число" ));
second_digit = (number % 100);
print("Вторая цифра числа:", second_digit); //не правильно говорит*/

/* Console.Write("Введите трехзначное число");
number = int.Parse(Console.ReadLine());
int result = number;
return result;

if (number > 100 || number >=1000 )
{ 
  Console.WriteLine("Вы ввели не трехзначное число, пожалуйста повторите ввод");
  return;
}
int second_digit = number / 10 % 10;
Console.WriteLine($"Вторая цифра {second_digit}");*/
//int Promt(string messege)
Console.Write("Введите трехзначное число");
int number = int.Parse(Console.ReadLine());
int result = number;
 
if (number < 100 || number >=1000 )
{ 
  Console.WriteLine("Вы ввели не трехзначное число, пожалуйста повторите ввод");
  return;
}
Console.WriteLine($"Введенное число '{number}'");
int second_digit = number / 10 % 10;
Console.WriteLine($"Вторая цифра '{second_digit}'");




/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа
или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6*/
/*Console.Write("Введите число");
int number = int.Parse(Console.ReadLine());
int a = 3;
int result = number % 10;

if (result == o)
{
Console.Write(result);
}*/

/*Console.Write("Введите число" );
int number = int.Parse(Console.ReadLine());
int a = 3; как индекс написать
int result = a;

Console.Write(result);


/*Console.Write(result);*/
Console.Write("Введите трехзначное число");
int number = int.Parse(Console.ReadLine());
int result = number;
 
if (number < 100 || number >=1000 )
{ 
  Console.WriteLine("Вы ввели не трехзначное число, пожалуйста повторите ввод");
  return;
}
Console.WriteLine($"Введенное число '{number}'");
int second_digit = number / 10 % 10;
Console.WriteLine($"Вторая цифра '{second_digit}'");


/*Задача 15: Напишите программу, которая принимает на вход цифру,
обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет*/
/*Console.Write("Введите число");
int number = int.Parse(Console.ReadLine());
int i = 0;
while (i <=7 )
{
  /*if (number == 6 & 7)
  if (number == 6 )
  {
    Console.Write("выходной");
  }
  else
  {
    Console.Write("нет"); здесь нет пошла писаться без остановки, ужас
    break

  }
}*/
