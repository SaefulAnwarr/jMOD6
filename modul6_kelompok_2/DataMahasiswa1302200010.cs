using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace modul6_kelompok_2
{
    class DataMahasiswa1302200010
    {
        public String firstName { get; set; }
        public String lastName { get; set; }
        public String gender { get; set; }
        public int age { get; set; }
        public Address address { get; set; }
        public Course course { get; set; }
    }
    public class Address
    {
        public String streetAddress { get; set; }
        public String city { get; set; }
        public String state { get; set; }
    }
    public class Course
    {
        public String code { get; set; }
        public String name { get; set; }
    }
    public void ReadJSON()
    {
        String jsonString = File.ReadAllText("E:/Tugas Tel-U/semester 4/KONSTRUKSI PERANGKAT LUNAK/visual projek/tpmodul6_kelompok_2/jurnal6_1_1302200010.json");

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