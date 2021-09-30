using System;
using System.Collections.Generic;
using System.Text;

namespace _Core.Utiletis.DataType
{
    public class ErrorDataResult<T> : DataResult<T>
    {

        public ErrorDataResult(T Data, string Message) : base(Data, false, Message)
        {
           
        }

        public ErrorDataResult(T Data) : base(Data, false)
        {
            
        }
        public ErrorDataResult(string Message) : base(default,false, Message)
        {
            
        }

        public ErrorDataResult() : base(default, true)
        {

        }
    }
}
