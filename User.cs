using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace WindowsFormsApp4
{
    public class User
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Email { get; set; }
        public string Mb { get; set; }
        

        public void Serialize(string fileName)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(User));
            using(TextWriter writer =new StreamWriter(@fileName))
            {
                serializer.Serialize(writer, this);
            }
        }

        public static User Deserialize(string fileName)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(User));
            FileStream stream = new FileStream(fileName, FileMode.Open);
            return (User)serializer.Deserialize(stream);
        }
    }
}
