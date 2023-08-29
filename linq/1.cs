//Print all numbers from 10 to 50 separated by commas
Console.WriteLine(string.Join(',', Enumerable.Range(10, 41).ToList()));

//Print only that numbers from 10 to 50 that can be divided by 3
Console.WriteLine(string.Join(',', Enumerable.Range(10, 41).ToList().Where(x => x % 3 == 0)));

//Output word "Linq" 10 times
Console.WriteLine(string.Join(' ', Enumerable.Repeat("Linq", 10)));

//Output all words with letter 'a' in string "aaa;abb;ccc;dap"
Console.WriteLine(string.Join(" ", "aaa;abb;ccc;dap".Split(';').Where(x => x.Contains('a'))));

//Output number of letters 'a' in the words with this letter in string "aaa;abb;ccc;dap" separated by comma
Console.WriteLine(string.Join(" ", "aaa;abb;ccc;dap".Split(';').Where(x => x.Contains("a")).Select(x => x.Count(y => y == 'a'))));

//Output true if word "abb" exists in line  "aaa;xabbx;abb;ccc;dap", otherwise false
Console.WriteLine(string.Join(" ", "aaa;xabbx;abb;ccc;dap".Split(';').Any(x => x.Equals("abb"))));

//. Get the longest word in string "aaa;xabbx;abb;ccc;dap"
Console.WriteLine(string.Join(" ", "aaa;xabbx;abb;ccc;dap".Split(';').Max()));

//Calculate average length of word in string "aaa;xabbx;abb;ccc;dap"
Console.WriteLine(string.Join(" ", "aaa;xabbx;abb;ccc;dap".Split(';').Average(x => x.Count())));

//Print the shortest word reversed in string "aaa;xabbx;abb;ccc;dap;zh"
string a = "aaa;xabbx;abb;ccc;dap;zh";
string b = a.Split(';').Where(x => x.Length == a.Split(';').Min(x => x.Length)).First();
Console.WriteLine(b);

//10.Print true if in the first word that starts from "aa" all letters are 'b' otherwise false "baaa;aabb;aaa;xabbx;abb;ccc;dap;zh"
Console.WriteLine(string.Join(" ", "baaa;aabb;aaa;xabbx;abb;ccc;dap;zh".Split(';').Select(x => x.StartsWith("aa") && x.Skip(2).All(x => x == 'b'))));

//11. Print last word in sequence that excepting first two elements that ends with "bb"
a = "aaa;xabbx;abb;ccc;dap;zh";
b = a.Split(';').Where(x => x.Length == a.Split(';').Min(x => x.Length)).First();