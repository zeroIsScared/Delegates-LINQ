﻿using Delegates_LINQ;
using System.Runtime.ConstrainedExecution;
using System.Threading.Channels;
using static Delegates_LINQ.Blog;

internal class Program
{
    
    private static void Main(string[] args)
    {


        CalculatePoints calculatePoints = delegate(Post post, User user) { 
        
            if (user.BirthDate.Year > 1990 && user.Points < 5 && post.Description.Contains("story"))
            {
                return 20;
            }
            else if (user.BirthDate.Year < 1990 && user.Points > 5)
            {
                return 10;
            }
            return 0;

        };

        DisplayResult displayResult = delegate (string fullName, string postTitle, int points)
        {
            Console.WriteLine($"{fullName} with the post titled {postTitle} had earned {points} points.");
        };

        Blog.PublishPost("Alan James", calculatePoints, displayResult);
    }
}