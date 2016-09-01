using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sammo.Blog.Common
{
    public class Requires
    {
        public static JsonData json = new JsonData(false);
        public static void NotNull<T>(T value, string parameterName) where T : class
        {
            if (value == null)
            {
                throw new ArgumentNullException(parameterName + "不能为空");
                //return json;
            }
        }

        public static void NotNullOrEmpty(string value, string parameterName)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException(parameterName + "不能为null或空字符串");
            }
        }
    }
}
