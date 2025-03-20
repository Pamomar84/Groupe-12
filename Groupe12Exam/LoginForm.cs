using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Groupe12Exam
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            
        }
        Utilisateurs user = new Utilisateurs();
        public bool timecheck = false;
        public int CheckCode(string code)
        {
            using (var db = new DbScolaire())
            {
                var otpCode = db.TOTPCodes.FirstOrDefault(p => p.Code == code);
                if (otpCode != null)
                {
                    timecheck = CheckTimeCode(otpCode.DateExpiration);
                    return otpCode.IdUtilisateur;
                }
            }
            return 0;
        }
        public void GetIt(Utilisateurs user)
        {
            this.user = user;
            textBox1.Text = user.Telephone;

        }
        public bool CheckTimeCode(DateTime dateTime)
        {
            if (dateTime > DateTime.Now) return true;
            return false;
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            using (var db = new DbScolaire())
            {
                var tel = textBox1.Text;
                var code = textBox2.Text;
                var user = db.TUtilisateurs.FirstOrDefault(p => p.Telephone == tel);
                if (user != null && CheckCode(code) == user.Id && timecheck == true)
                
                {
                    if (user.Role== "Administrateur")
                    {
                        Admin admin = new Admin();
                        admin.Show();
                        admin.MdiParent=this.MdiParent;
                        this.Hide();
                    }
                    if (user.Role == "DE")
                    {
                        DE dE = new DE();
                        dE.Show();
                        dE.MdiParent = this.MdiParent;
                        this.Hide();
                    }
                    if (user.Role == "Agent")
                    {
                        Agent agent = new Agent(); 
                        agent.Show();
                        agent.MdiParent = this.MdiParent;
                        this.Hide();
                    }

                }
                else MessageBox.Show("Code bi bakhoul");

            }
        }
    }
}
