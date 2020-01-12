namespace shopMVC.Model
{
    public class OrderPosition
    {
        public int OrderPositionId { get; set; }
        public int OrderId { get; set; }
        public int CourseId { get; set; }
        public int Amount { get; set; }
        public decimal Total { get; set; }

        public virtual Course course { get; set; }
        public virtual Order order { get; set; }
    }
}