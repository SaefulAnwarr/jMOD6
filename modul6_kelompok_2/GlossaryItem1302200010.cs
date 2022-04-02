using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace modul6_kelompok_2
{
    class GlossaryItem1302200010
    {
        public Glossary glossary { get; set; }
    }
    public class Glossary
    {
        public String title { get; set; }
        public GlossDiv GlossDiv { get; set; }
    }
    public class GlossDiv
    {
        public String title { get; set; }
        public GlossList GlossList { get; set; }
    }
    public class GlossList
    {
        public GlossEntry GlossEntry { get; set; }
    }
    public class GlossEntry
    {
        public String ID { get; set; }
        public String SortAs { get; set; }
        public String GlossTerm { get; set; }
        public String Acronym { get; set; }
        public String Abbrev { get; set; }
        public GlossDef GlossDef { get; set; }
        public String GlossSee { get; set; }
    }
    public class GlossEntry
    {
        public String para { get; set; }
        public String[] GlossSeeAlso { get; set; }
    }
    public void ReadJSON()
    {
        String jsonString = File.ReadAllText("E:/Tugas Tel-U/semester 4/KONSTRUKSI PERANGKAT LUNAK/visual projek/tpmodul6_kelompok_2/jurnal6_3_1302200010.json");

        dynamic input = JsonConvert.DeserializeObject(jsonString);
        Console.WriteLine(input.glossary);
    }
}