using System.Diagnostics;
using System.Net;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using WshRuntime = IWshRuntimeLibrary;

namespace supportlink
{
    public partial class SupportLink : Form
    {
        public SupportLink()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CreateDesktopShortcut();
            UpdateTokenLabel();
            SelectBranchFromIniFile();
            comboBox1.DataSource = new BindingSource(linkDictionary, null);
            comboBox1.DisplayMember = "Key";   // Tên hiển thị
            comboBox1.ValueMember = "Value";   // Giá trị URL

        }

        [DllImport("mpr.dll")]
        private static extern int WNetAddConnection2(ref NETRESOURCE netResource, string password, string username, int flags);

        [DllImport("mpr.dll")]
        private static extern int WNetCancelConnection2(string name, int flags, bool force);

        [StructLayout(LayoutKind.Sequential)]
        public struct NETRESOURCE
        {
            public int dwScope;
            public int dwType;
            public int dwDisplayType;
            public int dwUsage;
            public string lpLocalName;
            public string lpRemoteName;
            public string lpComment;
            public string lpProvider;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string filePath = @"C:\Windows\IPCAS2.ini";

            if (!File.Exists(filePath))
            {
                MessageBox.Show("Không tìm thấy file IPCAS2.ini!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string[] lines = File.ReadAllLines(filePath);
            bool found = false;
            string oldToken = "";
            string newToken = "";

            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i].StartsWith("ACTIVE=TOKEN"))
                {
                    found = true;
                    oldToken = lines[i].Substring("ACTIVE=".Length);

                    // Xử lý chuyển đổi TOKEN
                    switch (oldToken)
                    {
                        case "TOKEN2":
                            newToken = "TOKEN6";
                            break;
                        case "TOKEN6":
                            newToken = "TOKEN7";
                            break;
                        case "TOKEN7":
                            newToken = "TOKEN2";
                            break;
                        default:
                            MessageBox.Show("Token hiện tại không hợp lệ: " + oldToken);
                            return;
                    }

                    lines[i] = "ACTIVE=" + newToken;
                    break;
                }
            }

