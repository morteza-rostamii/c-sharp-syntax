using System;
using CSTut1;
using CSTut1.src;

class Program {

  //When you're working with asynchronous code in a console application (or a similar environment), it's important to ensure the main thread stays alive until all asynchronous operations complete.
  //basically setting Main async helps with all async/await stuff actually wait to finish
  static async Task Main(string[] args) {
    Console.WriteLine("******************************\n");
    //Lesson1.Run();
    Lesson2 lesson2 = new Lesson2();

    await lesson2.DoAsyncStuff();

    //new LessonOop();
    Console.WriteLine("\n******************************");
  }
}

/*
The issue was that the program was exiting before the asynchronous tasks (await Task.Delay(1000)) had time to complete. By making the Main method async and awaiting lesson.InitializeAsync(), we ensured the program waits for all asynchronous operations to finish before exiting. Without this, the async tasks were cut off because the program finished too soon.
*/ 