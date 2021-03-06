﻿using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Windows.Forms;

namespace ConsoleAppClient
{
    class Program
    {
        //initialize http client
        public static HttpClient client = new HttpClient();

        static void ShowInfo(User user)
        {
            Console.WriteLine($"User: {user.DbAwareEntity.Name}\tPassword: " +
                $"{user.Password}\tUsername: {user.Username}");
        }


        // POST
        public static async Task<Uri> CreateAsync(User user)
        {
            HttpResponseMessage response = await client.PostAsJsonAsync(
                "users", user);
            response.EnsureSuccessStatusCode();

            // return URI of the created resource.
            //response.Content.ReadAsAsync<User>();
            
            return response.Headers.Location;
        }


        //GET
        public static async Task<User> GetAsync(string path)
        {
            User user = null;

            //HttpResponseMessage response = client.GetAsync("users").Result;  // Blocking call!    
            //if (response.IsSuccessStatusCode)
            //{
            //    var products = response.Content.ReadAsStringAsync().Result;
            //}
            //else
            //{
            //    Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
            //}

            HttpResponseMessage response = await client.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                user = await response.Content.ReadAsAsync<User>();
            }
            return user;
        }


        //PUT 
        static async Task<User> UpdateAsync(User user)
        {
            HttpResponseMessage response = await client.PutAsJsonAsync(
                $"users/{user}", user);
            response.EnsureSuccessStatusCode();

            // Deserialize the updated product from the response body.
            user = await response.Content.ReadAsAsync<User>();
            return user;
        }


        //DELETE
        static async Task<HttpStatusCode> DeleteAsync(string id)
        {
            HttpResponseMessage response = await client.DeleteAsync(
                $"users/{id}");
            return response.StatusCode;
        }
        static void Main(string[] args)
        {
            // Update port # in the following line.
            client.BaseAddress = new Uri(" https://dist-lab-server.herokuapp.com/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            RunAsync().GetAwaiter().GetResult();
            Application.Run(new StartForm());
            
        }

        static async System.Threading.Tasks.Task RunAsync()
        {
            //// Update port # in the following line.
            //client.BaseAddress = new Uri(" https://dist-lab-server.herokuapp.com/");
            //client.DefaultRequestHeaders.Accept.Clear();
            //client.DefaultRequestHeaders.Accept.Add(
            //    new MediaTypeWithQualityHeaderValue("application/json"));

            try
            {
                DbAwareEntity dbAwareEntity = new DbAwareEntity
                {
                    Id = 1,
                    Name = "Name1",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    DeletedAt = DateTime.Now,
                };

                User user = new User
                {
                    Username = "Test11",
                    Password = "123456",
                    Position = "Position",
                    Status = "Status",
                    DbAwareEntity = dbAwareEntity,
                };
                
                var url = await CreateAsync(user);
                Console.WriteLine($"Created at {url}");

                // Get
                //user = await GetAsync("https://dist-lab-server.herokuapp.com/users/26");

                HttpResponseMessage response = client.GetAsync("users/26").Result;  // Blocking call!    
                if (response.IsSuccessStatusCode)
                {
                    var u = response.Content.ReadAsStringAsync().Result;
                }
                else
                {
                    Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
                }
                ShowInfo(user);

                // Update 
                Console.WriteLine("Updating name...");
                user.DbAwareEntity.Name = "UpdatedName";
                await UpdateAsync(user);

                // Get the updated 
                user = await GetAsync(url.PathAndQuery);
                ShowInfo(user);

                // Delete 
                var statusCode = await DeleteAsync(user.Position);
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
