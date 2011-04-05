using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using sub.Util.Encryption;

namespace sub.Util.Misc
{
    class SettingsParser
    {
        private string _file;
        private string _splitter = "<<|>>";
        private string _littleSplitter = "<<>>";

        public SettingsParser(string file)
        {
            _file = file;
        }
        public string GetSettings()
        {
            byte[] stub = File.ReadAllBytes(_file);
            //Format: filedata|split|appendData
            string appendData = Regex.Split(Encoding.Default.GetString(stub), _splitter)[1];

            //Format: keyPart1|lilsplit|encryptedSettings|lilsplit|keyPart2
            string[] firstCycle = Regex.Split(appendData, _littleSplitter);
            string key = firstCycle[0] + firstCycle[2];
            string encryptedSettings = firstCycle[1];
            SimpleAES decryptor = new SimpleAES(key);
            string decryptedSettings = decryptor.DecryptString(encryptedSettings);
            return decryptedSettings;
        }
    }
}
