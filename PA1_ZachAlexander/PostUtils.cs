using System.Collections.Generic;
using System;

namespace PA1_ZachAlexander
{
    public class postUtils
    {
        public static void PrintAllPosts(List<Post> Posts)
        {
            Posts.Sort();
            Posts.Reverse();
            foreach(Post post in Posts)
            {
                Console.WriteLine(post.ToString());
            }
        }
    }
}