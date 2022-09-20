using BugApplication.Services;
using Domain.Entities;

namespace Presentation.Tabs
{
    public partial class FormMain : Form
    {
        private UserControl currentView;
        public Angajat Angajat { get; set; }
        public Programator Programator => Angajat as Programator;
        public Verificator Verificator => Angajat as Verificator;
        public FormMain(ServiceAngajat serviceAngajat, ServiceBug serviceBug,
            ServicePasBug servicePasBug, ServiceMesaj serviceMesaj)
        {
            InitializeComponent();
            InitializeViewsServices(
                serviceAngajat, serviceBug, servicePasBug, serviceMesaj);
            viewLogin.Show();
            viewMain.Hide();
            viewBuguri.Hide();
            viewMesaje.Hide();
            currentView = viewLogin;
            labelAngajat.Visible = false;
        }

        private void SetLabelAngajat()
        {
            string text;
            if (Angajat.IsTester)
                text = "Verificator logat: " + Angajat.Username;
            else
                text = "Programator logat: " + Angajat.Username;
            labelAngajat.Text = text;
            labelAngajat.Visible = true;
        }

        private void InitializeViewsServices(
            ServiceAngajat serviceAngajat, ServiceBug serviceBug,
            ServicePasBug servicePasBug, ServiceMesaj serviceMesaj)
        {
            viewLogin.SetService(serviceAngajat);
            viewBuguri.SetService(serviceBug, servicePasBug);
            viewMesaje.SetService(serviceAngajat, serviceMesaj);
        }

        public void SetAngajat(Angajat angajat)
        {
            Angajat = angajat;
            SetLabelAngajat();
            viewBuguri.SetAngajat(angajat);
        }
        public void SetTabMain()
        {
            currentView.Hide();
            currentView = viewMain;
            currentView.Show();
        }
        public void SetTabLogin()
        {
            currentView.Hide();
            currentView = viewLogin;
            currentView.Show();
        }
        public void SetTabBuguri()
        {
            currentView.Hide();
            currentView = viewBuguri;
            viewBuguri.Initialize();
            currentView.Show();
        }
        public void SetTabMesaje()
        {
            currentView.Hide();
            currentView = viewMesaje;
            viewMesaje.Initialize();
            currentView.Show();
        }
    }
}
