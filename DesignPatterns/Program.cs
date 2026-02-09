// Interface Segregation Principle (ISP):

/*
 * Clients should not be forced to depend on intergaces they do not use.
 */

using DesignPatterns.SOLID.I;

var circle = new Circle();
circle.Radius = 10;
Console.WriteLine(circle.Area());

var sphere = new Sphere();
sphere.Radius = 10;
Console.WriteLine(sphere.Area());
Console.WriteLine(sphere.Volume());
