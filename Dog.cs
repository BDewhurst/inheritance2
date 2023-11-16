using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualOverideDemo
{
    class Dog: Animal
    {

        public bool isHappy {get; set;}
      public Dog(string name, int age): base (name, age) {
        isHappy = true;
      }  
      public override void Eat() {
        base.Eat(); 
      }

        public override void MakeSound()
        {
            Console.WriteLine("Woof!");
        }

        public override void Play()
        {
            if (isHappy) {
                base.Play();
            }
        }
    }
}