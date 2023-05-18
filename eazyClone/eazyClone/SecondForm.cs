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
            label.Font = new Font("Microsoft", 140, FontStyle.Regular);
            label.Text = "4";
            label.AutoSize = true;
            label.Location = new Point(390, 78);
            this.Controls.Add(label);

            Label label1 = new Label();
            label1.Font = new Font("Microsoft Sans Serif", 11, FontStyle.Regular);
            label1.Text = $"{startCountQustion} правильных ответов из {endCountQustion}";
            label1.AutoSize = true;
            label1.Location = new Point(366, 307);
            this.Controls.Add(label1);
    
            Label label2 = new Label();
            label2.Font = new Font("Microsoft Sans Serif", 15, FontStyle.Regular);
            label2.Text = "Хорошо";
            label2.AutoSize = true;
            label2.Location = new Point(428, 353);
            this.Controls.Add(label2);

            Button button = new Button();
            button.Text = "Посмотреть отчёт";
            button.Location = new Point(411, 599);
            button.Size = new Size(122, 28);
            Controls.Add(button);
        }
    }
}