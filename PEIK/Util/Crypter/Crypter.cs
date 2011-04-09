#region Imports

using System;
using System.Windows.Forms;

#endregion

namespace PEIK.Util.Crypter
{
    class Crypter
    {
        private string _file;
        private string _source;
        private string _key;
        private string _icon;

        public Crypter(string file, string source, string key)
        {
            _key = key;
            _file = file;
            _source = source;
        }

        public Crypter(string file, string source, string key, string icon)
        {
            _icon = icon;
            _key = key;
            _file = file;
            _source = source;
        }

        public void Process()
        {
            byte[] input = CrypterMethods.Encrypt(System.IO.File.ReadAllBytes(_file), _key);
            string[] vars = {
					"[var1]",
					"[var2]",
                    "[enc]",
                    "[key]",
					"[var4]",
					"[var5]",
                    "[var6]",
                    "[var7]"
				};
            foreach(string s in vars)
            {
                switch (s)
                {
                    case "[enc]":
                        _source = _source.Replace(s, Convert.ToBase64String(input));
                        break;
                    case "[key]":
                        _source = _source.Replace(s, _key);
                        break;
                    default:
                        string temp = s.Replace("[", "").Replace("]", "");
                        _source = _source.Replace(s, temp + CrypterMethods.GetKey(15));
                        break;
                }
            }
            MessageBox.Show(_source);
        }

        public void Save(string location)
        {
            Compiler.GenerateExecutable(location, _source, _icon);
        }
    }
}
