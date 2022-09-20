using BugApplication.Services;
using Domain.Entities;

namespace Presentation.Tabs
{
    public partial class BuguriController : UserControl
    {
        private ServiceBug _serviceBug;
        private ServicePasBug _servicePasBug;
        public BuguriController()
        {
            InitializeComponent();

            textBoxDescription.ReadOnly = true;
            dataGridViewBuguri.Columns.Add("bug", "Bug");
            dataGridViewBuguri.Columns["bug"].Visible = false;
            dataGridViewBuguri.Columns.Add("id", "Id");
            dataGridViewBuguri.Columns["id"].Visible = false;
            dataGridViewBuguri.Columns.Add("description", "Descriere");
            dataGridViewBuguri.Columns.Add("status", "Status");

            dataGridViewPasi.Columns.Add("pasBug", "Pas bug");
            dataGridViewPasi.Columns["pasBug"].Visible = false;
            dataGridViewPasi.Columns.Add("pasNumber", "Numar pas");
            dataGridViewPasi.Columns["pasNumber"].Visible = false;
            dataGridViewPasi.Columns.Add("description", "Descriere");
        }

        public async void Initialize()
        {
            await ReloadBugs();
        }

        public void SetService(ServiceBug serviceBug, ServicePasBug servicePasBug)
        {
            _serviceBug = serviceBug;
            _servicePasBug = servicePasBug;
        }

        private async Task ReloadBugs()
        {
            dataGridViewBuguri.Rows.Clear();
            foreach (var bug in await _serviceBug.GetAllBugs())
                dataGridViewBuguri.Rows.Add(bug, bug.Id, bug.Description, bug.Status);
        }

        private async Task ReloadPasiBug()
        {
            var cells = dataGridViewBuguri.SelectedCells;
            if (cells.Count < 1) return;
            var rowIndex = cells[0].RowIndex;
            var row = dataGridViewBuguri.Rows[rowIndex];
            Bug? bug = row.Cells["bug"].Value as Bug;
            if (bug == null) return;

            dataGridViewPasi.Rows.Clear();
            foreach (var pasBug in await _servicePasBug.GetPasiBug(bug))
                dataGridViewPasi.Rows.Add(pasBug, pasBug.PasNumber, pasBug.Description);
        }

        private void InitializeForProgramator()
        {
            panelVerificator.Hide();
            panelProgramator.Show();
            comboBoxStatus.Enabled = false;
        }

        private void InitializeForVerificator()
        {
            panelProgramator.Hide();
            panelVerificator.Show();
            comboBoxStatus.Enabled = true;
        }

        public void SetAngajat(Angajat angajat)
        {
            if (angajat.IsTester)
                InitializeForVerificator();
            else
                InitializeForProgramator();
        }

        public void ButtonBack_Click(object sender, EventArgs e)
        {
            var parent = Parent as FormMain;
            parent.SetTabMain();
        }

        public async void ButtonVerificaBug_Click(object sender, EventArgs e)
        {
            var cells = dataGridViewBuguri.SelectedCells;
            if (cells.Count < 1)
                MessageBox.Show("Selecteaza un bug");
            else
            {
                var rowIndex = cells[0].RowIndex;
                var row = dataGridViewBuguri.Rows[rowIndex];
                Bug? bug = row.Cells["bug"].Value as Bug;
                if (bug == null) return;
                if (bug.Status.Equals(BugStatus.REZOLVAT))
                {
                    bug.Status = BugStatus.VERIFICAT;
                    await _serviceBug.UpdateBug(bug);
                    await ReloadBugs();
                }
                else
                    MessageBox.Show("Bug-ul nu are statusul REZOLVAT");
            }
        }

        public async void ButtonRezolvaBug_Click(object sender, EventArgs e)
        {
            var cells = dataGridViewBuguri.SelectedCells;
            if (cells.Count < 1)
                MessageBox.Show("Selecteaza un bug");
            else
            {
                var rowIndex = cells[0].RowIndex;
                var row = dataGridViewBuguri.Rows[rowIndex];
                Bug? bug = row.Cells["bug"].Value as Bug;
                if (bug == null) return;
                if (bug.Status.Equals(BugStatus.ADAUGAT))
                {
                    bug.Status = BugStatus.REZOLVAT;
                    await _serviceBug.UpdateBug(bug);
                    await ReloadBugs();
                }
                else
                    MessageBox.Show("Bug-ul nu are statusul ADAUGAT");
            }
        }

        public async void ButtonInregistrareBug_Click(object sender, EventArgs e)
        {
            string description = textBoxTester.Text;
            if (string.IsNullOrWhiteSpace(description))
                MessageBox.Show("Introdu descrierea bug-ului");
            else
            {
                await _serviceBug.AddBug(description);
                textBoxTester.Clear();
                await ReloadBugs();
            }
        }

