
namespace AdminTemplate.Models.Models.Entities.Abstracts
{
    public abstract partial class BaseEntity<T> where T : IEquatable<T>
    {
        public T Id { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
        public string CreatedUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdatedUser { get; set; }

    }
}
