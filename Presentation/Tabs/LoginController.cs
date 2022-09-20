using BugApplication.Services;

namespace Presentation.Tabs
{
    public partial class LoginController : UserControl
    {
        private ServiceAngajat _serviceAngajat;
        public LoginController()
        {
            InitializeComponent();
        }

        public void SetService(ServiceAngajat serviceAngajat)
        {
            _serviceAngajat = serviceAngajat;
        }

        private async void ButtonLogin_Click(object sender, EventArgs e)
        {
            var username = textBoxUsername.Text;
            var password = textBoxPassword.Text;
            if (EmptyCredentials(username, password))
            {
                MessageBox.Show("Introduceti username si parola");
                return;
            }
            var angajat = await _serviceAngajat.GetAngajatByUsernameAndPassword(username, password);
            if (angajat == null)
            {
                MessageBox.Show("Username sau parola gresita");
                return;
            }

            var parent = Parent as FormMain;
            parent.SetAngajat(angajat);
            parent.SetTabMain();
        }

        private bool EmptyCredentials(string username, string password)
            => string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password);
    }
}
