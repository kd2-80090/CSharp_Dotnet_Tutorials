using System;
using System.Net.Http;
using System.IO;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace JsonPlaceholderClient
{
    // Define the structure of each comment
    public class Comment
    {
        public int PostId { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Body { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // The URL for the GET request
            string url = "https://jsonplaceholder.typicode.com/posts/1/comments";

            // Call the GetComments method to retrieve and display the comments
            GetComments(url);
        }

        // Synchronous method to send GET request and process the JSON response
        private static void GetComments(string url)
        {
            // Create an HttpClient instance
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    // Send the GET request and get the response (synchronously)
                    HttpResponseMessage response = client.GetAsync(url).Result;

                    // Ensure the request was successful (status code 200)
                    response.EnsureSuccessStatusCode();

                    // Read the response content as a string
                    string responseBody = response.Content.ReadAsStringAsync().Result;

                    // Deserialize the JSON string into a list of Comment objects
                    List<Comment> comments = JsonConvert.DeserializeObject<List<Comment>>(responseBody);

                    // Display the comments in the console
                    foreach (var comment in comments)
                    {
                        Console.WriteLine($"ID: {comment.Id}");
                        Console.WriteLine($"Name: {comment.Name}");
                        Console.WriteLine($"Email: {comment.Email}");
                        Console.WriteLine($"Body: {comment.Body}\n");
                    }
                }
                catch (HttpRequestException e)
                {
                    // Handle error if the HTTP request fails
                    Console.WriteLine($"Request error: {e.Message}");
                }
            }
        }
    }
}




///asynchronous
//using System;
//using System.Net.Http;
//using System.Threading.Tasks;
//using Newtonsoft.Json;
//using System.Collections.Generic;

//namespace JsonPlaceholderClient
//{
//    // Define the structure of each comment
//    public class Comment
//    {
//        public int PostId { get; set; }
//        public int Id { get; set; }
//        public string Name { get; set; }
//        public string Email { get; set; }
//        public string Body { get; set; }
//    }

//    class Program
//    {
//        // Main entry point
//        static async Task Main(string[] args)
//        {
//            // The URL for the GET request
//            string url = "https://jsonplaceholder.typicode.com/posts/1/comments";

//            // Call the GetCommentsAsync method to retrieve and display the comments
//            await GetCommentsAsync(url);
//        }

//        // Async method to send GET request and process the JSON response
//        private static async Task GetCommentsAsync(string url)
//        {
//            // Create an HttpClient instance
//            using (HttpClient client = new HttpClient())
//            {
//                try
//                {
//                    // Send GET request and await the response
//                    HttpResponseMessage response = await client.GetAsync(url);

//                    // Ensure the request was successful (status code 200)
//                    response.EnsureSuccessStatusCode();

//                    // Read the response content as a string
//                    string responseBody = await response.Content.ReadAsStringAsync();

//                    // Deserialize the JSON string into a list of Comment objects
//                    List<Comment> comments = JsonConvert.DeserializeObject<List<Comment>>(responseBody);

//                    // Display the comments in the console
//                    foreach (var comment in comments)
//                    {
//                        Console.WriteLine($"ID: {comment.Id}");
//                        Console.WriteLine($"Name: {comment.Name}");
//                        Console.WriteLine($"Email: {comment.Email}");
//                        Console.WriteLine($"Body: {comment.Body}\n");
//                    }
//                }
//                catch (HttpRequestException e)
//                {
//                    // Handle error if the HTTP request fails
//                    Console.WriteLine($"Request error: {e.Message}");
//                }
//            }
//        }
//    }
//}
