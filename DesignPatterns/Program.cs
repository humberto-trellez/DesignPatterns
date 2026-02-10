// Memento

// The Memento Pattern is used to restore an object to previous state.

using DesignPatterns.DesignPatterns.Behavioral.Memento;

var editor = new Editor();
var history = new History(editor);

history.Backup();
editor.Title = "Test";
history.Backup();
editor.Content = "Hello there, my name is Lalo";
history.Backup();
editor.Title = "The life of dev: my mementos";

Console.WriteLine("Title: " + editor.Title);
Console.WriteLine("Content: " + editor.Content);

history.Undo();
Console.WriteLine("Title: " + editor.Title);
Console.WriteLine("Content: " + editor.Content);

history.ShowHistory();
