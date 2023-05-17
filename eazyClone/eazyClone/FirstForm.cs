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
            
            _startCountText = new TextBox();
            _startCountText.Location = new Point(150, 100);
            _startCountText.Size = new Size(150, 20);
            
            Controls.Add(_startCountText);
            
            _nameTestText = new TextBox();
            _nameTestText.Location = new Point(50, 50);
            _nameTestText.Size = new Size(150, 20);
            _nameTestText.Text = " ";
            Controls.Add(_nameTestText);

            Test2 = new TextBox();
            Test2.Location = new Point(100, 150);
            Test2.Size = new Size(150, 20);
            Test2.Text = " ";
            Controls.Add(Test2);

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
            label.Location = new Point(200, 50);
            this.Controls.Add(label);
        }
        private void SettingsButton()
        {
            Button button = new Button();
            button.Text = "Нажми меня!";
            button.Location = new Point(50, 180);
            button.Size = new Size(100, 30);
            button.Click += new EventHandler(ButtonSend);
            Controls.Add(button);
        }
        
        private void ButtonSend(object sender, EventArgs e)
        {
            this.Hide();
            SecondForm secondForm = new SecondForm(NameTest(),StartCountQuestionTest(), _startCountText.Text);
            secondForm.Show();
        }
    }
}