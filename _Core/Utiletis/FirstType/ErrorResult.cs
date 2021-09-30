using System;
using System.Collections.Generic;
using System.Text;

namespace _Core.Utiletis.FirstType
{
    public class ErrorResult : Result
    {
        public ErrorResult(string Message) : base(false, Message)
        {
            Console.WriteLine(Message);
        }

        public ErrorResult() : base(false)
        {
            Console.WriteLine(Message);
        }

    }
}
