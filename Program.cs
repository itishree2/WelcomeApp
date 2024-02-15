// See https://aka.ms/new-console-template for more information
using WelcomeApp;

Console.WriteLine("Welcome to Authentication App");
SignIn obj= new SignIn();
Console.WriteLine(obj.Authenticate("Mama","Mama@123"));
