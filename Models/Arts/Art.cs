namespace web.Models.Arts
{
    public class Art : IArts
    {
        public int Id { get; set; }
        public string NameOfArt { get; set; }
        public string LinkOfArt { get; set; }
        public string DateCreationOfArt { get; set; }
    }
}
