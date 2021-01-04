using Leaf.xNet;
using Login.Json_Models;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.Functions
{
    class LoginAPIRequest
    {
        public static string Login(string email , string password)
        {
            RestClient client = new RestClient("http://localhost:3000/");
            RestRequest request = new RestRequest("api/user/login", Method.POST);
            var body = new{ email = email,password = password};
            request.AddJsonBody(body);           
            var response = client.Execute(request).Content;
            AuthModel _LoginResponse = JsonConvert.DeserializeObject<AuthModel>(response);
            return _LoginResponse.description;
        }

        public static string Register(string name , string email, string password)
        {
            RestClient client = new RestClient("http://localhost:3000/");
            RestRequest request = new RestRequest("api/user/register", Method.POST);
            var body = new {name= name, email = email, password = password };
            request.AddJsonBody(body);
            var response = client.Execute(request).Content;
            AuthModel _LoginResponse = JsonConvert.DeserializeObject<AuthModel>(response);
            return _LoginResponse.description;
        }
    }
}
