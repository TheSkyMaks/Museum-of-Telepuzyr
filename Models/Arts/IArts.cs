﻿namespace web.Models
{
    interface IArts
    {
        public int Id { get; set; }
        public string NameOfArt { get; set; }
        public string LinkOfArt { get; set; }
        public string DateCreationOfArt { get; set; }
    }
}
