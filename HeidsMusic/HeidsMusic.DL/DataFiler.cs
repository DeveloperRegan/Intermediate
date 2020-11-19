using System.IO;
using System;
using System.Xml.Serialization;

namespace HeidsMusic.Data
{
    public class DataFiler
    {
        string _sFileName;
        string _sXMLFileName;

        public DataFiler()
        {
            _sFileName = "FlatFile.txt";
            _sXMLFileName = _sFileName.Substring(0, _sFileName.IndexOf(".")) + ".xml";
        }
        public DataFiler(string sFileName)
        {
            _sFileName = sFileName;
            _sXMLFileName = _sFileName.Substring(0, _sFileName.IndexOf(".")) + ".xml";
        }

        public void Save(string stream)
        {
            try
            {
                StreamWriter oWriter;
                oWriter = File.AppendText(_sFileName);
                oWriter.WriteLine(stream);
                oWriter.Close();
                oWriter.Dispose();
                oWriter = null;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public string[] Load()
        {
            try
            {
                string[] stream;
                stream = File.ReadAllLines(_sFileName);
                return stream;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public void Delete(string filename)
        {
            try
            {
                if (File.Exists(filename))
                { File.Delete(filename); }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void SaveXML(object objectToSave, Type oType)
        {
            XmlSerializer serializer = new XmlSerializer(oType);
            TextWriter textWriter = new StreamWriter(_sXMLFileName);
            serializer.Serialize(textWriter, objectToSave);
            textWriter.Close();
            textWriter.Dispose();
            textWriter = null;
        }
    }
}
