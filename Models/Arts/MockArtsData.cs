using System.Collections.Generic;

namespace web.Models.Arts
{
    public class MockArtsData
    {
        public List<web.Models.Arts.Art> imgData;
        public void StartMock()
        {
            imgData = new List<web.Models.Arts.Art>
            {
                new web.Models.Arts.Art { NameOfArt = "Rei Ayanami", DateCreationOfArt = "23.06.20", LinkOfArt = "754679221829238814/Screenshot_12.png" },
                new web.Models.Arts.Art { NameOfArt = "Lilith", DateCreationOfArt = "01.05.20 ", LinkOfArt = "754679920982229095/Screenshot_10.png" },
                new web.Models.Arts.Art { NameOfArt = "Naruko", DateCreationOfArt = "17.05.20", LinkOfArt = "754679915344953364/Screenshot_8.png" },
                new web.Models.Arts.Art { NameOfArt = "Zero Two", DateCreationOfArt = " 05.03.20", LinkOfArt = "754679214028095518/Screenshot_82.png" },
                new web.Models.Arts.Art { NameOfArt = "Jane", DateCreationOfArt = "04.04.20", LinkOfArt = "754679910139822201/Screenshot_7.png" },
               // new web.Models.Arts.Art { NameOfArt = "Nero", DateCreationOfArt = "11.03.20", LinkOfArt = "754679219338084402/Screenshot_91.png" }
            };
        }
    }
}
