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
            
            Label label1 = new Label();
            label1.Text = $"{startCountQustion} правильных ответов из {endCountQustion}";
            label1.AutoSize = true;
            label1.Location = new Point((this.ClientSize.Width - label1.Width) / 2, (this.ClientSize.Height / 2) + 40);
            this.Controls.Add(label1);
            
            
            Label label = new Label();
            label.Font = new Font("Arial", 36, FontStyle.Bold);
            label.Text = "4";
            label.AutoSize = true;
            label.Location = new Point((this.ClientSize.Width - label.Width) / 2, (this.ClientSize.Height - label.Height) / 2);
            this.Controls.Add(label);
        }
    }
}