using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft;

namespace modul6_kelompok_2
{
    public class DataMahasiswa1302204058
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public int age { get; set; }
        public Address address { get; set; }
        public Course course { get; set; }

        public input() { } 

        public static void ReadJSON()
        {
            //Baca file Json yang diinginkan
            String jsonString = File.ReadAllText("Users/devar/source/repos/jMOD6/modul6_kelompok_2/jurnal6_1_1302204058.json");
            //Deserialize file json menjadi objectS
            dynamic input = JsonConvert.DeserializeObject(jsonString);

            Console.WriteLine("Nama: " + input.firstName + input.lastName);
            Console.WriteLine("Jenis Kelamin: " + input.gender);
            Console.WriteLine("Umur: " + input.age);
            Console.WriteLine("Alamat: " + input.address.streetAddress + input.address.city + input.address.state);
            Console.WriteLine("Mata Kuliah: ");
            foreach (var item in input.courses)
            {
                Console.Write("Kode Kelas: " + item.code + ", ");
                Console.WriteLine("Nama Kelas: " + item.name);
            }

        }
    }

    public class Address
    {
        public string streetAddress { get; set; }
        public string city { get; set; }
        public string state { get; set; }
    }

    public class Course
    {
        public string code { get; set; }
        public string name { get; set; }
    }
}
