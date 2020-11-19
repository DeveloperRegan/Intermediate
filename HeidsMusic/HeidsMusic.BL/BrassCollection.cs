using System;
using System.Collections.Generic;
using System.IO;
using HeidsMusic.Data;
using HeidsMusic.Utility;
using System.Xml.Serialization;

namespace HeidsMusic.Business
{
    public class BrassCollection : IInstrumentCollection
    {
        private List<Brass> brassList = new List<Brass>();

        public void Add(Brass oBrass)
        {
            brassList.Add(oBrass);
        }
        
        public List<Brass> BrassList
        {
            get { return brassList; }
        }


        public void Save()
        {
            try
            {
                DataFiler oFile = new DataFiler("Brass.xml");
                oFile.Delete("Brass.xml");
                oFile.SaveXML(brassList, typeof(List<Brass>));
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Load()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Brass>));
            TextReader textReader = new StreamReader("Brass.xml");
            brassList = (List<Brass>)serializer.Deserialize(textReader);
            textReader.Close();
            textReader.Dispose();
            textReader = null;
        }
    }
}
