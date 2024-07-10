namespace APIProjectForTest.Model
{
    public class Author
    {
        [GraphQLName("bookName")]
        public string Name { get; set; }
        public string Publication { get; set; }
    }
}
