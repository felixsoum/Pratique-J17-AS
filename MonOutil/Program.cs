// See https://aka.ms/new-console-template for more information

using MonOutil;

Console.Write("Bonjour, quel est votre nom?");

string? username;
username = Console.ReadLine();

// Code qui accueille l'utilisateur par son nom
Console.WriteLine($"Bienvenue {username} à MonOutil.");

new Meteo();