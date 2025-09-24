using System.ComponentModel.DataAnnotations.Schema;

namespace Rftim8Atlas.Models.CP
{
    public class CPModel
    {
        public long Id { get; set; }

        public string? Competition { get; set; }

        public DateTime Timestamp { get; set; } = DateTime.Now;

        public int Rank { get; set; }

        public int Rating { get; set; }

        public string? Problem { get; set; }

        public string? Description { get; set; }

        public string? Input { get; set; }
        public string? Output { get; set; }

        public int Difficulty { get; set; }

        public bool TestStatus { get; set; }

        [Column(TypeName = "decimal(6,2)")]
        public decimal Runtime { get; set; }

        [Column(TypeName = "decimal(6,2)")]
        public decimal Memory { get; set; }

        public List<string>? Algorithms { get; set; }

        public string? FilePath { get; set; }
    }
}
