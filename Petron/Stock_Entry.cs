﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;


namespace Petron
{
    public partial class StockEntry : Form
    {
        public StockEntry()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void StockEntry_Load(object sender, EventArgs e)
        {
            transno.Text = "TR-" + generateID.generateNewID();
        }

        private void cmdclose_Click(object sender, EventArgs e)
        {
            gbsupplier.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gbsupplier.Visible = true;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            //gbsupplier.Visible = true; 
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            transno.Text = "TR-" + generateID.generateNewID();
        }

        private void transno_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
