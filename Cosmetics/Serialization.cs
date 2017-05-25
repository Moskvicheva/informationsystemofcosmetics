using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace Cosmetics
{
    class Serialization
    {
        public void serialize(User user)
        {
            XmlSerializer xmls = new XmlSerializer(typeof(User));
            using (FileStream fl = new FileStream("database.xml", FileMode.OpenOrCreate))
            {
                xmls.Serialize(fl, user);
            }
        }
        public void deserialize(List<User> list)
        {
            XmlSerializer xmls = new XmlSerializer(typeof(User));
            using (FileStream fl = new FileStream("database.xml", FileMode.OpenOrCreate))
            {
                list = (List<User>)xmls.Deserialize(fl);
            }
        }
    }
}
