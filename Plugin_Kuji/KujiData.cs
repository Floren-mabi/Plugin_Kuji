using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Plugin_Kuji
{
    public class KujiData
    {
        // くじのキーワード
        [XmlAttribute("Keyword")]
        public string Keyword { get; set; }

        // 当選内容リスト(パイプ'|'区切り)
        [XmlAttribute("KujiList")]
        public string KujiList { get; set; }

        // 有効フラグ
        [XmlAttribute("Enable")]
        public string Enable { get; set; }
    }
}
