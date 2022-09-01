# SOLID-priciples-simple-app

S — Single Responsibility
O — Open Closed
L — Liskov Substitution
I — Interface Segregation
D — Dependency Inversion


Console App greets the user, loads all available products from a menu file, then displays the products to the user.

-added a file name it menu.json - Product list
-added a file name it menu.csv - Product list


1. Single Responsibility Principle (SRP) 
Definition:
  A class should have only one reason to change.
  
This is the original definition of the SRP, and I find it a little bit ambiguous. So my own translation for this principle is:
    A class should only do one type of things.

Please pay attention to my wording here, I said “one type of things”, not “one thing”, this is important, and I will explain why when we implement the SRP.

2. OPEN CLOSED PRINCIPLE.

Definition:
  Software entities such as classes, modules, functions, should be open for extension, but closed for modification

Hmm, not so clear. In my own words:
  When making changes, try to not modify the old working code, add new code instead.
  
3.Liskov Substitution Principle (LSP)

Definition:
  Objects of a superclass shall be replaceable with objects of its subclasses without breaking the application.

My translation:
  A Subclass must be able to fully replace its superclass.

4.Dependency Inversion Principle (DIP)

Definition:
  High level modules should not depend on low level modules. Both should depend on abstractions.

My translation:
  Depend on interfaces.

