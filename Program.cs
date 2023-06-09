namespace ProductReviewManagement;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Product Review Management");

        List<ProductReview> list = new List<ProductReview>()
        {
            new ProductReview() {PoductID=1, UserID=1,Rating=3.2, Review="Fine", IsLike=true},
            new ProductReview() {PoductID=2, UserID=2,Rating=2.9, Review="Bad", IsLike=true},
            new ProductReview() {PoductID=3, UserID=3,Rating=3.3, Review="Good", IsLike=true},
            new ProductReview() {PoductID=4, UserID=4,Rating=3.5, Review="Fine", IsLike=true},
            new ProductReview() {PoductID=5, UserID=5,Rating=4.6, Review="Good", IsLike=false},
            new ProductReview() {PoductID=6, UserID=6,Rating= 4.4, Review="Good", IsLike=true},
            new ProductReview() {PoductID=7, UserID=7,Rating=3.9, Review="Fine", IsLike=false},
            new ProductReview() {PoductID=8, UserID=8,Rating=4.2, Review="Good", IsLike=true},
            new ProductReview() {PoductID=9, UserID=9,Rating=3.3, Review="Worst", IsLike=true},
            new ProductReview() {PoductID=10, UserID=10,Rating=3.2, Review="Fine", IsLike=false},
            new ProductReview() {PoductID=11, UserID=11,Rating=4.6, Review="Best", IsLike=true},
            new ProductReview() {PoductID=12, UserID=12,Rating=5.0, Review="Exellent", IsLike=true},
            new ProductReview() {PoductID=13, UserID=13,Rating=4.4, Review="Best", IsLike=true},
            new ProductReview() {PoductID=14, UserID=14,Rating=3.1, Review="Good", IsLike=true},
            new ProductReview() {PoductID=15, UserID=15,Rating=4.1, Review="fine", IsLike=true},
            new ProductReview() {PoductID=16, UserID=1,Rating=3.2, Review="Fine", IsLike=true},
            new ProductReview() {PoductID=17, UserID=2,Rating=2.9, Review="Bad", IsLike=true},
            new ProductReview() {PoductID=18, UserID=3,Rating=3.3, Review="Good", IsLike=true},
            new ProductReview() {PoductID=19, UserID=4,Rating=3.2, Review="Fine", IsLike=true},
            new ProductReview() {PoductID=20, UserID=5,Rating=4.6, Review="Good", IsLike=false},
            new ProductReview() {PoductID=21, UserID=6,Rating= 4.4, Review="Good", IsLike=true},
            new ProductReview() {PoductID=22, UserID=7,Rating=3.9, Review="Fine", IsLike=false},
            new ProductReview() {PoductID=23, UserID=8,Rating=4.2, Review="Good", IsLike=true},
            new ProductReview() {PoductID=24, UserID=9,Rating=1.5, Review="Worst", IsLike=true},
            new ProductReview() {PoductID=25, UserID=10,Rating=3.2, Review="Fine", IsLike=false},
        };

        bool flag = true;
        while(flag)
        {
            Console.WriteLine("\nSelect options");
            Console.WriteLine("1. Create Product review \n2. Retrieve top 3 data \n3. Select data from the list\n4. Count each review ProductID \n5. Exit");
            int option = Convert.ToInt32 (Console.ReadLine());
            switch(option)
            {
                case 1:
                    foreach (var data in list)
                    {
                        Console.WriteLine("PoductID:" + " " + data.PoductID + " " + "UserID:" + data.UserID + " " + "Rating:" + data.Rating + " " + "Review:" + data.Review + " " + "IsLike:" + data.IsLike);
                    }
                    break;
                case 2:
                    ProductManagement productManagement = new ProductManagement();
                    productManagement.TopRecords(list);
                    break;
                case 3:
                    ProductManagement product = new ProductManagement();
                    product.SelectRecords(list);
                    break;
                case 4:
                    ProductManagement productCount = new ProductManagement();
                    productCount.CountProductID(list);
                    break;
                case 5:
                    flag = false;
                    break;
            }
        }
    }
}
