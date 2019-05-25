using System;
using System.Collections.Generic;
using System.Text;
using FNF.XmlSerializerSetting;
using FNF.BouyomiChanApp;
using FNF.Utility;
using System.IO;
using System.Xml.Serialization;
using System.Windows.Forms;
using System.Threading;
using System.Drawing;

namespace Plugin_Kuji
{
    public class Plugin_Kuji : IPlugin
    {
        // OriginalFields
        private string _path = Base.CallAsmPath + Base.CallAsmName + ".setting";
        private PluginSettings _setting = null;
        private SettingFormData _settingFormData = null;
        private string _kujiPath { get; set; }
        private KujiSettings KujiSettings { get; set; }
        private MessageReceiver Receiver { get; set; }
        private string _pipeName = "SEServer";

        // InterfaceFields
        public string Name { get { return "くじプラグイン"; } }
        public string Version { get { return "Test v0.1"; } }
        public string Caption { get { return "ｶﾞﾁｬｶﾞﾁｬ..."; } }
        public ISettingFormData SettingFormData { get { return _settingFormData; } }

        // UI Fields
        private ToolStripSeparator _toolStripSeparator = null;
        private ToolStripButton _toolStripButton = null;

        public void Begin()
        {
            _setting = new PluginSettings();
            _setting.Load(_path);
            if (_setting.KujiPath == null || _setting.KujiPath.Length == 0 || !Directory.Exists(_setting.KujiPath))
            {
                _setting.KujiPath = Base.CallAsmPath + Base.CallAsmName + ".Data.xml";
            }
            _settingFormData = new SettingFormData(_setting);

            _toolStripSeparator = new ToolStripSeparator();
            _toolStripButton = new ToolStripButton(Properties.Resources.KujiIcon);
            _toolStripButton.ToolTipText = "くじ設定";
            _toolStripButton.Click += new EventHandler(_toolStripButton_Click);
            Pub.ToolStrip.Items.Add(_toolStripSeparator);
            Pub.ToolStrip.Items.Add(_toolStripButton);

            LoadKujiSettings();

            Receiver = new MessageReceiver(_pipeName, _setting.Wait);
            Receiver.OnReceiveEvent += new MessageReceiver.OnReceive(OnMessage);

            Thread t = new Thread(() => { Receiver.Start(); });
            t.IsBackground = true;
            t.Start();
            return;
        }

        public void End()
        {
            _setting.Save(_path);
            SaveKujiSettings();
            if (_toolStripSeparator != null)
            {
                Pub.ToolStrip.Items.Remove(_toolStripSeparator);
                _toolStripSeparator.Dispose();
                _toolStripSeparator = null;
            }
            if (_toolStripButton != null)
            {
                Pub.ToolStrip.Items.Remove(_toolStripButton);
                _toolStripButton.Dispose();
                _toolStripButton = null;
            }
            return;
        }

        private void LoadKujiSettings()
        {
            if (!File.Exists(_setting.KujiPath))
            {
                KujiSettings = new KujiSettings();
                KujiSettings.KujiDatas = new List<KujiData>();
                SaveKujiSettings();
            }
            XmlSerializer se = new XmlSerializer(typeof(KujiSettings));
            using (StreamReader sr = new StreamReader(_setting.KujiPath, Encoding.UTF8))
            {
                KujiSettings = (KujiSettings) se.Deserialize(sr);
            }
            if (KujiSettings.KujiDatas == null)
            {
                KujiSettings.KujiDatas = new List<KujiData>();
            }
        }

        private void SaveKujiSettings()
        {
            XmlSerializer se = new XmlSerializer(typeof(KujiSettings));
            using (StreamWriter sw = new StreamWriter(_setting.KujiPath, false, Encoding.UTF8))
            {
                se.Serialize(sw, KujiSettings);
            }
        }

        private void OnMessage(string message)
        {
            Pub.AddTalkTask(message);
            string kujiMsg = KujiFind(message);
            if (kujiMsg.Length > 0)
            {
                Thread.Sleep(_setting.Interval);
                Pub.AddTalkTask(kujiMsg);
            }
        }

        private string KujiFind(string message)
        {
            string result = "";
            List<KujiData> data = KujiSettings.KujiDatas;
            KujiData resultData = data.Find(o => {
                return (message.IndexOf(o.Keyword) > -1) && (o.Enable == "1");
            });
            if (resultData != null && resultData.KujiList != null && resultData.KujiList.Length > 0)
            {
                string[] kujiList = resultData.KujiList.Split(new char[] {'|'});
                Random r = new Random();
                int idx = r.Next(0, kujiList.Length);
                result = kujiList[idx];
            }
            return result;
        }

        public void _toolStripButton_Click(object sender, EventArgs args)
        {
            LoadKujiSettings();
            KujiSettingWindow form = new KujiSettingWindow();
            form.KujiSettings = KujiSettings;
            DialogResult result = form.ShowDialog();
            if (result == DialogResult.OK)
            {
                SaveKujiSettings();
            } else
            {
                LoadKujiSettings();
            }
        }
    }
}






