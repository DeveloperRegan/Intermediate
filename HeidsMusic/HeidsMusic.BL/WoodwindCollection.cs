using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using HeidsMusic.Data;
using HeidsMusic.Utility;

namespace HeidsMusic.Business
{
    public class WoodwindCollection : IInstrumentCollection
    {
        private List<Woodwind> woodwindList = new List<Woodwind>();

        public List<Woodwind> WoodwindList
        {
            get { return woodwindList; }
        }
        

        public void Save()
        {

            try
            {
                DataFiler oFile = new DataFiler("Woodwinds.xml");
                oFile.Delete("Woodwinds.xml");
                oFile.SaveXML(woodwindList, typeof(List<Woodwind>));

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Load()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Woodwind>));
            TextReader textReader = new StreamReader("Woodwinds.xml");
            woodwindList = (List<Woodwind>)serializer.Deserialize(textReader);
            textReader.Close();
            textReader.Dispose();
            textReader = null;
        }
        public void Add(Woodwind oWoodwind)
        {
            woodwindList.Add(oWoodwind);
        }

    }
}
