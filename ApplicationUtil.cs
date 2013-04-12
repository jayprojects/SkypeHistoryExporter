using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
namespace SkypeHistoryExporter
{
    public class ApplicationUtil
    {
        public static void setDestDataSources(List<ComboboxItem> sourceList)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                using (StreamReader sr = new StreamReader(ms))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(ms, sourceList);
                    ms.Position = 0;
                    byte[] buffer = new byte[(int)ms.Length];
                    ms.Read(buffer, 0, buffer.Length);
                    Properties.Settings.Default.destDataSources = Convert.ToBase64String(buffer);
                    Properties.Settings.Default.Save();
                }
            }
        }

        public static List<ComboboxItem> getDestDataSources()
        {
            using (MemoryStream ms = new MemoryStream(Convert.FromBase64String(Properties.Settings.Default.destDataSources)))
            {
                BinaryFormatter bf = new BinaryFormatter();
                if (ms == null || ms.Length<1)
                    return new List<ComboboxItem>();
                else
                    return (List<ComboboxItem>)bf.Deserialize(ms);
            }
        }
    }
}
