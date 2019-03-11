using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ConsoleAppClient
{
    class Program
    {
        //initialize http client
        static HttpClient client = new HttpClient();

        static void ShowInfo(Task task)
        {
            Console.WriteLine($"Task: {task.Name}\tDescription: " +
                $"{task.Description}\tDeadline: {task.Deadline}");
        }


        // POST
        static async Task<Uri> CreateAsync(Task task)
        {
            HttpResponseMessage response = await client.PostAsJsonAsync(
                "api/tasks", task);
            response.EnsureSuccessStatusCode();

            // return URI of the created resource.
            return response.Headers.Location;
        }


        //GET
        static async Task<Task> GetAsync(string path)
        {
            Task task = null;
            HttpResponseMessage response = await client.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                task = await response.Content.ReadAsAsync<Task>();
            }
            return task;
        }


        //PUT 
        static async Task<Task> UpdateAsync(Task task)
        {
            HttpResponseMessage response = await client.PutAsJsonAsync(
                $"api/tasks/{task.Name}", task);
            response.EnsureSuccessStatusCode();

            // Deserialize the updated product from the response body.
            task = await response.Content.ReadAsAsync<Task>();
            return task;
        }


        //DELETE
        static async Task<HttpStatusCode> DeleteAsync(string id)
        {
            HttpResponseMessage response = await client.DeleteAsync(
                $"api/tasks/{id}");
            return response.StatusCode;
        }
        static void Main(string[] args)
        {
            RunAsync().GetAwaiter().GetResult();
        }

        static async System.Threading.Tasks.Task RunAsync()
        {
            // Update port # in the following line.
            client.BaseAddress = new Uri("http://localhost:8080/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            try
            {
                Task task = new Task
                {
                    Name = "Test",
                    Deadline = DateTime.Today,
                    Description = "TestTask"
                };

                var url = await CreateAsync(task);
                Console.WriteLine($"Created at {url}");

                // Get
                task = await GetAsync(url.PathAndQuery);
                ShowInfo(task);

                // Update 
                Console.WriteLine("Updating price...");
                task.Name = "UpdatedName";
                await UpdateAsync(task);

                // Get the updated 
                task = await GetAsync(url.PathAndQuery);
                ShowInfo(task);

                // Delete 
                var statusCode = await DeleteAsync(task.Name);
                Console.WriteLine($"Deleted (HTTP Status = {(int)statusCode})");

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
    }
}
