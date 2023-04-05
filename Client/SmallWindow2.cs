using Server;
using System.Data;

namespace Client;

public partial class SmallWindow2 : Form
{
    private ushort _year;
    public event EventHandler<Car>? DataSent;
    public SmallWindow2()
    {
        InitializeComponent();
    }

    public bool TextBoxChecker()
    {
        if (txtMake.Text == string.Empty)
            return false;
        else if (txtModel.Text == string.Empty)
            return false;
        else if (txtYear.Text == string.Empty)
            return false;
        else if (txtVin.Text == string.Empty)
            return false;
        else if (txtColor.Text == string.Empty)
            return false;

        if (ushort.TryParse(txtYear.Text, out _year))
            return true;
        else
            return false;
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
        if (TextBoxChecker())
        {
            Car c = new Car()
            {
                Color = txtColor.Text,
                Make = txtMake.Text,
                Model = txtModel.Text,
                Vin = txtVin.Text,
                Year = _year
            };

            DataSent?.Invoke(sender, c);
            Close();
        }
        else
            MessageBox.Show("Wrong info or empty fields error. Please check and try again...");
    }
}
