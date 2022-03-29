using System.Collections.Generic;
using System.IO;

namespace OOPinCSharp
{
    class Files
    {
        public void SearchMail(ref string s)
        {
            s = (s.Split('&'))[1].Trim();
        }

        public List<string> ReadEmailFromFile(string filename)
        {
            var list = new List<string>();
            using var fs = new FileStream(filename, FileMode.Open);
            using var r = new StreamReader(fs);
            while (!r.EndOfStream)
            {
                string s = r.ReadLine();
                SearchMail(ref s);
                list.Add(s);
            }
            return list;
        }

        public void WriteFile(string filename, List<string> list)
        {
            using var fs = new FileStream(filename, FileMode.OpenOrCreate);
            using var w = new StreamWriter(fs);
            foreach (var el in list)
                w.WriteLine(el);
        }
    }
}
