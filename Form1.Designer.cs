
namespace FrameDataToolWinform
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.st_note = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_rec2CFomart = new MaterialSkin.Controls.MaterialButton();
            this.btn_orgAscII2Char = new MaterialSkin.Controls.MaterialButton();
            this.btn_org2AscII = new MaterialSkin.Controls.MaterialButton();
            this.cmb_crcType = new System.Windows.Forms.ComboBox();
            this.ck_autoProcess = new System.Windows.Forms.CheckBox();
            this.btn_process = new MaterialSkin.Controls.MaterialButton();
            this.txt_lenHex = new System.Windows.Forms.TextBox();
            this.txt_crcRes = new System.Windows.Forms.TextBox();
            this.txt_len = new System.Windows.Forms.TextBox();
            this.txt_cksum16 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_cksum8 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_copy = new MaterialSkin.Controls.MaterialButton();
            this.btn_delSpace = new MaterialSkin.Controls.MaterialButton();
            this.txt_des = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.btn_addSpace = new MaterialSkin.Controls.MaterialButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_paste = new MaterialSkin.Controls.MaterialButton();
            this.btn_clear = new MaterialSkin.Controls.MaterialButton();
            this.txt_org = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.materialTabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Controls.Add(this.tabPage3);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.ImageList = this.imageList1;
            this.materialTabControl1.Location = new System.Drawing.Point(3, 64);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(904, 570);
            this.materialTabControl1.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.statusStrip1);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.ImageKey = "基本信息.png";
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(896, 537);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "常规处理";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.st_note});
            this.statusStrip1.Location = new System.Drawing.Point(3, 508);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(890, 26);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // st_note
            // 
            this.st_note.Name = "st_note";
            this.st_note.Size = new System.Drawing.Size(167, 20);
            this.st_note.Text = "toolStripStatusLabel1";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.cmb_crcType);
            this.groupBox3.Controls.Add(this.ck_autoProcess);
            this.groupBox3.Controls.Add(this.btn_process);
            this.groupBox3.Controls.Add(this.txt_lenHex);
            this.groupBox3.Controls.Add(this.txt_crcRes);
            this.groupBox3.Controls.Add(this.txt_len);
            this.groupBox3.Controls.Add(this.txt_cksum16);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txt_cksum8);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(3, 314);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(890, 220);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn_rec2CFomart);
            this.groupBox4.Controls.Add(this.btn_orgAscII2Char);
            this.groupBox4.Controls.Add(this.btn_org2AscII);
            this.groupBox4.Location = new System.Drawing.Point(7, 106);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(831, 89);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "扩展功能";
            // 
            // btn_rec2CFomart
            // 
            this.btn_rec2CFomart.AutoSize = false;
            this.btn_rec2CFomart.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_rec2CFomart.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_rec2CFomart.Depth = 0;
            this.btn_rec2CFomart.HighEmphasis = true;
            this.btn_rec2CFomart.Icon = null;
            this.btn_rec2CFomart.Location = new System.Drawing.Point(26, 26);
            this.btn_rec2CFomart.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_rec2CFomart.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_rec2CFomart.Name = "btn_rec2CFomart";
            this.btn_rec2CFomart.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_rec2CFomart.Size = new System.Drawing.Size(145, 36);
            this.btn_rec2CFomart.TabIndex = 7;
            this.btn_rec2CFomart.Text = "结果区转成C语言格式";
            this.btn_rec2CFomart.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_rec2CFomart.UseAccentColor = false;
            this.btn_rec2CFomart.UseVisualStyleBackColor = true;
            this.btn_rec2CFomart.Click += new System.EventHandler(this.btn_rec2CFomart_Click);
            // 
            // btn_orgAscII2Char
            // 
            this.btn_orgAscII2Char.AutoSize = false;
            this.btn_orgAscII2Char.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_orgAscII2Char.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_orgAscII2Char.Depth = 0;
            this.btn_orgAscII2Char.HighEmphasis = true;
            this.btn_orgAscII2Char.Icon = null;
            this.btn_orgAscII2Char.Location = new System.Drawing.Point(326, 26);
            this.btn_orgAscII2Char.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_orgAscII2Char.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_orgAscII2Char.Name = "btn_orgAscII2Char";
            this.btn_orgAscII2Char.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_orgAscII2Char.Size = new System.Drawing.Size(107, 36);
            this.btn_orgAscII2Char.TabIndex = 7;
            this.btn_orgAscII2Char.Text = "ASCII码转字符";
            this.btn_orgAscII2Char.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_orgAscII2Char.UseAccentColor = false;
            this.btn_orgAscII2Char.UseVisualStyleBackColor = true;
            this.btn_orgAscII2Char.Click += new System.EventHandler(this.btn_orgAscII2Char_Click);
            // 
            // btn_org2AscII
            // 
            this.btn_org2AscII.AutoSize = false;
            this.btn_org2AscII.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_org2AscII.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_org2AscII.Depth = 0;
            this.btn_org2AscII.HighEmphasis = true;
            this.btn_org2AscII.Icon = null;
            this.btn_org2AscII.Location = new System.Drawing.Point(197, 26);
            this.btn_org2AscII.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_org2AscII.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_org2AscII.Name = "btn_org2AscII";
            this.btn_org2AscII.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_org2AscII.Size = new System.Drawing.Size(107, 36);
            this.btn_org2AscII.TabIndex = 7;
            this.btn_org2AscII.Text = "转成ASCII码";
            this.btn_org2AscII.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_org2AscII.UseAccentColor = false;
            this.btn_org2AscII.UseVisualStyleBackColor = true;
            this.btn_org2AscII.Click += new System.EventHandler(this.btn_org2AscII_Click);
            // 
            // cmb_crcType
            // 
            this.cmb_crcType.FormattingEnabled = true;
            this.cmb_crcType.Items.AddRange(new object[] {
            "CRC8",
            "16-CCITT-FALSE",
            "16-MODBUS"});
            this.cmb_crcType.Location = new System.Drawing.Point(493, 29);
            this.cmb_crcType.Name = "cmb_crcType";
            this.cmb_crcType.Size = new System.Drawing.Size(106, 28);
            this.cmb_crcType.TabIndex = 5;
            this.cmb_crcType.Text = "CRC8";
            // 
            // ck_autoProcess
            // 
            this.ck_autoProcess.AutoSize = true;
            this.ck_autoProcess.Checked = true;
            this.ck_autoProcess.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ck_autoProcess.Location = new System.Drawing.Point(737, 78);
            this.ck_autoProcess.Name = "ck_autoProcess";
            this.ck_autoProcess.Size = new System.Drawing.Size(91, 24);
            this.ck_autoProcess.TabIndex = 4;
            this.ck_autoProcess.Text = "自动处理";
            this.ck_autoProcess.UseVisualStyleBackColor = true;
            // 
            // btn_process
            // 
            this.btn_process.AutoSize = false;
            this.btn_process.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_process.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_process.Depth = 0;
            this.btn_process.HighEmphasis = true;
            this.btn_process.Icon = null;
            this.btn_process.Location = new System.Drawing.Point(725, 20);
            this.btn_process.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_process.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_process.Name = "btn_process";
            this.btn_process.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_process.Size = new System.Drawing.Size(111, 56);
            this.btn_process.TabIndex = 3;
            this.btn_process.Text = "处理";
            this.btn_process.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_process.UseAccentColor = false;
            this.btn_process.UseVisualStyleBackColor = true;
            this.btn_process.Click += new System.EventHandler(this.btn_process_Click);
            // 
            // txt_lenHex
            // 
            this.txt_lenHex.Location = new System.Drawing.Point(313, 66);
            this.txt_lenHex.Name = "txt_lenHex";
            this.txt_lenHex.Size = new System.Drawing.Size(66, 27);
            this.txt_lenHex.TabIndex = 2;
            // 
            // txt_crcRes
            // 
            this.txt_crcRes.Location = new System.Drawing.Point(493, 69);
            this.txt_crcRes.Name = "txt_crcRes";
            this.txt_crcRes.Size = new System.Drawing.Size(106, 27);
            this.txt_crcRes.TabIndex = 2;
            // 
            // txt_len
            // 
            this.txt_len.Location = new System.Drawing.Point(313, 28);
            this.txt_len.Name = "txt_len";
            this.txt_len.Size = new System.Drawing.Size(66, 27);
            this.txt_len.TabIndex = 2;
            // 
            // txt_cksum16
            // 
            this.txt_cksum16.Location = new System.Drawing.Point(121, 64);
            this.txt_cksum16.Name = "txt_cksum16";
            this.txt_cksum16.Size = new System.Drawing.Size(72, 27);
            this.txt_cksum16.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(413, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "CRC类型:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(223, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "长度(HEX):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(413, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "CRC值：";
            // 
            // txt_cksum8
            // 
            this.txt_cksum8.Location = new System.Drawing.Point(121, 26);
            this.txt_cksum8.Name = "txt_cksum8";
            this.txt_cksum8.Size = new System.Drawing.Size(72, 27);
            this.txt_cksum8.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(223, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "长度：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "校验和(16bit)：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "校验和(8bit)：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_copy);
            this.groupBox2.Controls.Add(this.btn_delSpace);
            this.groupBox2.Controls.Add(this.txt_des);
            this.groupBox2.Controls.Add(this.btn_addSpace);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(3, 161);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(890, 153);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "处理结果";
            // 
            // btn_copy
            // 
            this.btn_copy.AutoSize = false;
            this.btn_copy.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_copy.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_copy.Depth = 0;
            this.btn_copy.HighEmphasis = true;
            this.btn_copy.Icon = null;
            this.btn_copy.Location = new System.Drawing.Point(769, 111);
            this.btn_copy.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_copy.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_copy.Name = "btn_copy";
            this.btn_copy.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_copy.Size = new System.Drawing.Size(69, 36);
            this.btn_copy.TabIndex = 3;
            this.btn_copy.Text = "复制";
            this.btn_copy.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_copy.UseAccentColor = false;
            this.btn_copy.UseVisualStyleBackColor = true;
            // 
            // btn_delSpace
            // 
            this.btn_delSpace.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_delSpace.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_delSpace.Depth = 0;
            this.btn_delSpace.HighEmphasis = true;
            this.btn_delSpace.Icon = null;
            this.btn_delSpace.Location = new System.Drawing.Point(769, 71);
            this.btn_delSpace.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_delSpace.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_delSpace.Name = "btn_delSpace";
            this.btn_delSpace.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_delSpace.Size = new System.Drawing.Size(69, 36);
            this.btn_delSpace.TabIndex = 6;
            this.btn_delSpace.Text = "去空格";
            this.btn_delSpace.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_delSpace.UseAccentColor = false;
            this.btn_delSpace.UseVisualStyleBackColor = true;
            // 
            // txt_des
            // 
            this.txt_des.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txt_des.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_des.Depth = 0;
            this.txt_des.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_des.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txt_des.Location = new System.Drawing.Point(7, 26);
            this.txt_des.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_des.Name = "txt_des";
            this.txt_des.Size = new System.Drawing.Size(755, 124);
            this.txt_des.TabIndex = 3;
            this.txt_des.Text = "";
            // 
            // btn_addSpace
            // 
            this.btn_addSpace.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_addSpace.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_addSpace.Depth = 0;
            this.btn_addSpace.HighEmphasis = true;
            this.btn_addSpace.Icon = null;
            this.btn_addSpace.Location = new System.Drawing.Point(769, 31);
            this.btn_addSpace.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_addSpace.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_addSpace.Name = "btn_addSpace";
            this.btn_addSpace.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_addSpace.Size = new System.Drawing.Size(69, 36);
            this.btn_addSpace.TabIndex = 4;
            this.btn_addSpace.Text = "加空格";
            this.btn_addSpace.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_addSpace.UseAccentColor = false;
            this.btn_addSpace.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_paste);
            this.groupBox1.Controls.Add(this.btn_clear);
            this.groupBox1.Controls.Add(this.txt_org);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(890, 158);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "原始数据";
            // 
            // btn_paste
            // 
            this.btn_paste.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_paste.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_paste.Depth = 0;
            this.btn_paste.HighEmphasis = true;
            this.btn_paste.Icon = null;
            this.btn_paste.Location = new System.Drawing.Point(769, 86);
            this.btn_paste.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_paste.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_paste.Name = "btn_paste";
            this.btn_paste.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_paste.Size = new System.Drawing.Size(64, 36);
            this.btn_paste.TabIndex = 2;
            this.btn_paste.Text = "粘贴";
            this.btn_paste.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_paste.UseAccentColor = false;
            this.btn_paste.UseVisualStyleBackColor = true;
            // 
            // btn_clear
            // 
            this.btn_clear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_clear.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_clear.Depth = 0;
            this.btn_clear.HighEmphasis = true;
            this.btn_clear.Icon = null;
            this.btn_clear.Location = new System.Drawing.Point(769, 38);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_clear.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_clear.Size = new System.Drawing.Size(64, 36);
            this.btn_clear.TabIndex = 1;
            this.btn_clear.Text = "清除";
            this.btn_clear.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_clear.UseAccentColor = false;
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // txt_org
            // 
            this.txt_org.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txt_org.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_org.Depth = 0;
            this.txt_org.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_org.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txt_org.Location = new System.Drawing.Point(7, 27);
            this.txt_org.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_org.Name = "txt_org";
            this.txt_org.Size = new System.Drawing.Size(755, 125);
            this.txt_org.TabIndex = 0;
            this.txt_org.Text = "";
            this.txt_org.TextChanged += new System.EventHandler(this.txt_org_TextChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.ImageKey = "关于.png";
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(896, 537);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "关于...";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "基本信息.png");
            this.imageList1.Images.SetKeyName(1, "关于.png");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(910, 637);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerAutoShow = true;
            this.DrawerBackgroundWithAccent = true;
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.Name = "Form1";
            this.Text = "数据帧处理工具_V1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialMultiLineTextBox txt_org;
        private MaterialSkin.Controls.MaterialButton btn_clear;
        private MaterialSkin.Controls.MaterialButton btn_paste;
        private MaterialSkin.Controls.MaterialButton btn_copy;
        private MaterialSkin.Controls.MaterialButton btn_delSpace;
        private MaterialSkin.Controls.MaterialMultiLineTextBox txt_des;
        private MaterialSkin.Controls.MaterialButton btn_addSpace;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cmb_crcType;
        private System.Windows.Forms.CheckBox ck_autoProcess;
        private MaterialSkin.Controls.MaterialButton btn_process;
        private System.Windows.Forms.TextBox txt_lenHex;
        private System.Windows.Forms.TextBox txt_crcRes;
        private System.Windows.Forms.TextBox txt_len;
        private System.Windows.Forms.TextBox txt_cksum16;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_cksum8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel st_note;
        private MaterialSkin.Controls.MaterialButton btn_orgAscII2Char;
        private MaterialSkin.Controls.MaterialButton btn_org2AscII;
        private MaterialSkin.Controls.MaterialButton btn_rec2CFomart;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ImageList imageList1;
    }
}

