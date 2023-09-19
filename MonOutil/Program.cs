// See https://aka.ms/new-console-template for more information

using MonOutil;

Console.Write("Hello, what is your name?");

string? username;
username = Console.ReadLine();

// Code qui accueille l'utilisateur par son nom
Console.WriteLine($"Nice to meet you {username}, welcome to MonOutil.");

new Meteo();