// Inheritance

/*
 * Inheritance involves creating new classes (subclasses or derived classes) based on existing classes (superclasses or base classes).
 * Subclasses inherit properties and behaviours from their superclasses and can also add new features or override existing ones. Inheritance is
 * often described in terms of an "is-a" relationship.
 */

using DesignPatterns.OOPPrinciples.Inheritance;

var car = new Car();

// Shared
car.Brand = "Chevy";
car.Start();
car.Stop();

// Unique
car.NumberOfDoors = 5;

