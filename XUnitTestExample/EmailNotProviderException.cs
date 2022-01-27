using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XUnitTestExample {
    public class EmailNotProviderException : Exception {
        public override string Message => "Email can't be empty.";
    }
}
