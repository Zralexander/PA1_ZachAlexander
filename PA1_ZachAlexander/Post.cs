using System;

namespace PA1_ZachAlexander
{
    public class Post : IComparable<Post>
    {
        public int Id {get; set;}
        public string PostText {get; set;}
        public DateTime Stamp {get; set;}

        public int CompareTo(Post temp)
        {
            return this.Stamp.CompareTo(temp.Stamp);
        }

        public override string ToString()
        {
            return "Post " + this.Id + ": " + this.PostText + " " + Stamp;
            
        }

        public string ToFile()
        {
            return this.Id + "#" + this.PostText + "#" + Stamp;
            
        }
    }
}