using lab02Tasks.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace lab02Tasks.Service
{
    public class DataService : IDataService
    {
        string Url = "http://localhost:56951/api/student";
        HttpClient client = new HttpClient();
        public List<Student> studentsList { get; set; }

        public DataService()
        {
            GetData();
        }
        async public void GetData()
        {
            var content = client.GetStringAsync(Url).Result;

            var data =  JsonConvert.DeserializeObject<List<Student>>(content);

            studentsList = data;

        }
        public Student Student(int id)
        {
            throw new NotImplementedException();
        }

        public List<Student> Students()
        {
            GetData();
            return studentsList;
        
        }


    }
}
