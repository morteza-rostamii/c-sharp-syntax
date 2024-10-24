using System;

namespace CSTut1.src;

public static class Lesson1
{
  //public Lesson1() {}

  // enum inside a class
  public enum Status {
    Active,
    Inactive,
    Deleted
  };

  public static void Run() {
    Console.WriteLine("Listen one!");
/*
    // c# array
    decimal[] grades = new decimal[5];
    grades[0] = 11;

    // declare and array of int
    int[] nums = [1, 2, 3, 4, 5];
    Console.WriteLine(nums);

    // empty array
    int[] nums2 = [];
    Console.WriteLine(nums2.Length);

    // also: 
    string[] names = new string[] {"ali", "sara", "angelina"};
    for (int i=0; i < names.Length; i++) {
      var value = names[i];
      Console.WriteLine(value);
    }
*/
    //=====================

    // collections: Array, ArrayList, List

    List<int> nums = new List<int> {1, 2, 3, 4};

    foreach(int num in nums) {
      //Console.WriteLine(num);
    }

    // dictionary:
    Dictionary<string, string> user1 = new Dictionary<string, string>() {
      {"name", "ali"},
      {"age", "22"},
      {"city", "tel aviv"}
    };

    foreach (KeyValuePair<string, string> item in user1) {
      //Console.WriteLine($"{item.Key}: {item.Value}");
    }

    // HashSet<T> =: does not allow duplicates
    HashSet<int> uniqueValues = new HashSet<int>{1, 2, 3, 3}; // only one 3
    foreach (int item in uniqueValues) {
    //  Console.WriteLine(item);
    }

    // Queue<T> // first-in and first-out
    Queue<string> queue = new Queue<string>();
    queue.Enqueue("ali");
    queue.Enqueue("sara");
    queue.Enqueue("angelina");
    //Console.WriteLine(queue.Dequeue()); // ali

    // stack # first-in and last-out
    Stack<string> stack = new Stack<string>();
    stack.Push("ali");
    stack.Push("sara");
    stack.Push("angelina");
    //Console.WriteLine(stack.Pop()); // angelina

    // dynamic object
    dynamic obj = new {
      name = "sara",
      age = 22,
      city = "tel aviv"
    };

    //Console.WriteLine(obj);

    // list of dynamic objects
    // List<dynamic> list = new List<dynamic> {
    //   new {name = "sara", age = 22, city = "tel aviv"},
    //   new {name = "ali", age = 22, city = "tel aviv"}
    // };
    List<dynamic> list = [
      new {name = "sara", age = 22, city = "tel aviv"},
      new {name = "ali", age = 22, city = "tel aviv"}
    ];

    Console.WriteLine(list[0]);

    //===============================
    
    // LINQ

    // data manupulation
    var names = new List<string> {"ali", "sara", "petter"};

    // Query like SQL syntax
    var results = from name in names
                  where name.Contains("a")
                  select name;

    foreach (string name in results) {
      //Console.WriteLine(name);
    }

    // Method syntax
    var results2 = names
      .Where(name => name.Contains("a"))
      .Select(name => name);

    foreach (string name in results2) {
      //Console.WriteLine(name);  
    }

    //========= use LINQ to filter stuff out of array of  object 

    List<dynamic> cars = [
      new {model = "x", color = "red", price = 34},
      new {model = "x", color = "blue", price = 436},
      new {model = "x", color = "red", price = 623},
    ];

    // get all the red colors
    var redCars = 
      cars
        .Where(car => car.color == "red") 
        // select can be use for massaging data
        .Select(car => new {model = car.model, color = car.color});

    foreach (var car in redCars) {
      //Console.WriteLine(car); //{ model = x, color = red }
    }

    //===============

    // by default LINQ -> has deferred execution
    // meaning does not execute untill you iterate over the data (like: foreach)

    // inmmediate execution
    List<int> numbers = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
    // even numbers
    var evens = numbers.Where(num => num % 2 == 0).ToList();
    // also: ToArray() and Count()

    foreach (var num in evens) {
      //Console.WriteLine(num);
    }

    // using enum

    // app status
    var status = Status.Active;

    Console.WriteLine(Status.Active); // Active
    if (Status.Active == status) {
      Console.WriteLine($"App status is: {status}");
    }

    
  }
}
