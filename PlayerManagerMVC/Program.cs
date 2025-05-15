using System;
using System.Collections.Generic;
using PlayerManagerMVC.controllers;

namespace PlayerManagerMVC
{
    /// <summary>
    /// The player listing program.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Program begins here.
        /// </summary>
        /// <param name="args">Not used.</param>
        private static void Main(string[] args)
        {
            var controller = new PlayerController();
            controller.Run();
        }
    }
}
