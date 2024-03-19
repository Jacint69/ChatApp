using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApp.Logic.Exceptions
{
    public class LengthExceptions : Exception
    {
        public LengthExceptions()
        {
            throw new Exception("Your message is too short!");
        }
    }
}
