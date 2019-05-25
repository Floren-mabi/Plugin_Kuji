using System;
using System.Collections.Generic;
using System.Text;
using FNF.BouyomiChanApp;
using FNF.XmlSerializerSetting;
using FNF.Utility;

namespace Plugin_Kuji
{
    public class PluginSettings :  SettingsBase
    {
        // くじ設定ファイルのパス
        public string KujiPath;
        // 受信待機インターバル(ms)
        public int Wait;
        // くじ発生時のKWとくじの間の待ち時間
        public int Interval;

        public override void ReadSettings()
        {
            return;
        }

        public override void WriteSettings()
        {
            return;
        }
    }
}
