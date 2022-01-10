using Microsoft.AspNetCore.Components.Forms;
using System.ComponentModel.DataAnnotations;

namespace TimesheetCollector.Data
{
    public record FileUpload
    {
        [Required]
        public string Project { get; set; } = default!;

        [Required]
        public IBrowserFile File { get; set; } = default!;
    }
}