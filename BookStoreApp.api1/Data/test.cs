namespace BookStoreApp.api1.Data
{
    public partial class test
    {
        public int Id { get; set; }

        public int? Date { get; set; }

        public int? Time { get; set; }

        public virtual ICollection<Book> Books { get; } = new List<Book>();
    }
}
