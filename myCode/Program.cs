// See https://aka.ms/new-console-template for more information
using FluentColorConsole;

Console.WriteLine("Test Message.");

var showMessage = new ShowMessage();
showMessage.WriteLine();

var textLine = ColorConsole.WithBlueText;
textLine.WriteLine("My text is blue.");