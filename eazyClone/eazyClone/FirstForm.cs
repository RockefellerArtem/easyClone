using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace eazyClone
{
    public partial class FirstForm : Form
    {
        private TextBox _startCountText;
        private TextBox _nameTestText;
        private TextBox Test2;

        public FirstForm()
        {
            InitializeComponent();
            
            ViewSettingsParameters();
            SettingsButton();

            _nameTestText = new TextBox();
            _nameTestText.Location = new Point(25, 20);
            _nameTestText.Size = new Size(150, 20);
            _nameTestText.Text = "";
            Controls.Add(_nameTestText);

            Test2 = new TextBox();
            Test2.Location = new Point(25, 50);
            Test2.Size = new Size(150, 20);
            Test2.Text = "";
            Controls.Add(Test2);

            _startCountText = new TextBox();
            _startCountText.Location = new Point(25, 80);
            _startCountText.Size = new Size(150, 20);
            Controls.Add(_startCountText);
        }
        
        private string StartCountQuestionTest()
        {
            return _startCountText.Text;
        }
        
        private string NameTest()
        {
            return _nameTestText.Text;
        }

        private void ViewSettingsParameters()
        {
            Label label = new Label();
            label.Text = "Имя | прав | из";
            label.AutoSize = true;
            label.Location = new Point(180, 24);
            this.Controls.Add(label);
        }
        private void SettingsButton()
        {
            Button button = new Button();
            button.Text = "Enter";
            button.Location = new Point(25, 110);
            button.Size = new Size(150, 30);
            button.Click += new EventHandler(ButtonSend);
            Controls.Add(button);
        }
        
        private void ButtonSend(object sender, EventArgs e)
        {
            this.Hide();
            SecondForm secondForm = new SecondForm(NameTest(), Test2.Text, StartCountQuestionTest());
            secondForm.Show();
        }
    }
}