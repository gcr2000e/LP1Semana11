using System;
using System.ComponentModel.Design;
using System.Runtime.CompilerServices;
using MathDuel.Controllers;

class Program
{
    static void Main()
    {
        var controller = new MathController();
        controller.Run();
    }
}
