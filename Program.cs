// See https://aka.ms/new-console-template for more information

using WebAPIClient.Model;

var nowIs = DateTime.Now;

string[] animals = { "Cat", "Alligator", "Fox", "Donkey" };
var str = string.Join(", ", animals);

var value = (new SumInteger()).Sum(new List<int>() { 15, 22, 38 }, 3);


var alice = new List<int>() { 17, 28, 30 };
var bob = new List<int>() { 99, 16, 8 };
var result = (new CompareTriplets()).Compare(alice, bob);

var winner = result[0] > result[1] ? "alice" : "bob";
winner = result[0] == result[1] ? "No one" : winner;

var obj = new SampleEnum();
var samples = obj.GetValues();



Console.WriteLine($"Winner is: {winner}");
Console.WriteLine($"Value is {value}");
foreach (var el in samples)
{
    Console.WriteLine(el.Value);
}
