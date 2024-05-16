## OOP Polymorphism
#### Du ska skapa en klass som ska vara ParentClass till de andra klasserna som ska ärva från den. Klassen ska heta Geometri{ } och den ska ha en metod som heter Area() och dess return type är en double.

#### Du ska skapa fem klasser som ska ärva från Geometriklassen, de klasserna ska heta Rektangel, Fyrkant, Cirkel , Parallellogram och Ellips. Alla dessa klasser ska ha en metod som heter Area().

####  Varje klass ska ha minst en egenskap, till exempel:

#### public class Cirkel
#### {
####      public double Radius {get; set;}
#### }

#### I alla ChildClasses ska vi overrida metoden Area() med olika implementeringar eftersom arean för en cirkel inte räknas ut på samma sätt som arean för en fyrkant.

#### Alla ChildClasses måste ha en konstruktor för att ge värden till egenskaperna. Vi ska ge ett fast värde i konstruktorn. Till exempel:

#### public Cirkel
#### {
####       Radius = 4;
#### }

#### I Main()-metoden ska du skapa en object reference från Geometriklassen och den ska peka mot ett objekt i varje klass.
