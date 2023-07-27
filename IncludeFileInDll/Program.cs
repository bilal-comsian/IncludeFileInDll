// See https://aka.ms/new-console-template for more information
using IncludeFileInDll;

Console.WriteLine("Hello, World!");

string data = EmbeddedFileClass.GetEmbeddedTxtFileContent();
Console.WriteLine(data);
Console.ReadLine();
