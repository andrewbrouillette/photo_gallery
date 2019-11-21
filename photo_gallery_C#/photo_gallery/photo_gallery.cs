using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace photo_gallery
{
    class photo_gallery
    {
        static void Main(string[] args)
        {
            using (StreamReader r = new StreamReader("./photos.json"))
            {
                Console.Write("Photo Album: ");
                string photoAlbum = Console.ReadLine();
                string json = r.ReadToEnd();
                List<Item> items = JsonConvert.DeserializeObject<List<Item>>(json);
                dynamic array = JsonConvert.DeserializeObject(json);
                foreach (var photo in array)
                {
                    if (photo.albumId == photoAlbum)
                    {
                        Console.WriteLine("[{0}] {1} {2} ", photo.id, photo.title, photo.url);
                    }
                }
            }
        }

        public class Item
        {
            public int albumId;
            public int id;
            public string title;
            public string url;
            public string thumbnailUrl;
        }

    }    
}
