using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_LINQ
{
    public static class MyExtensions
    {
        public static int DescriptionCountWords( this string description)
        {
            return description.Split(new string[] { "?", ".", " " }, StringSplitOptions.RemoveEmptyEntries).Length;            
        }
    }
}
