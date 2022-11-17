using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Lesson_14
{
    public class SquadProvide
    {
        public Squad Desirialize(string path)
        {
            Squad squad = new Squad();
            try
            {
                using (StreamReader reader = new StreamReader(path))
                {
                    string line = reader.ReadToEnd();
                    squad = JsonConvert.DeserializeObject<Squad>(line);
                    reader.Close();
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

            return squad;
        }

        public void Serialize(string path, Squad squad)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(path))
                {
                    string objectInput = JsonConvert.SerializeObject(squad);
                    writer.WriteLine(objectInput);
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void SerializeInXML(string path, Squad squad)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(path))
                {
                    XmlSerializer xml = new XmlSerializer(typeof(Squad));
                    xml.Serialize(writer, squad);
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }

}

