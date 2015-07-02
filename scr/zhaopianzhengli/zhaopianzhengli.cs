using MediaInfoNET;
using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace zhaopianzhengli
{
    public partial class zhaopianzhengli : Form
    {
        int cnt_photo = 0;
        int cnt_video = 0;

        public zhaopianzhengli()
        {
            InitializeComponent();
        }

        private void btn_qian_Click(object sender, EventArgs e)
        {
            this.fbd_qian.ShowDialog();
            this.txt_qian.Text = this.fbd_qian.SelectedPath;
        }

        private void btn_hou_Click(object sender, EventArgs e)
        {
            this.fbd_hou.ShowDialog();
            this.txt_hou.Text = this.fbd_hou.SelectedPath;
            string dir_qita = System.IO.Path.Combine(this.txt_hou.Text, "qita");
            if (System.IO.Directory.Exists(dir_qita) == false)
            {
                System.IO.Directory.CreateDirectory(dir_qita);
            }
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            bgw.RunWorkerAsync();
            this.btn_quxiao.Enabled = true;
            this.btn_start.Enabled = false;
        }

        private void check_dir(string path, string out_path)
        {
            string[] dirs = System.IO.Directory.GetDirectories(path);

            foreach (string dir in dirs)
            {
                DirectoryInfo di = new DirectoryInfo(dir);

                Boolean bl = true;
                if ((di.Attributes & FileAttributes.System) == FileAttributes.System)
                {
                    bl = false;
                }
                if ((di.Attributes & FileAttributes.Hidden) == FileAttributes.Hidden)
                {
                    bl = false;
                }

                if (bl)
                {
                    Console.WriteLine(dir);
                    check_dir(dir, out_path);
                    check_file(dir, out_path);
                }

            }
            
            check_file(path, out_path);

            System.IO.File.CreateText(System.IO.Path.Combine(path, DateTime.Now.ToString("yyyyMMddHHmmss") + "_copied.txt"));
        }

        private bool is_copy = false;
        private string file_name_hou = "";
        private string file_name_qian = "";

        private void check_file(string path, string out_path)
        {
            try
            {
                System.Drawing.Bitmap bmp = null;
                string val = "";
                DateTime dt = new DateTime();
                string file_name = "";
                string dir_qita = System.IO.Path.Combine(out_path, "qita");
                string file_name_qita = "";
                string ext = "";
                bool hasDate = false;
                string[] files = System.IO.Directory.GetFiles(path);
                string year = "";
                string month = "";
                string out_path_year = "";
                string out_path_month = "";

                foreach (string file in files)
                {
                    this.file_name_qian = file;
                    bgw.ReportProgress(100);

                    FileInfo fi = new FileInfo(file);
                    Boolean bl = true;
                    if ((fi.Attributes & FileAttributes.System) == FileAttributes.System)
                    {
                        bl = false;
                    }
                    if ((fi.Attributes & FileAttributes.Hidden) == FileAttributes.Hidden)
                    {
                        bl = false;
                    }
                    if(bl == false){
                        continue;
                    }
                    Console.WriteLine(file);
                    ext = System.IO.Path.GetExtension(file);
                    if (ext.ToLower() == ".jpg")
                    {
                        //読み込む
                        bmp = new System.Drawing.Bitmap(file);
                        foreach (System.Drawing.Imaging.PropertyItem item in bmp.PropertyItems)
                        {

                            //Exif情報から撮影時間を取得する
                            if (item.Id == 0x9003 && item.Type == 2)
                            {
                                //文字列に変換する
                                val = System.Text.Encoding.ASCII.GetString(item.Value);
                                val = val.Trim(new char[] { '\0' });

                                try
                                {
                                    dt = DateTime.ParseExact(val, "yyyy:MM:dd HH:mm:ss", null);
                                    
                                    year = dt.Year.ToString();
                                    out_path_year = System.IO.Path.Combine(out_path, year);
                                    
                                    if (System.IO.Directory.Exists(out_path_year) == false)
                                    {
                                        System.IO.Directory.CreateDirectory(out_path_year);
                                    }

                                    month = dt.Month.ToString();
                                    out_path_month = System.IO.Path.Combine(out_path_year, month);

                                    if (System.IO.Directory.Exists(out_path_month) == false)
                                    {
                                        System.IO.Directory.CreateDirectory(out_path_month);
                                    }

                                    file_name = dt.ToString("yyyy_MM_dd_HH_mm_ss");
                                    file_name = System.IO.Path.Combine(out_path_month, file_name + ext);
                                    Console.WriteLine(file_name);
                                    if (System.IO.File.Exists(file_name) == false)
                                    {
                                        System.IO.File.Copy(file, file_name);
                                        cnt_photo = cnt_photo + 1;
                                        this.file_name_qian = file;
                                        this.file_name_hou = file_name;
                                        this.is_copy = true;
                                        bgw.ReportProgress(100);
                                    }
                                }
                                catch (Exception)
                                {

                                }

                                hasDate = true;
                                break;
                            }
                        }

                        if (hasDate == false)
                        {
                            file_name_qita = System.IO.Path.GetFileName(file);
                            file_name_qita = System.IO.Path.Combine(dir_qita, file_name_qita);
                            if (System.IO.File.Exists(file_name_qita) == false)
                            {
                                System.IO.File.Copy(file, file_name_qita);
                                cnt_photo = cnt_photo + 1;
                                this.file_name_qian = file;
                                this.file_name_hou = file_name_qita;
                                this.is_copy = true;
                                bgw.ReportProgress(100);
                            }
                        }

                        bmp.Dispose();
                    }

                    if (ext.ToLower() == ".mp4" || ext.ToLower() == ".mov" || ext.ToLower() == ".3gp" || ext.ToLower() == ".wmv")
                    {
                        MediaFile mf = new MediaFile(file);
                        foreach (MediaInfo_Stream ms in mf.AllStreams)
                        {
                            if (ms.Properties.ContainsKey("Encoded date"))
                            {
                                try
                                {
                                    String strDt = ms.Properties["Encoded date"];
                                    strDt = strDt.Replace("UTC ", "");
                                    dt = Convert.ToDateTime(strDt);

                                    year = dt.Year.ToString();
                                    out_path_year = System.IO.Path.Combine(out_path, year);

                                    if (System.IO.Directory.Exists(out_path_year) == false)
                                    {
                                        System.IO.Directory.CreateDirectory(out_path_year);
                                    }

                                    month = dt.Month.ToString();
                                    out_path_month = System.IO.Path.Combine(out_path_year, month);

                                    if (System.IO.Directory.Exists(out_path_month) == false)
                                    {
                                        System.IO.Directory.CreateDirectory(out_path_month);
                                    }

                                    file_name = dt.ToString("yyyy_MM_dd_HH_mm_ss");
                                    file_name = System.IO.Path.Combine(out_path_month, file_name + ext);
                                    Console.WriteLine(file_name);
                                    if (System.IO.File.Exists(file_name) == false)
                                    {
                                        System.IO.File.Copy(file, file_name);
                                        cnt_video = cnt_video + 1;
                                        this.file_name_qian = file;
                                        this.file_name_hou = file_name;
                                        this.is_copy = true;
                                        bgw.ReportProgress(100);
                                    }
                                }
                                catch (Exception)
                                {
                                }
                                
                            }
                            if (ms.Properties.ContainsKey("Tagged date"))
                            {

                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                this.file_name_qian = "Error: " + ex.Message;
                bgw.ReportProgress(100);
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void zhaopianzhengli_Load(object sender, EventArgs e)
        {

        }

        private void bgw_DoWork(object sender, DoWorkEventArgs e)
        {
            this.check_dir(this.txt_qian.Text, this.txt_hou.Text);
        }

        private void bgw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.lbl_log.Text = "正在确认中文件： " + file_name_qian;

            if(this.is_copy == true){
                lbl.Text = "正在忙碌中... " + "已处理：" + cnt_photo.ToString() + "个照片。" + cnt_video.ToString() + "个视频。";
                rtb.AppendText(file_name_qian);
                rtb.AppendText("\r\n");
                rtb.AppendText(file_name_hou);
                rtb.AppendText("\r\n");
            }
            this.is_copy = false;
            this.Refresh();
        }

        private void bgw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            lbl.Text = "已完成 ^-^ " + "全部处理：" + cnt_photo.ToString() + "个照片。" + cnt_video.ToString() + "个视频。";
            MessageBox.Show("完成！");
            this.btn_quxiao.Enabled = false;
            this.btn_start.Enabled = true;
        }

        private void btn_quxiao_Click(object sender, EventArgs e)
        {
            if (bgw.WorkerSupportsCancellation == true)
            {
                bgw.CancelAsync();
            }
            lbl.Text = "中途取消 -_- " + "全部处理：" + cnt_photo.ToString() + "个照片。" + cnt_video.ToString() + "个视频。";
            this.btn_quxiao.Enabled = false;
            this.btn_start.Enabled = true;
        }
    }
}
