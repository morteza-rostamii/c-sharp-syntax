using System;

namespace CSTut1;

// Learn about events

public class Lesson2
{
  // player object
  private Player _player = new Player();

  public Lesson2() {
    this.Section1();

    // let's subscribe and event
    // += cause: you can add multiple listeners (methods) 
    _player.AchievementUnlocked += OnEchievementUnlocked;

    // add scores
    //_ = this.AddScore();
    
  }

  // addSocres
  public async Task DoAsyncStuff() {
    await _player.AddScore(20);
    await _player.AddScore(80);

    // unsubscribe
    //_player.AchievementUnlocked -= OnEchievementUnlocked;
  }

  //  eventListener 
  // our event listener has to take score =: which is defined in delagate
  private static void OnEchievementUnlocked(int score) {
    Console.WriteLine($"Achievement Unlocked! from Lesson 2! score is: {score}");
  }

  private void Section1() {
    //Console.WriteLine("Section 1");

    // exception 

    try {
      //Console.WriteLine("try");
      throw new Exception("something went wrong");
    } catch (Exception e) {
      //Console.WriteLine("catch");
      //Console.WriteLine(e.Message);
    } finally {
      //Console.WriteLine("finally");
    }


    
  }
}

// Player class
public class Player {
  private int _score;

  // delegate : defines what are event handler returns
  public delegate void AchievementUnlockedEventHandler(int score);
  // event: passed 100 scores
  // other classes can subscribe to this event
  // Action =: Encapsulates a method that has no parameters and does not return a value.
  //public event Action? AchievementUnlocked; //event
  public event AchievementUnlockedEventHandler? AchievementUnlocked;

  public Player() {}

  public async Task AddScore(int score) {
    _score += score;
    Console.WriteLine($"Player got {score} scores!");
    Console.WriteLine($"Total score: {this._score}");
    
    if (this._score >= 100) {
      // player passed 100 scores raise and event
      AchievementUnlocked?.Invoke(_score);
    }

    // just some delay between each call to AddScore
    await Task.Delay(1000);
  }
}