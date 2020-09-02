using System.IO;
using System.Collections.Generic;
using System;

namespace PA1_ZachAlexander
{
    public class postFile
    {
        public static List<Post> GetPosts()
        {
            List<Post> posts = new List<Post>();
            StreamReader inFile = null;

            try
            {
              inFile = new StreamReader("posts.txt");
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("Something went wrong.... {0}", e);
                return posts;
            }

            string line = inFile.ReadLine();
            while(line != null)
            {
                string[] temp = line.Split("#");
                posts.Add(new Post(){Id = int.Parse(temp[0]), PostText = temp[1], Stamp = DateTime.Parse(temp[2])});
                line = inFile.ReadLine();
            }

            inFile.Close();

            return posts;
        }

        public static void SavePosts(List<Post> Posts)
        {
            StreamWriter outFile = new StreamWriter("posts.txt");

             foreach (Post post in Posts)
                 {
                     outFile.WriteLine(post.ToFile());
                 }

            outFile.Close();

            
        }
    }
}