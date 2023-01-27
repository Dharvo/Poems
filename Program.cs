using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
// using Person;
// using Poems;

namespace Poems
{
  internal class Program
  {
    static void Main(string[] args)
    {
      // RECREAETE TEMP
      Console.WriteLine("Hey There, We've got some Artists for you");
      // CREATE COLLECTION & ADD TO COLLECTION

      // CALL ARTIST CLASS
      var musicArtists = new List<Artists>(){
        new Artists("Davido",62,"A Good Time",true,"30 Billion Gang"),
        new Artists("Wizkid",62,"More Love, Less Ego",true,"Wizkid FC"),
        new Artists("Asake",22,"Mr Money With the Vibe",true,"YBNL"),
        new Artists("Burna Boy",70,"Love, Damini",true,"Outsiders"),
        new VerifiedArtist("Black Sheriff",62,"The Villian I Never was",true,false,"Black Boyz")
      };

      // Come In introduce artist, select one, displays info, you can set info or go to displaying all again...And Read info from selecting index

      //Looping through collection


      // GET & SET ARTIST WITH GRAMMY 
      //FOR LOOP THRU ARTISTS WITH THEIR IDs FOR USER TO PICK


      // for (int i = 0; i < musicArtists.Count; i++)
      // {
      //   Console.WriteLine(musicArtists[i]);
      // }

      // foreach (var artist in musicArtists)
      // {
      Console.WriteLine(musicArtists[2]);
      foreach (var itm in musicArtists)
      {
        Console.WriteLine(itm.name + " , " + itm.album);
      }
      // }
      // musicArtists.ForEach(act =>
      // act.album)
      // );

      // IF ID MATCHES SELECTD OR NAME MATCHES 
      // DISPLAY ARTIST INFO & Request FOR CHANGE (DO YOU WISH TO CHANGE ANY INFO, SELECT A NUMBER)
      // CHANGED ?? LOOP THRU ARTISTS AGAIN (View Adjusted Information, Select Index ?? OR TRY ADDING ANOTHER ARTIST) (STATIC METHOD Artist.AddNewAct)
      // UNCHANGED ?? LOOP THRU ARTISTS AGAIN &  ... (You made no changes )
      // ASK SHOULD WE SECLUDE GRAMMY WINNERS (FILTER)

      // RETURN FUNCTIONS FROM ARTIST CLASS
      // 
      // FILTER THOSE WITH GRAMMY
      // THEN BY YEAR OF AWARD 
      // ADD TO THEIR LABELS
      // 
      // SET LATEST ALBUM OR GRAMMY AWARD

      // CREATE CLASSES & OBJECTS THAT USE ARRAYS 
      // FOR WHILE LOOPS 
      // CREATE OBJECT METHODS
      // USE SETTERS & GETTERS IN CLASS 
      // STATIC CLASS ATTRIBUTES
      // CREATE STATIC CLASSES WITH METHODS
      // CREATE STATIC CLASSES WITH OVERRIDABLE METHODS
      // CREATE STATIC CLASSES WITH OVERRIDABLE METHODS
      // INHERIT CLASS ND INSTANCE IN ANOTHER CLASS
      // CREATE DIFFERENT COLLECTIONS
      // PERFORM OPERATIONS ON COLLECTIONS (Add, AddRange, Remove, RemoveAt, RemoveRange, ) 

      // CREATE COLLECTION
      // MODIFY COLLECTION
      // ADD TO COLLECTION

      // QUERY COLLECTION FOR FAV ARTIST 


      /* ADDING RECORD LABEL IF IT IS VALID RECORD ASSIGN 
      IF NOT ASK TO CREATE LABEL WITH USER AS AUTHOR
      IF AVAIL ASSIGN AND POPULATE LABBEL WITH ARTSIST INFO WITH CALL TO LABEL LIST ARTISTS 
      CALL TO ARTIST LIST BIO 
      CALL TO SONG NUM LIST SONGS

      */
      // SortedList<int> nums = ();


    }

    /*  static void Main(string[] args)
      {
        //CREATE USER PROFILE
        string user = "";
        string pet = "";
        Person User = new Person(user, pet);

        Console.WriteLine("Hey Whats your Name ?");
        User.name = Console.ReadLine();
        Console.WriteLine("Hello " + User.name + ". Try using our calculator");

        //CREATE VARIABLES
        double num1, num2;
        //PERFORM OP
        Console.WriteLine("Enter a number and Click Enter");
        double no1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Which Operation do you want to perform ?");
        string op = Console.ReadLine();
        Cons,ole.WriteLine("Enter another number & Press Enter");
        double no2 = Convert.ToDouble(Console.ReadLine());
        //CALL CALCULATOR FUNCTION
        Calc(no1, no2, op);
        Console.WriteLine(" ");
        Console.WriteLine("Would you like to guess a number, Yes / No");

        string answer = Console.ReadLine();
        switch (answer.ToLower())
        {
          case "yes":
            CheckKey();
            break;
          case "no":
            //RETRIEVE DATA & RECITE POEM
            Console.WriteLine("Okay " + user + ", do you have a Pet. Like a dog or cat, what is it ?");
            pet = Console.ReadLine();
            User.pet = pet;
            Poem.returnPoem(User.name, User.pet);
            break;
          default:
            Console.WriteLine(" ");
            break;
        }
        Person newPerson = new Person(user, pet);
        if (answer == "no")
        {
          Console.WriteLine("Thank you " + newPerson.name + ", take good care of your " + newPerson.pet + ".");
        }
        Console.ReadLine();
      }
  */
    public static void Calc(double no1, double no2, string op)
    {
      if (op == "+")
      {
        Console.WriteLine("Your answer is: " + (no1 + no2));
      }
      else if (op == "-")
      {
        Console.WriteLine("Your answer is: " + (no1 - no2));
      }
      else if (op == "/")
      {
        Console.WriteLine("Your answer is: " + no1 / no2);
      }
      else if (op == "*")
      {
        Console.WriteLine("Your answer is: " + no1 * no2);
      }
      else if (op == "^")
      {
        double answer = 1;
        // for (int i = 0; i < no2; i++) { answer = answer * no1; }
        do
        {
          answer = answer * no1;
          no2--;
        }
        while (no2 > 0);
        Console.WriteLine("Your answer is: " + answer);
      }
      else { Console.WriteLine("Invalid Operation"); }
    }
    private static void CheckKey()
    {
      string[,] luckyNumbers = { };
      //Console.
      Console.WriteLine("Okay, Now Try to guess a number from 1-10");
      double guess = Convert.ToDouble(Console.ReadLine());
      //RETRIEVE NUMBER & CONVERT
      double luckyNo = 7;
      int trials = 3;
      bool outOfTrials = false;
      while (guess != luckyNo && !outOfTrials)
      {
        //CHECK NO OF TRIALS 
        if (trials == 0)
        {
          outOfTrials = true;
          Console.WriteLine("You are out of Trials");
          Console.WriteLine("The lucky number was " + luckyNo);
        }
        else
        {
          Console.WriteLine("You guessed Wrong, Try again: ");
          guess = Convert.ToDouble(Console.ReadLine());
          trials--;
        }
      }
      if (guess == luckyNo) Console.WriteLine("You guessed Right, the lucky number is " + guess);
    }

  }
}
