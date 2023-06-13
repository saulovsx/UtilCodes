﻿using System;
using ExtensionsMethodsSample;

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
Console.WriteLine($"The string with white space : {stringWhiteSpace.ContainsValue()}");

string stringValue  = "Test value";
Console.WriteLine($"The string value : {stringValue.ContainsValue()}");

string stringTileCase  = "title case";
Console.WriteLine($"The string in TileCase : {stringTileCase.ToTitleCase()}");

string stringAlphaNumeric  = "siga-me 30/10 {3}";
Console.WriteLine($"Clean string : {stringAlphaNumeric.RemoveNonAlphanumeric()}");

DateTime dateISO8601 = DateTime.Now;
TimeSpan offSet = new TimeSpan(-3,0,0);
Console.WriteLine($"DateTime ISO8601 String : {dateISO8601.ToISO8601(offSet)}");
Console.WriteLine($"DateTimeOffset : {dateISO8601.ToDateOffSet(offSet)}");