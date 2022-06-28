Console.Clear();
Console.WriteLine();
Console.Write("Введи трёхзначное число: ");
int threeDigitNumber = Convert.ToInt32(Console.ReadLine());
string stringNumber = Convert.ToString(threeDigitNumber);
Console.WriteLine("вторая цифра этого числа "+stringNumber[1]);


Console.Write("Введи число: ");
int anyNumber = Convert.ToInt32(Console.ReadLine());
string anyNumberText = Convert.ToString(anyNumber);
if (anyNumberText.Length > 2){
  Console.WriteLine("третья цифра" + anyNumberText[2]);
}
else {
  Console.WriteLine("третьей цифры нет");
}
Console.Write("Введи цифру, обозначающую день недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

void CheckingTheDayOfTheWeek (int dayNumber) {
  if (dayNumber == 6 || dayNumber == 7) {
  Console.WriteLine("этот день выходной");
  }
  else if (dayNumber < 1 || dayNumber > 7) {
    Console.WriteLine("это вообще не день недели");
  }
  else Console.WriteLine("это не выходной");
}

CheckingTheDayOfTheWeek(dayNumber);

Console.WriteLine("Введите 1 число");
int namberOdin = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2 число");
int namberDva = Convert.ToInt32(Console.ReadLine());
if (namberOdin % namberDva == 0)
{
    Console.WriteLine("1 кратно 2");
}
else
{
    Console.WriteLine($"{namberOdin} не кратно {namberDva}, остаток {namberOdin%namberDva}");
    
}

