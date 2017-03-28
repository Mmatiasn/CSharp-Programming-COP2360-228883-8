using CSharp_Programming_COP2360_228883_8.Controls;
using CSharp_Programming_COP2360_228883_8.MaterialDesign;

namespace CSharp_Programming_COP2360_228883_8
{
    public partial class MainForm : MaterialForm
    {
        public MainForm()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void SpeedMph_TextChanged(object sender, System.EventArgs e)
        {
            UserFeedbackLabel.Text = Calculation.SpeedTextChanged(SpeedMph.Text);
        }

        private void TimeTraveled_TextChanged(object sender, System.EventArgs e)
        {
            UserFeedbackLabel.Text = Calculation.TimeTextChanged(TimeTraveled.Text);
        }

        private void ResetButton_Click(object sender, System.EventArgs e)
        {
            UserFeedbackLabel.Text = string.Empty;
            SpeedMph.Text = string.Empty;
            TimeTraveled.Text = string.Empty;
        }
    }
}
