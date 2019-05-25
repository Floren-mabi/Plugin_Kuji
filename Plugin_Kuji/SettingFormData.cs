using System;
using System.Collections.Generic;
using System.Text;
using FNF.XmlSerializerSetting;

namespace Plugin_Kuji
{
    class SettingFormData : ISettingFormData
    {
        // プラグイン設定内容
        private PluginSettings _settings = null;
        // プラグイン設定画面設定
        public SettingPropertyGrid _settingPropertyGrid = null;

        // 設定画面タイトル
        public string Title { get { return "くじプラグインの設定"; } }

        // TreeView開閉設定
        public bool ExpandAll { get { return false; } }

        // 設定内容
        public SettingsBase Setting { get { return _settings; } }

        // コンストラクタ
        public SettingFormData(PluginSettings settings)
        {
            _settings = settings;
            _settingPropertyGrid = new SettingPropertyGrid(_settings);
        }
    }
}
