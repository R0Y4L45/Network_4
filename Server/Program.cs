using Server;
using System.Net;
using System.Net.Sockets;
using System.Text.Json;

List<Car> cars = new List<Car>();
string path = Directory.GetCurrentDirectory();
path = Path.Combine(path.Remove(path.IndexOf("\\bin\\Debug\\net6.0")), "CarsJson.json");

IPAddress ip = IPAddress.Parse("127.0.0.1");
int port = 12345;

TcpListener tcplistner = new TcpListener(ip, port);
tcplistner.Start();

var client = tcplistner.AcceptTcpClient();
Console.WriteLine($"Client {client.Client.RemoteEndPoint} accepted.");
NetworkStream stream = client.GetStream();
StreamReader? sr = new StreamReader(stream);
StreamWriter? sw = new StreamWriter(stream);
sw.AutoFlush = true;

string? jsonStr, response;

if (File.Exists(path))
{
    List<Car> fakedatas = JsonSerializer.Deserialize<List<Car>>(File.ReadAllText(path))!;
    cars = fakedatas;
}
else
    throw new Exception("not found path");

bool Delete(int id)
{
    if (cars.Count > 0)
        for (int i = 0; i < cars.Count; i++)
            if (id == cars[i].Id)
            {
                if (cars.Remove(cars[i]))
                    return true;
                else
                    return false;
            }

    return false;
}

bool Update(Car? car)
{
    if (car != null)
    {
        if (cars.Count > 0)
            for (int i = 0; i < cars.Count; i++)
                if (car.Id == cars[i].Id)
                {
                    cars[i].Make = car.Make;
                    cars[i].Model = car.Model;
                    cars[i].Year = car.Year;
                    cars[i].Vin = car.Vin;
                    cars[i].Color = car.Color;

                    return true;
                }

        return false;
    }

    return false;
}

try
{
    while (true)
    {
        jsonStr = sr.ReadLine();
        Command? command = JsonSerializer.Deserialize<Command>(jsonStr!);
        Console.WriteLine(command?.Method);

        if (command is null) continue;

        switch (command.Method)
        {
            case HttpMethods.Get:
                response = JsonSerializer.Serialize(cars);
                sw.WriteLine(response);

                break;
            case HttpMethods.Post:
                if (command.Car is not null)
                {
                    command.Car.Id = cars.Last().Id + 1;
                    cars.Add(command.Car);
                    string carString = JsonSerializer.Serialize<List<Car>>(cars);
                    File.WriteAllText(path, carString);
                    sw.WriteLine(true);
                }
                else
                    sw.WriteLine(false);

                break;
            case HttpMethods.Delete:
                if (command.Car is not null)
                {
                    bool isCompleted = Delete(command.Car.Id);
                    if (isCompleted)
                    {
                        string carString = JsonSerializer.Serialize<List<Car>>(cars);
                        File.WriteAllText(path, carString);
                        sw.WriteLine(isCompleted);
                    }
                    else
                        sw.WriteLine(false);
                }
                else sw.WriteLine(false);

                break;
            case HttpMethods.Put:
                if (command.Car is not null)
                {
                    if (Update(command.Car))
                    {
                        string carString = JsonSerializer.Serialize<List<Car>>(cars);
                        File.WriteAllText(path, carString);
                        sw.WriteLine(true);
                    }
                    else
                        sw.WriteLine(false);
                }
                else sw.WriteLine(false);

                break;
            default:
                break;
        }

    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
finally
{
    stream.Dispose();
    sw.Dispose();
    sr.Dispose();
}
