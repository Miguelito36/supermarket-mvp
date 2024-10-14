namespace Supermarket_mvp.Views
{
    partial class ProductsView
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel1 = new Panel();
            tabControl1 = new TabControl();
            tabPagePayModeList = new TabPage();
            BtnClose = new Button();
            BtnDelete = new Button();
            BtnEdit = new Button();
            BtnNew = new Button();
            DgPayMode = new DataGridView();
            BtnSearch = new Button();
            Txtsearch = new TextBox();
            label2 = new Label();
            tabPayPayModeDetail = new TabPage();
            BtnCancel = new Button();
            BtnSave = new Button();
            TxtPayModeId = new TextBox();
            TxtPayModeName = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label6 = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPagePayModeList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgPayMode).BeginInit();
            tabPayPayModeDetail.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.products;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(129, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(135, 42);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 1;
            label1.Text = "Products";
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 100);
            panel1.TabIndex = 0;
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
            tabControl1.TabIndex = 2;
            // 
            // tabPagePayModeList
            // 
            tabPagePayModeList.Controls.Add(BtnClose);
            tabPagePayModeList.Controls.Add(BtnDelete);
            tabPagePayModeList.Controls.Add(BtnEdit);
            tabPagePayModeList.Controls.Add(BtnNew);
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
            // BtnClose
            // 
            BtnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnClose.Image = Properties.Resources.cerrar;
            BtnClose.Location = new Point(589, 249);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(171, 60);
            BtnClose.TabIndex = 7;
            BtnClose.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            BtnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnDelete.Image = Properties.Resources.delete;
            BtnDelete.Location = new Point(589, 183);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(171, 60);
            BtnDelete.TabIndex = 6;
            BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnEdit
            // 
            BtnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnEdit.Image = Properties.Resources.edit;
            BtnEdit.Location = new Point(589, 120);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(171, 60);
            BtnEdit.TabIndex = 5;
            BtnEdit.UseVisualStyleBackColor = true;
            // 
            // BtnNew
            // 
            BtnNew.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnNew.Image = Properties.Resources._new;
            BtnNew.Location = new Point(589, 56);
            BtnNew.Name = "BtnNew";
            BtnNew.Size = new Size(171, 60);
            BtnNew.TabIndex = 4;
            BtnNew.UseVisualStyleBackColor = true;
            // 
            // DgPayMode
            // 
            DgPayMode.AllowUserToAddRows = false;
            DgPayMode.AllowUserToDeleteRows = false;
            DgPayMode.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DgPayMode.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgPayMode.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgPayMode.Location = new Point(19, 56);
            DgPayMode.Name = "DgPayMode";
            DgPayMode.ReadOnly = true;
            DgPayMode.Size = new Size(564, 253);
            DgPayMode.TabIndex = 3;
            // 
            // BtnSearch
            // 
            BtnSearch.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnSearch.BackgroundImage = Properties.Resources.search;
            BtnSearch.BackgroundImageLayout = ImageLayout.Zoom;
            BtnSearch.Location = new Point(548, 21);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.RightToLeft = RightToLeft.No;
            BtnSearch.Size = new Size(35, 33);
            BtnSearch.TabIndex = 2;
            BtnSearch.UseVisualStyleBackColor = true;
            // 
            // Txtsearch
            // 
            Txtsearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Txtsearch.Location = new Point(19, 27);
            Txtsearch.Name = "Txtsearch";
            Txtsearch.PlaceholderText = "Data to Search";
            Txtsearch.Size = new Size(523, 23);
            Txtsearch.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 6);
            label2.Name = "label2";
            label2.Size = new Size(126, 15);
            label2.TabIndex = 0;
            label2.Text = "Search Products Mode";
            // 
            // tabPayPayModeDetail
            // 
            tabPayPayModeDetail.Controls.Add(textBox2);
            tabPayPayModeDetail.Controls.Add(textBox3);
            tabPayPayModeDetail.Controls.Add(label6);
            tabPayPayModeDetail.Controls.Add(label7);
            tabPayPayModeDetail.Controls.Add(textBox1);
            tabPayPayModeDetail.Controls.Add(BtnCancel);
            tabPayPayModeDetail.Controls.Add(BtnSave);
            tabPayPayModeDetail.Controls.Add(TxtPayModeId);
            tabPayPayModeDetail.Controls.Add(TxtPayModeName);
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
            // BtnCancel
            // 
            BtnCancel.Image = Properties.Resources.cancel;
            BtnCancel.Location = new Point(159, 225);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(123, 52);
            BtnCancel.TabIndex = 7;
            BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnSave
            // 
            BtnSave.Image = Properties.Resources.save;
            BtnSave.Location = new Point(38, 225);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(115, 52);
            BtnSave.TabIndex = 6;
            BtnSave.UseVisualStyleBackColor = true;
            // 
            // TxtPayModeId
            // 
            TxtPayModeId.Location = new Point(38, 41);
            TxtPayModeId.Name = "TxtPayModeId";
            TxtPayModeId.ReadOnly = true;
            TxtPayModeId.Size = new Size(149, 23);
            TxtPayModeId.TabIndex = 5;
            TxtPayModeId.Text = "0";
            TxtPayModeId.TextAlign = HorizontalAlignment.Right;
            // 
            // TxtPayModeName
            // 
            TxtPayModeName.Location = new Point(38, 98);
            TxtPayModeName.Name = "TxtPayModeName";
            TxtPayModeName.PlaceholderText = "Name";
            TxtPayModeName.Size = new Size(254, 23);
            TxtPayModeName.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(41, 144);
            label5.Name = "label5";
            label5.Size = new Size(117, 15);
            label5.TabIndex = 2;
            label5.Text = "Products Mode Price";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(41, 26);
            label4.Name = "label4";
            label4.Size = new Size(101, 15);
            label4.TabIndex = 1;
            label4.Text = "Products Mode Id";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 83);
            label3.Name = "label3";
            label3.Size = new Size(123, 15);
            label3.TabIndex = 0;
            label3.Text = "Products Mode Name";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(38, 162);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Price";
            textBox1.Size = new Size(254, 23);
            textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(392, 162);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Category";
            textBox2.Size = new Size(254, 23);
            textBox2.TabIndex = 12;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(392, 98);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Stock Product";
            textBox3.Size = new Size(254, 23);
            textBox3.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(395, 144);
            label6.Name = "label6";
            label6.Size = new Size(139, 15);
            label6.TabIndex = 10;
            label6.Text = "Products Mode Category";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(395, 83);
            label7.Name = "label7";
            label7.Size = new Size(120, 15);
            label7.TabIndex = 9;
            label7.Text = "Products Mode Stock";
            // 
            // ProductsView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "ProductsView";
            Text = "ProductsView";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPagePayModeList.ResumeLayout(false);
            tabPagePayModeList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgPayMode).EndInit();
            tabPayPayModeDetail.ResumeLayout(false);
            tabPayPayModeDetail.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel1;
        private TabControl tabControl1;
        private TabPage tabPagePayModeList;
        private Button BtnClose;
        private Button BtnDelete;
        private Button BtnEdit;
        private Button BtnNew;
        private DataGridView DgPayMode;
        private Button BtnSearch;
        private TextBox Txtsearch;
        private Label label2;
        private TabPage tabPayPayModeDetail;
        private Button BtnCancel;
        private Button BtnSave;
        private TextBox TxtPayModeId;
        private TextBox TxtPayModeName;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label6;
        private Label label7;
        private TextBox textBox1;
    }
}