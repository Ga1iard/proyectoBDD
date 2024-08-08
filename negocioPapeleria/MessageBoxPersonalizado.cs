using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace negocioPapeleria
{
    internal class MessageBoxPersonalizado : Form
    {

        public DialogResult Show(string text, string caption, MessageBoxButtons buttons)
        {
            this.Text = caption;
            this.ShowIcon = false;

            Label label = new Label();
            label.Text = text;
            label.AutoSize = true;
            label.Font = new System.Drawing.Font("Cambria", 10); 
            label.Anchor = AnchorStyles.Left | AnchorStyles.Right;

            Button btnExcel = new Button();
            btnExcel.Text = "Excel";
            btnExcel.Click += (sender, e) => { this.DialogResult = DialogResult.Yes; };
            btnExcel.Font = new System.Drawing.Font("Cambria", 10);

            Button btnPDF = new Button();
            btnPDF.Text = "PDF";
            btnPDF.Click += (sender, e) => { this.DialogResult = DialogResult.No; };
            btnPDF.Font = new System.Drawing.Font("Cambria", 10);

            TableLayoutPanel tableLayoutPanel = new TableLayoutPanel();
            tableLayoutPanel.Dock = DockStyle.Fill;
            tableLayoutPanel.AutoSize = true;
            tableLayoutPanel.RowCount = 2;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            tableLayoutPanel.Controls.Add(label, 0, 0);
            tableLayoutPanel.Controls.Add(btnPDF, 0, 1);
            tableLayoutPanel.Controls.Add(btnExcel, 1, 1);

            this.Controls.Add(tableLayoutPanel);

            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.StartPosition = FormStartPosition.CenterParent;

            return base.ShowDialog();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // MessageBoxPersonalizado
            // 
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Name = "MessageBoxPersonalizado";
            this.ResumeLayout(false);

        }
    }
}
