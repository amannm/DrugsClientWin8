using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Json;
using System.Net.Http;
using System.Diagnostics;
using System.Collections.ObjectModel;

namespace DrugsLib {

    public class Service {
        private static DataContractJsonSerializer conceptListSerializer = new DataContractJsonSerializer(typeof(List<Term>), new DataContractJsonSerializerSettings() { UseSimpleDictionaryFormat = true });
        private static DataContractJsonSerializer attributesSerializer = new DataContractJsonSerializer(typeof(Dictionary<string, List<string>>), new DataContractJsonSerializerSettings() { UseSimpleDictionaryFormat = true });
        private static DataContractJsonSerializer conceptSerializer = new DataContractJsonSerializer(typeof(Term), new DataContractJsonSerializerSettings() { UseSimpleDictionaryFormat = true });
        private static DataContractJsonSerializer successorSerializer = new DataContractJsonSerializer(typeof(Dictionary<string, List<Term>>), new DataContractJsonSerializerSettings() { UseSimpleDictionaryFormat = true });
        private static DataContractJsonSerializer wordListSerializer = new DataContractJsonSerializer(typeof(List<string>), new DataContractJsonSerializerSettings() { UseSimpleDictionaryFormat = true });

        private static HttpClient client = new HttpClient() {
            BaseAddress = new Uri("http://192.168.1.3:9090/SimpleDrugs/drugs/")
        };
        static Service() {
            client.DefaultRequestHeaders.Add("Accept", "application/json");
        }
        public static async Task<List<Term>> FindTermsAsync(string query) {
            var response = await client.GetAsync("search/" + query);
            if (response.IsSuccessStatusCode) {
                return conceptListSerializer.ReadObject(await response.Content.ReadAsStreamAsync()) as List<Term>;
            } else {
                Debug.WriteLine("Debug: HTTP Error >> " + response.StatusCode.ToString() + " " + response.ReasonPhrase);
                return new List<Term>();
            }
        }

        public static async Task<Term> GetTermAsync(int id) {
            var response = await client.GetAsync(id.ToString());
            if (response.IsSuccessStatusCode) {
                return conceptSerializer.ReadObject(await response.Content.ReadAsStreamAsync()) as Term;
            } else {
                Debug.WriteLine("Debug: HTTP Error >> " + response.StatusCode.ToString() + " " + response.ReasonPhrase);
                return new Term();
            }
        }
        public static async Task<Dictionary<string, List<string>>> GetAttributesAsync(int id) {
            var response = await client.GetAsync(id.ToString() + "/attributes");
            if (response.IsSuccessStatusCode) {
                return attributesSerializer.ReadObject(await response.Content.ReadAsStreamAsync()) as Dictionary<string, List<string>>;
            } else {
                Debug.WriteLine("Debug: HTTP Error >> " + response.StatusCode.ToString() + " " + response.ReasonPhrase);
                return new Dictionary<string, List<string>>();
            }
        }

        public static async Task<Dictionary<string, List<Term>>> GetSuccessorsAsync(int id) {
            var response = await client.GetAsync(id.ToString() + "/successors");
            if (response.IsSuccessStatusCode) {
                return successorSerializer.ReadObject(await response.Content.ReadAsStreamAsync()) as Dictionary<string, List<Term>>;
            } else {
                Debug.WriteLine("Debug: HTTP Error >> " + response.StatusCode.ToString() + " " + response.ReasonPhrase);
                return new Dictionary<string, List<Term>>();
            }
        }

        public static async Task<List<string>> SuggestCompletionsAsync(string query) {
            var response = await client.GetAsync("completions/" + query);
            if (response.IsSuccessStatusCode) {
                return wordListSerializer.ReadObject(await response.Content.ReadAsStreamAsync()) as List<string>;
            } else {
                Debug.WriteLine("Debug: HTTP Error >> " + response.StatusCode.ToString() + " " + response.ReasonPhrase);
                return new List<string>();
            }
        }
        public static async Task<List<string>> SuggestSpellingsAsync(string query) {
            var response = await client.GetAsync("spellings/" + query);
            if (response.IsSuccessStatusCode) {
                return wordListSerializer.ReadObject(await response.Content.ReadAsStreamAsync()) as List<string>;
            } else {
                Debug.WriteLine("Debug: HTTP Error >> " + response.StatusCode.ToString() + " " + response.ReasonPhrase);
                return new List<string>();
            }
        }
    }
}
