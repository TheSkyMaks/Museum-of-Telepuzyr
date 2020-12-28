namespace web.Models.News
{
    interface INews
    {
        public string Id { get; set; }
        public string NameOfNews { get; set; }
        public string DescriptionOfNews { get; set; }
        public string LinkOfNews { get; set; }
        public string LinkOfArt { get; set; }
        public string DateCreationOfNews { get; set; }
    }
}