            if (!found)
            {
                MessageBox.Show("Không tìm thấy dòng ACTIVE trong file.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Ghi lại file
            File.WriteAllLines(filePath, lines);

            // Thông báo
            MessageBox.Show($"Đã chuyển đổi thành công từ {oldToken} sang {newToken}!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //lbl_tt_token_Click(lbl_tt_token, EventArgs.Empty);
            UpdateTokenLabel();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem is KeyValuePair<string, string> selectedItem)
            {
                string url = selectedItem.Value;

                try
                {
                    System.Diagnostics.Process.Start(new ProcessStartInfo
                    {
                        FileName = url,
                        UseShellExecute = true
                    });
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể mở link: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Khai báo Dictionary lưu tên và URL
        private Dictionary<string, string> linkDictionary = new Dictionary<string, string>()
    {
        { "Hệ thống thanh toán tập trung", "https://payment.agribank.com.vn/login" },
        { "Hệ thống thanh toán quốc tế - SWIFT", "https://swifthub.agribank.com.vn/" },
        { "Quản lý xác thực và làm sạch thông tin khách hàng", "https://qlxt.agribank.com.vn/" },
        { "ARS - Kiều hối", "https://ars.agribank.com.vn/" },
        { "Hệ thống thanh toán song phương kho bạc", "https://spkb.agribank.com.vn/" },
        { "Hệ thống thanh toán bảo hiểm xã hội", "https://ttbhxh.agribank.com.vn/" },
        { "Hệ thống thanh toán hoá đợn - Bill Payment", "https://billpayment.agribank.com.vn/" }
    };

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string localIP = "";

                // Lấy danh sách các địa chỉ IP của máy tính
                var host = Dns.GetHostEntry(Dns.GetHostName());
                foreach (var ip in host.AddressList)
                {
                    // Lọc chỉ lấy IPv4
                    if (ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                    {
                        localIP = ip.ToString();
                        break;
                    }
                }

                if (!string.IsNullOrEmpty(localIP))
                {
                    MessageBox.Show("Địa chỉ IP máy của bạn là: " + localIP, "Thông tin IP", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy địa chỉ IP!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy IP: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateTokenLabel()
        {
            try
            {
                string iniPath = @"C:\Windows\IPCAS2.ini";

                if (!File.Exists(iniPath))
                {
                    lbl_tt_token.Text = "Không tìm thấy file IPCAS2.ini";
                    return;
                }

                string[] lines = File.ReadAllLines(iniPath);

                foreach (string line in lines)
                {
                    if (line.StartsWith("ACTIVE=", StringComparison.OrdinalIgnoreCase))
                    {
                        string tokenValue = line.Substring("ACTIVE=".Length).Trim();
                        lbl_tt_token.Text = tokenValue;
                        return;
                    }
                }

                lbl_tt_token.Text = "Không tìm thấy ACTIVE=";
            }
            catch (Exception ex)
            {
                lbl_tt_token.Text = "Lỗi: " + ex.Message;
            }
        }
        private void SelectBranchFromIniFile()
        {
            string filePath = @"C:\Windows\IPCAS2.ini";

            if (!File.Exists(filePath))
            {
                MessageBox.Show("Không tìm thấy file IPCAS2.ini", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string currentCode = File.ReadLines(filePath)
                                         .FirstOrDefault(line => line.StartsWith("sys_brcd="))
                                         ?.Substring("sys_brcd=".Length)
                                         .Trim();

                if (string.IsNullOrEmpty(currentCode))
                {
                    MessageBox.Show("Không tìm thấy mã chi nhánh trong file IPCAS2.ini");
                    return;
                }

                // Duyệt qua tất cả item trong comboBox3
                for (int i = 0; i < comboBox3.Items.Count; i++)
                {
                    string itemText = comboBox3.Items[i].ToString();

                    if (itemText.StartsWith(currentCode + " "))
                    {
                        comboBox3.SelectedIndex = i;
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đọc IPCAS2.ini: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string filePath = @"C:\Windows\IPCAS2.ini";
            string key = comboBox3.Text.Substring(0, 4);

            if (!File.Exists(filePath))
            {
                MessageBox.Show("File IPCAS2.ini không tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string[] lines = File.ReadAllLines(filePath);
                bool found = false;

                for (int i = 0; i < lines.Length; i++)
                {
                    if (lines[i].StartsWith("sys_brcd="))
                    {
                        lines[i] = $"sys_brcd={key}";
                        found = true;
                        break;
                    }
                }

                if (!found)
                {
                    // Nếu không có dòng sys_brcd, thêm mới vào cuối
                    Array.Resize(ref lines, lines.Length + 1);
                    lines[lines.Length - 1] = $"sys_brcd={key}";
                }

                // Ghi lại file (cần quyền admin để ghi vào C:\Windows)
                File.WriteAllLines(filePath, lines);

                MessageBox.Show("Cập nhật chi nhánh thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("Không có quyền ghi vào file. Vui lòng chạy chương trình bằng quyền Administrator.", "Lỗi quyền", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //private void button6_Click(object sender, EventArgs e)
        //{
        //    string networkPath = @"\\10.144.10.250\fastnet";
        //    string username = @"administrator";
        //    string password = @"Agribank@la";

        //    // Đường dẫn nguồn và đích
        //    string sourceFolder = @"\\10.144.10.250\fastnet\@@@@PHIENBAN IPCAS\AUTOUPDATE\IPCAS2\Bin";
        //    string destinationFolder = @"C:\IPCAS2\Bin";

        //    NETRESOURCE nr = new NETRESOURCE
        //    {
        //        dwType = 1, // Disk resource
        //        lpLocalName = null, // Không map ổ đĩa cụ thể
        //        lpRemoteName = networkPath,
        //        lpProvider = null
        //    };

        //    try
        //    {
        //        // Kết nối network share với tài khoản chỉ định
        //        int result = WNetAddConnection2(ref nr, password, username, 0);
        //        if (result != 0)
        //        {
        //            MessageBox.Show("Không thể kết nối tới share mạng, mã lỗi: " + result, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            return;
        //        }

        //        // Bắt đầu copy như bạn đang làm
        //        if (!Directory.Exists(sourceFolder))
        //        {
        //            MessageBox.Show("Không tìm thấy thư mục nguồn @@@@PHIENBAN IPCAS!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            WNetCancelConnection2(networkPath, 0, true);
        //            return;
        //        }

        //        if (Directory.Exists(destinationFolder))
        //        {
        //            Directory.Delete(destinationFolder, true);
        //        }

        //        Directory.CreateDirectory(destinationFolder);

        //        CopyAllFiles(sourceFolder, destinationFolder);

        //        MessageBox.Show("Đã sao chép và thay thế IPCAS thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

        //        // Ngắt kết nối sau khi xong
        //        WNetCancelConnection2(networkPath, 0, true);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Lỗi khi sao chép IPCAS: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        WNetCancelConnection2(networkPath, 0, true);
        //    }
        //}

        private async void button6_Click(object sender, EventArgs e)
        {
            string networkPath = @"\\10.144.10.250\fastnet";
            string username = @"administrator";
            string password = @"Agribank@la";

            string sourceFolder = @"\\10.144.10.250\fastnet\@@@@PHIENBAN IPCAS\AUTOUPDATE\IPCAS2\Bin";
            string destinationFolder = @"C:\IPCAS2\Bin";

            NETRESOURCE nr = new NETRESOURCE
            {
                dwType = 1,
                lpLocalName = null,
                lpRemoteName = networkPath,
                lpProvider = null
            };

            // Tạo form loading (giả sử bạn đã có form này)
            FormLoading loadingForm = new FormLoading();
            // Tính vị trí để đặt ở giữa form cha
            loadingForm.StartPosition = FormStartPosition.Manual;
            loadingForm.Location = new Point(
                this.Location.X + (this.Width - loadingForm.Width) / 2,
                this.Location.Y + (this.Height - loadingForm.Height) / 2);

            try
            {
                // Hiển thị form loading không modal (show)
                loadingForm.Show();

                // Chạy việc kết nối và copy trên luồng khác, tránh UI bị đơ
                await Task.Run(() =>
                {
                    int result = WNetAddConnection2(ref nr, password, username, 0);
                    if (result != 0)
                        throw new Exception("Không thể kết nối tới share mạng, mã lỗi: " + result);

                    if (!Directory.Exists(sourceFolder))
                        throw new Exception("Không tìm thấy thư mục nguồn @@@@PHIENBAN IPCAS!");

                    if (Directory.Exists(destinationFolder))
                        Directory.Delete(destinationFolder, true);

                    Directory.CreateDirectory(destinationFolder);

                    CopyAllFiles(sourceFolder, destinationFolder);

                    WNetCancelConnection2(networkPath, 0, true);
                });

                loadingForm.Close();

                MessageBox.Show("Đã sao chép và thay thế IPCAS thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                loadingForm.Close();
                MessageBox.Show("Lỗi khi sao chép IPCAS: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                try
                {
                    WNetCancelConnection2(networkPath, 0, true);
                }
                catch { }
            }
        }

        private void CopyAllFiles(string sourceDir, string targetDir)
        {
            // Copy tất cả file trong thư mục hiện tại
            foreach (string file in Directory.GetFiles(sourceDir))
            {
                string fileName = Path.GetFileName(file);
                string destFile = Path.Combine(targetDir, fileName);
                File.Copy(file, destFile, true); // true = overwrite
            }

            // Đệ quy copy thư mục con
            foreach (string directory in Directory.GetDirectories(sourceDir))
            {
                string dirName = Path.GetFileName(directory);
                string destSubDir = Path.Combine(targetDir, dirName);
                Directory.CreateDirectory(destSubDir);
                CopyAllFiles(directory, destSubDir); // recursive
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string exePath = @"C:\IPCAS2\Bin\ipcas2.exe";

            try
            {
                if (!File.Exists(exePath))
                {
                    MessageBox.Show("Không tìm thấy file ipcas2.exe!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Process.Start(new ProcessStartInfo
                {
                    FileName = exePath,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi mở file: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //private void button7_Click(object sender, EventArgs e)
        //{

        //    try
        //    {
        //        // Thông tin đường dẫn
        //        string updateSource = @"\\10.144.10.250\fastnet\SOFT\Supportlink\Update\supportlink.exe";
        //        string currentDir = Application.StartupPath;
        //        string currentExe = Path.Combine(currentDir, "supportlink.exe");
        //        string updaterExe = Path.Combine(currentDir, "Updater.exe");
        //        string tempNewExe = Path.Combine(currentDir, "supportlink_new.exe");

        //        // Copy file mới về thành supportlink_new.exe
        //        File.Copy(updateSource, tempNewExe, true);

        //        // Tạo nội dung file Updater.exe nếu chưa có
        //        if (!File.Exists(updaterExe))
        //        {
        //            MessageBox.Show("Không tìm thấy file Updater.exe trong thư mục!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            return;
        //        }

        //        // Khởi chạy Updater.exe với tham số
        //        Process.Start(new ProcessStartInfo
        //        {
        //            FileName = updaterExe,
        //            Arguments = $"\"{currentExe}\" \"{tempNewExe}\"",
        //            UseShellExecute = true
        //        });

        //        // Thoát app hiện tại
        //        Application.Exit();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Lỗi cập nhật: " + ex.Message);
        //    }
        //}
        private async void button7_Click(object sender, EventArgs e)
        {
            // Hiển thị form đang cập nhật
            UpdateForm updateForm = new UpdateForm();
            updateForm.Show();
            updateForm.Refresh(); // Đảm bảo form vẽ xong

            await Task.Delay(500); // Đợi chút để hiển thị form rõ hơn

            try
            {
                // Thông tin đường dẫn
                string updateSource = @"\\10.144.10.250\fastnet\SOFT\Supportlink\Update\supportlink.exe";
                string currentDir = Application.StartupPath;
                string currentExe = Path.Combine(currentDir, "supportlink.exe");
                string updaterExe = Path.Combine(currentDir, "Updater.exe");
                string tempNewExe = Path.Combine(currentDir, "supportlink_new.exe");

                // Copy file mới về
                File.Copy(updateSource, tempNewExe, true);

                if (!File.Exists(updaterExe))
                {
                    updateForm.Close();
                    MessageBox.Show("Không tìm thấy file Updater.exe trong thư mục!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Gọi updater
                Process.Start(new ProcessStartInfo
                {
                    FileName = updaterExe,
                    Arguments = $"\"{currentExe}\" \"{tempNewExe}\"",
                    UseShellExecute = true
                });

                updateForm.Close();
                // Thoát app hiện tại
                Application.Exit();
            }
            catch (Exception ex)
            {
                updateForm.Close();
                MessageBox.Show("Lỗi cập nhật: " + ex.Message);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ScheduleForm scheduleForm = new ScheduleForm();
            scheduleForm.Show(); // hoặc dùng ShowDialog() nếu bạn muốn form này là modal
        }

        private void CreateDesktopShortcut()
        {
            string shortcutName = "SupportLink.lnk";
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string shortcutPath = Path.Combine(desktopPath, shortcutName);
            string exePath = Application.ExecutablePath;

            if (!System.IO.File.Exists(shortcutPath))
            {
                var shell = new IWshRuntimeLibrary.WshShell();
                var shortcut = (IWshRuntimeLibrary.IWshShortcut)shell.CreateShortcut(shortcutPath);

                shortcut.Description = "Shortcut for SupportLink";
                shortcut.TargetPath = exePath;
                shortcut.WorkingDirectory = Path.GetDirectoryName(exePath);
                shortcut.IconLocation = exePath; // <--- Gán icon từ chính file .exe
                shortcut.Save();
            }
        }

    }
}