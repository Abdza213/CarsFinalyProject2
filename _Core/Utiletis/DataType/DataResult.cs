using System;
using System.Collections.Generic;
using System.Text;

namespace _Core.Utiletis.DataType
{
    public class DataResult<T> : Result, IDataResult<T>
    {

        public DataResult(T Data, bool Success, string Message) : base(Success, Message)
        {
            this.Data = Data;
        }

        public DataResult(T Data, bool Success) : base(Success)
        {

        }

        public T Data { get; }

    }
}
