// Liskov Substitution Principle (LSP):

/*
 * Objects of superclass should be replaceable with objects of its subclass without
 * affecting the correctness of the program.
 */

using DesignPatterns.SOLID.L;

Shape rectangle = new Rectangle { Width = 5, Height = 4 };
Console.WriteLine($"Area of the rectangle: {rectangle.Area}");

Shape square = new Square { SideLength = 5 };
Console.WriteLine($"Area of the square: {square.Area}");
