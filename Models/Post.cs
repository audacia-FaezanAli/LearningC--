using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningC__.Models
{
    internal class Post
    {
        public string postContent;
        public string postTitle;
        public string postAuthor;
        public string postId;

        public Post(string postContent, string postTitle, string postAuthor, string postId)
        {
            this.postContent = postContent;
            this.postTitle = postTitle;
            this.postAuthor = postAuthor;
            this.postId = postId;
        }
    }
}
