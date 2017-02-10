using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win_OOP_Objek_II
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Shooter Test1 = new Shooter();
            Shooter Test2 =  new Shooter();
            Shooter Test3 = new Shooter();
            Test1.WriteName("Karel");
            Test2.WriteName("Jura");
            Test3.WriteName("Milos");

            comboBox3.Items.Add(Test1);
            comboBox3.Items.Add(Test2);
            comboBox3.Items.Add(Test3);

            comboBox4.Items.Add(Test1.GetName(Test1));
            comboBox4.Items.Add(Test2.GetName(Test2));
            comboBox4.Items.Add(Test3.GetName(Test3));

            textBox3.Text = Test1.GetName(Test1) + Environment.NewLine + Test2.GetName(Test2) + Environment.NewLine + Test3.GetName(Test3) + Environment.NewLine + Environment.NewLine;
        }

        
        private void button3_Click(object sender, EventArgs e)
        {
            Shooter temp = (Shooter)comboBox3.SelectedItem;
            temp.ShootUp(temp);
            textBox3.Text += temp.GetName(temp) + temp.GetHealt(temp).ToString() + Environment.NewLine;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Shooter temp = (Shooter)comboBox3.SelectedItem;
            temp.HealUp(temp);
            textBox3.Text += temp.GetName(temp) + temp.GetHealt(temp).ToString() + Environment.NewLine;
        }
    }
}
