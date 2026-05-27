// chiedo all'utente quanto pesa
Console.WriteLine("Mi dici quanto pesi?");
// ascolto quello che mi dice
string peso = Console.ReadLine();
// chiedo ora all'utente quanto è alto in metri
Console.WriteLine("E quanto sei alto?");
// aspetto che me lo dica
string altezza = Console.ReadLine();
// se ora voglio calcolare il BMI
// devo usare la formula: pesoKg / (altezzaMt * altezzaMt)
float pesoKg = float.Parse(peso);
float altezzaMt = float.Parse(altezza);
// calcolo il mio indice
float bmi = pesoKg / (altezzaMt * altezzaMt);
Console.WriteLine("Il tuo BMI è " + bmi);