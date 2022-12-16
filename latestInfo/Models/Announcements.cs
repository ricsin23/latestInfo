using System.ComponentModel.DataAnnotations;

namespace latestInfo.Models
{
    public class Announcements
    {
        [Key]
        public int Id { get; set; }
        public string AnnouncementUrl { get; set; }
        public string AnnouncementName { get; set; }

    }
}
