using System;
using System.Collections.Generic;
using System.Text;

namespace Sapphire.Core.Infrastructure.Helper
{
    /// <summary>
    /// 
    /// </summary>
    public class BooleanHelper
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string IsBool(string value)
        {
            if (value == "0")
            {
                return "false";
            }
            else if (value == "1")
            {
                return "true";
            }
            else
            {
                return value;
            }
        }
    }
}
