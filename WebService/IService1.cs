using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WebService;

namespace WebService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        // TODO: Add your service operations here

        [OperationContract]
        //Added for handling REST get one Pass Item ID in the Query String
        [WebGet(ResponseFormat = WebMessageFormat.Json,
                   UriTemplate = "/GetUserByUserID?userID={userID}")]
        User GetUserByUserID(int userID);

        [OperationContract]
        //Added for handling REST return array of items
        [WebGet(ResponseFormat = WebMessageFormat.Json,
           UriTemplate = "/Register?username={username}&password={password}")]
        Boolean RegisterUser(string username,string password);

        [OperationContract]
        //Added for handling REST return array of items
        [WebGet(ResponseFormat = WebMessageFormat.Json,
           UriTemplate = "/GetAllUsers")]
        User[] GetAllUsers();

        [OperationContract]
        //Added for handling REST get one item
        [WebGet(ResponseFormat = WebMessageFormat.Json,
                   UriTemplate = "/GetPostByPostID?postID={postID}")]
        Post GetPostByPostID(int postID);

        [OperationContract]
        //Added for handling REST return array of items
        [WebGet(ResponseFormat = WebMessageFormat.Json,
           UriTemplate = "/CreatePost?username={username}&content={content}&date={date}")]
        Boolean CreatePost(string username, string content, string date);

        [OperationContract]
        //Added for handling REST return array of items
        [WebGet(ResponseFormat = WebMessageFormat.Json,
           UriTemplate = "/GetAllPosts")]
        Post[] GetAllPosts();

    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
