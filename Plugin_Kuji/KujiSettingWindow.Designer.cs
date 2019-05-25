namespace Plugin_Kuji
{
    partial class KujiSettingWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KujiSettingWindow));
            this.kujiListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.UpButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.kujiItems = new System.Windows.Forms.TextBox();
            this.kujiKeyword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DownButton = new System.Windows.Forms.Button();
            this.PlusButton = new System.Windows.Forms.Button();
            this.MinusButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // kujiListView
            // 
            this.kujiListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.kujiListView.CheckBoxes = true;
            this.kujiListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.kujiListView.FullRowSelect = true;
            this.kujiListView.GridLines = true;
            this.kujiListView.HideSelection = false;
            this.kujiListView.Location = new System.Drawing.Point(3, 18);
            this.kujiListView.MultiSelect = false;
            this.kujiListView.Name = "kujiListView";
            this.kujiListView.Size = new System.Drawing.Size(324, 239);
            this.kujiListView.TabIndex = 0;
            this.kujiListView.UseCompatibleStateImageBehavior = false;
            this.kujiListView.View = System.Windows.Forms.View.Details;
            this.kujiListView.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.kujiListView_ItemChecked);
            this.kujiListView.SelectedIndexChanged += new System.EventHandler(this.kujiListView_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "キーワード";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "くじ内容";
            this.columnHeader2.Width = 200;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(416, 246);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(497, 246);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "キャンセル";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.MinusButton);
            this.groupBox1.Controls.Add(this.DownButton);
            this.groupBox1.Controls.Add(this.UpButton);
            this.groupBox1.Controls.Add(this.kujiListView);
            this.groupBox1.Location = new System.Drawing.Point(12, 9);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.groupBox1.Size = new System.Drawing.Size(362, 260);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "くじ一覧";
            // 
            // UpButton
            // 
            this.UpButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("UpButton.BackgroundImage")));
            this.UpButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.UpButton.Location = new System.Drawing.Point(327, 18);
            this.UpButton.Name = "UpButton";
            this.UpButton.Size = new System.Drawing.Size(32, 32);
            this.UpButton.TabIndex = 1;
            this.UpButton.UseVisualStyleBackColor = true;
            this.UpButton.Click += new System.EventHandler(this.UpButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.kujiItems);
            this.groupBox2.Controls.Add(this.PlusButton);
            this.groupBox2.Controls.Add(this.kujiKeyword);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(381, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(191, 231);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "個別設定";
            // 
            // kujiItems
            // 
            this.kujiItems.Location = new System.Drawing.Point(6, 56);
            this.kujiItems.Multiline = true;
            this.kujiItems.Name = "kujiItems";
            this.kujiItems.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.kujiItems.Size = new System.Drawing.Size(179, 138);
            this.kujiItems.TabIndex = 5;
            // 
            // kujiKeyword
            // 
            this.kujiKeyword.Location = new System.Drawing.Point(63, 15);
            this.kujiKeyword.Name = "kujiKeyword";
            this.kujiKeyword.Size = new System.Drawing.Size(122, 19);
            this.kujiKeyword.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "くじ内容";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "キーワード";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DownButton
            // 
            this.DownButton.BackgroundImage = global::Plugin_Kuji.Properties.Resources.Down;
            this.DownButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.DownButton.Location = new System.Drawing.Point(327, 56);
            this.DownButton.Name = "DownButton";
            this.DownButton.Size = new System.Drawing.Size(32, 32);
            this.DownButton.TabIndex = 2;
            this.DownButton.UseVisualStyleBackColor = true;
            this.DownButton.Click += new System.EventHandler(this.DownButton_Click);
            // 
            // PlusButton
            // 
            this.PlusButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PlusButton.Location = new System.Drawing.Point(6, 200);
            this.PlusButton.Name = "PlusButton";
            this.PlusButton.Size = new System.Drawing.Size(75, 25);
            this.PlusButton.TabIndex = 3;
            this.PlusButton.Text = "保存";
            this.PlusButton.UseVisualStyleBackColor = true;
            this.PlusButton.Click += new System.EventHandler(this.PlusButton_Click);
            // 
            // MinusButton
            // 
            this.MinusButton.BackgroundImage = global::Plugin_Kuji.Properties.Resources.Minus;
            this.MinusButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.MinusButton.Location = new System.Drawing.Point(327, 129);
            this.MinusButton.Name = "MinusButton";
            this.MinusButton.Size = new System.Drawing.Size(32, 32);
            this.MinusButton.TabIndex = 4;
            this.MinusButton.UseVisualStyleBackColor = true;
            this.MinusButton.Click += new System.EventHandler(this.MinusButton_Click);
            // 
            // KujiSettingWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 281);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(600, 320);
            this.MinimumSize = new System.Drawing.Size(600, 320);
            this.Name = "KujiSettingWindow";
            this.Text = "くじ設定";
            this.Load += new System.EventHandler(this.KujiSettingWindow_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView kujiListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox kujiItems;
        private System.Windows.Forms.TextBox kujiKeyword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button UpButton;
        private System.Windows.Forms.Button DownButton;
        private System.Windows.Forms.Button PlusButton;
        private System.Windows.Forms.Button MinusButton;
    }
}