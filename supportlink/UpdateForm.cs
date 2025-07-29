using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace supportlink
{
    public partial class UpdateForm : Form
    {
        public UpdateForm()
        {
            InitializeComponent();
            this.Text = "Đang cập nhật";
            Label label = new Label();
            label.Text = "⏳ Đang cập nhật, vui lòng chờ...";
            label.AutoSize = true;
            label.Font = new Font("Segoe UI", 12);
            label.Dock = DockStyle.Fill;
            label.TextAlign = ContentAlignment.MiddleCenter;
            this.Controls.Add(label);

            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new Size(300, 100);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.ControlBox = false; // Ẩn nút đóng
        }

    }
}
