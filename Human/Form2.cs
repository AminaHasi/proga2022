using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace WindowsFormsApp3
{
    public partial class Form2 : Form
    {
        private listTeacher teacherlist;

        public void CurrentChartData(List<Teacher> spysok)
        {
            Series chartcolumn = new Series();
            for (int i = 0; i < spysok.Count; i++)
            {
                chart1.Series.Add(spysok[i].Surname + " " + spysok[i].Name);
                this.chart1.Series[i].Points.AddXY(spysok[i].Surname, spysok[i].List.Count);
            }
        }
        public Form2()
        {
            InitializeComponent();
        }

        
        private void Form2_Load(object sender, EventArgs e)
        {
            chart1.Series.RemoveAt(0);
            chart1.Titles.Add("К-кість студентів у вчителя");
            chart1.Palette = ChartColorPalette.Berry;
            teacherlist = new listTeacher(); comboBox2.Visible= false;
            createteacher.Visible= false; createstudent.Visible= false; createcoursework.Visible= false;
            label7.Visible = false; label12.Visible = false; label13.Visible = false; textBox1.Visible = false; 
            textBox2.Visible = false; textBox3.Visible = false; textBox4.Visible = false; textBox5.Visible = false;
            label14.Visible = false; label15.Visible = false; label16.Visible = false; label17.Visible = false;
            label18.Visible = false; label19.Visible = false; textBox6.Visible = false; textBox7.Visible = false;
            textBox8.Visible = false; comboBox3.Visible = false; treeView1.Visible = false;
            dataGridView1.Columns.Add("column1", "Ім'я");
            dataGridView1.Columns.Add("column2", "Прізвище");
            dataGridView1.Columns.Add("column3", "Вік");
            dataGridView2.Columns.Add("column1", "Ім'я");
            dataGridView2.Columns.Add("column2", "Прізвище");
            dataGridView2.Columns.Add("column3", "Вік");


        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Student")
            {
                createteacher.Visible = false; createstudent.Visible = true; createcoursework.Visible = false; button4.Visible = false;
                textBox4.Visible = true; textBox5.Visible = true; label14.Visible = true; label15.Visible = true;
                comboBox1.Visible = false; comboBox2.Visible = true; treeView1.Visible = true;
            }
            if (comboBox1.SelectedItem.ToString() == "Teacher")
            {
                createteacher.Visible = true; createstudent.Visible = false; createcoursework.Visible = false; button4.Visible = false;
                label7.Visible = true; label12.Visible = true; label13.Visible = true; textBox1.Visible = true; textBox2.Visible = true;
                textBox3.Visible = true; comboBox1.Visible = false; treeView1.Visible = true; pictureBox1.Visible = true;
                button3.Visible = true;
            }
            if (comboBox1.SelectedItem.ToString() == "CourseWork")
            {
                createteacher.Visible = false; createstudent.Visible = false; createcoursework.Visible = true; button4.Visible = false;
                label16.Visible = true; label17.Visible = true;
                label18.Visible = true; label19.Visible = true; textBox6.Visible = true; textBox7.Visible = true;
                textBox8.Visible = true; comboBox1.Visible = false; comboBox3.Visible = true; treeView1.Visible = true;
            }
        }

        private void createteacher_Click_1(object sender, EventArgs e)
        {
            int count = Convert.ToInt32(label22.Text);
            bool habbits = false;
            if (radioButton1.Checked == true)
            {
                habbits = true;
            }
            else if (radioButton2.Checked == true)
                habbits = false;
            Teacher teacher = new Teacher(HName.Text, HSurname.Text, Convert.ToInt32(HAge.Text), Convert.ToInt32(HHeight.Text), Convert.ToInt32(HWeight.Text), habbits, Nation.French, new Adress(HCountry.Text,HCity.Text, HStreet.Text, Convert.ToInt32(HHouse.Text)), HEmail.Text, Convert.ToInt32(textBox2.Text), textBox1.Text, KeyWords.java, Convert.ToInt32(textBox3.Text));
            teacherlist.add(teacher); comboBox2.Items.Add(HSurname.Text); treeView1.Nodes.Add(HSurname.Text);

            if (count == 0)
            {
                dataGridView1.Rows[count].Cells[0].Value = HName.Text;
                dataGridView1.Rows[count].Cells[1].Value = HSurname.Text;
                dataGridView1.Rows[count].Cells[2].Value = HAge.Text;
            }
            else
            {
                dataGridView1.Rows.Add(HName.Text, HSurname.Text, HAge.Text);
            }
            label22.Text = Convert.ToString(Convert.ToInt32(label22.Text) + 1);

            

            HName.Clear(); HSurname.Clear(); HCountry.Clear(); HStreet.Clear(); HCity.Clear(); HAge.Clear(); HEmail.Clear();
            HHeight.Clear(); HHouse.Clear(); HWeight.Clear(); radioButton1.Checked = false; radioButton2.Checked = false;
            textBox1.Clear(); textBox2.Clear(); textBox3.Clear(); label7.Visible = false; label12.Visible = false; label13.Visible = false; textBox1.Visible = false; textBox2.Visible = false;
            textBox3.Visible = false; comboBox1.Visible = true; createteacher.Visible = false; button4.Visible = true;
            pictureBox1.Visible = false; button3.Visible = false;
        }

        private void createcoursework_Click(object sender, EventArgs e)
        {
            CourseWork cursova = new CourseWork(textBox6.Text, textBox7.Text, Convert.ToDateTime(textBox8.Text));
            for (int i = 0; i < teacherlist.List.Count; i++)
                for (int j = 0; j < teacherlist.List[i].List.Count; j++)
                {
                    if (teacherlist.List[i].List[j].Surname == comboBox3.SelectedItem.ToString())
                    {
                        treeView1.Nodes[i].Nodes[j].Nodes.Add(textBox7.Text);
                    }
                }

            label16.Visible= false; label17.Visible = false; label18.Visible = false; label19.Visible = false;
            textBox7.Visible = false; textBox8.Visible = false; textBox6.Visible = false; createcoursework.Visible = false;
            comboBox1.Visible = true; button4.Visible = true; comboBox3.Visible = false; 
        }

        private void createstudent_Click(object sender, EventArgs e)
        {
            int count = Convert.ToInt32(label23.Text);
            bool habbits = true;
            if (radioButton1.Checked == true)
            {
                habbits = true;
            }
            else if (radioButton2.Checked == false)
                habbits = false;
            Student student = new Student(HName.Text, HSurname.Text, Convert.ToInt32(HAge.Text), Convert.ToInt32(HHeight.Text), Convert.ToInt32(HWeight.Text), habbits, Nation.French, new Adress(HCountry.Text, HCity.Text, HStreet.Text, Convert.ToInt32(HHouse.Text)), HEmail.Text, Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox5.Text), Key.java);
            comboBox3.Items.Add(HSurname.Text); teacher_to_student(student);
            treeView1.Nodes[comboBox2.SelectedIndex].Nodes.Add(HSurname.Text);

            if (count == 0)
            {
                dataGridView2.Rows[count].Cells[0].Value = (HName.Text);
                dataGridView2.Rows[count].Cells[1].Value = (HSurname.Text);
                dataGridView2.Rows[count].Cells[2].Value = (HAge.Text);
            }
            else
            {
                dataGridView2.Rows.Add(HName.Text, HSurname.Text, HAge.Text);
            }
            label23.Text = Convert.ToString(Convert.ToInt32(label23.Text) + 1);

            
            //chart1.Series[0].Points.Add(treeView1.Nodes[count].Nodes.Count);

            HName.Clear(); HSurname.Clear(); HCountry.Clear(); HStreet.Clear(); HCity.Clear(); HAge.Clear(); HEmail.Clear();
            HHeight.Clear(); HHouse.Clear(); HWeight.Clear(); radioButton1.Checked = false; radioButton2.Checked = false;
            textBox4.Clear(); textBox5.Clear();
            textBox4.Visible= false; textBox5.Visible = false; comboBox2.Visible = false; label15.Visible = false;
            label14.Visible = false; createstudent.Visible = false; button4.Visible = true; comboBox1.Visible = true;
        
        }

        public void teacher_to_student(Student student)
        {
            for (int i = 0; i < teacherlist.List.Count; i++)
            {
                if (teacherlist.List[i].Surname == comboBox2.SelectedItem.ToString())
                {
                    teacherlist.List[i].List.Add(student);
                    //Console.WriteLine(teacherlist.List[i].List.Count);
                    break;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CurrentChartData(teacherlist.List);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            teacherlist.save_json();
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void Fotochka_Click(object sender, EventArgs e)
        {
            Thread MyNewThread = new Thread((ThreadStart)(() => {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Image Files(*.BMP; *.JPG; *.PNG).|*.BMP; *.JPG; *.PNG|All files (*.*)|*.*";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = new Bitmap(dialog.FileName);
                }
            }));
            MyNewThread.SetApartmentState(ApartmentState.STA);
            MyNewThread.Start();
            MyNewThread.Join();
            //pictureBox1.Visible = true;
        }

        private void Pochta_Click(object sender, EventArgs e)
        {
            MailAddress Otrymuvach = new MailAddress("Почта  отримувача");
            MailAddress Vidpravnyk = new MailAddress("Почта відправника");

            MailMessage Povidomlennya = new MailMessage(Vidpravnyk, Otrymuvach);
            Povidomlennya.IsBodyHtml = true;
            Povidomlennya.Body = "<h1>Message_text</h1>";
            Povidomlennya.Subject = "Windows Forms";
            SmtpClient new_smtp = new SmtpClient("smtp.gmail.com", 587);
            new_smtp.Credentials = new NetworkCredential("Почта", "Пароль");
            new_smtp.EnableSsl = true;
            new_smtp.Send(Povidomlennya);
        }
    }
}
