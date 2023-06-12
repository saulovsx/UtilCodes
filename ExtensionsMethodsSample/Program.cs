﻿using ExtensionsMethodsSample;

string stringDate = "21/12/2023";
DateTime date = stringDate.ToDate();
Console.WriteLine($"The date is {date}");

string pathBase = "C:\\MyFolder";
string datePath = date.ToPath(pathBase);
Console.WriteLine($"The path is {datePath}");

string textAccent = "Café com Açucar";
Console.WriteLine($"{textAccent}\n{textAccent.RemoveAccent()}");

string stringEmpty  = string.Empty;
Console.WriteLine($"The string empty : {stringEmpty.ContainsValue()}");

string stringWhiteSpace = " ";
Console.WriteLine($"The string white space : {stringWhiteSpace.ContainsValue()}");

string stringValue  = "Test value";
Console.WriteLine($"The string value : {stringValue.ContainsValue()}");