using System;

namespace CommLib
{
    public class CommHelper
    {
        public bool Check(string name)
        {
            if (name.Length > 10)
            {
                return false;
            }

            return true;
        }
    }
}
