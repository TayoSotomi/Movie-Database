

using Movie_Database;
using System;
using System.ComponentModel;
using System.Diagnostics;
using Circle;
;
//int count = 0;
List<Movie> Films = new List<Movie>()

{
    new Movie("Wednesday", "action"),
    new Movie("Grease", "romance"),
    new Movie("Carter", "action"),
    new Movie("White Noise", "drama"),
    new Movie("Spider Head", "sci-fi"),
    new Movie("Shawshank Redemption", "drama"),
    new Movie("The Dark Knight", "action"),
    new Movie("Run Hide Fight", "action"),
    new Movie("Zootopia", "animated"),
    new Movie("How to Train Your Dragon", "animation"),
    new Movie("Terminal List", "action"),
    new Movie("Instant Family", "drama"),
    new Movie("La Misma Luna", "drama"),
    new Movie("Pilgrim's Progress", "animation"),
    new Movie("Insanity of God", "historical"),
    new Movie("Swiss Family Robinson", "adventure"),
    new Movie("Harriet", "historical"),
    new Movie("The Green Book", "historical"),
    new Movie("News of the World", "drama"),
    new Movie("Lord of the Rings", "adventure"),
    new Movie("The Princess Bride", "adventure"),
    new Movie("Big Hero 6", "animation"),
    new Movie("Little Women", "historical"),
    new Movie("Avengers: Endgame", "adventure")

};

//bool Input = true;

bool ToContinue = true;

Console.WriteLine("Welcome to my Movies!");
//list all movie categories
List<Movie> distinctCategory = Films.GroupBy(x => x.Category).Select(x => x.First()).ToList();
foreach (Movie film in distinctCategory)
{
    Console.WriteLine($"This are my categories {film.Category}");
}
Console.WriteLine();

while (ToContinue)
{

    Console.WriteLine("1. Action");
    Console.WriteLine("2. Drama");
    Console.WriteLine("3. Romance");
    Console.WriteLine("4. Historical");
    Console.WriteLine("5. Adventure");
    Console.WriteLine("6. Animation");
    Console.WriteLine("7. Sci-Fi");
    Console.Write("which Category would you like to view?: Please choose from the directory above: \n");


    //Validate user input

    int choice = Validator.GetUserNumberInt();

    //Returns movie category based on user input
    if (choice == 1)
    {
        string category = "action"; 
        //saves the list by category
        List<Movie> Action = Films.Where(nameof => nameof.Category == category).ToList();
        Console.WriteLine($"There are {Action.Count} movies in this category");
        //space
        Console.WriteLine();
        Console.WriteLine(String.Format("{0,-25} {1,-25}", "Title", "Category"));
        Console.WriteLine(String.Format("{0,-25} {1,-25}", "========", "========"));

        foreach (Movie M in Action.Where(s => s.Category == category))
        {
            Console.WriteLine(M.GetDetails());
            
        }
        
    }
    else if (choice == 2)
    {
        string category = "drama";
        //saves the list by category
        List<Movie> Drama = Films.Where(nameof => nameof.Category == category).ToList();
        Console.WriteLine($"There are {Drama.Count} movies in this category");
        //space
        Console.WriteLine();
        Console.WriteLine(String.Format("{0,-25} {1,-25}", "Title", "Category"));
        Console.WriteLine(String.Format("{0,-25} {1,-25}", "========", "========"));
        foreach (Movie M in Films.Where(s => s.Category.ToLower() == category))
        {
            Console.WriteLine(M.GetDetails());
        }
    }
    else if (choice == 3)
    {
        string category = "romance";
        //saves the list by category
        List<Movie> Romance = Films.Where(nameof => nameof.Category == category).ToList();
        Console.WriteLine($"There are {Romance.Count} movies in this category");
        //space
        Console.WriteLine();
        Console.WriteLine(String.Format("{0,-25} {1,-25}", "Title", "Category"));
        Console.WriteLine(String.Format("{0,-25} {1,-25}", "========", "========"));
        foreach (Movie M in Films.Where(s => s.Category.ToLower() == category))
        {
            Console.WriteLine(M.GetDetails());
        }
    }
    else if (choice == 4)
    {
        string category = "historical";
        //saves the list by category
        List<Movie> Historical = Films.Where(nameof => nameof.Category == category).ToList();
        Console.WriteLine($"There are {Historical.Count} movies in this category");
        //space
        Console.WriteLine();
        Console.WriteLine(String.Format("{0,-25} {1,-25}", "Title", "Category"));
        Console.WriteLine(String.Format("{0,-25} {1,-25}", "========", "========"));
        foreach (Movie M in Films.Where(s => s.Category.ToLower() == category))
        {
            Console.WriteLine(M.GetDetails());
        }
    }
    else if (choice == 5)
    {
        string category = "adventure";
        //saves the list by category
        List<Movie> Adventure = Films.Where(nameof => nameof.Category == category).ToList();
        Console.WriteLine($"There are {Adventure.Count} movies in this category");
        //space
        Console.WriteLine();
        Console.WriteLine(String.Format("{0,-25} {1,-25}", "Title", "Category"));
        Console.WriteLine(String.Format("{0,-25} {1,-25}", "========", "========"));
        foreach (Movie M in Films.Where(s => s.Category.ToLower() == category))
        {
            Console.WriteLine(M.GetDetails());
        }
    }
    else if (choice == 6)
    {
        string category = "animation";
        //saves the list by category
        List<Movie> Animation = Films.Where(nameof => nameof.Category == category).ToList();
        Console.WriteLine($"There are {Animation.Count} movies in this category");
        //space
        Console.WriteLine();
        Console.WriteLine(String.Format("{0,-25} {1,-25}", "Title", "Category"));
        Console.WriteLine(String.Format("{0,-25} {1,-25}", "========", "========"));
        foreach (Movie M in Films.Where(s => s.Category.ToLower() == category))
        {
            Console.WriteLine(M.GetDetails());
        }
    }
    else if (choice == 7)
    {
        string category = "sci-fi";
        //saves the list by category
        List<Movie> Sci = Films.Where(nameof => nameof.Category == category).ToList();
        Console.WriteLine($"There are {Sci.Count} movies in this category");
        //space
        Console.WriteLine();
        Console.WriteLine(String.Format("{0,-25} {1,-25}", "Title", "Category"));
        Console.WriteLine(String.Format("{0,-25} {1,-25}", "========", "========"));
        foreach (Movie M in Films.Where(s => s.Category.ToLower() == category))
        {
            Console.WriteLine(M.GetDetails());
        }
    }
    else if(choice < 1 || choice > 7)
    {
        ToContinue = false;
        Console.WriteLine("Goodbye");
    }
    //space
    Console.WriteLine();
    ToContinue = Validator.GetContinue();
    //clears the list 
    Console.Clear();
}























