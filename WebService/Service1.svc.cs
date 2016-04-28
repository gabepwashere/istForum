using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

using System.Web.Script.Serialization;

namespace WebService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public bool CreatePost(string username, string content, string date)
        {
            using (ist420row2Entities Entity = new ist420row2Entities())
            {
                Post post = new Post();
                post.username = username;
                post.content = content;
                post.date = date;
                Entity.Posts.Add(post);
                Entity.SaveChanges();
                if (post.postID > 0)
                    return true;
                else
                    return false;
            }
        }

        public Boolean DeletePostByPostID(int postID)
        {

            using (ist420row2Entities Entity = new ist420row2Entities())
            {
                Post post = new Post();
                try
                {
                    post = Entity.Posts.Find(postID);
                    Entity.Posts.Remove(post);
                    Entity.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }

        public Boolean DeleteUserByUserID(int userID)
        {
            using (ist420row2Entities Entity = new ist420row2Entities())
            {
                User user= new User();
                try
                {
                    user = Entity.Users.Find(userID);
                    Entity.Users.Remove(user);
                    Entity.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }

        public Post[] GetAllPosts()
        {
            using (ist420row2Entities Entity = new ist420row2Entities())
            {
                var posts = from Post in Entity.Posts select Post;
                return posts.ToArray();
            }

        }

        public User[] GetAllUsers()
        {
            using (ist420row2Entities Entity = new ist420row2Entities())
            {
                var users = from User in Entity.Users select User;
                return users.ToArray();
            }

        }

        public string GetData(int value)
        {
            throw new NotImplementedException();
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            throw new NotImplementedException();
        }

        public Post GetPostByPostID(int postID)
        {

            using (ist420row2Entities entities = new ist420row2Entities())
            {
                Post post = new Post();
                post = entities.Posts.Find(postID);
                return post;
            }

        }

        public User GetUserByUserID(int userID)
        {
            using (ist420row2Entities entities = new ist420row2Entities())
            {
                User user = new User();
                user = entities.Users.Find(userID);
                return user;
            }
        }

        public Boolean RegisterUser(string username, string password)
        {
            using (ist420row2Entities Entity = new ist420row2Entities())
            {
                User user = new User();
                user.userName = username;
                user.password = password;
                Entity.Users.Add(user);
                Entity.SaveChanges();
                if (user.userID > 0)
                    return true;
                else
                    return false;
            }
        }

        public Boolean UpdatePostByPostID(int postID, string username, string content, string date)
        {
            using (ist420row2Entities Entity = new ist420row2Entities())
            {
                Post post = new Post();
                post= Entity.Posts.Find(postID);
                post.username = username;
                post.content= content;
                post.date = date;
                Entity.SaveChanges();
                if (post.postID > 0)
                    return true;
                else
                    return false;
            }
        }

        public Boolean UpdateUserByUserID(int userID, string username, string password)
        {
            using(ist420row2Entities Entity = new ist420row2Entities())
            {
                User user = new User();
                user = Entity.Users.Find(userID);
                user.userName = username;
                user.password = password;
                Entity.SaveChanges();
                if (user.userID > 0)
                    return true;
                else
                    return false;
            }
        }
    }
}