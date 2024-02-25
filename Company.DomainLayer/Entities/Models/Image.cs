namespace Company.Domain.Entities.Models
{
    public class Image
    {
        public int Id { get; set; }
        public string FileName { get; set; }
        public string Path { get; set; }
        public long Lenth { get; set; }
        public string ContentType { get; set; }
    }
}
