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

namespace Navises_Array
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
           
                    Workbook book = new Workbook();
                    book.LoadFromFile(@"C:\Users\ACT-STUDENT\Desktop\Navises.xlsx");
                    Worksheet sheet = book.Worksheets[0];
                    int row = sheet.Rows.Length;
                    bool log = false;
                    for (int i = 2; i <= row; i++)
                    {
                        if (sheet.Range[i, 8].Value == txtusername.Text && sheet.Range[i, 9].Value == txtpassword.Text)
                        {
                            log = true;
                            break;
                        }
                        else
                        {
                            log = false;
                        }
                    }
                    if (log == true)
                    {
                        Dashboard dashboard = new Dashboard();
                        dashboard.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid");
                        txtpassword.Clear();
                        txtusername.Clear();
                    }
                }

        private void btnsignup_Click(object sender, EventArgs e)
        {
            SignIn signIn = new SignIn();
            signIn.Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
    }
        

       
