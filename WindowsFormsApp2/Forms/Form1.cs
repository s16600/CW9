using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LinqConsoleApp;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        //public List<Emp> lista;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void setData(IList lista)
        {
            this.dataGridView1.DataSource = lista;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //lista = new LinqSamples().Emps.ToList();
            //this.dataGridView1.DataSource = new LinqSamples().Emps.ToList();
            //setData(new LinqSamples(this).Emps.ToList());
            new LinqSamples(this).Przyklad1();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //setData(new LinqSamples(this).Emps.ToList());
            new LinqSamples(this).Przyklad2();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new LinqSamples(this).Przyklad3();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new LinqSamples(this).Przyklad4();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new LinqSamples(this).Przyklad5();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new LinqSamples(this).Przyklad6();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            new LinqSamples(this).Przyklad7();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            new LinqSamples(this).Przyklad8();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            new LinqSamples(this).Przyklad9();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            new LinqSamples(this).Przyklad10();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            new LinqSamples(this).Przyklad11();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            new LinqSamples(this).Przyklad12();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            new LinqSamples(this).Przyklad13();
        }
    }
}
