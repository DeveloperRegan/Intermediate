using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace TPR.AutoRepair.PL
{
    public static class DataAccess
    {
        public static void SaveToXML(string filepath, object obj, Type type)
        {

            try
            {
                StreamWriter sw = new StreamWriter(filepath);
                XmlSerializer Serializer = new XmlSerializer(type);
                Serializer.Serialize(sw, obj);
                sw.Close();
            }
            catch (Exception e)
            {
                
                throw e;
            }
        }

        public static object LoadFromXml(string filepath, Type type)
        {
            try
            {
                StreamReader Reader = new StreamReader(filepath);
                XmlSerializer Serializer = new XmlSerializer(type);

                object obj = Serializer.Deserialize(Reader);

                Reader.Close();
                return obj;
            }
            catch (Exception e)
            {

                throw e;
            }
            
        }
    }
}
