using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LiveShow.Dal.Models
{
    // Alternatively, this class could be called Relationship.
    public class Following
    {
        [Key]
        [Column(Order = 1)]
        public long FollowerId { get; set; }

        [Key]
        [Column(Order = 2)]
        public long FolloweeId { get; set; }

        public User Follower { get; set; }

        public User Followee { get; set; }
    }
}