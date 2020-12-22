using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ktformdemo
{
    public partial class ktform : Form
    {
        public ktform()
        {
            InitializeComponent();

            exam_textBox.Text = "MAY-JUNE";
            this.exam_textBox.Leave += new System.EventHandler(this.exam_textbox_Leave);
            this.exam_textBox.Enter += new System.EventHandler(this.exam_textBox_Enter);

            surname_textBox.Text = "SURNAME";
            this.surname_textBox.Leave += new System.EventHandler(this.surname_textBox_Leave);
            this.surname_textBox.Enter += new System.EventHandler(this.surname_textBox_Enter);

            name_textBox.Text = "NAME";
            this.name_textBox.Leave += new System.EventHandler(this.name_textBox_Leave);
            this.name_textBox.Enter += new System.EventHandler(this.name_textBox_Enter);

            father_textBox.Text = "FATHER NAME";
            this.father_textBox.Leave += new System.EventHandler(this.father_textBox_Leave);
            this.father_textBox.Enter += new System.EventHandler(this.father_textBox_Enter);

            podate_textBox.Text = "DD/MM/YYYY";
            this.podate_textBox.Leave += new System.EventHandler(this.podate_textBox_Leave);
            this.podate_textBox.Enter += new System.EventHandler(this.podate_textBox_Enter);

            internal_textBox.Text = "INTERNAL";
            this.internal_textBox.Leave += new System.EventHandler(this.internal_textBox_Leave);
            this.internal_textBox.Enter += new System.EventHandler(this.internal_textBox_Enter);

            external_textBox.Text = "EXTERNAL";
            this.external_textBox.Leave += new System.EventHandler(this.external_textBox_Leave);
            this.external_textBox.Enter += new System.EventHandler(this.external_textBox_Enter);

            //staticpressure_label.Text = "";
            //staticpressure_textBox.Hide();

            //temp_label.Text = "";
            //temp_textBox.Hide();
        }

        private void exam_textbox_Leave(object sender, EventArgs e)
            {
                if (exam_textBox.Text.Length == 0)
                {
                    exam_textBox.Text = "MAY-JUNE";
                    exam_textBox.ForeColor = SystemColors.GrayText;
                }
            }

            private void exam_textBox_Enter(object sender, EventArgs e)
            {
                if (exam_textBox.Text == "MAY-JUNE")
                {
                    exam_textBox.Text = "";
                    exam_textBox.ForeColor = SystemColors.WindowText;
                }
            }

        private void surname_textBox_Leave(object sender, EventArgs e)
        {
            if (surname_textBox.Text.Length == 0)
            {
                surname_textBox.Text = "SURNAME";
                surname_textBox.ForeColor = SystemColors.GrayText;
            }
        }

        private void surname_textBox_Enter(object sender, EventArgs e)
        {
            if (surname_textBox.Text == "SURNAME")
            {
                surname_textBox.Text = "";
                surname_textBox.ForeColor = SystemColors.WindowText;
            }
        }

        private void name_textBox_Leave(object sender, EventArgs e)
        {
            if (name_textBox.Text.Length == 0)
            {
                name_textBox.Text = "NAME";
                name_textBox.ForeColor = SystemColors.GrayText;
            }
        }

        private void name_textBox_Enter(object sender, EventArgs e)
        {
            if (name_textBox.Text == "NAME")
            {
                name_textBox.Text = "";
                name_textBox.ForeColor = SystemColors.WindowText;
            }
        }

        private void father_textBox_Leave(object sender, EventArgs e)
        {
            if (father_textBox.Text.Length == 0)
            {
                father_textBox.Text = "FATHER NAME";
                father_textBox.ForeColor = SystemColors.GrayText;
            }
        }

        private void father_textBox_Enter(object sender, EventArgs e)
        {
            if (father_textBox.Text == "FATHER NAME")
            {
                father_textBox.Text = "";
                father_textBox.ForeColor = SystemColors.WindowText;
            }
        }

        private void podate_textBox_Leave(object sender, EventArgs e)
        {
            if (podate_textBox.Text.Length == 0)
            {
                podate_textBox.Text = "DD/MM/YYYY";
                podate_textBox.ForeColor = SystemColors.GrayText;
            }
        }

        private void podate_textBox_Enter(object sender, EventArgs e)
        {
            if (podate_textBox.Text == "DD/MM/YYYY")
            {
                podate_textBox.Text = "";
                podate_textBox.ForeColor = SystemColors.WindowText;
            }
        }

        private void internal_textBox_Leave(object sender, EventArgs e)
        {
            if (internal_textBox.Text.Length == 0)
            {
                internal_textBox.Text = "INTERNAL";
                internal_textBox.ForeColor = SystemColors.GrayText;
            }
        }

        private void internal_textBox_Enter(object sender, EventArgs e)
        {
            if (internal_textBox.Text == "INTERNAL")
            {
                internal_textBox.Text = "";
                internal_textBox.ForeColor = SystemColors.WindowText;
            }
        }

        private void external_textBox_Leave(object sender, EventArgs e)
        {
            if (external_textBox.Text.Length == 0)
            {
                external_textBox.Text = "EXTERNAL";
                external_textBox.ForeColor = SystemColors.GrayText;
            }
        }

        private void external_textBox_Enter(object sender, EventArgs e)
        {
            if (external_textBox.Text == "EXTERNAL")
            {
                external_textBox.Text = "";
                external_textBox.ForeColor = SystemColors.WindowText;
            }
        }

        private void ktform_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string url = "http://aiktcexamcell.blogspot.com/";
            System.Diagnostics.Process.Start(url);
        }

        private void calculate_button_Click(object sender, EventArgs e)
        {
            //Double i = Double.Parse(internal_textBox.Text);

            //if (internal_textBox.Text == "")
            //{
            //    internal_textBox.Text = "0";
            //}


            //Double ex = Double.Parse(external_textBox.Text);

            //if (external_textBox.Text == "")
            //{
            //   external_textBox.Text = "0";
            //}

            Double money = ((Convert.ToDouble(internal_textBox.Text) * 250) + (Convert.ToDouble(external_textBox.Text) * 250));

            money_textBox.Text = "Rs. " + Convert.ToString(money);


            if (internal_specify_textBox.Text == "")
            {
                internal_specify_textBox.Text = "   -";
            }
            else
            { }

            if (external_specify_textBox.Text == "")
            {
                external_specify_textBox.Text = "   -";
            }
            else
            { }

        }

        private void reset_button_Click(object sender, EventArgs e)
        {
            BRANCH_comboBox.Text = " ";

            class_comboBox.Text = " ";

            sem_comboBox.Text = "";

            year_textBox.Text = "";

            rollno_textBox.Text = "";

            exam_textBox.ForeColor = SystemColors.GrayText;
            exam_textBox.Text = "MAY-JUNE";
            this.exam_textBox.Leave += new System.EventHandler(this.exam_textbox_Leave);
            this.exam_textBox.Enter += new System.EventHandler(this.exam_textBox_Enter);

            surname_textBox.ForeColor = SystemColors.GrayText;
            surname_textBox.Text = "SURNAME";
            this.surname_textBox.Leave += new System.EventHandler(this.surname_textBox_Leave);
            this.surname_textBox.Enter += new System.EventHandler(this.surname_textBox_Enter);

            name_textBox.ForeColor = SystemColors.GrayText;
            name_textBox.Text = "NAME";
            this.name_textBox.Leave += new System.EventHandler(this.name_textBox_Leave);
            this.name_textBox.Enter += new System.EventHandler(this.name_textBox_Enter);

            father_textBox.ForeColor = SystemColors.GrayText;
            father_textBox.Text = "FATHER NAME";
            this.father_textBox.Leave += new System.EventHandler(this.father_textBox_Leave);
            this.father_textBox.Enter += new System.EventHandler(this.father_textBox_Enter);

            podate_textBox.ForeColor = SystemColors.GrayText;
            podate_textBox.Text = "DD/MM/YYYY";
            this.podate_textBox.Leave += new System.EventHandler(this.podate_textBox_Leave);
            this.podate_textBox.Enter += new System.EventHandler(this.podate_textBox_Enter);

            internal_textBox.ForeColor = SystemColors.GrayText;
            internal_textBox.Text = "INTERNAL";
            this.internal_textBox.Leave += new System.EventHandler(this.internal_textBox_Leave);
            this.internal_textBox.Enter += new System.EventHandler(this.internal_textBox_Enter);

            external_textBox.ForeColor = SystemColors.GrayText;
            external_textBox.Text = "EXTERNAL";
            this.external_textBox.Leave += new System.EventHandler(this.external_textBox_Leave);
            this.external_textBox.Enter += new System.EventHandler(this.external_textBox_Enter);

            prnno_textBox.Text = "";

            mobileno_textBox.Text = "";

            money_textBox.Text = "";

            internal_specify_textBox.Text = "";

            external_specify_textBox.Text = "";

        }

        private void finalprintDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //Double i = Double.Parse(internal_textBox.Text);

            //if (internal_textBox.Text == "")
            //{
            //    internal_textBox.Text = "0";
            //}


            //Double ex = Double.Parse(external_textBox.Text);

            //if (external_textBox.Text == "")
            //{
            //   external_textBox.Text = "0";
            //}

            Double money = ((Convert.ToDouble(internal_textBox.Text) * 250) + (Convert.ToDouble(external_textBox.Text) * 250));

            money_textBox.Text = "Rs. " + Convert.ToString(money);


            if (internal_specify_textBox.Text == "")
            {
                internal_specify_textBox.Text = "   -";
            }
            else
            { }

            if (external_specify_textBox.Text == "")
            {
                external_specify_textBox.Text = "   -";
            }
            else
            { }

            Bitmap bmp = Properties.Resources.header1;
            Image head = bmp;

            Font drawFont = new Font("Roboto", 12);
            Font drawFontm = new Font("Roboto", 11, FontStyle.Bold);
            Font drawFontBold = new Font("Roboto", 12, FontStyle.Bold);
            Font drawFontUnderline = new Font("Roboto", 12, FontStyle.Underline);
            SolidBrush drawBrush = new SolidBrush(Color.Black);
            Font drawHeader = new Font("Square721 BT", 15, FontStyle.Bold);
            Font drawFooter = new Font("Roboto", 9, FontStyle.Bold);

            e.Graphics.DrawImage(head, 160, 40, head.Width, head.Height);

            e.Graphics.DrawString(DateTime.Now.Date.ToString("dd/MM/yyyy"), drawFont, drawBrush, new Point(25, 115));
            e.Graphics.DrawString("Page 1", drawFont, drawBrush, new Point(750, 115));
            e.Graphics.DrawString(DashLine.Text, drawFontBold, drawBrush, new Point(25, 120));

            e.Graphics.DrawString("KT EXAMINATION FORM ", drawHeader, drawBrush, new Point(300, 145));

            e.Graphics.DrawString("BRANCH: ", drawFontBold, drawBrush, new Point(25, 185));
            e.Graphics.DrawString(BRANCH_comboBox.Text, drawFont, drawBrush, new Point(110, 185));

            e.Graphics.DrawString("CLASS: ", drawFontBold, drawBrush, new Point(350, 185));
            e.Graphics.DrawString(class_comboBox.Text, drawFont, drawBrush, new Point(435, 185));

            e.Graphics.DrawString("SEM: ", drawFontBold, drawBrush, new Point(25, 205));
            e.Graphics.DrawString(sem_comboBox.Text, drawFont, drawBrush, new Point(110, 205));

            e.Graphics.DrawString("EXAM: ", drawFontBold, drawBrush, new Point(350, 205));
            e.Graphics.DrawString(exam_textBox.Text, drawFont, drawBrush, new Point(435, 205));

            e.Graphics.DrawString("YEAR: ", drawFontBold, drawBrush, new Point(25, 225));
            e.Graphics.DrawString(year_textBox.Text, drawFont, drawBrush, new Point(110, 225));

            e.Graphics.DrawString("ROLL NO.: ", drawFontBold, drawBrush, new Point(350, 225));
            e.Graphics.DrawString(rollno_textBox.Text, drawFont, drawBrush, new Point(435, 225));

            e.Graphics.DrawString("NAME: ", drawFontBold, drawBrush, new Point(25, 245));
            e.Graphics.DrawString(surname_textBox.Text + " " + name_textBox.Text + " " + father_textBox.Text, drawFont, drawBrush, new Point(110, 245));

            e.Graphics.DrawString("PRN NO.: ", drawFontBold, drawBrush, new Point(25, 265));
            e.Graphics.DrawString(prnno_textBox.Text, drawFont, drawBrush, new Point(110, 265));

            e.Graphics.DrawString("MOB. NO.: ", drawFontBold, drawBrush, new Point(350, 265));
            e.Graphics.DrawString(mobileno_textBox.Text, drawFont, drawBrush, new Point(435, 265));

            e.Graphics.DrawString(DashLine.Text, drawFontBold, drawBrush, new Point(25, 280));

            e.Graphics.DrawString("NO. OF KTs (INTERNAL): ", drawFontBold, drawBrush, new Point(25, 305));
            e.Graphics.DrawString(internal_textBox.Text, drawFontBold, drawBrush, new Point(250, 305));

            e.Graphics.DrawString("NO. OF KTs (EXTERNAL): ", drawFontBold, drawBrush, new Point(25, 325));
            e.Graphics.DrawString(external_textBox.Text, drawFontBold, drawBrush, new Point(250, 325));

            if (podate_textBox.Text == "DD/MM/YYYY")
            {
                podate_textBox.Text = "-";
            }

            e.Graphics.DrawString("DATE OF RECEIPT: ", drawFontBold, drawBrush, new Point(25, 345));
            e.Graphics.DrawString(podate_textBox.Text, drawFontBold, drawBrush, new Point(250, 345));

            e.Graphics.DrawString("TOTAL KT FEES: ", drawFontBold, drawBrush, new Point(25, 365));
            e.Graphics.DrawString(money_textBox.Text, drawFontBold, drawBrush, new Point(250, 365));

            e.Graphics.DrawString("INTERNAL KT SUBJECTS: ", drawFontBold, drawBrush, new Point(25, 385));
            e.Graphics.DrawString(internal_specify_textBox.Text, drawFontBold, drawBrush, new Point(50, 405));

            e.Graphics.DrawString("EXTERNAL KT SUBJECTS: ", drawFontBold, drawBrush, new Point(350, 385));
            e.Graphics.DrawString(external_specify_textBox.Text, drawFontBold, drawBrush, new Point(435, 405));

            e.Graphics.DrawString(DashLine.Text, drawFontBold, drawBrush, new Point(25, 525));

            e.Graphics.DrawString("*ATTACH COPY OF MARKSHEET*", drawFont, drawBrush, new Point(535, 545));

            e.Graphics.DrawString("CANDIDATE SIGNATURE:", drawFontBold, drawBrush, new Point(575, 665));
        }

        private void printpreview_button_Click(object sender, EventArgs e)
        {
            finalprintPreviewDialog.Document = finalprintDocument;
            finalprintPreviewDialog.Show();
        }

        private void print_button_Click(object sender, EventArgs e)
        {
            finalprintDialog.ShowDialog();
            finalprintDocument.Print();
        }
    }
}
