namespace ConsoleApp2
{
    class Program
    {
        static async Task Main()
        {
            const string url = "https://jsonplaceholder.typicode.com/posts";
            await Get(url);
            await Post(url);
        }
        
        static async Task Post(string url)
        {
            var client = new HttpClient();
            var response = await client.PostAsync(url, new StringContent("{'title':'foo','body':'bar','userId':1}"));
            var content = await response.Content.ReadAsStringAsync();
            Console.WriteLine(content);
        }
        
        static async Task Get(string url)
        {
            var client = new HttpClient();
            var response = await client.GetAsync(url);
            var content = await response.Content.ReadAsStringAsync();
            Console.WriteLine(content);
        }
    }
}