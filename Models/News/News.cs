﻿namespace web.Models.News
{
    public class News : INews
    {
        public int Id { get; set; }
        public string NameOfNews { get; set; }
        public string DescriptionOfNews { get; set; }
        public string LinkOfNews { get; set; }
        public string DateCreationOfNews { get; set; }
    }
}
