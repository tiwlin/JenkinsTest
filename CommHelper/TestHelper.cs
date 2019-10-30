using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommHelper
{
    public class TestHelper
    {
        public bool Check(string name)
        {
            if (name.Length > 10)
            {
                return false;
            }

            return true;
        }

        public bool IsInt(string o)
        {
            int result = 0;
            return int.TryParse(o, out result);
        }

        public bool IsString(int o)
        {
            throw new Exception();
        }

        public bool TestCover()
        {
            throw new Exception();
        }
    }
}
