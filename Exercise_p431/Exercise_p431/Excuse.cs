using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Exercise_p431
{
    class Excuse
    {
        public string Description { get; set; }
        public string Results { get; set; }
        public DateTime LastUsed { get; set; }
        public string ExcusePath;

        private StreamWriter writer;
        private StreamReader reader;

        public Excuse()
        {
            this.ExcusePath = "";
        }

        public Excuse(string excusePath)
        {
            OpenFile(excusePath);
        }

        public void OpenFile(string excusePath)
        {
            this.ExcusePath = excusePath;
            reader = new StreamReader(this.ExcusePath);
            Description = reader.ReadLine();
            Results = reader.ReadLine();
            this.LastUsed = Convert.ToDateTime(reader.ReadLine());
            reader.Close();
        }

        public void Save(string name)
        {
            writer = new StreamWriter(name);
            writer.WriteLine(this.Description);
            writer.WriteLine(this.Results);
            writer.WriteLine(this.LastUsed);
            writer.Close();
        }

    }
}
