using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Help
    {
        private static MarkChange markChange = new MarkChange();

        public static MarkChange HelpForChange
        {
            get { return markChange; }
        }
    }
}
