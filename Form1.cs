using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace Navises_Array
{
    public partial class Form1 : Form
    {
        Form2 F2 = new Form2();
        public Form1()
        {
            InitializeComponent();
        }
        string[] Student = new string[5];
        //int x = 0;
         int i=0;

        private void btnadd_Click(object sender, EventArgs e)
        {
            string data = "";
            string gender = "";
            string hobbies = "";
            string favoritecolor = "";
            string saying = "";
           
            data += txtName.Text;
            if (rbmale.Checked)
            {
                gender = rbmale.Text;
            }
            if (rbfemale.Checked)
            {
               gender = rbfemale.Text;
            }
            if (cbbasketball.Checked)
            {
                hobbies += cbbasketball.Text + ", ";
            }
            if (cbsoccer.Checked)
            {
                hobbies += cbsoccer.Text + ", ";
            }
            if (cbvolleyball.Checked)
            {
                hobbies += cbvolleyball.Text + ", ";
            }
            favoritecolor= cbfavoritecolor.Text;
            saying = txtsaying.Text + ".";

            Student[i] = data;
            i++;
            F2.insert(txtName.Text, gender, hobbies, favoritecolor, saying);
            txtName.Clear();
            rbmale.Checked = false;
            rbfemale.Checked = false;
            cbbasketball.Checked = false;
            cbvolleyball.Checked = false;
            cbsoccer.Checked = false;
            cbfavoritecolor.SelectedIndex = -1;
            txtsaying.Clear();
            
         
        }

        private void btndisplay_Click(object sender, EventArgs e)
        { 
            string Dis = "";

            for (int x = 0; x < Student.Length; x++)
            {
                Dis += "[" + x + "]" + Student[x] + "\n";

            }
           // MessageBox.Show(Dis);
            F2.Show();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            string data = "";
            string gender = "";
            string hobbies = "";
            string favoritecolor = "";
            string saying = "";

            data += txtName.Text;
            if (rbmale.Checked)
            {
                gender = rbmale.Text;
            }
            if (rbfemale.Checked)
            {
                gender = rbfemale.Text;
            }
            if (cbbasketball.Checked)
            {
                hobbies += cbbasketball.Text + ", ";
            }
            if (cbsoccer.Checked)
            {
                hobbies += cbsoccer.Text + ", ";
            }
            if (cbvolleyball.Checked)
            {
                hobbies += cbvolleyball.Text + ", ";
            }
            favoritecolor = cbfavoritecolor.Text;
            saying = txtsaying.Text + ".";

            Student[i] = data;
            i++;
            F2.update(Convert.ToInt32(lblid.Text),txtName.Text, gender, hobbies, favoritecolor, saying);
            
            txtName.Clear();
            rbmale.Checked = false;
            rbfemale.Checked = false;
            cbbasketball.Checked = false;
            cbvolleyball.Checked = false;
            cbsoccer.Checked = false;
            cbfavoritecolor.SelectedIndex = -1;
            txtsaying.Clear();

        }

        private void dtpicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
 }

