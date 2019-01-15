using Korvi.Vimeo.Api.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Korvi.Vimeo.Api
{
    public class ApiClient
    {

        #region Constants 

        private const string API_URL = "https://api.vimeo.com/";

        #endregion

        #region Fields 

        private string _privateKey;

        #endregion

        #region Ctor

        /// <summary>
        /// Genera una nueva clase para empezar a ejecutar las llamadas.
        /// </summary>
        /// <param name="privateKey"></param>
        public ApiClient(string privateKey)
        {
            _privateKey = privateKey;
        }

        #endregion

        #region Methods

        private T Get<T>(string url)
        {
            HttpWebResponse response = Get(url);
            var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
            T result = JsonConvert.DeserializeObject<T>(responseString);
            return result;
        }

        private HttpWebResponse Get(string url)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(new Uri(url));
            request.Accept = "application/json";
            request.Method = "GET";
            
            request.Headers.Add("Authorization", $"Bearer {_privateKey}");

            try
            {
                return (HttpWebResponse)request.GetResponse();
            }
            catch (WebException ex)
            {
                throw new VimeoException(ex.Message);
            }
        }

        public Video GetVideo(string id)
        {
            string url = $"{API_URL}videos/{id}";
            return Get<Video>(url);
        }

        #endregion
    }
}
