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


//7. Output how many different letters used in all actors names

Console.WriteLine(string.Join(" ", list1.Where(x => x is Film)
    .GroupBy(x => (x as Film).Actors)
    .SelectMany(x => x.Key
                    .Select(x => x.Name))
                    .Distinct()
                    .Select(x => x + " - " + x.Distinct().Count())));
//8. Output names of all books ordered by names of their authors and number of pages

Console.WriteLine(string.Join(" ", list1.Where(x => x is Book)
    .OrderBy(x => ((Book)x).Author)
    .ThenBy(x => ((Book)x).Pages)
    .Select(x => ((Book)x).Name + " " + ((Book)x).Pages + " " + ((Book)x).Author + "\n")));



//9.Output actor name and all films with this actor

Console.WriteLine(string.Join(" ", list1.Where(x => x is Film)
    .SelectMany(x => ((Film)x).Actors).GroupBy(x =>
    new
    {
        film = list1.Where(y => y is Film && ((Film)y).Actors.Any(name => name.Name == x.Name))
    })
    .Select(x => x.First().Name + " " + string.Join(", ", x.Key.film.Select(y => ((Film)y).Name)) + "\n")));

//10 Output sum of total number of pages in all books and all int values inside all sequences in data

Console.WriteLine(string.Join(" ", list1.Where(x => x is Book).Sum(x => ((Book)x).Pages)
    + list1.Where(x => x is Film).Sum(x => ((Film)x).Length)));

