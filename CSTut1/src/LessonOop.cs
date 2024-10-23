using System;

namespace CSTut1.src;

public class LessonOop
{

  public LessonOop() {
    Animal animalChicken = new Animal(
      "chicken", "blue", 2, "Gho! Gho!"
    );

    animalChicken.MakeSound();
    animalChicken.WhoAreYou();

    Car car1 = new Car();

    car1.Color = "red";

    var carName = car1.Color;
    Console.WriteLine(carName);

    Car car2 = new Car();
    car2.Color = "blue";
    Console.WriteLine(car2.Color);

  }
}

public class Animal{
  private string _Name;
  private string _Color;
  private int _Age;
  private string _Sound;

  public Animal(string Name, string Color, int Age, string Sound) {
    this._Name = Name;
    this._Color = Color;
    this._Age = Age;
    this._Sound = Sound;
  }

  public void MakeSound() {
    Console.WriteLine($"{this._Name} says {this._Sound}!");
  }

  public void WhoAreYou() {
    Console.WriteLine($"name is: {this._Name}, i am {this._Color}");
  }
}

public class Car {
  private string Make {get; set;}
  private string Model {get; set;}
  private int Year {get; set;}
  // _Color can be null
  private string? _color;
  public string Color {
    get {return this._color;}

    set {
      // you can do validation inside of the setter
      if (value != "blue") {
        this._color = value;
      }
      else {
        this._color = "You want blue!?";
      }
    }
  }
}

public class Person {
  public Person(){}
}

/*

# about namespace:
==

# folder based namespace: 
==
  # Folder 
    # Class
    # Class

and then inside the file 

# put this on top
namespace CSTut1.src;

# or wrap class inside namespace
namespace MyProject.Models
{
  public class User
  {
      // Class implementation
  }
}

# also you can not have a folder and just wrap class inside a namespace

namespace MyCustomNamespace
{
  public class User
  {
      // Class implementation
  }
}

*/ 