using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManagement
{
    public class ProductManagement
    {
        public void TopRecords(List<ProductReview> listReview)
        {
            var Top3Records = (from productReview in listReview orderby productReview.Rating descending select productReview).Take(3);

            foreach (var data in Top3Records)
            {
                Console.WriteLine("PoductID:" + data.PoductID + " " + "UserID" + data.UserID + " " + "Rating:" + data.Rating + "  " + "Review:" + data.Review + " " + "IsLike:" + data.IsLike);
            }
        }
    }
}
