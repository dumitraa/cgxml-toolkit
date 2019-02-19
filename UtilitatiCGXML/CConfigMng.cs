using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UtilitatiCGXML
{
    [Serializable()]
    public class CConfigDO
    {
        private System.Drawing.Point m_oStartPos;
        private System.Drawing.Size m_oStartSize;

        public System.Drawing.Point StartPos
        {
            get { return m_oStartPos; }
            set { m_oStartPos = value; }
        }

        public System.Drawing.Size StartSize
        {
            get { return m_oStartSize; }
            set { m_oStartSize = value; }
        }
        public string JudetNume;
        public int JudetIndex;
    }

    class CConfigMng
    {
        private string m_sConfigFileName = string.Concat(AppDomain.CurrentDomain.BaseDirectory) + "\\ProgramData\\" + "Settings.xml";
        private CConfigDO m_oConfig = new CConfigDO();

        public CConfigDO Config
        {
            get { return m_oConfig; }
            set { m_oConfig = value; }
        }

        // Load configuration file
        public void LoadConfig()
        {
            if (System.IO.File.Exists(m_sConfigFileName))
            {
                System.IO.StreamReader srReader = System.IO.File.OpenText(m_sConfigFileName);
                Type tType = m_oConfig.GetType();
                System.Xml.Serialization.XmlSerializer xsSerializer = new System.Xml.Serialization.XmlSerializer(tType);
                object oData = xsSerializer.Deserialize(srReader);
                m_oConfig = (CConfigDO)oData;
                srReader.Close();
            }
        }

        // Save configuration file
        public void SaveConfig()
        {
            System.IO.StreamWriter swWriter = System.IO.File.CreateText(m_sConfigFileName);
            Type tType = m_oConfig.GetType();
            if (tType.IsSerializable)
            {
                System.Xml.Serialization.XmlSerializer xsSerializer = new System.Xml.Serialization.XmlSerializer(tType);
                xsSerializer.Serialize(swWriter, m_oConfig);
                swWriter.Close();
            }
        }
    }
}
