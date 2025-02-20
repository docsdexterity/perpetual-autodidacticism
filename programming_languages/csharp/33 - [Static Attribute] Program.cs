using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace App1
{
    class Program
    {   
        static void Main(string[] args)
        {
            // static attribute doesn't talk or tell about the objects but rather the class itself.
            // Anything defined as static is accessed through the class name.

            // When a member of a class is declared as static,
            // it means that this member belongs to the class,
            // not to any specific object created from that class.

            // This means there is only one copy of the static member in memory,
            // regardless of how many instances of the class are created.

            Song song1 = new Song("are u ok?", "VOSZA");
            Song song2 = new Song("Forget Me Forget You", "Nakani");
            Song song3 = new Song("NIGHTLIFE", "HXVRMXN");
            Song song4 = new Song("Labyrinth", "Devilish Trio");

            // For e.g. if we want to know how many songs are there in Song class
            // We can create a static variable and set its count to 0
            // and then increment the value each time an object is created.

            // Console.WriteLine("Total Songs: " + Song.songCount);
            Console.WriteLine($"Total Songs: {Song.songCount}");
            
            // Logic behind this has been discussed in Song.cs
            Console.WriteLine($"Song Count for {song2.artist} is {song2.getSongCount()}");
            Console.WriteLine($"Song Count for {song4.artist} is {song4.getSongCount()}");
            Console.WriteLine($"Song Count for {song3.artist} is {song3.getSongCount()}");
            Console.WriteLine($"Song Count for {song1.artist} is {song1.getSongCount()}");

            Console.ReadLine();
        }
    }
}
