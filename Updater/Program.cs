using System;
using System.IO;
using System.Diagnostics;
using System.Threading;

class Program
{
    static void Main()
    {
        string updateSource = @"\\10.144.10.250\fastnet\SOFT\Supportlink\Update";
        string currentFolder = AppDomain.CurrentDomain.BaseDirectory;

        try
        {
            Console.WriteLine("Đang cập nhật ứng dụng...");

            // Copy toàn bộ file từ thư mục update
            CopyAllFiles(updateSource, currentFolder);

            Console.WriteLine("✅ Cập nhật thành công!");

            // Mở lại ứng dụng chính nếu cần
            string exePath = Path.Combine(currentFolder, "supportlink.exe");
            if (File.Exists(exePath))
            {
                Console.WriteLine("Đang mở lại ứng dụng...");
                Process.Start(new ProcessStartInfo
                {
                    FileName = exePath,
                    UseShellExecute = true
                });
            }

            Thread.Sleep(1000);
        }
        catch (Exception ex)
        {
            Console.WriteLine("❌ Lỗi cập nhật: " + ex.Message);
        }
    }

    static void CopyAllFiles(string sourceDir, string targetDir)
    {
        foreach (string file in Directory.GetFiles(sourceDir))
        {
            string fileName = Path.GetFileName(file);
            string destFile = Path.Combine(targetDir, fileName);
            File.Copy(file, destFile, true);
        }

        foreach (string dir in Directory.GetDirectories(sourceDir))
        {
            string dirName = Path.GetFileName(dir);
            string destDir = Path.Combine(targetDir, dirName);
            Directory.CreateDirectory(destDir);
            CopyAllFiles(dir, destDir);
        }
    }
}
