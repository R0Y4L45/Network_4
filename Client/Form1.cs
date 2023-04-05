using Server;
using System.Net;
using System.Net.Sockets;
using System.Text.Json;

namespace Client;

public partial class Form1 : Form
{
    private TcpClient? _tcpClient = null;
    private NetworkStream? _nS = null;
    private StreamWriter? _sw = null;
    private StreamReader? _sr = null;
    private List<Car>? _cars = null;

    public Form1()
    {
        InitializeComponent();

        listView1.View = View.Details;
        listView1.Columns.Add("Id");
        listView1.Columns.Add("Make");
        listView1.Columns.Add("Model");
        listView1.Columns.Add("Year");
        listView1.Columns.Add("Vin");
        listView1.Columns.Add("Color");
        listView1.MultiSelect = false;

        ClientConnect();
    }
    public void ClientConnect()
    {
        _tcpClient = new TcpClient();
        _tcpClient.Connect(IPAddress.Parse("127.0.0.1"), 12345);
        _nS = _tcpClient.GetStream();
        _sr = new StreamReader(_nS);
        _sw = new StreamWriter(_nS);
        _sw.AutoFlush = true;
    }
    public void GetAllCars()
    {
        if (_nS != null && _sw != null && _sr != null)
        {
            listView1.Items.Clear();

            string request = JsonSerializer.Serialize(new Command()
            {
                Method = HttpMethods.Get
            });

            _sw.WriteLine(request);
            string? response = _sr.ReadLine();
            if (response != null)
                _cars = JsonSerializer.Deserialize<List<Car>>(response);


            if (_cars != null)
                for (int i = 0; i < _cars.Count; i++)
                {
                    ListViewItem l = new ListViewItem(_cars[i].Id.ToString());
                    l.SubItems.Add(_cars[i].Make);
                    l.SubItems.Add(_cars[i].Model);
                    l.SubItems.Add(_cars[i].Year.ToString());
                    l.SubItems.Add(_cars[i].Vin);
                    l.SubItems.Add(_cars[i].Color);

                    listView1.Items.Add(l);
                }
        }
    }
    public void DeleteSelectedCar()
    {
        try
        {
            string? id = listView1.SelectedItems[0].Text;

            if (_nS != null && _sw != null && _sr != null && id != null)
            {
                string request = JsonSerializer.Serialize(new Command()
                {
                    Car = new Car()
                    {
                        Id = int.Parse(id)
                    },

                    Method = HttpMethods.Delete
                });

                _sw.WriteLine(request);
                string? response = _sr.ReadLine();
                if (response != null)
                {
                    bool isCompleted = bool.Parse(response);
                    if (isCompleted)
                    {
                        MessageBox.Show("The operation was completed");
                        GetAllCars();
                    }
                    else
                        MessageBox.Show("The operation was not completed");
                }
                else
                    MessageBox.Show("The operation was not completed");
            }
        }
        catch (Exception)
        {
            MessageBox.Show("You didn't choice car...");
        }
    }
    public void AddCar(object? sender, Car? car)
    {
        if (car != null && _nS != null && _sw != null && _sr != null)
        {
            string request = JsonSerializer.Serialize(new Command()
            {
                Car = car,

                Method = HttpMethods.Post
            });

            _sw.WriteLine(request);
            string? response = _sr.ReadLine();
            if (response != null)
            {
                bool isCompleted = bool.Parse(response);
                if (isCompleted)
                {
                    MessageBox.Show("The operation was completed");
                    GetAllCars();
                }
                else
                    MessageBox.Show("The operation was not completed");
            }
            else
                MessageBox.Show("The operation was not completed");
        }
    }
    public void UpdateCar(object? sender, Car? car)
    {
        try
        {
            string? id = listView1.SelectedItems[0].Text;

            if (id != null && car != null && _nS != null && _sw != null && _sr != null)
            {
                car.Id = int.Parse(id);

                string request = JsonSerializer.Serialize(new Command()
                {
                    Car = car,

                    Method = HttpMethods.Put
                });

                _sw.WriteLine(request);
                string? response = _sr.ReadLine();

                if (response != null)
                {
                    bool isCompleted = bool.Parse(response);
                    if (isCompleted)
                    {
                        MessageBox.Show("The operation was completed");
                        GetAllCars();
                    }
                    else
                        MessageBox.Show("The operation was not completed");
                }
                else
                    MessageBox.Show("The operation was not completed");
            }
        }
        catch (Exception)
        {
            MessageBox.Show("You didn't choice car...");
        }
    }

    private void button_Click(object sender, EventArgs e)
    {
        Button? btn = sender as Button;

        if (btn == btnGet)
            GetAllCars();
        else if (btn == btnDel)
            DeleteSelectedCar();
        else if (btn == btnAdd)
        {
            SmallWindow smallWindow = new SmallWindow();
            smallWindow.Show();

            smallWindow.DataSent += AddCar;
        }
        else if (btn == btnUpdate)
        {
            SmallWindow2 smallWindow2 = new SmallWindow2();
            smallWindow2.Show();

            smallWindow2.DataSent += UpdateCar;
        }
    }

    private void Form1_FormClosed(object sender, FormClosedEventArgs e)
    {
        if (_nS != null && _sw != null && _sr != null)
        {
            _nS.Dispose();
            _sw.Dispose();
            _sr.Dispose();
        }
    }
}