using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MathDuel.models;

namespace MathDuel.views
{
    public class MathView
    {
        public void ShowQuestion()
        {
            Console.WriteLine("=== Math Duel ===");
            Console.WriteLine("Answer the math problems correctly!");
            Console.WriteLine("You can make up to 3 mistakes.");
            Console.WriteLine();
        }
        public void ShowResult()
        {
            Console.WriteLine("Correct!\n");
        }
    }
}