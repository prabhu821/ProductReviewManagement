using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewMangement
{
    public class ProductReview
    {
        public int ProductId { get; set; }
        public int userId { get; set; }
        public int Rating { get; set; }
        public string Review { get; set; }
        public bool IsLike { get; set; }
    }
}
