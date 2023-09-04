//1Output all elements excepting ArtObjects
/*Console.WriteLine(string.Join(" ", list1.Where(x => x is ArtObject)));*/

// 2 Output all actors names

/*Console.WriteLine();
Console.WriteLine(string.Join(" ", list1.Where(x => x is Film)
    .SelectMany(x => ((Film)x).Actors.Select(x => x.Name + "\n"))));*/

// 3 Output number of actors born in august
/*Console.WriteLine();
Console.WriteLine(string.Join(" ", list1.Where(x => x is Film)
    .SelectMany(x => ((Film)x).Actors.Where(x => x.Birthdate.Month == 8)
    .Select(y=> y.Name + "\n"))));*/

// 4 Output two oldest actors names
/*Console.WriteLine(string.Join(" ", list1.Where(x => x is Film)
    .SelectMany(x => ((Film)x).Actors.OrderBy(b => b.Birthdate)
    .Take(2)
    .Select(y => y.Name + "\n"))));*/