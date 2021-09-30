using System;
using System.Collections.Generic;
using System.Text;

namespace _Core.Utiletis.FirstType
{
    public class SuccessResult : Result
    {

        public SuccessResult(string Message) : base(true, Message)
        {
            Console.WriteLine(Message);
        }

        public SuccessResult() : base(true)
        {
            Console.WriteLine(Message);
        }
    }
}
