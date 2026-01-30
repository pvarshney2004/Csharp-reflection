using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace Reflection.RetrieveAttributeAtRuntime
{
    public class Retrieve
    {
        // Apply it to a class and use Reflection to retrieve and display the attribute value at runtime.
        public static void Execute()
        {
            Type type = typeof(Book);
            AuthorAttribute? author = type.GetCustomAttribute<AuthorAttribute>();
            if (author != null)
            {
                Console.WriteLine($"Author Name: {author.Name}");
            }
        }
    }
}