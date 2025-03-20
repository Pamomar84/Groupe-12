using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Groupe12Exam
{
    public partial class ConnectForm : Form
    {
        public ConnectForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
        }
        public string phone { get; set; }
        public string mdp { get; set; }
        public string GenererCode(Utilisateurs User)
        {
            Random random = new Random();
            string code = random.Next(100000, 999999).ToString();
            OTPCodes otpCode = new OTPCodes();
            otpCode.Code = code;
            otpCode.IdUtilisateur = User.Id;
            otpCode.DateExpiration = DateTime.Now.AddMinutes(15);
            using (var db = new DbScolaire())
            {
                db.TOTPCodes.Add(otpCode);
                db.SaveChanges();
            }

            return code;
        }
        public void refresh()
        {
            textBox1.Text = "+221";
        }
        public string HashPassword(string password)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // Convertir le mot de passe en tableau de bytes
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));

                // Convertir les bytes en chaîne hexadécimale
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));  // Format hexadécimal
                }

                return builder.ToString();
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            TwilioServices twilioService = new TwilioServices();

            using (var db = new DbScolaire())
            {
                phone = textBox1.Text;
                mdp = HashPassword(textBox2.Text);
                var user = db.TUtilisateurs.FirstOrDefault(p => p.Telephone == phone && p.MotDePasse == mdp);
                if (user != null)
                {
                    twilioService.SendSms(user.Telephone, GenererCode(user));
                    
                    LoginForm loginForm = new LoginForm();
                    loginForm.Show();
                    loginForm.GetIt(user);
                    loginForm.MdiParent = this.MdiParent;
                    this.Hide();




                }

                else MessageBox.Show("Echec de la connexion");
            }
        }

        private void ConnectForm_Load(object sender, EventArgs e)
        {
            refresh();
        }
    }
}
