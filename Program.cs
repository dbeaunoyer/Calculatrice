int num1 = 0; int num2 = 0;

// Titre app
Console.WriteLine("Calculatrice en C#\r");
Console.WriteLine("------------------------\n");

// 1 nombre
Console.WriteLine("Choisi un nombre + enter");
num1 = Convert.ToInt32(Console.ReadLine());

// 2e nombres
Console.WriteLine("Choisi un deuxième nombre + enter\n");
num2 = Convert.ToInt32(Console.ReadLine());

// Condition plus grand que 
if (num1 > num2)
{
    Console.WriteLine("le premier est plus grand que le deuxieme \n");
}

// Deux nombres égaux ?
else if (num1 == num2)
{
    Console.WriteLine("les deux nombres sont égaux \n");

}

// option type operation
Console.WriteLine("Choisir le type d'opération :");
Console.WriteLine("\ta - Addition");
Console.WriteLine("\ts - Soustraction");
Console.WriteLine("\tm - Multiplication");
Console.WriteLine("\td - Division");
Console.Write("Ton choix? ");


// switch
switch (Console.ReadLine())
{
    case "a":
        Console.WriteLine($"Ton résulat: {num1} + {num2} = " + (num1 + num2));
        break;
    case "s":
        Console.WriteLine($"Ton résultat: {num1} - {num2} = " + (num1 - num2));
        break;
    case "m":
        Console.WriteLine($"Ton résultat: {num1} * {num2} = " + (num1 * num2));
        break;
    case "d":
        Console.WriteLine($"Ton résultat: {num1} / {num2} = " + (num1 / num2));
        break;
}
// attendre réponse et ferme
Console.Write("Appuis sur une touche pour fermer");
Console.ReadKey();