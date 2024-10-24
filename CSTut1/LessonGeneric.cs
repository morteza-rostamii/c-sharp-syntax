using System;

namespace CSTut1;

public class LessonGeneric
{
  public LessonGeneric(){
    
    // use string on run time
    //HeyGeneric<string> hey = new HeyGeneric<string>("hello");
    HeyGeneric<string> hey = new("hello");
    Console.WriteLine(hey.Data);
    Console.WriteLine("--");

    // type of T = decimal
    MoreGeneric.GenericMethod<decimal>(2.3M);
  }
}

// T and U are generic types used in this class: and you can add more
//public class HeyGeneric<T, U> {}

// T is a generic type: can be any type
public class HeyGeneric<T> {

  private T _data;
  public T Data { get => _data; set => _data = value; }

  public HeyGeneric(T value) {
    _data = value;
  }
}

// generic methods
public class MoreGeneric {

  // a generic method
  public static void GenericMethod<T>(T value) {
    Console.WriteLine(value);
  }
}