
Console.WriteLine("Введите массив строк через пробел");
string stroka = Console.ReadLine();
string[] strArr = stroka.Split(' ');
var result = new string[strArr.Length];
int realSize = 0;
foreach (var value in strArr)
{
    if (value.Length <= 3)
    {
        result[realSize] = value;
        realSize++;
    }
}
Console.WriteLine(string.Join(", ", result, 0, realSize));