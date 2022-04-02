using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft;

namespace modul6_kelompok_2
{
    class DataMahasiswa1302204065
    {
        private static string path;

        public String firstName { get; set; }
        public String lastName { get; set; }
        public String gander { get; set; }
        public int age { get; set; }
        public class Addres 
        {
            public String streetAddres { get; set; }
            public String City { get; set; }
            public String State { get; set; }
        }
        public class Course 
        {
            public String Name { get; set; }
            public String code { get; set; }
        }
        public static void ReadJSON()
        {
            string jsonString = File.ReadAllText(path: path + "D:/Tugas Kuliah/Semester IV/Konstruksi PL/Praktikum_kpl/Journal/jmodul6/modul6_kelompok_2_1302204065.json");

            dynamic input = Newtonsoft.Json.JsonConvert.DeserializeObject(jsonString);
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
}
