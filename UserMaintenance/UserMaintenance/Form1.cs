﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserMaintenance.Entities;

namespace UserMaintenance
{
    public partial class Form1 : Form
    {
        BindingList<User> users = new BindingList<User>();
        public Form1()
        {
            InitializeComponent();
            label1.Text = Resource1.FullName; 
            button1.Text = Resource1.Add;
            button2.Text = Resource1.WriteToFile;

            listBox1.DataSource = users;
            listBox1.ValueMember = "ID";
            listBox1.DisplayMember = "FullName";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var u = new User()
            {
                FullName = textBox1.Text,
            };
            users.Add(u);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();
            using (StreamWriter sw= new StreamWriter(sf.FileName, false, Encoding.UTF8))
            {
                foreach (var i in users)
                {
                    sw.Write(i.ID);
                    sw.Write(";");
                    sw.Write(i.FullName);
                    sw.WriteLine();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var del = listBox1.SelectedItem;
            if (del != null)
            {
                users.Remove((User)del);
            }
        }
    }
}
