using Newtonsoft.Json;
using System.Net;
using System.Text;
using System.Text.Json.Serialization;

namespace Program
{
    class HW_17
    {
        public static void Main(string[] args)
        {
            SendAsync1().GetAwaiter().GetResult();
            SendAsync2().GetAwaiter().GetResult();
            SendAsync3().GetAwaiter().GetResult();
            SendAsync5().GetAwaiter().GetResult();
            SendAsync6().GetAwaiter().GetResult();
            SendPostAsync1().GetAwaiter().GetResult();
            SendPutAsync1().GetAwaiter().GetResult();
            SendPatchAsync1().GetAwaiter().GetResult();
            SendDeleteAsync1().GetAwaiter().GetResult();
        }

        private async static Task SendAsync1()
        {
            using (var httpClient = new HttpClient())
            {
                var result = await httpClient.GetAsync(@"https://reqres.in/api/users?page=2");

                if (result.StatusCode == HttpStatusCode.OK)
                {
                    var content = await result.Content.ReadAsStringAsync();
                    Console.WriteLine(result.ToString());
                }
            }
        }

        private async static Task SendAsync2()
        {
            using (var httpClient = new HttpClient())
            {
                var result = await httpClient.GetAsync(@"https://reqres.in/api/users/2");

                if (result.StatusCode == HttpStatusCode.OK)
                {
                    var content = await result.Content.ReadAsStringAsync();
                    Console.WriteLine(result.ToString());
                }
            }
        }

        private async static Task SendAsync3()
        {
            using (var httpClient = new HttpClient())
            {
                var result = await httpClient.GetAsync(@"https://reqres.in/api/users/23");

                if (result.StatusCode == HttpStatusCode.OK)
                {
                    var content = await result.Content.ReadAsStringAsync();
                    Console.WriteLine(result.ToString());
                }
            }
        }

        private async static Task SendAsync4()
        {
            using (var httpClient = new HttpClient())
            {
                var result = await httpClient.GetAsync(@"https://reqres.in/api/unknown/2");

                if (result.StatusCode == HttpStatusCode.OK)
                {
                    var content = await result.Content.ReadAsStringAsync();
                    Console.WriteLine(result.ToString());
                }
            }
        }

        private async static Task SendAsync5()
        {
            using (var httpClient = new HttpClient())
            {
                var result = await httpClient.GetAsync(@"https://reqres.in/api/unknown/2");

                if (result.StatusCode == HttpStatusCode.OK)
                {
                    var content = await result.Content.ReadAsStringAsync();
                    Console.WriteLine(result.ToString());
                }
            }
        }

        private async static Task SendPostAsync1()
        {
            using (var httpClient = new HttpClient())
            {
                var payload = new
                {
                    name = "morpheus",
                    job = "leader"
                };
                var httpContent = new StringContent(JsonConvert.SerializeObject(payload), Encoding.UTF8, "application/json");
                var result = await httpClient.PostAsync(@"https://reqres.in/api/unknown/2", httpContent);

                if (result.StatusCode == HttpStatusCode.OK)
                {
                    var content = await result.Content.ReadAsStringAsync();
                    Console.WriteLine(result.ToString());
                }
            }
        }

        private async static Task SendPutAsync1()
        {
            using (var httpClient = new HttpClient())
            {
                var payload = new
                {
                    name = "morpheus",
                    job = "leader"
                };
                var httpContent = new StringContent(JsonConvert.SerializeObject(payload), Encoding.UTF8, "application/json");
                var result = await httpClient.PutAsync(@"https://reqres.in/api/users/2", httpContent);

                if (result.StatusCode == HttpStatusCode.OK)
                {
                    var content = await result.Content.ReadAsStringAsync();
                    Console.WriteLine(result.ToString());
                }
            }
        }

        private async static Task SendPatchAsync1()
        {
            using (var httpClient = new HttpClient())
            {
                var payload = new
                {
                    name = "morpheus",
                    job = "leader"
                };
                var httpContent = new StringContent(JsonConvert.SerializeObject(payload), Encoding.UTF8, "application/json");
                var result = await httpClient.PatchAsync(@"https://reqres.in/api/users/2", httpContent);

                if (result.StatusCode == HttpStatusCode.OK)
                {
                    var content = await result.Content.ReadAsStringAsync();
                    Console.WriteLine(result.ToString());
                }
            }
        }

        private async static Task SendDeleteAsync1()
        {
            using (var httpClient = new HttpClient())
            {
                var result = await httpClient.DeleteAsync(@"https://reqres.in/api/users/2");

                if (result.StatusCode == HttpStatusCode.OK)
                {
                    var content = await result.Content.ReadAsStringAsync();
                    Console.WriteLine(result.ToString());
                }
            }
        }

        private async static Task SendPostAsync2()
        {
            using (var httpClient = new HttpClient())
            {
                var payload = new
                {
                    email = "eve.holt@reqres.in",
                    password = "pistol"
                };
                var httpContent = new StringContent(JsonConvert.SerializeObject(payload), Encoding.UTF8, "application/json");
                var result = await httpClient.PostAsync(@"https://reqres.in/api/register", httpContent);

                if (result.StatusCode == HttpStatusCode.OK)
                {
                    var content = await result.Content.ReadAsStringAsync();
                    Console.WriteLine(result.ToString());
                }
            }
        }

        private async static Task SendPostAsync3()
        {
            using (var httpClient = new HttpClient())
            {
                var payload = new
                {
                    email = "sydney@fife"
                };
                var httpContent = new StringContent(JsonConvert.SerializeObject(payload), Encoding.UTF8, "application/json");
                var result = await httpClient.PostAsync(@"https://reqres.in/api/register", httpContent);

                if (result.StatusCode == HttpStatusCode.OK)
                {
                    var content = await result.Content.ReadAsStringAsync();
                    Console.WriteLine(result.ToString());
                }
            }
        }

        private async static Task SendPostAsync4()
        {
            using (var httpClient = new HttpClient())
            {
                var payload = new
                {
                    email = "eve.holt@reqres.in",
                    password = "pistol"
                };
                var httpContent = new StringContent(JsonConvert.SerializeObject(payload), Encoding.UTF8, "application/json");
                var result = await httpClient.PostAsync(@"https://reqres.in/api/login", httpContent);

                if (result.StatusCode == HttpStatusCode.OK)
                {
                    var content = await result.Content.ReadAsStringAsync();
                    Console.WriteLine(result.ToString());
                }
            }
        }

        private async static Task SendPostAsync5()
        {
            using (var httpClient = new HttpClient())
            {
                var payload = new
                {
                    email = "email"
                };
                var httpContent = new StringContent(JsonConvert.SerializeObject(payload), Encoding.UTF8, "application/json");
                var result = await httpClient.PostAsync(@"https://reqres.in/api/login", httpContent);

                if (result.StatusCode == HttpStatusCode.OK)
                {
                    var content = await result.Content.ReadAsStringAsync();
                    Console.WriteLine(result.ToString());
                }
            }
        }

        private async static Task SendAsync6()
        {
            using (var httpClient = new HttpClient())
            {
                var result = await httpClient.GetAsync(@"https://reqres.in/api/users?delay=3");

                if (result.StatusCode == HttpStatusCode.OK)
                {
                    var content = await result.Content.ReadAsStringAsync();
                    Console.WriteLine(result.ToString());
                }
            }
        }
    }
}