// See https://aka.ms/new-console-template for more information
using ImmoConsole.Models;

var agent = new Agent("Dupont", "Alice");
var bien = new BienImmobilier("Appartement T2", "Paris", 50);

Console.WriteLine("Informations du bien");
Console.WriteLine($"Agent : {agent.Prenom} {agent.Nom}");
Console.WriteLine($"Bien : {bien.Title}");
Console.WriteLine($"Ville : {bien.Ville}");
Console.WriteLine($"Surface : {bien.Surface} m²");