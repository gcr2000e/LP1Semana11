using System;
using System.Collections.Generic;
using PlayerManagerMVC2.controllers;

namespace PlayerManagerMVC2
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
            if (args.Length == 0)
            {
                Console.Error.WriteLine("Erro: Nome do ficheiro com jogadores não fornecido.");
                Console.Error.WriteLine("Uso: PlayerManagerMVC <ficheiro>");
                return;
            }

            string filePath = args[0];

            var controller = new PlayerController(filePath);
            controller.Run();
        }
    }
}
