using System;
using System.Collections.Generic;

namespace PA1_ZachAlexander
{
    class Program
    {
        static void Main(string[] args)
        {
           List<Post> myPosts = postFile.GetPosts();

            int menuInput = 0;

            while(menuInput != 4){
                Console.WriteLine("\nMain Menu... Please enter \n1. To show all posts \n2. To add a post \n3. To delete a post by ID \n4. To exit application");
                Console.Write("Enter Choice: ");
                try{
                    menuInput = int.Parse(Console.ReadLine());
                    if(menuInput<1 || menuInput>4){
                        throw new Exception("!!! Not a valid menu choice !!");
                    }
                }
                catch(Exception e){
                    Console.WriteLine(e.Message);
                }
                finally{
                    if(menuInput == 1){
                        postUtils.PrintAllPosts(myPosts);
                        menuInput = 0;
                    }
                    else if(menuInput == 2){
                        Console.Write("Enter the what you want to post: ");
                        string message = Console.ReadLine();

                        Post newPost = new Post{Id =myPosts.Count + 1, PostText = message, Stamp = DateTime.Now};
                        myPosts.Add(newPost);
                        Console.WriteLine("New Post: " + newPost);
                        postFile.SavePosts(myPosts);

                        menuInput = 0;
                    }
                    else if(menuInput == 3){
                        postUtils.PrintAllPosts(myPosts);
                        Console.Write("Enter the ID of the post you woud like to delete: ");
                        int deleteID = int.Parse(Console.ReadLine());
                        int indexFound = myPosts.FindIndex(tempPost => tempPost.Id == deleteID);



                        foreach(Post post in myPosts)
                        {
                            if(indexFound == -1)
                            {
                                continue;
                            }
                            else
                            {
                                Console.WriteLine("Now Removing: " + post);
                                myPosts.Remove(post);

                            }

                        }
                        postUtils.PrintAllPosts(myPosts);
                        postFile.SavePosts(myPosts);
                        menuInput = 0;
                    }
                    else if(menuInput == 4){
                        Console.WriteLine("Now exiting... Goodbye!");
                        
                    }
                }

            }
        }
    }
}