using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace WinFormsApp1.AllProgramSettings
{
    public static class SaveSettings
    {
        public static void SerializerXML(string SettingsFile, Object obj)
        {
            var ds = new DataContractSerializer(obj.GetType());
            var set = new XmlWriterSettings { Indent = true, IndentChars = "\t" };
            using (XmlWriter w = XmlWriter.Create(SettingsFile, set))
            {
                ds.WriteObject(w, obj);
            }
        }
        public static Object DeserializeXML(string SettingsFile, Object obj)
        {
            using (var fs = new FileStream(SettingsFile, FileMode.Open))
            {
                var ds = new DataContractSerializer(obj.GetType());
                return ds.ReadObject(fs);
            }
        }
    }
}
