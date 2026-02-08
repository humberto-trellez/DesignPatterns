// Coupling

// The degree of dependency between different classes

using DesignPatterns.OOPPrinciples.Coupling;

var order = new Order(new SmsSender());
order.PlaceHolder();