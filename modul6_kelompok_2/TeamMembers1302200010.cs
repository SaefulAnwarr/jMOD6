using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace modul6_kelompok_2
{
    class TeamMembers1302200010
    {
        public Members members { get; set; }
    }
    public class Members
    {
        public String firstName { get; set; }
        public String lastName { get; set; }
        public String gender { get; set; }
        public int age { get; set; }
        public String nim { get; set; }
    }
    public void ReadJSON()
    {
        String jsonString = File.ReadAllText("E:/Tugas Tel-U/semester 4/KONSTRUKSI PERANGKAT LUNAK/visual projek/tpmodul6_kelompok_2/jurnal6_2_1302200010.json");

        dynamic input = JsonConvert.DeserializeObject(jsonString);
        Console.WriteLine("Team member list: ");
        
        foreach (var item in input.members)
        {
            Console.WriteLine(input.nim + " "+input.firstName +" "+ input.lastName + " ("+input.age+" "+input.gender+")");
        }
    }
}