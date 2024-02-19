
System.Console.WriteLine("Введите пароль: ");
string str = Console.ReadLine();

System.Console.WriteLine(GetLetters(str));

string GetLetters(string str)
{
    string finalString = "";
    foreach (char i in str)
    {
        if(char.IsAsciiLetter(i) == true)
        {
            finalString = finalString + i;
        }
    }
    return finalString;
}
