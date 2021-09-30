using System;
using System.Collections.Generic;
using System.Text;

namespace _Core.Utiletis.DataType
{
    public class SuccessDataResult<T> : DataResult<T>
    {
        public SuccessDataResult(T Data,  string Message) : base(Data, true, Message)
        {
            
        }

        public SuccessDataResult(T Data) : base(Data, true)
        {
           
        }

        public SuccessDataResult() : base(default, true)
        {

        }
    }
}
