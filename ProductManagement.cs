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
        public void SelectRecords(List<ProductReview> listReview)
        {
            var result = (from productReview in listReview where (productReview.PoductID == 1 || productReview.PoductID == 4 || productReview.PoductID == 9) && productReview.Rating > 3 select productReview);
            foreach (var data in result)
            {
                Console.WriteLine("PoductID:" + data.PoductID + " " + "UserID:" + data.UserID + " " + "Rating:" + data.Rating + "  " + "Review:" + data.Review + " " + "IsLike:" + data.IsLike);
            }
        }
        public void CountProductID(List<ProductReview> listReview)
        {
            var result = listReview.GroupBy(a => a.PoductID).Select(a => new { PoductID = a.Key, Count = a.Count() });
            foreach (var data in result)
            {
                Console.WriteLine("PoductID= " + data.PoductID + " " + "Count= " + data.Count);
            }
        }
        
    }
}
