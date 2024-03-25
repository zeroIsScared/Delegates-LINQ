using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_LINQ

{
    public class Blog
    {
        public delegate int CalculatePoints(Post post, User user);

        public delegate void DisplayResult(string fullName, string postTitle, int points);
        public static void PublishPost (string fullName, CalculatePoints calculatePoints, DisplayResult displayResult ) 
        {
            var users = ResourceManager.LoadUserData();
            var userResult = users.Where(x => x.FullName == fullName).ToList();
            var user = userResult[0];

            var posts = ResourceManager.LoadBlogsData();
            var postResult = (from p in posts
                        where p.Author == fullName && !p.IsPosted
                        select new Post { Title = p.Title, Description = p.Description, Author = p.Author, IsPosted = p.IsPosted }).ToList();
            var post = postResult[0];

             int points = calculatePoints(post, user);

            displayResult(user.FullName, post.Title, points);
            Console.WriteLine($"Your post descriprion contains {post.DescriptionCountWords()} words, please make sure it is no longer than 5 words.");
        }       
    }
}
