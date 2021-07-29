using System;
using System.IO;
using System.Text;
using Newtonsoft.Json;

namespace JsonSerialization
{
    class Program
    {
        static void Main(string[] args)
        {
            Post myPost = new Post() {                    //create object of a class to serialize it
                userid = 1,
                id = 1,
                title = "sunt aut facere repellat provident occaecati excepturi optio reprehenderit",
                body = "quia et suscipit\nsuscipit recusandae consequuntur expedita et cum\nreprehenderit molestiae ut ut quas totam\nnostrum rerum est autem sunt rem eveniet architecto"

            };

            //Serialize above object. C# to json
            string serializedPost = JsonConvert.SerializeObject(myPost);                    //JsonConvert.SerializeObject always returns a string- hence string 
            Console.WriteLine(serializedPost);

            //Now, Deserialize it back to Post object
            Post resultPost = JsonConvert.DeserializeObject<Post>(serializedPost);             //since class Post is there,we used <post> else we use ExpandoObject
            Console.WriteLine("##### De-Serialized ");
            Console.WriteLine($"resultPost.userid: {resultPost.userid}");
            Console.WriteLine($"resultPost.id: {resultPost.id}");
            Console.WriteLine($"resultPost.title: {resultPost.title}");
            Console.WriteLine($"resultPost.body: {resultPost.body}");

            ///File & Streams
            ///
            CreateFile();
        }

        static void CreateFile() {
            FileStream fs = new FileStream(@"D:\dotnettraining\sampleFile.txt", FileMode.OpenOrCreate, FileAccess.Write,FileShare.None );
            string text = "Hello, I look different when converted to byte??";
            byte[] textAsBytes = Encoding.UTF8.GetBytes(text);
            fs.Write(textAsBytes, 0, textAsBytes.Length);
            fs.Close();
        
        }
    }
    public class Post
    {
        public int userid { get; set; }
        public int id { get; set; }
        public string title { get; set; }
        public string body { get; set; }
    }
}
