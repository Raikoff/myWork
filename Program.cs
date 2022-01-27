
string[] myArray = new string[3];
Console.Write("Введите данные №1: ");
string a = Console.ReadLine();
Console.Write("Введите данные №2: ");
string b = Console.ReadLine();
Console.Write("Введите данные №3: ");
string c = Console.ReadLine();
myArray[0] = a;
myArray[1] = b;
myArray[2] = c;

for(int i = 0; i < 3; i++)
    {
       if(myArray[i].Length < 4 && myArray[i].Length > 0)
       {
        Console.WriteLine(myArray[i]);
       }
    }


