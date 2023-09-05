//1Output all elements excepting ArtObjects
Console.WriteLine(string.Join(" ", list1.Where(x => x is ArtObject)));

// 2 Output all actors names

Console.WriteLine();
Console.WriteLine(string.Join(" ", list1.Where(x => x is Film)
    .SelectMany(x => ((Film)x).Actors.Select(x => x.Name + "\n"))));

// 3 Output number of actors born in august
Console.WriteLine();
Console.WriteLine(string.Join(" ", list1.Where(x => x is Film)
    .SelectMany(x => ((Film)x).Actors.Where(x => x.Birthdate.Month == 8)
    .Select(y=> y.Name + "\n"))));

// 4 Output two oldest actors names
Console.WriteLine(string.Join(" ", list1.Where(x => x is Film)
    .SelectMany(x => ((Film)x).Actors.OrderBy(b => b.Birthdate)
    .Take(2)
    .Select(y => y.Name + "\n"))));


// 5 Output number of books per authors
Console.WriteLine(string.Join(" ", list1.Where(x => x is Book)
    .GroupBy(x => ((Book)x).Author)
    .Select(x => x.Key + " - " + x.Count())));


//6 Output number of books per authors and films per director
Console.WriteLine(string.Join(" ", list1.Where(x => x is Book || x is Film)
    .GroupBy(x => ((ArtObject)x).Author)
    .Select(x => "\n" + (x.GetType() == typeof(Book) ? "Book Author" : "Film Author") + x.Key + " - " + x.Count() + "\n"))); //mistake

Console.WriteLine(string.Join(" ", list1.Where(x => x is Book || x is Film)
    .GroupBy(x => ((ArtObject)x).Author)
    .Select(x => "\n" + (x.GetType() == typeof(Book) ? "Book Author" : "Film Author") + x.Key + " - " + x.Count() + "\n")));//mistake

Console.WriteLine(string.Join(" ", list1.Where(x => x is Book || x is Film)
    .GroupBy(x => ((ArtObject)x)))
    .Select(group => new);//mistake

Console.WriteLine(string.Join(" ", list1.Where(x => x is Book || x is Film)
    .GroupBy(x => new { author = ((ArtObject)x).Author, t = ((ArtObject)x).GetType() })
    .Select(x => "\n" + (x.Key.t == typeof(Book) ? "AuthorBook" : "Author Film") + x.Key.author + " " + x.Count())));