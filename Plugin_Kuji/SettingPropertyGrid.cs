using System;
using System.Collections.Generic;
using System.Text;
using FNF.XmlSerializerSetting;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Drawing.Design;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace Plugin_Kuji
{
    public class SettingPropertyGrid : ISettingPropertyGrid
    {
        // プラグイン設定
        private PluginSettings _settings = null;

        // コンストラクタ
        public SettingPropertyGrid(PluginSettings settings)
        {
            _settings = settings;
        }

        // 設定画面名
        public string GetName()
        {
            return "くじ設定";
        }

        // 設定内容 くじ設定ファイルのパス
        [Category("基本設定")]
        [DisplayName("くじ設定ファイルのパス")]
        [Description("くじ設定ファイルのパスを指定してください")]
        public string KujiPath
        {
            get { return _settings.KujiPath; }
            set { _settings.KujiPath = value; }
        }

        // 設定内容 待機時間
        [Category("基本設定")]
        [DisplayName("受付待機時間(ミリ秒)")]
        [Description("メッセージ受付待機のインターバルをミリ秒で指定してください")]
        public int Wait
        {
            get { return _settings.Wait; }
            set { _settings.Wait = value; }
        }

        // 設定内容 くじ発生タイミング
        [Category("基本設定")]
        [DisplayName("キーワード発声からくじ発声までの待ち時間(ミリ秒)")]
        [Description("キーワード発生からくじ発声までの待ち時間をミリ秒で指定してください")]
        public int Interval
        {
            get { return _settings.Interval; }
            set { _settings.Interval = value; }
        }
    }
}
