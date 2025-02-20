using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    internal class Song
    {
        public string title;
        public string artist;
        public int instanceID;
        public static int songCount = 0;

        public Song(string arg_Title, string arg_Artist)
        {
            title = arg_Title;
            artist = arg_Artist;
            instanceID = ++songCount;
        }

        public int getSongCount()
        {
            return instanceID;
        }
    }
}

// In object-oriented programming, static variables, like songCount,
// are shared across all instances of the class.

// When a static variable is incremented,
// its updated value is visible to all instances of the class.

// When songCount is initially 0 and a new Song object is created,
// the ++songCount expression in the constructor pre-increments songCount to 1
// and assigns this value to the instanceID of the current object.
// After this operation, songCount is 1 and the instanceID of the newly created object is also 1.

// If another Song object is created, the same process occurs:
// - songCount is incremented to 2.
// - The new object's instanceID is set to the updated value of songCount, which is 2.

// Difference between Pre-Increment Operation & Post-Increment Operation

/*
 * Pre-Increment Operation:
 * 
 * - songCount is incremented to 1 before its value is assigned to instanceID.
 * - instanceID of the current object becomes 1.
 * - After the operation, songCount is 1.
*/

/*
 * Post-Increment Operation:
 * 
 * - The current value of songCount (0) is used in the expression and 
 *   is assigned to instanceID of the current object.
 * - So, instanceID of the current object becomes 0 (which should've been 1).
 * - Then, songCount is incremented to 1.
*/
