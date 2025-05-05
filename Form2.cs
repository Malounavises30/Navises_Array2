using Spire.Xls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Navises_Array
{
    public partial class Form2 : Form
    {

        Workbook book = new Workbook();

        public Form2()
        {
            InitializeComponent();
            // LoadExelFile();
        }

       private void LoadExelFile()
        {
            book.LoadFromFile(@"C:\Users\ACT-STUDENT\Desktop\Navises.xlsx");
            Worksheet sheet = book.Worksheets[0];

            DataTable dt = sheet.ExportDataTable();
            dtgView.DataSource = dt;
        }

        public void insert(string name, string gender, string hobbies, string favoritecolor, string saying)
        {
            int i = dtgView.Rows.Add();
            dtgView.Rows[i].Cells[0].Value = name;
            dtgView.Rows[i].Cells[1].Value = gender;
            dtgView.Rows[i].Cells[2].Value = hobbies;
            dtgView.Rows[i].Cells[3].Value = favoritecolor;
            dtgView.Rows[i].Cells[4].Value = saying;

        }
        public void update(int id, string name, string gender, string hobbies, string favoritecolor, string saying)
        {
            
            dtgView.Rows[id].Cells[0].Value = name;
            dtgView.Rows[id].Cells[1].Value = gender;
            dtgView.Rows[id].Cells[2].Value = hobbies;
            dtgView.Rows[id].Cells[3].Value = favoritecolor;
            dtgView.Rows[id].Cells[4].Value = saying;

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in dtgView.SelectedRows)
            {
                dtgView.Rows.Remove(item);
            }
                
        }

        private void dtgView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Form1 F1 = (Form1)Application.OpenForms["Form1"];
            int r = dtgView.CurrentCell.RowIndex;
            F1.txtName.Text = dtgView.Rows[r].Cells[0].Value.ToString();
            F1.lblid.Text = r.ToString();
            string gender = dtgView.Rows[r].Cells[1].Value.ToString();
            string[] gen = gender.Split();
            if (gender.Trim() == "Male")
            {
                F1.rbmale.Checked = true;
            }
            if (gender.Trim() == "Female")
            {
                F1.rbfemale.Checked = true;
            }
            string hobbies = dtgView.Rows[r].Cells[2].Value.ToString();
            string[] hob = hobbies.Split(',');
            foreach (string h in hob) {
                if (h.Trim() == "Basketball")
                {
                    F1.cbbasketball.Checked = true;
                }
                if (h.Trim()== "Volleyball")
                {
                    F1.cbvolleyball.Checked = true;
                }
                if (h.Trim() == "Soccer")

                {
                    F1.cbsoccer.Checked = true;
                }
            }
            F1.cbfavoritecolor.SelectedItem = dtgView.Rows[r].Cells[3].Value.ToString();
            F1.txtsaying.Text = dtgView.Rows[r].Cells[4].Value.ToString();
            
            
            //dtgView.Rows[i].Cells[1].Value.ToString();
            //dtgView.Rows[i].Cells[2].Value.ToString();
            //dtgView.Rows[i].Cells[3].Value.ToString();
            //dtgView.Rows[i].Cells[4].Value.ToString();


        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            dtgView.ClearSelection();
            foreach(DataGridViewRow i in dtgView.Rows)
            {
                if (i.Cells[0].Value.ToString().Equals(txtsearch.Text))
                {
                    i.Selected = true;
                    break;
                }

            }

        }

        public void showStudent(string status)
        {
            book.LoadFromFile(@"C:\Users\ACT-STUDENT\Desktop\Navises.xlsx");
            Worksheet sheet = book.Worksheets[0];

            DataTable dt = sheet.ExportDataTable();

            DataRow[] row = dt.Select("STATUS=" + status);

            int count = 0;

            foreach (DataRow r in row)
            {

                dtgView.Rows.Insert(count,
                     r[0],
                     r[1],
                     r[2],
                     r[3],
                     r[4],
                     r[5],
                     r[6],
                     r[7],
                     r[8],
                     r[9],
                     r[10],
                     r[11],
                     r[12]
                     );
                count++;
            }

            
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
     
}
 

