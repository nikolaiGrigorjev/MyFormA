using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFormA
{
    class Start_Form : System.Windows.Forms.Form
    {
        public Start_Form()
        {
            Button st_btn = new Button
            {
                Text = "My Form",
                Location = new System.Drawing.Point(10, 10)
            };
            st_btn.Click += St_btn_Click;
            this.Controls.Add(st_btn);
            Button st_btn2 = new Button()
            {
                Text = "Second form",
                Location = new System.Drawing.Point(100, 10)
            };
            st_btn2.Click += St_btn_Click1; ;
            this.Controls.Add(st_btn2);

        }

        private void St_btn_Click1(object sender, EventArgs e)
        {
            FormAgain newWin = new FormAgain(10,10);
            newWin.StartPosition = FormStartPosition.CenterScreen;
            newWin.ShowDialog();
        }

        private void St_btn_Click(object sender, EventArgs e)
        {
            FormAgain newWin = new FormAgain("Hello","Joker", "1", "2", "3", "4");
            newWin.StartPosition = FormStartPosition.CenterScreen;
            newWin.ShowDialog();
        }
    }
}
