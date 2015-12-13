﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _462_ManagementApp
{
    public partial class Main :Form
    {
     
        public Main()
        {
            InitializeComponent();
            BodyControl.SelectedIndexChanged += new EventHandler(BodyControl_Selected);
            FillCombo3();
         
           
        }

        private void BodyControl_Selected(object sender, EventArgs e)
        {
             if (BodyControl.SelectedTab == AssignmentsPage)
            {
                try
                {
                    String myConnection1 = "datasource=localhost;port=3306;username=root;password=admin";
                    MySqlConnection myConn1 = new MySqlConnection(myConnection1);
                    MySqlCommand cmdDataBase = new MySqlCommand("select Details, DueDate, UserAssigned, Assignment, ID from project.assignments;", myConn1);
                    MySqlDataAdapter sda = new MySqlDataAdapter();
                    sda.SelectCommand = cmdDataBase;
                    DataTable dbdataset = new DataTable();
                    sda.Fill(dbdataset);
                    dataGridView1.BringToFront();
                    BindingSource bsource = new BindingSource();
                    bsource.DataSource = dbdataset;
                    dataGridView1.DataSource = bsource;
                    sda.Update(dbdataset);
                }
                catch (Exception exx)
                {
                    MessageBox.Show(exx.Message);
                }

            }







            if (BodyControl.SelectedTab == tabPage2)
            {
              
            }



            if (BodyControl.SelectedTab == tabPage3)
            {
                try
                {
                    string MyConnection44 = "datasource=localhost;port=3306;username=root;password=admin";
                    string Query = "SELECT * FROM project.log where Assignment = '" + this.textBox8.Text + "';";
                    MySqlConnection MyConn44 = new MySqlConnection(MyConnection44);
                    MySqlCommand MyCommand44 = new MySqlCommand(Query, MyConn44);
                    MyConn44.Open();
                    MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                    MyAdapter.SelectCommand = MyCommand44;
                    DataTable dTable = new DataTable();
                    dataGridView4.BringToFront();
                    MyAdapter.Fill(dTable);
                    dataGridView4.DataSource = dTable;
                    MyConn44.Close();
                    
                }
                catch (Exception ex1)
                {
                    MessageBox.Show(ex1.Message);
                }
             
            }
        }

       

        void FillCombo3()
        {
              try
            {
                string MyConnection38 = "datasource=localhost;port=3306;username=root;password=admin";
                string Query = "select Assignment from project.assignments;";
                MySqlConnection MyConn38 = new MySqlConnection(MyConnection38);
                MySqlCommand MyCommand38 = new MySqlCommand(Query, MyConn38);
                MySqlDataReader MyReader38;
                MyConn38.Open();
                MyReader38 = MyCommand38.ExecuteReader();
                while (MyReader38.Read())
                {
                    string sName = MyReader38.GetString("Assignment");
                    comboBox2.Items.Add(sName);
                }
                MyConn38.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       

        
        private void assignmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void WelcomeLabel_Click(object sender, EventArgs e)
        {

        }

        private void HomeUsernameLabel_Click(object sender, EventArgs e)
        {

        }

        private void HomePage_Click(object sender, EventArgs e)
        {

        }

        private void companynamelabel_Click(object sender, EventArgs e)
        {

        }
            
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void AssignmentsLabel_Click(object sender, EventArgs e)
        {

        }

        private void Assign_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AssignmentsTabControl_SelectAssignmentsPage_Click(object sender, EventArgs e)
        {
     
        }


      
        private void AssignmentsPage_Click(object sender, EventArgs e)
        {
            
        }

        private void PendingTab_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void homeToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void assignmentsToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void authorizationRequestToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void signOutToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void helpToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void employeeIDLabel2_Click(object sender, EventArgs e)
        {

        }

        private void EmployeeIDLabel_Click(object sender, EventArgs e)
        {

        }

        private void StatusLabel_Click(object sender, EventArgs e)
        {

        }

        private void CompanyNameLabel2_Click(object sender, EventArgs e)
        {

        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void authorizeRequestToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void SignInPage_Click(object sender, EventArgs e)
        {

        }

        private void HelpLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void CompanyLogoPix_Click(object sender, EventArgs e)
        {

        }

        private void PasswordLabel_Click(object sender, EventArgs e)
        {

        }

        private void UsernameLabel_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void HomePage_Click_1(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewAssign f2 = new NewAssign();
            f2.ShowDialog();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f3 = new Form1();
            f3.ShowDialog();
        }

        private string nm;

        public string Passvalue
        {
            get { return nm; }
            set { nm = value; }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            PassNameLbl.Text = "Welcome " + nm;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            {
               
            }
        }

        private void Assign_Click_1(object sender, EventArgs e)
        {

        }

                      
   
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                String myConnection1 = "datasource=localhost;port=3306;username=root;password=admin";
                MySqlConnection myConn1 = new MySqlConnection(myConnection1);
                MySqlCommand cmdDataBase = new MySqlCommand("select Details, DueDate, UserAssigned, Assignment, ID from project.assignments;", myConn1);
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDataBase;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                dataGridView1.BringToFront();
                BindingSource bsource = new BindingSource();
                bsource.DataSource = dbdataset;
                dataGridView1.DataSource = bsource;
                sda.Update(dbdataset);
                this.Refresh();
            }
            catch (Exception exx)
            {
                MessageBox.Show(exx.Message);
            }
        }
        

        private void signOutToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form f3 = new Form1();
            f3.ShowDialog();
        }
        
        private void button4_Click(object sender, EventArgs e)
        {
            
            try
            {
                string MyConnection4 = "datasource=localhost;port=3306;username=root;password=admin";
                string Query = "SELECT assignment, id, SetAuthorization FROM project.assignments WHERE SetAuthorization ='Pending';";
                MySqlConnection MyConn4 = new MySqlConnection(MyConnection4);
                MySqlCommand MyCommand4 = new MySqlCommand(Query, MyConn4);
                MyConn4.Open();
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand4;
                DataTable dTable = new DataTable();
                dataGridView2.BringToFront();
                MyAdapter.Fill(dTable);
                dataGridView2.DataSource = dTable;
                MyConn4.Close();
            }
            catch (Exception ex1)
            {
                MessageBox.Show(ex1.Message);
            }
            
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        public void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            
        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void LogEntryTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void newAssignmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Assignments on HOMEPAGE
            BodyControl.SelectedTab = AssignmentsPage;
        }

        private void homeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            //HOME PAGE ON ASSIGNMENTS
            BodyControl.SelectedTab = HomePage;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //MODIFY BUTTON
            Modify f5 = new Modify();
            f5.ShowDialog();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            //
        }

        private void ViewAssignDetailsButton_Click(object sender, EventArgs e)
        {
            //VIEW ASSIGNMENT DETAILS
           
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Details Page FOR HOME
            BodyControl.SelectedTab = HomePage;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            //DETAILS PAGE FOR ASSIGNMENTS
            BodyControl.SelectedTab = AssignmentsPage;
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            //SIGNOUT FOR DETAILS PAGE
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            //MODIFY ASSIGNMENTS TO GO TO HOME
            BodyControl.SelectedTab = HomePage;
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            //MODIFY ASSIGNMENTS TO GO TO ASSIGNMENTS
            BodyControl.SelectedTab = AssignmentsPage;
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            //SIGNOUT FROM THE MODIFY ASSIGNMENTS PAGE
        }

        private void ModifyButton_Click(object sender, EventArgs e)
        {
            //Modify button
            //CHECK FOR THE DATE TIME IF IT IS PASSED OR NOT
            //dateTimePicker1;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
      
        private void dataGridView1_CellButtonClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ignore clicks that are not in our 
            if (e.ColumnIndex == dataGridView1.Columns["Column1"].Index && e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                textBox8.Text = row.Cells["Assignment"].Value.ToString();
                textBox7.Text = row.Cells["UserAssigned"].Value.ToString();
                textBox4.Text = row.Cells["ID"].Value.ToString();
                textBox5.Text = row.Cells["DueDate"].Value.ToString();
                textBox1.Text = row.Cells["Details"].Value.ToString();
                BodyControl.SelectedTab = tabPage3;
            }
            try
            {
                string MyConnection44 = "datasource=localhost;port=3306;username=root;password=admin";
                string Query = "SELECT * FROM project.log where Assignment = '" + this.textBox8.Text + "';";
                MySqlConnection MyConn44 = new MySqlConnection(MyConnection44);
                MySqlCommand MyCommand44 = new MySqlCommand(Query, MyConn44);
                MyConn44.Open();
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand44;
                DataTable dTable = new DataTable();
                dataGridView4.BringToFront();
                MyAdapter.Fill(dTable);
                dataGridView4.DataSource = dTable;
                MyConn44.Close();
            }
            catch (Exception ex1)
            {
                MessageBox.Show(ex1.Message);
            }
        }
      
            
        




        private void button6_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure You Want To Delete ?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                object cell = row.Cells["cell_del"].Value;
                if (cell =="yes")
                dataGridView1.Rows.RemoveAt(row.Index);
                        /*
                            String myConnection11 = "datasource=localhost;port=3306;username=root;password=admin";
                            MySqlConnection myConn11 = new MySqlConnection(myConnection11);
                            MySqlCommand cmdDataBase = new MySqlCommand("Delete ID, assignment, UserAssigned, DueDate, Details, Status, SetAuthorization from project.assignments WHERE ID= " cell_del.Equals("ID") ";", myConn11);
                            MySqlDataAdapter sda = new MySqlDataAdapter();
                            sda.SelectCommand = cmdDataBase;
                            DataTable dbdataset = new DataTable();
                            sda.Fill(dbdataset);
                            BindingSource bsource = new BindingSource();
                            bsource.DataSource = dbdataset;
                            dataGridView1.DataSource = bsource;
                            sda.Update(dbdataset);*/
                
            }
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

            try
            {
                string MyConnection41 = "datasource=localhost;port=3306;username=root;password=admin";
                string Query = "SELECT Assignment, ID, SetAuthorization FROM project.assignments WHERE SetAuthorization ='Complete';";
                MySqlConnection MyConn41 = new MySqlConnection(MyConnection41);
                MySqlCommand MyCommand41 = new MySqlCommand(Query, MyConn41);
                MyConn41.Open();
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand41;
                DataTable dTable = new DataTable();
                dataGridView3.BringToFront();
                MyAdapter.Fill(dTable);
                dataGridView3.DataSource = dTable;
                MyConn41.Close();
            }
            catch (Exception ex11)
            {
                MessageBox.Show(ex11.Message);
            }
        }

        private void DetailsTab_Click(object sender, EventArgs e)
        {

        }

        private void AssignmentsPage_Click_1(object sender, EventArgs e)
        {

        }

        private void dataGridView5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

       
       

       

        

        private void StatusLabel_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string MyConnection39 = "datasource=localhost;port=3306;username=root;password=admin";
                string Query = "select * from project.assignments where Assignment = '" + comboBox2.Text + "';";
                MySqlConnection MyConn39 = new MySqlConnection(MyConnection39);
                MySqlCommand MyCommand39 = new MySqlCommand(Query, MyConn39);
                MySqlDataReader MyReader39;
                MyConn39.Open();
                MyReader39 = MyCommand39.ExecuteReader();
                while (MyReader39.Read())
                {
                    string details = MyReader39.GetString("Details");
                    string ID = MyReader39.GetInt32("ID").ToString();
                    textBox3.Text = ID;
                    textBox2.Text = details;

                }
                MyConn39.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                string MyConnection8 = "datasource=localhost;port=3306;username=root;password=admin";
                string Query = "update project.assignments set SetAuthorization = 'Pending' WHERE ID= " + textBox3.Text + ";";
                MySqlConnection MyConn8 = new MySqlConnection(MyConnection8);
                MySqlCommand MyCommand8 = new MySqlCommand(Query, MyConn8);
                MySqlDataReader MyReader8;
                MyConn8.Open();
                MyReader8 = MyCommand8.ExecuteReader();
                MessageBox.Show("Authorization Requested");
                BodyControl.SelectedTab = AssignmentsPage;
                while (MyReader8.Read())
                {

                }
                MyConn8.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        

        

        private void button10_Click(object sender, EventArgs e)
        {

            try
            {
                string MyConnection44 = "datasource=localhost;port=3306;username=root;password=admin";
                string Query = "SELECT * FROM project.log where Assignment = '" + this.textBox8.Text + "';";
                MySqlConnection MyConn44 = new MySqlConnection(MyConnection44);
                MySqlCommand MyCommand44 = new MySqlCommand(Query, MyConn44);
                MyConn44.Open();
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand44;
                DataTable dTable = new DataTable();
                dataGridView4.BringToFront();
                MyAdapter.Fill(dTable);
                dataGridView4.DataSource = dTable;
                MyConn44.Close();
            }
            catch (Exception ex1)
            {
                MessageBox.Show(ex1.Message);
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void signOutToolStripMenuItem1_Click_2(object sender, EventArgs e)
        {
            this.Hide();
            Form f3 = new Form1();
            f3.ShowDialog();
        }

        private void signOutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form f3 = new Form1();
            f3.ShowDialog();
        }

        private void signOutToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f3 = new Form1();
            f3.ShowDialog();
        }

        private void signOutToolStripMenuItem2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form f3 = new Form1();
            f3.ShowDialog();
        }

        private void signOutToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f3 = new Form1();
            f3.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox6.Text == "")
            {
                MessageBox.Show("Log Can't Be Empty Please Enter the Log !!");
            }
            else
            {
                try
                {
                    string MyConnection88 = "datasource=localhost;port=3306;username=root;password=admin";
                    string Query = "insert into project.log(Assignment,Logger,Designation,Log) values('" + this.textBox8.Text + "','" + this.PassNameLbl1.Text + "','" + this.label12.Text + "', '" + this.textBox6.Text + "');";
                    MySqlConnection MyConn88 = new MySqlConnection(MyConnection88);
                    MySqlCommand MyCommand88 = new MySqlCommand(Query, MyConn88);
                    MySqlDataReader MyReader88;
                    MyConn88.Open();
                    MyReader88 = MyCommand88.ExecuteReader();
                    MessageBox.Show("Log Entered");
                    while (MyReader88.Read())
                    {
                    }
                    MyConn88.Close();


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

      
        }

       
        }

      

    

