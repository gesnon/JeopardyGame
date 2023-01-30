using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeopardyGame.Core.Common.Exceptions
{
    public class DisputeExeption : Exception
    {
        public DisputeExeption()
        {

        }
        public DisputeExeption(string Message) : base(Message)
        {

        }
    }
}
