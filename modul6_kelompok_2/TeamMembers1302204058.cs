using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft;

namespace modul6_kelompok_2
{
    public class TeamMembers1302204058
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public int age { get; set; }
        public int nim { get; set; }

        public input() { }

        public static void ReadJSON()
        {
            //Baca file Json yang diinginkan
            String jsonString = File.ReadAllText("Users/devar/source/repos/jMOD6/modul6_kelompok_2/jurnal6_2_1302204058.json");
            //Deserialize file json menjadi objectS
            dynamic input = JsonConvert.DeserializeObject(jsonString);
            Console.WriteLine("Team member list:");

        }

        }
    }
}