using System;
using System.Collections.Generic;
using System.Text;

namespace _Core.Utiletis
{
    public class Result : IResult
    {

        public Result(bool Success, string Message) : this(Success)
        {
            //this.Success = Success;
            this.Message = Message;
        }

        public Result(bool Success)
        {
            this.Success = Success;
        }

        public bool Success { get; }

        public string Message { get; }
    }
    
}