using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dht11_winform.Properties;

using System.IO;
using System.IO.Ports;
using System.Xml;
using ZedGraph; 

namespace dht11_winform
{
    public partial class Form1 : Form
    {
        double time_read;

        double read_temp;
        double read_humd;
        double ght = 45.0;
        double ghd = 10.0;

        string string_temp = "";
        string string_humd = "";

        string lenh = "";   // cai nay tao ra 1 chuoi string de hien thi lenh
        public Form1()
        {
            InitializeComponent();
            ModifyProgressBarColor.SetState(veticalProgressBar1, 1); // mau xanh

        }

        string[] list_baud = { "2400", "4800", "9600", "19200", "38400", "115200" };
        private void Form1_Load(object sender, EventArgs e)
        {
            string[] list_name_com = SerialPort.GetPortNames();
            comboBox_com.Items.AddRange(list_name_com);
            comboBox_baud.Items.AddRange(list_baud);

            GraphPane my_pane = zedGraphControl1.GraphPane;
            my_pane.Title.Text = "Biểu Đồ Mức Nước ";
            my_pane.YAxis.Title.Text = "Mức Nước (cm)";
            my_pane.XAxis.Title.Text = "thời gian (s)";

            RollingPointPairList list_1 = new RollingPointPairList(60000);
            RollingPointPairList list_2 = new RollingPointPairList(60000);
            RollingPointPairList list_3= new RollingPointPairList(6000);
            RollingPointPairList list_4 = new RollingPointPairList(6000);

            LineItem line_nhiet_do= my_pane.AddCurve("Nhiet do ", list_1, Color.Green, SymbolType.None);
            LineItem line_do_am = my_pane.AddCurve("Do am", list_2, Color.Blue, SymbolType.None);
            LineItem line_ght= my_pane.AddCurve("GHT", list_3, Color.Red, SymbolType.XCross);
            LineItem line_ghd = my_pane.AddCurve("GHD", list_4, Color.Yellow, SymbolType.XCross);

            my_pane.XAxis.Scale.Min = 0;
            my_pane.XAxis.Scale.Max = 40;
            my_pane.XAxis.Scale.MinorStep = 1;
            my_pane.XAxis.Scale.MajorStep = 5;

            my_pane.YAxis.Scale.Min = 0;
            my_pane.YAxis.Scale.Max = 100;
            my_pane.YAxis.Scale.MinorStep = 1;
            my_pane.YAxis.Scale.MajorStep = 3;

            zedGraphControl1.AxisChange();

            label_ght.Text = ght.ToString();
            label_ghd.Text = ghd.ToString();
        }

        // ham ve do thi zedgraph
        public void draw_zedgraph(double line1,double line2)
        {
            // duong nhiet do
            LineItem line_nhiet_do= zedGraphControl1.GraphPane.CurveList[0] as LineItem;
            if (line_nhiet_do == null)
            {
                return;
            }
            IPointListEdit list1 =line_nhiet_do.Points as IPointListEdit;
            if (list1 == null)
            {
                return;
            }
            list1.Add(time_read, line1);

            // duong do am
            LineItem line_do_am = zedGraphControl1.GraphPane.CurveList[1] as LineItem;
            if (line_do_am == null)
            {
                return;
            }
            IPointListEdit list2 = line_do_am.Points as IPointListEdit;
            if (list2 == null)
            {
                return;
            }
            list2.Add(time_read, line2);
            // duog gioi han tren 
            LineItem line_ght = zedGraphControl1.GraphPane.CurveList[2] as LineItem;
            IPointListEdit list_3 = line_ght.Points as IPointListEdit;
            if (list_3 == null) { return; }
            list_3.Add(time_read, ght);
            // duong gioi han duoi
            LineItem line_ghd = zedGraphControl1.GraphPane.CurveList[3] as LineItem;
            IPointListEdit list_4 = line_ghd.Points as IPointListEdit;
            if (list_4 == null) { return; }
            list_4.Add(time_read, ghd);

            // 1 cong thuc de nham tinh tooa khoan nhay sai so nha
            // tuk la thoi gian se k chay cho dden khi khoan thoi gian la 30s thi 
            // bieu do zedgraph se chay voi muc tuong thich nha
            Scale xscale = zedGraphControl1.GraphPane.XAxis.Scale;
            if (time_read > (xscale.Max - xscale.MajorStep))
            {
                xscale.Max = time_read + xscale.MajorStep;
                xscale.Min = xscale.Max - 30;
            }

            zedGraphControl1.AxisChange();
            zedGraphControl1.Invalidate();
            zedGraphControl1.Refresh();
        }

