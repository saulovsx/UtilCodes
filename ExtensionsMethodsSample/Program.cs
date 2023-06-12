using ExtensionsMethodsSample;

string stringDate = "21/12/2023";
DateTime date = stringDate.ToDate();
Console.WriteLine($"The date is {date}");

string pathBase = "C:\\MyFolder";
string datePath = date.ToPath(pathBase);
Console.WriteLine($"The path is {datePath}");

string textAccent = "Café com Açucar";
Console.WriteLine($"{textAccent}\n{textAccent.RemoveAccent()}");