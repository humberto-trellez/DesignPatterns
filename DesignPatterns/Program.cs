// Dependency Inversion Principle (DIP):

/*
 * High-level modules should not depend on low-level modules. Both should depend on
 * abstraction
 */

using DesignPatterns.SOLID.D;

var car = new Car(new Engine());