        // cac nut nhan dieu khien nha
        // nut nhan ket noi voi cong COM
        private void btn_connect_Click(object sender, EventArgs e)
        {
            if ((comboBox_com.Text == "") || (comboBox_baud.Text == ""))
            {
                MessageBox.Show("Vui Lòng Chọn Dữ Liệu Kết Nối", "Thông  Báo");
            }
            if (!serialPort1.IsOpen)
            {
                try
                {
                    serialPort1.PortName = comboBox_com.Text;
                    serialPort1.BaudRate = int.Parse(comboBox_baud.Text);
                    serialPort1.Open();
                    label_trang_thai.Text = "Đã Kết Nối";
                    label_trang_thai.ForeColor = Color.Green;
                    progressBar1.Value = 100;
                    btn_connect.Enabled = false;
                    btn_disconnect.Enabled = true;
                    lenh = "ket noi".ToString();
                }
                catch (Exception)
                {
                    MessageBox.Show("Lỗi !! \n Vui Lòng Kiểm Tra Kết Nối", "ERROR!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        // nut ngat ket noi voi cong serial monitor
        private void btn_disconnect_Click(object sender, EventArgs e)
        {
            if ((comboBox_com.Text == "") || (comboBox_baud.Text == ""))
            {
                MessageBox.Show("Vui Lòng Chọn Dữ Liệu Kết Nối", "Thông  Báo");
            }
            if (serialPort1.IsOpen)
            {
                try
                {
                    serialPort1.Close();
                    label_trang_thai.Text = "Đã Ngắt Kết Nối";
                    label_trang_thai.ForeColor = Color.Red;
                    progressBar1.Value = 0;
                    btn_connect.Enabled = true;
                    btn_disconnect.Enabled = false;
                    lenh = "ngat ket noi".ToString();
                }
                catch
                {
                }
            }
        }
        // nut exit co cau hoi de phan hoi
        private void btn_exit_Click(object sender, EventArgs e)
        {
            DialogResult tra_loi;
            tra_loi = MessageBox.Show("Ban Muốn Thoát Khỏi Chương Trình ??", "EXIT", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (tra_loi == DialogResult.OK)
            {
                Application.Exit();
            }
        }
        // nut luu file excel
        private void bt_excel_Click(object sender, EventArgs e)
        {
            DialogResult tra_loi;
            tra_loi = MessageBox.Show("Bạn Muốn Lưu Dữ Liệu Vào  Microsoft  EXCEL ", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (tra_loi == DialogResult.Yes)
            {
                save_excel();
            }
        }
        // nut nhan bat may lanh
        private void bt_on_mlanh_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                if (pic_m_lanh_off.Visible==true)
                {
                    serialPort1.Write("#SUOON" + "\n");
                    pic_may_lanh.Visible = true;
                    pic_m_lanh_off.Visible = false;
                    lenh ="bat m lanh";
                }
            }
            else
            {
                MessageBox.Show("Chưa Kết Nối Cổng COM", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // nut nhan tat may lanh (quat cg ok nha)
        private void bt_off_mlanh_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                if (pic_may_lanh.Visible==true)
                {
                    serialPort1.Write("#SUOOF" + "\n");
                    pic_may_lanh.Visible = false;
                    pic_m_lanh_off.Visible = true;
                    lenh = "tat m lanh";
                }
            }
            else
            {
                MessageBox.Show("Chưa Kết Nối Cổng COM", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // nut nhan on bat lo suoi
        private void bt_on_suoi_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                if (pic_m_suoi_off.Visible==true)
                {
                    serialPort1.Write("#TULON" + "\n");
                    pic_m_suoi_off.Visible = false;
                    pic_suoi.Visible = true;
                    lenh ="bat m suoi";
                }
            }
            else
            {
                MessageBox.Show("Chưa Kết Nối Cổng COM", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // nut tat lo suoi :(co the simulation vo bong den hoac voi quat nghiet)
        private void bt_off_suoi_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                if (pic_suoi.Visible==true)
                {
                    serialPort1.Write("#TULOF" + "\n");
                    pic_suoi.Visible = false;
                    pic_m_suoi_off.Visible = true;
                    lenh ="tat m suoi";
                }
            }
            else
            {
                MessageBox.Show("Chưa Kết Nối Cổng COM", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // nut nhan set muc gioi han tren cho gia tri coi bao dong va nhietj do nha may pro 
        private void bt_set_ght_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                try
                {
                    if ((double.Parse(text_ght.Text) <= 60.0) && (double.Parse(text_ght.Text) >= 8.00) && (double.Parse(text_ght.Text) >= ghd + 5) && (text_ght.Text.Length <= 4))
                    {
                        serialPort1.Write("#SE1" + text_ght.Text + "\n");
                        label_ght.Text = text_ght.Text;
                        ght = double.Parse(text_ght.Text);
                        lenh = "set ght=" + ght.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Lỗi !!! \n  Giá trị vượt quá phạm vi cho phép ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        text_ght.Text = "";
                    }
                }
                catch
                {
                    MessageBox.Show("Lỗi !!! \n Vui Lòng Nhập Giá Trị Thực ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    text_ght.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Chưa Kết Nối Cổng COM", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // nut set gioi han duoi : gui ve gioi han duoi set cho ESP-8266
        private void bt_set_ghd_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                try
                {
                    if ((double.Parse(text_ghd.Text) <= 60) && (double.Parse(text_ghd.Text) >= 8)&& ((double.Parse(text_ghd.Text) <=ght-5)) && (text_ghd.Text.Length <= 4))
                    {
                        ghd = double.Parse(text_ghd.Text);
                        serialPort1.Write("#SE2" + text_ghd.Text + "\n");
                        label_ghd.Text = text_ghd.Text;
                        lenh = "set ghd=" + ghd.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Lỗi !!! \n  Giá trị vượt quá phạm vi cho phép ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        text_ghd.Text = "";
                    }
                }
                catch
                {
                    MessageBox.Show("Lỗi !!! \n Vui Lòng Nhập Giá Trị Thực ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    text_ghd.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Chưa Kết Nối Cổng COM", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // nut reset gioi han tren va gioi han duoi ve lai voi muc set ban dau
        private void bt_reset_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Write("#RES" + "\n");
                text_ghd.Text = label_ghd.Text = 10.ToString();
                text_ght.Text = label_ght.Text = 45.ToString();
                ght= 45.0;
                ghd = 10.0;
                lenh = "reset gioi han";

                // hien thi tat ca cacmuc bi an
                label_80.Visible = true;
                label_60.Visible = true;
                label_40.Visible = true;
                label_20.Visible = true;
            }
            else
            {
                MessageBox.Show("Chưa Kết Nối Cổng COM", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                string[] arrList = serialPort1.ReadLine().Split('|'); // Đọc một dòng của Serial, cắt chuỗi khi gặp ký tự gạch đứng
                string_temp = arrList[0];
                string_humd = arrList[1];

                double.TryParse(string_temp,out read_temp);
                double.TryParse(string_humd, out read_humd);

            }
            catch
            {
                return;
            }
        }
        // ham luu file excel
        private void save_excel()
        {

            Microsoft.Office.Interop.Excel.Application so_lieu = new Microsoft.Office.Interop.Excel.Application();
            so_lieu.Visible = true;
            Microsoft.Office.Interop.Excel.Workbook wb = so_lieu.Workbooks.Add(Microsoft.Office.Interop.Excel.XlSheetType.xlWorksheet);

            Microsoft.Office.Interop.Excel.Worksheet ws = (Microsoft.Office.Interop.Excel.Worksheet)so_lieu.ActiveSheet;

            Microsoft.Office.Interop.Excel.Range rg = (Microsoft.Office.Interop.Excel.Range)ws.get_Range("A1","C1");

            ws.Cells[1, 1] = "Thời Gian (s)        ";
            ws.Cells[1, 2] = "nhiet do --- do am ";
            ws.Cells[1, 3] = "lenh dieu khien      ";
            rg.Columns.AutoFit();
            int i = 2;
            int j = 2;
            foreach (ListViewItem comp in listView1.Items)
            {
                ws.Cells[i, j] = comp.Text.ToString();
                foreach (ListViewItem.ListViewSubItem drv in comp.SubItems)
                {
                    ws.Cells[i, j] = drv.Text.ToString();
                    j++;
                }
                j = 1;
                i++;
            }
        }
        // cac lenh  ve history va luu 
        private void data_list_view()
        {
            if (serialPort1.IsOpen)
            {
                ListViewItem item = new ListViewItem(label_time.Text);
                string hien_thi = "    "+ read_temp.ToString() + "--" + read_humd.ToString();
                item.SubItems.Add(hien_thi);
                item.SubItems.Add(lenh);
                listView1.Items.Add(item);
                listView1.Items[listView1.Items.Count - 1].EnsureVisible();
               // listView1.Items[listView1.Items.Count - 2].EnsureVisible();
            }
        }
        private void clear_zedgraph()
        {
            zedGraphControl1.GraphPane.CurveList.Clear();
            zedGraphControl1.GraphPane.GraphObjList.Clear();

            zedGraphControl1.AxisChange();
            zedGraphControl1.Invalidate();

            GraphPane my_pane = zedGraphControl1.GraphPane;
            my_pane.Title.Text = "ĐỒ THỊ MỨC NƯỚC ";
            my_pane.XAxis.Title.Text = "Thời Gian (s)    ";
            my_pane.YAxis.Title.Text = "Mức Nước (cm)";

            RollingPointPairList list_1 = new RollingPointPairList(60000);
            RollingPointPairList list_2 = new RollingPointPairList(60000);
            RollingPointPairList list_3 = new RollingPointPairList(6000);
            RollingPointPairList list_4 = new RollingPointPairList(6000);

            LineItem line_nhiet_do = my_pane.AddCurve("Nhiet do ", list_1, Color.Green, SymbolType.None);
            LineItem line_do_am = my_pane.AddCurve("Do am", list_2, Color.Blue, SymbolType.None);
            LineItem line_ght = my_pane.AddCurve("GHT", list_3, Color.Red, SymbolType.XCross);
            LineItem line_ghd = my_pane.AddCurve("GHD", list_4, Color.Yellow, SymbolType.XCross);

            my_pane.XAxis.Scale.Min = 0;
            my_pane.XAxis.Scale.Max = 40;
            my_pane.XAxis.Scale.MinorStep = 1;
            my_pane.XAxis.Scale.MajorStep = 5;

            my_pane.YAxis.Scale.Min = 0;
            my_pane.YAxis.Scale.Max = 100;
            my_pane.YAxis.Scale.MinorStep = 1;
            my_pane.YAxis.Scale.MajorStep = 3;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Start();
            if (read_temp!= 0)
            {
                time_read++;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Start();
            label_date.Text = DateTime.Now.ToLongDateString();
            label_time.Text = DateTime.Now.ToLongTimeString();
            if (serialPort1.IsOpen)
            {
                if (read_temp != 0)
                {
                    draw_zedgraph(read_temp, read_humd);
                    data_list_view();
                    label_nhiet_do.Text = read_temp.ToString();
                    label_do_am.Text = read_humd.ToString();
                }
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            timer3.Start();
            if (read_temp != 0)
            {
                veticalProgressBar1.Value = (int)read_temp;

                if (read_temp >= ght)
                {
                    ModifyProgressBarColor.SetState(veticalProgressBar1, 2);
                }
                else if (read_temp <= ghd)
                {
                    ModifyProgressBarColor.SetState(veticalProgressBar1, 3);
                }
                else
                {
                    ModifyProgressBarColor.SetState(veticalProgressBar1, 1);
                }

                // hien thi tren progressbar
                label_pro_ht_nhiet_do.Text = read_temp.ToString();
                label_pro_ht_nhiet_do.Location = new Point(103, 328 - (int)(read_temp * 2.9 - 6));
                if (read_humd != 0)
                {
                    label_muc_ghd.Location = new Point(10, 316 - (int)(ghd * 2.9));
                    label_muc_ght.Location = new Point(10, 316 - (int)(ght * 2.9));
                    //                                       cai dat viec an hien cac muc de de dang quan sat
                    //                                                              doi voi gioi han tren
                    //       cai nay dua theo so do va tu duy cua cac ban de tinh toan va giai thuat sao cho phu hop nha
                    // co the tach rieng ra theo giai thuat nha %%% nhung o day minh ghep lai cho viec code de dang hon
                    if ((ght >= 75 && ght < 85) || (ghd > 75 && ghd <= 85))
                    {
                        lb_80.Visible = false;
                    }
                    if ((ght < 65 && ght >= 55) || (ghd <= 65 && ghd >= 55))
                    {
                        lb_60.Visible = false;
                    }
                    if ((ght < 45 && ght >= 35)|| (ghd <= 45 && ghd > 35))
                    {
                        lb_40.Visible = false;
                    }
                    else if((ght<25&&ght>=15)|| (ghd <= 25 && ght > 15))
                    {
                        lb_20.Visible = false;
                    }
                }
            }
        }

        // lenh ghi vao trong history
        private void timer4_Tick(object sender, EventArgs e)
        {
            timer4.Start();
            if(lenh!="")
            {
                lenh = "";
            }
        }
    }
}
