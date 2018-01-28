using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Exercise_p461
{
    [Serializable]
    class Excuse
    {
        public string Description { get; set; }
        public string Results { get; set; }
        public DateTime LastUsed { get; set; }
        public string ExcusePath;

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

            using (Stream input = File.OpenRead(ExcusePath))
            {

                BinaryFormatter formatter = new BinaryFormatter();

                Excuse readExcuse = (Excuse)formatter.Deserialize(input);
                this.Description = readExcuse.Description;
                this.Results = readExcuse.Results;
                this.LastUsed = readExcuse.LastUsed;
            }


            //reader = new StreamReader(this.ExcusePath);
            //Description = reader.ReadLine();
            //Results = reader.ReadLine();
            //this.LastUsed = Convert.ToDateTime(reader.ReadLine());
            //reader.Close();
        }

        public void Save(string excusePath)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (Stream output = File.OpenWrite(excusePath))
            {
                formatter.Serialize(output, this);
            }

        }

    }
}
