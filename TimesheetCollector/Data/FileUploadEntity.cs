using System.ComponentModel.DataAnnotations;

namespace TimesheetCollector.Data
{
    public class FileUploadEntity
    {
        [Key]
        public Guid ID { get; set; }
        public string Project { get; set; } = default!;
        public string Bucket { get; set; } = default!;
        public string Object { get; set; } = default!;
    }
}
