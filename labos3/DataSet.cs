using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace labos3
{
    //Zad1
    [Serializable]
    class DataSet : IPrototype<DataSet>
    {

        private List<List<string>> Data; //list of lists of strings
        public DataSet()
        {
            this.Data = new List<List<string>>();
        }
        public DataSet(string filePath) : this()
        {
            this.LoadDataFromCSV(filePath);
        }

        public void LoadDataFromCSV(string filePath)
        {
            using (System.IO.StreamReader reader = new System.IO.StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    List<string> row = new List<string>();
                    string[] items = line.Split(',');
                    foreach (string item in items)
                    {
                        row.Add(item);
                    }
                    this.Data.Add(row);
                }
            }
        }
        public string PrintList()
        {

            StringBuilder stringBuilder = new StringBuilder();
            foreach (List<string> item in this.Data)
            {
                foreach (var obj in item)
                {
                    stringBuilder.Append(obj);
                }
                stringBuilder.Append("\n");
            }
            return stringBuilder.ToString();
        }


        public DataSet Clone()
        {
            return new DataSet();

        }

        //deep clone
        public static List<T> Clone<T>(List<T> oldList)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            MemoryStream stream = new MemoryStream();
            formatter.Serialize(stream, oldList);
            stream.Position = 0;
            return (List<T>)formatter.Deserialize(stream);

        }

    }

}
      
 
