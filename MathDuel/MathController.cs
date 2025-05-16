using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MathDuel.views;
using MathDuel.models;

namespace MathDuel.Controllers
{
    public class MathController
    {
        private readonly MathView view;
        private readonly MathModels model;
        private readonly MathModels.MathResult result;
        Random rand = new Random();
        int score = 0;
        int wrongAnswers = 0;

        public MathController()
        {
            view = new MathView();
        }

        public void Run()
        {

            view.ShowQuestion();

            while (wrongAnswers < 3)
            {
                int a = rand.Next(1, 11);     // 1 to 10
                int b = rand.Next(1, 11);
                int operation = rand.Next(3); // 0: +, 1: -, 2: *

                int correctAnswer;
                string question;

                if (operation == 0)
                {
                    correctAnswer = a + b;
                    question = $"{a} + {b} = ?";
                }
                else if (operation == 1)
                {
                    correctAnswer = a - b;
                    question = $"{a} - {b} = ?";
                }
                else
                {
                    correctAnswer = a * b;
                    question = $"{a} * {b} = ?";
                }

                Console.Write("Question: " + question + " ");
                string input = Console.ReadLine();

                int playerAnswer = int.Parse(input);

                if (playerAnswer == correctAnswer)
                {
                    view.ShowResult();
                    score++;
                }
                else
                {
                    Console.WriteLine($"Wrong! The correct answer was {correctAnswer}.\n");
                    wrongAnswers++;
                }
            }

            Console.WriteLine($"Game over! Your final score is: {score}");
        }
    }
}