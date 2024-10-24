using System;

namespace CSTut1.src;

// learn about null in c#
public class LessonNull
{
  public LessonNull(){

    // nulable
    string? username = "null";
    //Console.WriteLine(username);

    if (username != null) {
      //Console.WriteLine("username is not null");
    }

    // if use Nullable  => access HasValue and Value
    // the generic Nullable<T> can only be a value type
    Nullable<int> age = 23;
    if (age.HasValue) {
      //Console.WriteLine(age.Value);//23
    }

    // nullable reference types
    Phone? phone = null;

    if (phone == null){} 
    //Console.WriteLine("phone is null");

    //Null Coalescing and Nullable Value Types

    string? a = null;
    // if not null =: return: a and if null =: set default value
    a ??= "default value"; 
    //Console.WriteLine(a);

    // Null Conditional Operator
    //var authUser = new {name = "ali"};
    User? authUser = null;
    //Console.WriteLine(authUser?.Name);

  }
}

public class Phone {}
public class User {
  private string? _name;
  //public string? name => _name;
  public string? Name {get; set;}
} 