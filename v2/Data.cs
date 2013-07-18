using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;
using Windows.Foundation;
using Windows.Foundation.Collections;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.ComponentModel;
using System.Runtime.CompilerServices;

using System.Net.Http;
using System.Diagnostics;

namespace Drugs2 {

    [DataContract]
    public class Concept : INotifyPropertyChanged {

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        private int _id;
        private string _name;
        private string _type;

        [DataMember(Name = "id")]
        public int Id {
            get { return _id; }
            set { if (this.SetProperty(ref _id, value)) this.OnPropertyChanged("Id"); }
        }

        [DataMember(Name = "name")]
        public String Name {
            get { return _name; }
            set { if (this.SetProperty(ref _name, value)) this.OnPropertyChanged("Name"); }
        }

        [DataMember(Name = "type")]
        public String Type {
            get { return _type; }
            set { if (this.SetProperty(ref _type, value)) this.OnPropertyChanged("Type"); }
            
        }

        protected bool SetProperty<T>(ref T storage, T value, [CallerMemberName] String propertyName = null) {
            if (object.Equals(storage, value)) return false;
            storage = value;
            this.OnPropertyChanged(propertyName);
            return true;
        }

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null) {
            var eventHandler = this.PropertyChanged;
            if (eventHandler != null) {
                eventHandler(this, new PropertyChangedEventArgs(propertyName));
            }
        }

    }


    public class Service {
        private static DataContractJsonSerializer conceptListSerializer = new DataContractJsonSerializer(typeof(ObservableCollection<Concept>), new DataContractJsonSerializerSettings() { UseSimpleDictionaryFormat = true });
        private static DataContractJsonSerializer attributesSerializer = new DataContractJsonSerializer(typeof(Dictionary<string, ObservableCollection<string>>), new DataContractJsonSerializerSettings() { UseSimpleDictionaryFormat = true });
        private static DataContractJsonSerializer conceptSerializer = new DataContractJsonSerializer(typeof(Concept), new DataContractJsonSerializerSettings() { UseSimpleDictionaryFormat = true });
        private static DataContractJsonSerializer successorSerializer = new DataContractJsonSerializer(typeof(Dictionary<string, ObservableCollection<Concept>>), new DataContractJsonSerializerSettings() { UseSimpleDictionaryFormat = true });
        private static DataContractJsonSerializer wordListSerializer = new DataContractJsonSerializer(typeof(ObservableCollection<string>), new DataContractJsonSerializerSettings() { UseSimpleDictionaryFormat = true });
              
        private static HttpClient client = new HttpClient() {
            BaseAddress = new Uri("http://192.168.1.3:9090/DrugsWeb/drugs/")
        };
        static Service() {
            client.DefaultRequestHeaders.Add("Accept", "application/json");
        }
        public static async Task<T> GetAsyncResult<T>(string requestString) where T : class, new() {
            var response = await client.GetAsync(requestString);
            if (response.IsSuccessStatusCode) {
                var stream = await response.Content.ReadAsStreamAsync();
                var result = conceptSerializer.ReadObject(stream);
                return result as T;
            } else {
                Debug.WriteLine("Debug: HTTP Error >> " + response.StatusCode.ToString() + " " + response.ReasonPhrase);
                return new T();
            }
        }
        public static async Task<ObservableCollection<Concept>> FindConceptsAsync(string query) {
            var response = await client.GetAsync("search/" + query);
            if (response.IsSuccessStatusCode) {
                return conceptListSerializer.ReadObject(await response.Content.ReadAsStreamAsync()) as ObservableCollection<Concept>;
            } else {
                Debug.WriteLine("Debug: HTTP Error >> " + response.StatusCode.ToString() + " " + response.ReasonPhrase);
                return new ObservableCollection<Concept>();
            }
        }

        public static async Task<Concept> GetConceptAsync(int id) {
            var response = await client.GetAsync(id.ToString());
            if (response.IsSuccessStatusCode) {
                return conceptSerializer.ReadObject(await response.Content.ReadAsStreamAsync()) as Concept;
            } else {
                Debug.WriteLine("Debug: HTTP Error >> " + response.StatusCode.ToString() + " " + response.ReasonPhrase);
                return new Concept();
            }
        }
        public static async Task<Dictionary<string, ObservableCollection<string>>> GetAttributesAsync(int id) {
            var response = await client.GetAsync("attributes/" + id.ToString());
            if (response.IsSuccessStatusCode) {
                return attributesSerializer.ReadObject(await response.Content.ReadAsStreamAsync()) as Dictionary<string, ObservableCollection<string>>;
            } else {
                Debug.WriteLine("Debug: HTTP Error >> " + response.StatusCode.ToString() + " " + response.ReasonPhrase);
                return new Dictionary<string, ObservableCollection<string>>();
            }
        }

        public static async Task<Dictionary<string, ObservableCollection<Concept>>> GetSuccessorsAsync(int id) {
            var response = await client.GetAsync("successors/" + id.ToString());
            if (response.IsSuccessStatusCode) {
                return successorSerializer.ReadObject(await response.Content.ReadAsStreamAsync()) as Dictionary<string, ObservableCollection<Concept>>;
            } else {
                Debug.WriteLine("Debug: HTTP Error >> " + response.StatusCode.ToString() + " " + response.ReasonPhrase);
                return new Dictionary<string, ObservableCollection<Concept>>();
            }
        }

        public static async Task<ObservableCollection<string>> SuggestCompletionsAsync(string query) {
            var response = await client.GetAsync("completions/" + query);
            if (response.IsSuccessStatusCode) {
                return wordListSerializer.ReadObject(await response.Content.ReadAsStreamAsync()) as ObservableCollection<string>;
            } else {
                Debug.WriteLine("Debug: HTTP Error >> " + response.StatusCode.ToString() + " " + response.ReasonPhrase);
                return new ObservableCollection<string>();
            }
        }
        public static async Task<ObservableCollection<string>> SuggestSpellingsAsync(string query) {
            var response = await client.GetAsync("spellings/" + query);
            if (response.IsSuccessStatusCode) {
                return wordListSerializer.ReadObject(await response.Content.ReadAsStreamAsync()) as ObservableCollection<string>;
            } else {
                Debug.WriteLine("Debug: HTTP Error >> " + response.StatusCode.ToString() + " " + response.ReasonPhrase);
                return new ObservableCollection<string>();
            }
        }
    }
}
