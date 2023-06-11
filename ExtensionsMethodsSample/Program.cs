using ExtensionsMethodsSample;

string stringDate = "21/12/2023";
Console.WriteLine($"The date is {stringDate.ToDate()}");

string textAccent = "Café com Açucar";
Console.WriteLine($"{textAccent}\n{textAccent.RemoveAccent()}");