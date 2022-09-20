namespace Presentation.Tabs
{
    public partial class MainController : UserControl
    {
        public MainController()
        {
            InitializeComponent();
        }

        private void ButtonBuguri_Click(object sender, EventArgs e)
        {
            var parent = Parent as FormMain;
            parent.SetTabBuguri();
        }

        private void ButtonMesaje_Click(object sender, EventArgs e)
        {
            var parent = Parent as FormMain;
            parent.SetTabMesaje();
        }
    }
}