        public void DataGridViewBuguri_SelectionChanged(object sender, EventArgs e)
        {
            var cells = dataGridViewBuguri.SelectedCells;
            if (cells.Count == 0) return;
            var rowIndex = cells[0].RowIndex;
            var row = dataGridViewBuguri.Rows[rowIndex];
            Bug? bug = row.Cells["bug"].Value as Bug;
            if (bug == null) return;
            comboBoxStatus.Text = bug.Status.ToString();
            textBoxDescription.Text = bug.Description;
            textBoxReview.Text = bug.Review;
            ReloadPasiBug();
        }

        public async void ComboBoxStatus_StatusChanged(object sender, EventArgs e)
        {
            // change status (for tester)
            var newStatus = comboBoxStatus.SelectedItem;
            if (newStatus == null) return;
            var cells = dataGridViewBuguri.SelectedCells;
            if (cells.Count == 0) return;
            var rowIndex = cells[0].RowIndex;
            var row = dataGridViewBuguri.Rows[rowIndex];
            Bug? bug = row.Cells["bug"].Value as Bug;
            if (bug == null) return;
            bug.Status = (BugStatus)Enum.Parse(typeof(BugStatus), newStatus.ToString());
            await _serviceBug.UpdateBug(bug);
            await ReloadBugs();
        }

        public async void ButtonReview_Click(object sender, EventArgs e)
        {
            var cells = dataGridViewBuguri.SelectedCells;
            if (cells.Count < 1)
                MessageBox.Show("Selecteaza un bug");
            else
            {
                var rowIndex = cells[0].RowIndex;
                var row = dataGridViewBuguri.Rows[rowIndex];
                Bug? bug = row.Cells["bug"].Value as Bug;
                if (bug == null) return;
                var bugStatus = bug.Status;
                if (bugStatus.Equals(BugStatus.REZOLVAT))
                {
                    string review = textBoxReview.Text;
                    bug.Review = review;
                    await _serviceBug.UpdateBug(bug);
                    await ReloadBugs();
                    MessageBox.Show("Review-ul a fost modificat");
                }
                else
                    MessageBox.Show("Bug-ul nu are statusul REZOLVAT");
            }
        }

        public async void ButtonAdaugaPas_Click(object sender, EventArgs e)
        {
            var cells = dataGridViewBuguri.SelectedCells;
            if (cells.Count < 1)
                MessageBox.Show("Selecteaza un bug");
            else
            {
                var rowIndex = cells[0].RowIndex;
                var row = dataGridViewBuguri.Rows[rowIndex];
                Bug? bug = row.Cells["bug"].Value as Bug;
                if (bug == null) return;
                var pasNumber = dataGridViewPasi.Rows.Count;
                var description = textBoxTester.Text;
                if (string.IsNullOrWhiteSpace(description))
                    MessageBox.Show("Introdu descrierea bug-ului");
                else
                {
                    await _servicePasBug.AddPasBug(bug, pasNumber, description);
                    ReloadPasiBug();
                    textBoxTester.Clear();
                }
            }
        }

        public async void ButtonStergePas_Click(object sender, EventArgs e)
        {
            var cells = dataGridViewPasi.SelectedCells;
            if (cells.Count < 1)
                MessageBox.Show("Selecteaza un pas al bug-ului");
            else
            {
                var rowIndex = cells[0].RowIndex;
                var row = dataGridViewPasi.Rows[rowIndex];
                PasBug? pasBug = row.Cells["pasBug"].Value as PasBug;
                if (pasBug == null) return;
                await _servicePasBug.DeletePasBug(pasBug.Bug, pasBug.PasNumber);
                ReloadPasiBug();
            }
        }

        public async void ButtonModificaPas_Click(object sender, EventArgs e)
        {
            var cells = dataGridViewPasi.SelectedCells;
            if (cells.Count < 1)
                MessageBox.Show("Selecteaza un pas al bug-ului");
            else
            {
                var rowIndex = cells[0].RowIndex;
                var row = dataGridViewPasi.Rows[rowIndex];
                PasBug? pasBug = row.Cells["pasBug"].Value as PasBug;
                if (pasBug == null) return;
                string description = textBoxTester.Text;
                if (string.IsNullOrWhiteSpace(description))
                    MessageBox.Show("Introdu descrierea bug-ului");
                else
                {
                    pasBug.Description = description;
                    await _servicePasBug.UpdatePasBug(pasBug);
                    ReloadPasiBug();
                    textBoxTester.Clear();
                }
            }
        }
    }
}
