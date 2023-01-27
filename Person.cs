using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Poems
{
  class Person
  {
    public string name, pet;

    public Person(string userName, string userPet)
    {
      //EVERY PERSON WILL HAVE A NAME & PET
      name = userName;
      pet = userPet;

      // switch (gend)
      // {
      //  case Gender.female.ToString: 'Female';
      //  break;

      //   default: Gender.male
      // }


      // Char 
    }
    public void petName()
    {
      Console.WriteLine(pet);
    }
    // static void Main(string[] args)


  }
}