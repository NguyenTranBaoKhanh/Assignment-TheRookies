using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BKShop.ViewModels.ViewModels
{
    public class ReviewViewModel
    {
        public int Id { get; set; }
        public Guid UserId { get; set; }
        public string UserName { get; set; }
        public string Name { get; set; }
        public int ProductId { get; set; }
        public string Comment { get; set; }
        [Range(1, 5)]
        public int Star { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public DateTime? DateDeleted { get; set; }
    }
}
