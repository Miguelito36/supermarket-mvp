namespace Supermarket_mvp.Views
{
    partial class PayModeView
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
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            tabControl1 = new TabControl();
            tabPagePayModeList = new TabPage();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            DgPayMode = new DataGridView();
            BtnSearch = new Button();
            Txtsearch = new TextBox();
            label2 = new Label();
            tabPayPayModeDetail = new TabPage();
            button6 = new Button();
            button5 = new Button();
            TxtPayModeId = new TextBox();
            TxtPayModeName = new TextBox();
            TxtPayModeObservation = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabPagePayModeList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgPayMode).BeginInit();
            tabPayPayModeDetail.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 100);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.buy;
            pictureBox1.Location = new Point(12, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(106, 94);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(124, 25);
            label1.Name = "label1";
            label1.Size = new Size(128, 41);
            label1.TabIndex = 0;
            label1.Text = "Pay Mode";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPagePayModeList);
            tabControl1.Controls.Add(tabPayPayModeDetail);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 100);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 350);
            tabControl1.TabIndex = 1;
            // 
            // tabPagePayModeList
            // 
            tabPagePayModeList.Controls.Add(button4);
            tabPagePayModeList.Controls.Add(button3);
            tabPagePayModeList.Controls.Add(button2);
            tabPagePayModeList.Controls.Add(button1);
            tabPagePayModeList.Controls.Add(DgPayMode);
            tabPagePayModeList.Controls.Add(BtnSearch);
            tabPagePayModeList.Controls.Add(Txtsearch);
            tabPagePayModeList.Controls.Add(label2);
            tabPagePayModeList.Location = new Point(4, 24);
            tabPagePayModeList.Name = "tabPagePayModeList";
            tabPagePayModeList.Padding = new Padding(3);
            tabPagePayModeList.Size = new Size(792, 322);
            tabPagePayModeList.TabIndex = 0;
            tabPagePayModeList.Text = "Page Mode List";
            tabPagePayModeList.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Image = Properties.Resources.cerrar;
            button4.Location = new Point(589, 252);
            button4.Name = "button4";
            button4.Size = new Size(171, 60);
            button4.TabIndex = 7;
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Image = Properties.Resources.delete;
            button3.Location = new Point(589, 189);
            button3.Name = "button3";
            button3.Size = new Size(171, 60);
            button3.TabIndex = 6;
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Image = Properties.Resources.edit;
            button2.Location = new Point(589, 125);
            button2.Name = "button2";
            button2.Size = new Size(171, 60);
            button2.TabIndex = 5;
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Image = Properties.Resources._new;
            button1.Location = new Point(589, 61);
            button1.Name = "button1";
            button1.Size = new Size(171, 60);
            button1.TabIndex = 4;
            button1.UseVisualStyleBackColor = true;
            // 
            // DgPayMode
            // 
            DgPayMode.AllowUserToAddRows = false;
            DgPayMode.AllowUserToDeleteRows = false;
            DgPayMode.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgPayMode.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgPayMode.Location = new Point(16, 61);
            DgPayMode.Name = "DgPayMode";
            DgPayMode.ReadOnly = true;
            DgPayMode.Size = new Size(567, 255);
            DgPayMode.TabIndex = 3;
            // 
            // BtnSearch
            // 
            BtnSearch.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnSearch.BackgroundImage = Properties.Resources.search;
            BtnSearch.BackgroundImageLayout = ImageLayout.Zoom;
            BtnSearch.Location = new Point(540, 14);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.RightToLeft = RightToLeft.No;
            BtnSearch.Size = new Size(43, 41);
            BtnSearch.TabIndex = 2;
            BtnSearch.UseVisualStyleBackColor = true;
            // 
            // Txtsearch
            // 
            Txtsearch.Location = new Point(16, 24);
            Txtsearch.Name = "Txtsearch";
            Txtsearch.PlaceholderText = "Data to Search";
            Txtsearch.Size = new Size(518, 23);
            Txtsearch.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 3);
            label2.Name = "label2";
            label2.Size = new Size(98, 15);
            label2.TabIndex = 0;
            label2.Text = "Search Pay Mode";
            // 
            // tabPayPayModeDetail
            // 
            tabPayPayModeDetail.Controls.Add(button6);
            tabPayPayModeDetail.Controls.Add(button5);
            tabPayPayModeDetail.Controls.Add(TxtPayModeId);
            tabPayPayModeDetail.Controls.Add(TxtPayModeName);
            tabPayPayModeDetail.Controls.Add(TxtPayModeObservation);
            tabPayPayModeDetail.Controls.Add(label5);
            tabPayPayModeDetail.Controls.Add(label4);
            tabPayPayModeDetail.Controls.Add(label3);
            tabPayPayModeDetail.Location = new Point(4, 24);
            tabPayPayModeDetail.Name = "tabPayPayModeDetail";
            tabPayPayModeDetail.Padding = new Padding(3);
            tabPayPayModeDetail.Size = new Size(792, 322);
            tabPayPayModeDetail.TabIndex = 1;
            tabPayPayModeDetail.Text = "Pay Mode Details";
            tabPayPayModeDetail.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Image = Properties.Resources.cancel;
            button6.Location = new Point(159, 225);
            button6.Name = "button6";
            button6.Size = new Size(123, 52);
            button6.TabIndex = 7;
            button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Image = Properties.Resources.save;
            button5.Location = new Point(38, 225);
            button5.Name = "button5";
            button5.Size = new Size(115, 52);
            button5.TabIndex = 6;
            button5.UseVisualStyleBackColor = true;
            // 
            // TxtPayModeId
            // 
            TxtPayModeId.Location = new Point(38, 41);
            TxtPayModeId.Name = "TxtPayModeId";
            TxtPayModeId.Size = new Size(149, 23);
            TxtPayModeId.TabIndex = 5;
            // 
            // TxtPayModeName
            // 
            TxtPayModeName.Location = new Point(38, 98);
            TxtPayModeName.Name = "TxtPayModeName";
            TxtPayModeName.PlaceholderText = "Pay Mode Name";
            TxtPayModeName.Size = new Size(355, 23);
            TxtPayModeName.TabIndex = 4;
            // 
            // TxtPayModeObservation
            // 
            TxtPayModeObservation.Location = new Point(38, 159);
            TxtPayModeObservation.Multiline = true;
            TxtPayModeObservation.Name = "TxtPayModeObservation";
            TxtPayModeObservation.PlaceholderText = "Pay Mode Observation";
            TxtPayModeObservation.Size = new Size(355, 60);
            TxtPayModeObservation.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(38, 141);
            label5.Name = "label5";
            label5.Size = new Size(127, 15);
            label5.TabIndex = 2;
            label5.Text = "Pay Mode Observation";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(38, 23);
            label4.Name = "label4";
            label4.Size = new Size(73, 15);
            label4.TabIndex = 1;
            label4.Text = "Pay Mode Id";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 80);
            label3.Name = "label3";
            label3.Size = new Size(95, 15);
            label3.TabIndex = 0;
            label3.Text = "Pay Mode Name";
            // 
            // PayModeView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "PayModeView";
            Text = "Pay Mode Management";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPagePayModeList.ResumeLayout(false);
            tabPagePayModeList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgPayMode).EndInit();
            tabPayPayModeDetail.ResumeLayout(false);
            tabPayPayModeDetail.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private TabControl tabControl1;
        private TabPage tabPagePayModeList;
        private TabPage tabPayPayModeDetail;
        private TextBox Txtsearch;
        private Label label2;
        private Button BtnSearch;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private DataGridView DgPayMode;
        private TextBox TxtPayModeId;
        private TextBox TxtPayModeName;
        private TextBox TxtPayModeObservation;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button button6;
        private Button button5;
    }
}