public void LoadJson()
{
using (StreamReader r = new StreamReader("photos.json"))
{
    string json = r.ReadToEnd();
    List<Item> items = JsonConvert.DeserializeObject<List<Item>>(json);
}
}

public class Item
{
    public int millis;
    public string stamp;
    public DateTime datetime;
    public string light;
    public float temp;
    public float vcc;
}

dynamic array = JsonConvert.DeserializeObject(json);
foreach(var item in array)
{
Console.WriteLine("{0} {1}", item.temp, item.vcc);
}