using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrightIdeasSoftware.Utilities
{
    /// <summary>
    /// 
    /// </summary>
   public  class Properties : IDisposable
    {
        private Dictionary<String, String> list;
        private String filename;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="file"></param>
        public Properties(String file)
        {
            filename = file;
            list = new Dictionary<string, string>();
            list =(Dictionary<string, string>)ReadDictionaryFile(file);
        }
        /// <summary>
        /// Generacarpeta default
        /// </summary>
        public Properties()
        {
            filename = DefaultUserPerfile();
            list = new Dictionary<string, string>();
            list = (Dictionary<string, string>)ReadDictionaryFile(filename);
        }

        private string DefaultUserPerfile()
        {
            string perfil = System.Environment.GetFolderPath(
                         System.Environment.SpecialFolder.UserProfile);
            return  String.Format("{0}\\JMTSystemSoftwareSignature.properties", perfil);
        }

        public String get(String field, String defValue)
        {
            return (get(field) == null) ? (defValue) : (get(field));
        }
        public String get(String field)
        {
            return (list.ContainsKey(field)) ? (list[field]) : (null);
        }

        public void set(String field, Object value)
        {
            if (!list.ContainsKey(field))
                list.Add(field, value.ToString());
            else
                list[field] = value.ToString();
        }

        public void Save()
        {
            Save(this.filename);
        }

        public void Save(String filename)
        {
            this.filename = filename;

            if (!System.IO.File.Exists(filename))
                System.IO.File.Create(filename);

            System.IO.StreamWriter file = new System.IO.StreamWriter(filename);

            foreach (String prop in list.Keys.ToArray())
                if (!String.IsNullOrWhiteSpace(list[prop]))
                    file.WriteLine(prop + "=" + list[prop]);

            file.Close();
        }


        private void loadFromFile(String file)
        {
            foreach (String line in System.IO.File.ReadAllLines(file))
            {
                if ((!String.IsNullOrEmpty(line)) &&
                    (!line.StartsWith(";")) &&
                    (!line.StartsWith("#")) &&
                    (!line.StartsWith("'")) &&
                    (line.Contains('=')))
                {
                    int index = line.IndexOf('=');
                    String key = line.Substring(0, index).Trim();
                    String value = line.Substring(index + 1).Trim();

                    if ((value.StartsWith("\"") && value.EndsWith("\"")) ||
                        (value.StartsWith("'") && value.EndsWith("'")))
                    {
                        value = value.Substring(1, value.Length - 2);
                    }

                    try
                    {
                        //ignore dublicates
                        list.Add(key, value);
                    }
                    catch { }
                }
            }
        }

        public static IDictionary ReadDictionaryFile(string fileName)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();

            if (!System.IO.File.Exists(fileName)) {
                FileStream writeFile = File.Open(fileName, FileMode.Create, FileAccess.Write);
                StreamWriter writer = new StreamWriter(writeFile);
                writer.Close();
                writeFile.Close();
            }

            string data = File.ReadAllText(fileName);
            if (string.IsNullOrEmpty (data))
            {
                return dictionary;
            }

            foreach (string line in File.ReadAllLines(fileName))
                {
                    if ((!string.IsNullOrEmpty(line)) &&
                        (!line.StartsWith(";")) &&
                        (!line.StartsWith("#")) &&
                        (!line.StartsWith("'")) &&
                        (line.Contains('=')))
                    {
                        int index = line.IndexOf('=');
                        string key = line.Substring(0, index).Trim();
                        string value = line.Substring(index + 1).Trim();

                        if ((value.StartsWith("\"") && value.EndsWith("\"")) ||
                            (value.StartsWith("'") && value.EndsWith("'")))
                        {
                            value = value.Substring(1, value.Length - 2);
                        }
                        dictionary.Add(key, value);
                    }
                }
          
            return dictionary;
        }

        public void Dispose()
        {
            filename = null;
            list = null;
        }
    }
}
