using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Plugin_Kuji
{
    public class KujiSettings
    {
        // くじ内容のリスト
        [XmlArray("KujiDatas")]
        [XmlArrayItem("KujiData")]
        public List<KujiData> KujiDatas { get; set; }
    }
}
