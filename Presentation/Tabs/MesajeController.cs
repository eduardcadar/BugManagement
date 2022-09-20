using BugApplication.Services;
using Domain.Entities;

namespace Presentation.Tabs
{
    public partial class MesajeController : UserControl
    {
        private ServiceAngajat _serviceAngajat;
        private ServiceMesaj _serviceMesaj;
        public MesajeController()
        {
            InitializeComponent();

            dataGridViewAngajati.Columns.Add("angajat", "Angajat");
            dataGridViewAngajati.Columns["angajat"].Visible = false;
            dataGridViewAngajati.Columns.Add("username", "Username");

            dataGridViewMesaje.Columns.Add("mesaj", "Mesaj");
            dataGridViewMesaje.Columns["mesaj"].Visible = false;
            dataGridViewMesaje.Columns.Add("sender", "Trimis de");
            dataGridViewMesaje.Columns.Add("text", "Text");
            dataGridViewMesaje.Columns.Add("sentAt", "Trimis la");
        }

        public async void Initialize()
        {
            await ReloadEmployees();
        }

        private async Task ReloadEmployees()
        {
            dataGridViewAngajati.Rows.Clear();
            foreach (var angajat in await _serviceAngajat.GetAllEmployees())
                if (angajat.Id != (Parent as FormMain).Angajat.Id)
                    dataGridViewAngajati.Rows.Add(angajat, angajat.Username);
        }

        private async Task ReloadMessages()
        {
            var cells = dataGridViewAngajati.SelectedCells;
            if (cells.Count < 1) return;
            var rowIndex = cells[0].RowIndex;
            var row = dataGridViewAngajati.Rows[rowIndex];
            Angajat? ang1 = row.Cells["angajat"].Value as Angajat;
            if (ang1 == null) return;
            var ang2 = (Parent as FormMain).Angajat;

            var mesaje = await _serviceMesaj.GetMesajeBetween(ang1, ang2);
            dataGridViewMesaje.Rows.Clear();
            foreach (var mesaj in mesaje.OrderBy(m => m.SentAt))
                dataGridViewMesaje.Rows.Add(mesaj, mesaj.Sender.Username, mesaj.Text, mesaj.SentAt);
        }

        public void SetService(ServiceAngajat serviceAngajat, ServiceMesaj serviceMesaj)
        {
            _serviceAngajat = serviceAngajat;
            _serviceMesaj = serviceMesaj;
        }

        public void ButtonBack_Click(object sender, EventArgs e)
        {
            var parent = Parent as FormMain;
            parent.SetTabMain();
        }

        public void DataGridViewAngajati_SelectionChanged(object sender, EventArgs e)
        {
            ReloadMessages();
        }

        public async void ButtonTrimiteMesaj_Click(object sender, EventArgs e)
        {
            var cells = dataGridViewAngajati.SelectedCells;
            if (cells.Count < 1)
                MessageBox.Show("Selecteaza un angajat");
            else
            {
                var rowIndex = cells[0].RowIndex;
                var row = dataGridViewAngajati.Rows[rowIndex];
                Angajat? msgReceiver = row.Cells["angajat"].Value as Angajat;
                if (msgReceiver == null) return;
                var msgSender = (Parent as FormMain).Angajat;
                var text = textBoxMesaj.Text;
                if (string.IsNullOrWhiteSpace(text))
                    MessageBox.Show("Introdu un mesaj");
                else
                {
                    await _serviceMesaj.AddMesaj(msgSender, msgReceiver, text, DateTime.Now);
                    textBoxMesaj.Clear();
                    ReloadMessages();
                }
            }
        }
    }
}
