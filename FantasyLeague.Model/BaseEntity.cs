

namespace FantasyLeague.Model;

public class BaseEntity
{
        public string? Id { get; set; } = Guid.NewGuid().ToString();

        public bool IsDeleted { get; set; }

        public DateTime CreationDate { get; set; } = DateTime.Now;

        public DateTime UpdatedAt { get; set; } = DateTime.Now;
}
