using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_LINQ
{
    public static class MyExtensions
    {
        public static int DescriptionCountWords( this Post post)
        {
            return post.Description.Split(new string[] { "?", ".", " " }, StringSplitOptions.RemoveEmptyEntries).Length;            
        }
    }
}
