using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.ListView;

namespace Plugin_Kuji
{
    public partial class KujiSettingWindow : Form
    {
        public KujiSettings KujiSettings { get; set; }

        public KujiSettingWindow()
        {
            InitializeComponent();
            kujiListView.GetType().InvokeMember("DoubleBuffered", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetProperty, null, kujiListView, new object[] { true });
        }

        public KujiSettingWindow(KujiSettings kujiSettings)
        {
            InitializeComponent();
            kujiListView.GetType().InvokeMember("DoubleBuffered", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetProperty, null, kujiListView, new object[] { true });
        }

        private void RenderList()
        {
            List<KujiData> datas = KujiSettings.KujiDatas;

            kujiListView.Items.Clear();
            datas.ForEach(o => {
                ListViewItem item = new ListViewItem(o.Keyword);
                item.SubItems.Add(o.KujiList);
                if (o.Enable == "1")
                {
                    item.Checked = true;
                }
                kujiListView.Items.Add(item);
            });
        }

        private void kujiListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedIndexCollection idc = kujiListView.SelectedIndices;

            if (idc.Count > 0)
            {
                int idx = idc[0];
                KujiData data = KujiSettings.KujiDatas[idx];
                kujiKeyword.Text = data.Keyword;
                kujiItems.Text = data.KujiList.Replace("|", "\r\n");
            }
        }

        private void PlusButton_Click(object sender, EventArgs e)
        {
            if (kujiKeyword.Text.Length == 0)
            {
                MessageBox.Show("キーワードが未入力です", "登録エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (kujiItems.Text.Length == 0)
            {
                MessageBox.Show("くじ内容が未入力です", "登録エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string key = kujiKeyword.Text;
            int findIdx = KujiSettings.KujiDatas.FindIndex(o => {
                return o.Keyword == key;
            });
            if (findIdx == -1)
            {
                KujiData data = new KujiData();
                data.Keyword = kujiKeyword.Text;
                data.KujiList = kujiItems.Text.Trim().Replace("\r\n", "|");
                data.Enable = "1";
                KujiSettings.KujiDatas.Add(data);
            } else
            {
                KujiSettings.KujiDatas[findIdx].KujiList = kujiItems.Text.Trim().Replace("\r\n", "|");
            }
            RenderList();
        }

        private void MinusButton_Click(object sender, EventArgs e)
        {
            SelectedIndexCollection idc = kujiListView.SelectedIndices;

            if (idc.Count > 0)
            {
                KujiSettings.KujiDatas.RemoveAt(idc[0]);
                RenderList();
            }
        }

        private void KujiSettingWindow_Load(object sender, EventArgs e)
        {
            RenderList();
        }

        private void UpButton_Click(object sender, EventArgs e)
        {
            SelectedIndexCollection idc = kujiListView.SelectedIndices;

            if (idc.Count > 0 && idc[0] > 0)
            {
                int idx = idc[0];
                KujiData temp = KujiSettings.KujiDatas[idx - 1];
                KujiSettings.KujiDatas[idx - 1] = KujiSettings.KujiDatas[idx];
                KujiSettings.KujiDatas[idx] = temp;
                RenderList();
                kujiListView.Items[idx - 1].Selected = true;
                kujiListView.Items[idx - 1].Focused = true;
                kujiListView.Focus();
            }
        }

        private void DownButton_Click(object sender, EventArgs e)
        {
            SelectedIndexCollection idc = kujiListView.SelectedIndices;

            if (idc.Count > 0 && idc[0] < (kujiListView.Items.Count - 1))
            {
                int idx = idc[0];
                KujiData temp = KujiSettings.KujiDatas[idx + 1];
                KujiSettings.KujiDatas[idx + 1] = KujiSettings.KujiDatas[idx];
                KujiSettings.KujiDatas[idx] = temp;
                RenderList();
                kujiListView.Items[idx + 1].Selected = true;
                kujiListView.Items[idx + 1].Focused = true;
                kujiListView.Focus();
            }
        }

        private void kujiListView_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            ListViewItem item = e.Item;
            int findIdx = KujiSettings.KujiDatas.FindIndex(o => {
                return o.Keyword == item.Text;
            });
            if (findIdx > -1)
            {
                KujiSettings.KujiDatas[findIdx].Enable = e.Item.Checked ? "1" : "0";
            }
        }
    }
}
