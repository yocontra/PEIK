using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace sub
{
    public class Settings
    {
        #region Settings
        #region Keylogger
        private string emailAddress;
        public string EmailAddress
        {
            get { return emailAddress; }
            set { emailAddress = value; }
        }
        private string emailPassword;
        public string EmailPassword
        {
            get { return emailPassword; }
            set { emailPassword = value; }
        }
        #endregion
        #endregion

        #region Serialization
        /// <summary>
        /// Serializes the settings object
        /// </summary>
        /// <param name="setting">Instance of the settings class</param>
        /// <param name="stream">Stream to write the xml data to</param>
        public static void Serialize(Settings setting, Stream stream)
        {
            System.Xml.Serialization.XmlSerializer xmlSerializer = new System.Xml.Serialization.XmlSerializer(typeof(Settings));
            xmlSerializer.Serialize(stream, setting);
        }
        public static Settings DeSerializeFromSelf(string xmlData)
        {
            System.Xml.Serialization.XmlSerializer xmlSerializer = new System.Xml.Serialization.XmlSerializer(typeof(Settings));
            MemoryStream memoryStream = new MemoryStream(StringToUTF8ByteArray(xmlData));
            return (Settings)xmlSerializer.Deserialize(memoryStream);
        }
        /// <summary>
        /// Converts the String to UTF8 Byte array and is used in De serialization
        /// </summary>
        /// <param name="pXmlString">The Xml data in string form</param>
        /// <returns></returns>
        private static Byte[] StringToUTF8ByteArray(string pXmlString)
        {
            UTF8Encoding encoding = new UTF8Encoding();
            Byte[] byteArray = encoding.GetBytes(pXmlString);
            return byteArray;
        }
        #endregion
    }
}
