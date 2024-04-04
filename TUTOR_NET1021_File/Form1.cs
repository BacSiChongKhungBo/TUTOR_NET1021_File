using System.Text;

namespace TUTOR_NET1021_File
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Một số lưu ý:
            // 1.
            // Path mặc định: E:\NET1021.txt
            // Path trong chương trình: E:\\NET1021.txt
            // => nếu trong path xuất hiện dấu \ => đổi thành \\
            // 2. 
            // Nếu không close File | reader | write => có thể lỗi do xung đột luồng
            // 3.
            // Khi đóng luồng , đóng Reader và Writer trước
            // dóng Filestream cuối cùng
        }

        private void btn_Doc_Click(object sender, EventArgs e)
        {
            //4 bước cho đọc file
            //B1: FileStream : yêu cầu khoảng 2 đầu vào
            // - Path : địa chỉ file
            // - FileMode: file sẽ có thể làm gì
            //C1:
            //FileStream fs = new FileStream(txt_Path.Text, FileMode.OpenOrCreate);
            //C2:
            string path = "E:\\NET1021.txt";
            FileMode mode = FileMode.OpenOrCreate;
            FileStream fs = new FileStream(path, mode);
            //B2: StreamReader: bộ đọc dữ liệu
            StreamReader sr = new StreamReader(fs); // lấy dữ liệu ra để đọc từ FileStream
            //B3: tiến hành đọc và gán kết quả
            string result = sr.ReadToEnd(); // đọc đến hết luồng file
            rtxt_NoiDung.Text = result;
            //B4: Tiến hành thông báo và đóng các luồng
            sr.Close();
            fs.Close();
            MessageBox.Show("Đọc file thành công");
        }

        private void btn_Ghi_Click(object sender, EventArgs e)
        {
            //File Stream
            FileStream fs = new FileStream(txt_Path.Text, FileMode.OpenOrCreate);
            //StreamWriter
            StreamWriter sw = new StreamWriter(fs, Encoding.Unicode);
            //dùng StreamWriter để ghi vào file
            sw.Write(rtxt_NoiDung.Text);
            //Đóng các Stream lại
            sw.Close();
            fs.Close();
            MessageBox.Show("Ghi File thành công");
        }

        private void btn_GhiSV_Click(object sender, EventArgs e)
        {
            //File Stream
            string path = "E:\\NET1021_SV.txt";
            //FileMode.Append: tạo hoặc tìm đến dòng cuối cùng của file
            FileStream fs = new FileStream(path, FileMode.Append);
            //StreamWriter
            StreamWriter sw = new StreamWriter(fs, Encoding.Unicode);
            string content = $"{txt_MaSV.Text} | {txt_HoTen.Text} | {txt_Tuoi.Text}\n";
            sw.Write(content);
            sw.Close();
            fs.Close();
            MessageBox.Show("Ghi File thành công");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = "E:\\NET1021_SV.txt";
            FileMode mode = FileMode.OpenOrCreate;
            FileStream fs = new FileStream(path, mode);
            StreamReader sr = new StreamReader(fs);
            string result = sr.ReadToEnd();
            sr.Close();
            fs.Close();
            MessageBox.Show("Đọc file thành công");
            string[] data = GetData(result);
            txt_MaSV.Text = data[0];
            txt_HoTen.Text = data[1];
            txt_Tuoi.Text = data[2];
        }

        //Tạo nút đọc File, điền ngược lại những gì đã lưu vào file vào textbox
        //gợi ý : sử dụng split

        public string[] GetData(string reader)
        {
            string[] arr = reader.Split(" | ");
            return arr;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string path = "E:\\quan.txt";
            FileMode mode = FileMode.OpenOrCreate;
            FileStream fs = new FileStream(path, mode);
            StreamReader sr = new StreamReader(fs);
            string result = sr.ReadToEnd();
            sr.Close();
            fs.Close();
            MessageBox.Show("Đọc file thành công");
            string[] data = GetQuan(result);
            foreach(var item in data)
            {
                comboBox1.Items.Add(item);
            }
            comboBox1.SelectedIndex = 0;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public string[] GetQuan(string reader)
        {
            string[] arr = reader.Split("\n");
            return arr;
        }
    }
}
