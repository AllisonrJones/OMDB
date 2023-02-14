using System;
using Microsoft.AspNetCore.DataProtection.KeyManagement;
using Newtonsoft.Json;
using System.Net;
using System.Reflection.PortableExecutable;

namespace OMDB.Models
{
    public class MovieDAL
    {
        public static MovieDB GetMovie(string Title)  //THIS IS A PLUG AND PLAY METHOD
        {
            //setup
            string key = "b01a2efa";
            string url = $"http://www.omdbapi.com/?t={Title}&apikey={key}";

            //request
            HttpWebRequest request = WebRequest.CreateHttp(url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();


            //Convert it to JSON
            StreamReader reader = new StreamReader(response.GetResponseStream());
            string JSON = reader.ReadToEnd();

            //Convert to C#
            MovieDB result = JsonConvert.DeserializeObject<MovieDB>(JSON);
            return result;
        }


    }
  }