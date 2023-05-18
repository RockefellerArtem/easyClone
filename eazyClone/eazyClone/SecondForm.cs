using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eazyClone
{

    public partial class SecondForm : Form
    {
        public SecondForm(string nameTest, string startCountQustion, string endCountQustion)
        {
            InitializeComponent(nameTest);

            Label label = new Label();
            label.Font = new Font("Arial", 136, FontStyle.Bold);
            label.Text = "4";
            label.AutoSize = true;
            label.Location = new Point(380, 50);
            this.Controls.Add(label);

            Label label1 = new Label();
            label1.Font = new Font("Times New Roman", 12, FontStyle.Bold);
            label1.Text = $"{startCountQustion} правильных ответов из {endCountQustion}";
            label1.AutoSize = true;
            label1.Location = new Point(357, 260);
            this.Controls.Add(label1);

            Label label2 = new Label();
            label2.Font = new Font("Times New Roman", 14, FontStyle.Bold);
            label2.Text = "Удовлетварительно";
            label2.AutoSize = true;
            label2.Location = new Point((this.ClientSize.Width - label1.Width) / 2 + 21, 292);
            this.Controls.Add(label2);

            Button button = new Button();
            button.Text = "Посмотреть отчёт";
            button.Location = new Point((this.ClientSize.Width - label1.Width) / 2 + 21, 607);
            button.Size = new Size(150, 30);
            Controls.Add(button);
        }
    }
}