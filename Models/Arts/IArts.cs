namespace web.Models
{
    interface IArts
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string LinkOfArt { get; set; }
    }
}
