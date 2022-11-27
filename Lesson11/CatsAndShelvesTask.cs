using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson11
{
    internal class CatsAndShelvesTask
    {
        //An infinite number of shelves are arranged one above the other in a staggered fashion.
        //The cat can jump up to 3 shelves at the same time: from shelf 1 to shelf 2 or 4
        //(the cat cannot climb on the shelf directly above its head)
        //Intput: 
        //Start and finish shelf numbers (always positive integers, finish no smaller than start)
        //Task:
        //Find the minimum number of jumps to go from start to finish

        public int GetMinumNumbersOfJump(int startShelf, int finishShelf)
        {
            var diff = finishShelf - startShelf;
            return diff / 3 + diff % 3;
        }
    }
}
