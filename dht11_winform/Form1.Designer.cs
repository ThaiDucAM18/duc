
namespace dht11_winform
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.groupBox_setting = new System.Windows.Forms.GroupBox();
            this.label_trang_thai = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_baud = new System.Windows.Forms.ComboBox();
            this.comboBox_com = new System.Windows.Forms.ComboBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btn_disconnect = new System.Windows.Forms.Button();
            this.btn_connect = new System.Windows.Forms.Button();
            this.groupBox_time = new System.Windows.Forms.GroupBox();
            this.label_time = new System.Windows.Forms.Label();
            this.label_date = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label_nhiet_do = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label_do_am = new System.Windows.Forms.Label();
            this.groupBox_hien_thi = new System.Windows.Forms.GroupBox();
            this.label22 = new System.Windows.Forms.Label();
            this.lb_80 = new System.Windows.Forms.Label();
            this.lb_60 = new System.Windows.Forms.Label();
            this.lb_40 = new System.Windows.Forms.Label();
            this.lb_20 = new System.Windows.Forms.Label();
            this.label_pro_ht_nhiet_do = new System.Windows.Forms.Label();
            this.label_muc_ghd = new System.Windows.Forms.Label();
            this.label_muc_ght = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label_80 = new System.Windows.Forms.Label();
            this.label_60 = new System.Windows.Forms.Label();
            this.label_40 = new System.Windows.Forms.Label();
            this.label_20 = new System.Windows.Forms.Label();
            this.veticalProgressBar1 = new dht11_winform.veticalProgressBar();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox_control_may_lanh = new System.Windows.Forms.GroupBox();
            this.pic_m_lanh_off = new System.Windows.Forms.PictureBox();
            this.pic_may_lanh = new System.Windows.Forms.PictureBox();
            this.bt_off_mlanh = new System.Windows.Forms.Button();
            this.bt_on_mlanh = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox_control_suoi = new System.Windows.Forms.GroupBox();
            this.pic_m_suoi_off = new System.Windows.Forms.PictureBox();
            this.pic_suoi = new System.Windows.Forms.PictureBox();
            this.bt_off_suoi = new System.Windows.Forms.Button();
            this.bt_on_suoi = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.timer5 = new System.Windows.Forms.Timer(this.components);
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox_set_gh = new System.Windows.Forms.GroupBox();
            this.bt_reset = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label_ghd = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label_ght = new System.Windows.Forms.Label();
            this.text_ghd = new System.Windows.Forms.TextBox();
            this.text_ght = new System.Windows.Forms.TextBox();
            this.bt_set_ghd = new System.Windows.Forms.Button();
            this.bt_set_ght = new System.Windows.Forms.Button();
            this.bt_excel = new System.Windows.Forms.Button();
            this.bt_clean = new System.Windows.Forms.Button();
            this.groupBox_setting.SuspendLayout();
            this.groupBox_time.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.groupBox_hien_thi.SuspendLayout();
            this.groupBox_control_may_lanh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_m_lanh_off)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_may_lanh)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox_control_suoi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_m_suoi_off)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_suoi)).BeginInit();
            this.groupBox_set_gh.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_setting
            // 
            this.groupBox_setting.Controls.Add(this.label_trang_thai);
            this.groupBox_setting.Controls.Add(this.label3);
            this.groupBox_setting.Controls.Add(this.label2);
            this.groupBox_setting.Controls.Add(this.label1);
            this.groupBox_setting.Controls.Add(this.comboBox_baud);
            this.groupBox_setting.Controls.Add(this.comboBox_com);
            this.groupBox_setting.Controls.Add(this.progressBar1);
            this.groupBox_setting.Controls.Add(this.btn_disconnect);
            this.groupBox_setting.Controls.Add(this.btn_connect);
            this.groupBox_setting.Location = new System.Drawing.Point(12, 184);
            this.groupBox_setting.Name = "groupBox_setting";
            this.groupBox_setting.Size = new System.Drawing.Size(280, 186);
            this.groupBox_setting.TabIndex = 0;
            this.groupBox_setting.TabStop = false;
            this.groupBox_setting.Text = "Setting";
            // 
            // label_trang_thai
            // 
            this.label_trang_thai.AutoSize = true;
            this.label_trang_thai.ForeColor = System.Drawing.Color.Red;
            this.label_trang_thai.Location = new System.Drawing.Point(126, 102);
            this.label_trang_thai.Name = "label_trang_thai";
            this.label_trang_thai.Size = new System.Drawing.Size(86, 19);
            this.label_trang_thai.TabIndex = 8;
            this.label_trang_thai.Text = "Chua ket noi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Trang Thai :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Baud Rate :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cong COM :";
            // 
            // comboBox_baud
            // 
            this.comboBox_baud.FormattingEnabled = true;
            this.comboBox_baud.Location = new System.Drawing.Point(130, 67);
            this.comboBox_baud.Name = "comboBox_baud";
            this.comboBox_baud.Size = new System.Drawing.Size(135, 27);
            this.comboBox_baud.TabIndex = 4;
            // 
            // comboBox_com
            // 
            this.comboBox_com.FormattingEnabled = true;
            this.comboBox_com.Location = new System.Drawing.Point(130, 25);
            this.comboBox_com.Name = "comboBox_com";
            this.comboBox_com.Size = new System.Drawing.Size(135, 27);
            this.comboBox_com.TabIndex = 3;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(15, 168);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(250, 4);
            this.progressBar1.TabIndex = 2;
            // 
            // btn_disconnect
            // 
            this.btn_disconnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_disconnect.Location = new System.Drawing.Point(152, 134);
            this.btn_disconnect.Name = "btn_disconnect";
            this.btn_disconnect.Size = new System.Drawing.Size(97, 28);
            this.btn_disconnect.TabIndex = 1;
            this.btn_disconnect.Text = "ngat ket noi";
            this.btn_disconnect.UseVisualStyleBackColor = false;
            this.btn_disconnect.Click += new System.EventHandler(this.btn_disconnect_Click);
            // 
            // btn_connect
            // 
            this.btn_connect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_connect.Location = new System.Drawing.Point(27, 134);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(100, 28);
            this.btn_connect.TabIndex = 0;
            this.btn_connect.Text = "Ket noi";
            this.btn_connect.UseVisualStyleBackColor = false;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // groupBox_time
            // 
            this.groupBox_time.Controls.Add(this.label_time);
            this.groupBox_time.Controls.Add(this.label_date);
            this.groupBox_time.Controls.Add(this.label5);
            this.groupBox_time.Controls.Add(this.label4);
            this.groupBox_time.Location = new System.Drawing.Point(12, 91);
            this.groupBox_time.Name = "groupBox_time";
            this.groupBox_time.Size = new System.Drawing.Size(280, 73);
            this.groupBox_time.TabIndex = 1;
            this.groupBox_time.TabStop = false;
            this.groupBox_time.Text = "Thoi gian";
            // 
            // label_time
            // 
            this.label_time.Location = new System.Drawing.Point(91, 51);
            this.label_time.Name = "label_time";
            this.label_time.Size = new System.Drawing.Size(148, 19);
            this.label_time.TabIndex = 3;
            this.label_time.Text = "08:36 PM";
            // 
            // label_date
            // 
            this.label_date.Location = new System.Drawing.Point(91, 22);
            this.label_date.Name = "label_date";
            this.label_date.Size = new System.Drawing.Size(174, 19);
            this.label_date.TabIndex = 2;
            this.label_date.Text = "06/01/2022";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 19);
            this.label5.TabIndex = 1;
            this.label5.Text = "time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "date";
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zedGraphControl1.Location = new System.Drawing.Point(298, 13);
            this.zedGraphControl1.Margin = new System.Windows.Forms.Padding(4);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(415, 358);
            this.zedGraphControl1.TabIndex = 2;
            this.zedGraphControl1.UseExtendedPrintDialog = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MistyRose;
            this.groupBox1.Controls.Add(this.pictureBox4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label_nhiet_do);
            this.groupBox1.Location = new System.Drawing.Point(172, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(161, 79);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhiet Do";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::dht11_winform.Properties.Resources.nhietdo;
            this.pictureBox4.Location = new System.Drawing.Point(6, 25);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(40, 36);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 20;
            this.pictureBox4.TabStop = false;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(116, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 32);
            this.label6.TabIndex = 2;
            this.label6.Text = "\'C";
            // 
            // label_nhiet_do
            // 
            this.label_nhiet_do.BackColor = System.Drawing.Color.Snow;
            this.label_nhiet_do.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nhiet_do.Location = new System.Drawing.Point(51, 29);
            this.label_nhiet_do.Name = "label_nhiet_do";
            this.label_nhiet_do.Size = new System.Drawing.Size(68, 32);
            this.label_nhiet_do.TabIndex = 1;
            this.label_nhiet_do.Text = "30.0";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.groupBox2.Controls.Add(this.pictureBox3);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label_do_am);
            this.groupBox2.Location = new System.Drawing.Point(172, 200);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(161, 79);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Do am";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::dht11_winform.Properties.Resources.doam;
            this.pictureBox3.Location = new System.Drawing.Point(6, 25);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(40, 37);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 19;
            this.pictureBox3.TabStop = false;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(121, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 32);
            this.label7.TabIndex = 2;
            this.label7.Text = "%";
            // 
            // label_do_am
            // 
            this.label_do_am.BackColor = System.Drawing.Color.Azure;
            this.label_do_am.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_do_am.Location = new System.Drawing.Point(56, 26);
            this.label_do_am.Name = "label_do_am";
            this.label_do_am.Size = new System.Drawing.Size(72, 32);
            this.label_do_am.TabIndex = 1;
            this.label_do_am.Text = "70.0";
            // 
            // groupBox_hien_thi
            // 
            this.groupBox_hien_thi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupBox_hien_thi.Controls.Add(this.label22);
            this.groupBox_hien_thi.Controls.Add(this.lb_80);
            this.groupBox_hien_thi.Controls.Add(this.lb_60);
            this.groupBox_hien_thi.Controls.Add(this.lb_40);
            this.groupBox_hien_thi.Controls.Add(this.lb_20);
            this.groupBox_hien_thi.Controls.Add(this.label_pro_ht_nhiet_do);
            this.groupBox_hien_thi.Controls.Add(this.label_muc_ghd);
            this.groupBox_hien_thi.Controls.Add(this.label_muc_ght);
            this.groupBox_hien_thi.Controls.Add(this.label13);
            this.groupBox_hien_thi.Controls.Add(this.label12);
            this.groupBox_hien_thi.Controls.Add(this.label11);
            this.groupBox_hien_thi.Controls.Add(this.label9);
            this.groupBox_hien_thi.Controls.Add(this.label8);
            this.groupBox_hien_thi.Controls.Add(this.label10);
            this.groupBox_hien_thi.Controls.Add(this.label_80);
            this.groupBox_hien_thi.Controls.Add(this.label_60);
            this.groupBox_hien_thi.Controls.Add(this.label_40);
            this.groupBox_hien_thi.Controls.Add(this.label_20);
            this.groupBox_hien_thi.Controls.Add(this.veticalProgressBar1);
            this.groupBox_hien_thi.Controls.Add(this.groupBox1);
            this.groupBox_hien_thi.Controls.Add(this.groupBox2);
            this.groupBox_hien_thi.Location = new System.Drawing.Point(720, 13);
            this.groupBox_hien_thi.Name = "groupBox_hien_thi";
            this.groupBox_hien_thi.Size = new System.Drawing.Size(338, 358);
            this.groupBox_hien_thi.TabIndex = 5;
            this.groupBox_hien_thi.TabStop = false;
            this.groupBox_hien_thi.Text = "Hien thi nhiet do";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(73, 57);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(15, 19);
            this.label22.TabIndex = 23;
            this.label22.Text = "-";
            // 
            // lb_80
            // 
            this.lb_80.AutoSize = true;
            this.lb_80.Location = new System.Drawing.Point(35, 86);
            this.lb_80.Name = "lb_80";
            this.lb_80.Size = new System.Drawing.Size(39, 19);
            this.lb_80.TabIndex = 22;
            this.lb_80.Text = "80\'C";
            // 
            // lb_60
            // 
            this.lb_60.AutoSize = true;
            this.lb_60.Location = new System.Drawing.Point(35, 144);
            this.lb_60.Name = "lb_60";
            this.lb_60.Size = new System.Drawing.Size(39, 19);
            this.lb_60.TabIndex = 21;
            this.lb_60.Text = "60\'C";
            // 
            // lb_40
            // 
            this.lb_40.AutoSize = true;
            this.lb_40.Location = new System.Drawing.Point(35, 204);
            this.lb_40.Name = "lb_40";
            this.lb_40.Size = new System.Drawing.Size(39, 19);
            this.lb_40.TabIndex = 20;
            this.lb_40.Text = "40\'C";
            // 
            // lb_20
            // 
            this.lb_20.AutoSize = true;
            this.lb_20.Location = new System.Drawing.Point(35, 260);
            this.lb_20.Name = "lb_20";
            this.lb_20.Size = new System.Drawing.Size(39, 19);
            this.lb_20.TabIndex = 19;
            this.lb_20.Text = "20\'C";
            // 
            // label_pro_ht_nhiet_do
            // 
            this.label_pro_ht_nhiet_do.BackColor = System.Drawing.Color.PaleGreen;
            this.label_pro_ht_nhiet_do.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_pro_ht_nhiet_do.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label_pro_ht_nhiet_do.Location = new System.Drawing.Point(103, 278);
            this.label_pro_ht_nhiet_do.Name = "label_pro_ht_nhiet_do";
            this.label_pro_ht_nhiet_do.Size = new System.Drawing.Size(54, 21);
            this.label_pro_ht_nhiet_do.TabIndex = 18;
            this.label_pro_ht_nhiet_do.Text = "20.0\'C";
            // 
            // label_muc_ghd
            // 
            this.label_muc_ghd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label_muc_ghd.Location = new System.Drawing.Point(10, 289);
            this.label_muc_ghd.Name = "label_muc_ghd";
            this.label_muc_ghd.Size = new System.Drawing.Size(64, 20);
            this.label_muc_ghd.TabIndex = 17;
            this.label_muc_ghd.Text = "MIN---";
            // 
            // label_muc_ght
            // 
            this.label_muc_ght.ForeColor = System.Drawing.Color.Red;
            this.label_muc_ght.Location = new System.Drawing.Point(6, 115);
            this.label_muc_ght.Name = "label_muc_ght";
            this.label_muc_ght.Size = new System.Drawing.Size(68, 20);
            this.label_muc_ght.TabIndex = 16;
            this.label_muc_ght.Text = "MAX---";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(73, 318);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(15, 19);
            this.label13.TabIndex = 15;
            this.label13.Text = "-";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(73, 289);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(15, 19);
            this.label12.TabIndex = 14;
            this.label12.Text = "-";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(73, 231);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(15, 19);
            this.label11.TabIndex = 13;
            this.label11.Text = "-";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(73, 173);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(15, 19);
            this.label9.TabIndex = 12;
            this.label9.Text = "-";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(73, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 19);
            this.label8.TabIndex = 11;
            this.label8.Text = "-";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(36, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 19);
            this.label10.TabIndex = 10;
            this.label10.Text = "100 \'C-";
            // 
            // label_80
            // 
            this.label_80.AutoSize = true;
            this.label_80.Location = new System.Drawing.Point(73, 86);
            this.label_80.Name = "label_80";
            this.label_80.Size = new System.Drawing.Size(15, 19);
            this.label_80.TabIndex = 9;
            this.label_80.Text = "-";
            // 
            // label_60
            // 
            this.label_60.AutoSize = true;
            this.label_60.Location = new System.Drawing.Point(73, 144);
            this.label_60.Name = "label_60";
            this.label_60.Size = new System.Drawing.Size(15, 19);
            this.label_60.TabIndex = 8;
            this.label_60.Text = "-";
            // 
            // label_40
            // 
            this.label_40.AutoSize = true;
            this.label_40.Location = new System.Drawing.Point(73, 202);
            this.label_40.Name = "label_40";
            this.label_40.Size = new System.Drawing.Size(15, 19);
            this.label_40.TabIndex = 7;
            this.label_40.Text = "-";
            // 
            // label_20
            // 
            this.label_20.AutoSize = true;
            this.label_20.Location = new System.Drawing.Point(73, 260);
            this.label_20.Name = "label_20";
            this.label_20.Size = new System.Drawing.Size(15, 19);
            this.label_20.TabIndex = 6;
            this.label_20.Text = "-";
            // 
            // veticalProgressBar1
            // 
            this.veticalProgressBar1.Location = new System.Drawing.Point(94, 38);
            this.veticalProgressBar1.Name = "veticalProgressBar1";
            this.veticalProgressBar1.Size = new System.Drawing.Size(72, 290);
            this.veticalProgressBar1.TabIndex = 5;
            this.veticalProgressBar1.Value = 40;
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox_control_may_lanh
            // 
            this.groupBox_control_may_lanh.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.groupBox_control_may_lanh.Controls.Add(this.pic_m_lanh_off);
            this.groupBox_control_may_lanh.Controls.Add(this.pic_may_lanh);
            this.groupBox_control_may_lanh.Controls.Add(this.bt_off_mlanh);
            this.groupBox_control_may_lanh.Controls.Add(this.bt_on_mlanh);
            this.groupBox_control_may_lanh.Location = new System.Drawing.Point(6, 25);
            this.groupBox_control_may_lanh.Name = "groupBox_control_may_lanh";
            this.groupBox_control_may_lanh.Size = new System.Drawing.Size(227, 101);
            this.groupBox_control_may_lanh.TabIndex = 3;
            this.groupBox_control_may_lanh.TabStop = false;
            this.groupBox_control_may_lanh.Text = "may lanh ";
            // 
            // pic_m_lanh_off
            // 
            this.pic_m_lanh_off.Image = global::dht11_winform.Properties.Resources.tulanhoff;
            this.pic_m_lanh_off.Location = new System.Drawing.Point(31, 25);
            this.pic_m_lanh_off.Name = "pic_m_lanh_off";
            this.pic_m_lanh_off.Size = new System.Drawing.Size(76, 70);
            this.pic_m_lanh_off.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_m_lanh_off.TabIndex = 3;
            this.pic_m_lanh_off.TabStop = false;
            // 
            // pic_may_lanh
            // 
            this.pic_may_lanh.Image = global::dht11_winform.Properties.Resources.tulanhon;
            this.pic_may_lanh.Location = new System.Drawing.Point(31, 25);
            this.pic_may_lanh.Name = "pic_may_lanh";
            this.pic_may_lanh.Size = new System.Drawing.Size(76, 70);
            this.pic_may_lanh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_may_lanh.TabIndex = 2;
            this.pic_may_lanh.TabStop = false;
            this.pic_may_lanh.Visible = false;
            // 
            // bt_off_mlanh
            // 
            this.bt_off_mlanh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.bt_off_mlanh.Location = new System.Drawing.Point(146, 63);
            this.bt_off_mlanh.Name = "bt_off_mlanh";
            this.bt_off_mlanh.Size = new System.Drawing.Size(75, 32);
            this.bt_off_mlanh.TabIndex = 1;
            this.bt_off_mlanh.Text = "OFF";
            this.bt_off_mlanh.UseVisualStyleBackColor = false;
            this.bt_off_mlanh.Click += new System.EventHandler(this.bt_off_mlanh_Click);
            // 
            // bt_on_mlanh
            // 
            this.bt_on_mlanh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bt_on_mlanh.Location = new System.Drawing.Point(146, 25);
            this.bt_on_mlanh.Name = "bt_on_mlanh";
            this.bt_on_mlanh.Size = new System.Drawing.Size(75, 32);
            this.bt_on_mlanh.TabIndex = 0;
            this.bt_on_mlanh.Text = "ON";
            this.bt_on_mlanh.UseVisualStyleBackColor = false;
            this.bt_on_mlanh.Click += new System.EventHandler(this.bt_on_mlanh_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox3.Controls.Add(this.groupBox_control_suoi);
            this.groupBox3.Controls.Add(this.groupBox_control_may_lanh);
            this.groupBox3.Location = new System.Drawing.Point(12, 376);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(239, 241);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "manual_quat";
            // 
            // groupBox_control_suoi
            // 
            this.groupBox_control_suoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.groupBox_control_suoi.Controls.Add(this.pic_m_suoi_off);
            this.groupBox_control_suoi.Controls.Add(this.pic_suoi);
            this.groupBox_control_suoi.Controls.Add(this.bt_off_suoi);
            this.groupBox_control_suoi.Controls.Add(this.bt_on_suoi);
            this.groupBox_control_suoi.Location = new System.Drawing.Point(6, 132);
            this.groupBox_control_suoi.Name = "groupBox_control_suoi";
            this.groupBox_control_suoi.Size = new System.Drawing.Size(227, 103);
            this.groupBox_control_suoi.TabIndex = 4;
            this.groupBox_control_suoi.TabStop = false;
            this.groupBox_control_suoi.Text = "lo suoi";
            // 
            // pic_m_suoi_off
            // 
            this.pic_m_suoi_off.Image = global::dht11_winform.Properties.Resources.hutmuioff;
            this.pic_m_suoi_off.Location = new System.Drawing.Point(31, 23);
            this.pic_m_suoi_off.Name = "pic_m_suoi_off";
            this.pic_m_suoi_off.Size = new System.Drawing.Size(76, 70);
            this.pic_m_suoi_off.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_m_suoi_off.TabIndex = 4;
            this.pic_m_suoi_off.TabStop = false;
            // 
            // pic_suoi
            // 
            this.pic_suoi.Image = global::dht11_winform.Properties.Resources.hutmuion;
            this.pic_suoi.Location = new System.Drawing.Point(31, 23);
            this.pic_suoi.Name = "pic_suoi";
            this.pic_suoi.Size = new System.Drawing.Size(76, 70);
            this.pic_suoi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_suoi.TabIndex = 3;
            this.pic_suoi.TabStop = false;
            this.pic_suoi.Visible = false;
            // 
            // bt_off_suoi
            // 
            this.bt_off_suoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.bt_off_suoi.Location = new System.Drawing.Point(146, 62);
            this.bt_off_suoi.Name = "bt_off_suoi";
            this.bt_off_suoi.Size = new System.Drawing.Size(75, 33);
            this.bt_off_suoi.TabIndex = 1;
            this.bt_off_suoi.Text = "OFF";
            this.bt_off_suoi.UseVisualStyleBackColor = false;
            this.bt_off_suoi.Click += new System.EventHandler(this.bt_off_suoi_Click);
            // 
            // bt_on_suoi
            // 
            this.bt_on_suoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bt_on_suoi.Location = new System.Drawing.Point(146, 25);
            this.bt_on_suoi.Name = "bt_on_suoi";
            this.bt_on_suoi.Size = new System.Drawing.Size(75, 31);
            this.bt_on_suoi.TabIndex = 0;
            this.bt_on_suoi.Text = "ON";
            this.bt_on_suoi.UseVisualStyleBackColor = false;
            this.bt_on_suoi.Click += new System.EventHandler(this.bt_on_suoi_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.Red;
            this.btn_exit.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_exit.Location = new System.Drawing.Point(142, 1);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(69, 47);
            this.btn_exit.TabIndex = 7;
            this.btn_exit.Text = "EXIT";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Enabled = true;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // timer4
            // 
            this.timer4.Enabled = true;
            this.timer4.Interval = 1000;
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(523, 378);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(371, 234);
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "thoi gian(s)";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "giá trị(temp-hum)";
            this.columnHeader2.Width = 130;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "lenh";
            this.columnHeader3.Width = 130;
            // 
            // groupBox_set_gh
            // 
            this.groupBox_set_gh.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.groupBox_set_gh.Controls.Add(this.bt_reset);
            this.groupBox_set_gh.Controls.Add(this.label19);
            this.groupBox_set_gh.Controls.Add(this.label18);
            this.groupBox_set_gh.Controls.Add(this.label17);
            this.groupBox_set_gh.Controls.Add(this.label_ghd);
            this.groupBox_set_gh.Controls.Add(this.label15);
            this.groupBox_set_gh.Controls.Add(this.label_ght);
            this.groupBox_set_gh.Controls.Add(this.text_ghd);
            this.groupBox_set_gh.Controls.Add(this.text_ght);
            this.groupBox_set_gh.Controls.Add(this.bt_set_ghd);
            this.groupBox_set_gh.Controls.Add(this.bt_set_ght);
            this.groupBox_set_gh.Location = new System.Drawing.Point(257, 376);
            this.groupBox_set_gh.Name = "groupBox_set_gh";
            this.groupBox_set_gh.Size = new System.Drawing.Size(260, 235);
            this.groupBox_set_gh.TabIndex = 9;
            this.groupBox_set_gh.TabStop = false;
            this.groupBox_set_gh.Text = "SET GH";
            // 
            // bt_reset
            // 
            this.bt_reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.bt_reset.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_reset.ForeColor = System.Drawing.Color.Navy;
            this.bt_reset.Location = new System.Drawing.Point(76, 180);
            this.bt_reset.Name = "bt_reset";
            this.bt_reset.Size = new System.Drawing.Size(93, 45);
            this.bt_reset.TabIndex = 10;
            this.bt_reset.Text = "RESET ";
            this.bt_reset.UseVisualStyleBackColor = false;
            this.bt_reset.Click += new System.EventHandler(this.bt_reset_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(6, 107);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(85, 19);
            this.label19.TabIndex = 9;
            this.label19.Text = "gioi han duoi";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 38);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(82, 19);
            this.label18.TabIndex = 8;
            this.label18.Text = "gioi han tren";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(201, 107);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(29, 22);
            this.label17.TabIndex = 7;
            this.label17.Text = "\'C";
            // 
            // label_ghd
            // 
            this.label_ghd.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ghd.Location = new System.Drawing.Point(142, 107);
            this.label_ghd.Name = "label_ghd";
            this.label_ghd.Size = new System.Drawing.Size(53, 22);
            this.label_ghd.TabIndex = 6;
            this.label_ghd.Text = "10.0";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(201, 38);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(29, 22);
            this.label15.TabIndex = 5;
            this.label15.Text = "\'C";
            // 
            // label_ght
            // 
            this.label_ght.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ght.Location = new System.Drawing.Point(135, 38);
            this.label_ght.Name = "label_ght";
            this.label_ght.Size = new System.Drawing.Size(53, 19);
            this.label_ght.TabIndex = 4;
            this.label_ght.Text = "45.0";
            // 
            // text_ghd
            // 
            this.text_ghd.Location = new System.Drawing.Point(139, 136);
            this.text_ghd.Name = "text_ghd";
            this.text_ghd.Size = new System.Drawing.Size(100, 26);
            this.text_ghd.TabIndex = 3;
            // 
            // text_ght
            // 
            this.text_ght.Location = new System.Drawing.Point(139, 67);
            this.text_ght.Name = "text_ght";
            this.text_ght.Size = new System.Drawing.Size(100, 26);
            this.text_ght.TabIndex = 2;
            // 
            // bt_set_ghd
            // 
            this.bt_set_ghd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bt_set_ghd.Location = new System.Drawing.Point(6, 132);
            this.bt_set_ghd.Name = "bt_set_ghd";
            this.bt_set_ghd.Size = new System.Drawing.Size(104, 32);
            this.bt_set_ghd.TabIndex = 1;
            this.bt_set_ghd.Text = "SET GHD";
            this.bt_set_ghd.UseVisualStyleBackColor = false;
            this.bt_set_ghd.Click += new System.EventHandler(this.bt_set_ghd_Click);
            // 
            // bt_set_ght
            // 
            this.bt_set_ght.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bt_set_ght.Location = new System.Drawing.Point(6, 63);
            this.bt_set_ght.Name = "bt_set_ght";
            this.bt_set_ght.Size = new System.Drawing.Size(104, 32);
            this.bt_set_ght.TabIndex = 0;
            this.bt_set_ght.Text = "SET GHT";
            this.bt_set_ght.UseVisualStyleBackColor = false;
            this.bt_set_ght.Click += new System.EventHandler(this.bt_set_ght_Click);
            // 
            // bt_excel
            // 
            this.bt_excel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.bt_excel.ForeColor = System.Drawing.Color.Black;
            this.bt_excel.Location = new System.Drawing.Point(74, 1);
            this.bt_excel.Name = "bt_excel";
            this.bt_excel.Size = new System.Drawing.Size(71, 47);
            this.bt_excel.TabIndex = 10;
            this.bt_excel.Text = "SAVE EXCEL";
            this.bt_excel.UseVisualStyleBackColor = false;
            this.bt_excel.Click += new System.EventHandler(this.bt_excel_Click);
            // 
            // bt_clean
            // 
            this.bt_clean.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bt_clean.ForeColor = System.Drawing.Color.Black;
            this.bt_clean.Location = new System.Drawing.Point(0, 1);
            this.bt_clean.Name = "bt_clean";
            this.bt_clean.Size = new System.Drawing.Size(74, 47);
            this.bt_clean.TabIndex = 11;
            this.bt_clean.Text = " clean \r\nzedgraph";
            this.bt_clean.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 618);
            this.Controls.Add(this.bt_clean);
            this.Controls.Add(this.bt_excel);
            this.Controls.Add(this.groupBox_set_gh);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox_hien_thi);
            this.Controls.Add(this.zedGraphControl1);
            this.Controls.Add(this.groupBox_time);
            this.Controls.Add(this.groupBox_setting);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox_setting.ResumeLayout(false);
            this.groupBox_setting.PerformLayout();
            this.groupBox_time.ResumeLayout(false);
            this.groupBox_time.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.groupBox_hien_thi.ResumeLayout(false);
            this.groupBox_hien_thi.PerformLayout();
            this.groupBox_control_may_lanh.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_m_lanh_off)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_may_lanh)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox_control_suoi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_m_suoi_off)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_suoi)).EndInit();
            this.groupBox_set_gh.ResumeLayout(false);
            this.groupBox_set_gh.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_setting;
        private System.Windows.Forms.Label label_trang_thai;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_baud;
        private System.Windows.Forms.ComboBox comboBox_com;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btn_disconnect;
        private System.Windows.Forms.Button btn_connect;
        protected internal System.Windows.Forms.GroupBox groupBox_time;
        private System.Windows.Forms.Label label_time;
        private System.Windows.Forms.Label label_date;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private ZedGraph.ZedGraphControl zedGraphControl1;
        protected internal System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label_nhiet_do;
        protected internal System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label_do_am;
        private System.Windows.Forms.GroupBox groupBox_hien_thi;
        private veticalProgressBar veticalProgressBar1;
        private System.Windows.Forms.Label label_pro_ht_nhiet_do;
        private System.Windows.Forms.Label label_muc_ghd;
        private System.Windows.Forms.Label label_muc_ght;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label_80;
        private System.Windows.Forms.Label label_60;
        private System.Windows.Forms.Label label_40;
        private System.Windows.Forms.Label label_20;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox_control_may_lanh;
        private System.Windows.Forms.PictureBox pic_may_lanh;
        private System.Windows.Forms.Button bt_off_mlanh;
        private System.Windows.Forms.Button bt_on_mlanh;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox_control_suoi;
        private System.Windows.Forms.PictureBox pic_suoi;
        private System.Windows.Forms.Button bt_off_suoi;
        private System.Windows.Forms.Button bt_on_suoi;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Timer timer5;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.GroupBox groupBox_set_gh;
        private System.Windows.Forms.Button bt_reset;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label_ghd;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label_ght;
        private System.Windows.Forms.TextBox text_ghd;
        private System.Windows.Forms.TextBox text_ght;
        private System.Windows.Forms.Button bt_set_ghd;
        private System.Windows.Forms.Button bt_set_ght;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label lb_80;
        private System.Windows.Forms.Label lb_60;
        private System.Windows.Forms.Label lb_40;
        private System.Windows.Forms.Label lb_20;
        private System.Windows.Forms.Button bt_excel;
        private System.Windows.Forms.Button bt_clean;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.PictureBox pic_m_lanh_off;
        private System.Windows.Forms.PictureBox pic_m_suoi_off;
    }
}

