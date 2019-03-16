using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleAppClient
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void buttonDeleteProject_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //Program.client
            //var webClient = new WebClient();
            //webClient.QueryString.Add("format", "json");

            //textBoxNameUser.Text = Program.client.response.Content.ReadAsAsync<Сущность>();
        }

        private void buttonEditUser_Click(object sender, EventArgs e)
        {
            Users users = new Users();
            users.Show();
        }

        private void buttonNewTeam_Click(object sender, EventArgs e)
        {
            TeamsForm teamsForm = new TeamsForm();
            teamsForm.Show();
        }
    }
}
