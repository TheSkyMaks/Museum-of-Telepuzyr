using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace web.Models.News
{
    public class MockNewsData
    {
        public List<News> imgData;
        public void StartMockNews()
        {
            imgData = new List<News>
            {
                new News { NameOfNews = "Artoria Pendragon (lineart)", DateCreationOfNews = "25.12.20", LinkOfNews = "791829245520248852/deb0q3w-59b5f3a9-2361-4896-ab07-122432d27b1e.png" },
                new News { NameOfNews = "Jean (lineart)", DateCreationOfNews = "12.12.20", LinkOfNews = "791829447795933224/Jean_2.png" },
                new News { NameOfNews = "Noelle (line art)", DateCreationOfNews = "01.11.20", LinkOfNews = "791829745758765056/noelle__line_art__by_vitanator_de7xdij-fullview.jpg" },
            };
        }
    }
}
