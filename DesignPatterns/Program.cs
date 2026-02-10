// State pattern

using DesignPatterns.DesignPatterns.State;
using Document = DesignPatterns.DesignPatterns.State.GoodSolution.Document;

var doc = new Document(UserRoles.Admin);
Console.WriteLine(doc.State);

doc.Publish();
Console.WriteLine(doc.State);

doc.Publish();
Console.WriteLine(doc.State);

