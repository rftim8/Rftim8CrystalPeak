using System.ComponentModel.DataAnnotations.Schema;

namespace Rftim8Atlas.Models.CP
{
    public class CPModel
    {
        public long Id { get; set; }

        public string? Competition { get; set; }

        public DateTime Timestamp { get; set; }

        public int Rank { get; set; }

        public int Rating { get; set; }

        public string? Problem { get; set; }

        public string? Description { get; set; }
        
        public string? Solution { get; set; }

        public string? Input { get; set; }
        
        public string? Output { get; set; }

        public int Difficulty { get; set; }

        public bool TestStatus { get; set; }

        [Column(TypeName = "decimal(6,2)")]
        public double Runtime { get; set; }

        [Column(TypeName = "decimal(6,2)")]
        public double Memory { get; set; }

        public string? Algorithms { get; set; }

        public string? FilePath { get; set; }
    }
}
