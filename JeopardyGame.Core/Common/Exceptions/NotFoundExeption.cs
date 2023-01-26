using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeopardyGame.Core.Common.Exceptions
{
    public class NotFoundExeption : Exception
    {
        public NotFoundExeption()
        {

        }
        public NotFoundExeption(string Message) : base(Message)
        {

        }
    }
}
