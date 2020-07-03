using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Result
{
    public class Result : IResult
    {
        public Result(bool success,string message):this(success) //thisli kod bloğu baska ctoru da tetikle yanı once mesajı set et sonra successi
        {
            Message = message;
        }
        public Result(bool success)// mesajı gecmek yerine işlem basarılı mı değil mi onu gormek ısteyebılır. Sadece success set edılır.
        {
            Success = success;
        }
        public bool Success { get; }

        public string Message { get; }
    }
}
