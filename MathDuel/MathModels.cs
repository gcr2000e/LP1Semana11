using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MathDuel.models
{
    public class MathModels
    {
        public enum Operation
        {
            Addition = 1,
            Subtraction = 2,
            Multiplication = 3
        }

        public class MathQuestion
        {
            public int Operand1 { get; set; }
            public int Operand2 { get; set; }
            public Operation Operation { get; set; }
            public int CorrectAnswer { get; set; }
        }

        public class MathResult
        {
            public int Score { get; set; }
            public int WrongAnswers { get; set; }
        }
    }
}