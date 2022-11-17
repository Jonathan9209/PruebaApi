
using System;
//using RestSharp;

namespace HelloWorldApplication {
  class HelloWorld {
        public static object Method { get; private set; }



      static void Main(string[] args, object method) {
      var client = new RestClient("https://rickandmortyapi.com/documentation/#rest");
      client.Timeout = -1;
      var request = new RestRequest(method.GetType);
      IRestResponse response = client.Execute(request);
      Console.WriteLine(value: response.Content);
    }
  }
}

