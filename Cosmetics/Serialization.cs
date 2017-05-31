using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Cosmetics
{
    class Serialization
    {

        public static void serialize(User[] list)
        {
            
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream("users.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, list);
            }
        }
        public static User[] deserialize()
        {
            User[] list;
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream("users.dat", FileMode.OpenOrCreate))
            {
                list = (User[])formatter.Deserialize(fs);
            }
            return list;
            
        }
    }
}
