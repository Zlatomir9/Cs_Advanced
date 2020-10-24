namespace Threeuple
{
    public class Threeuple<Tfirst, Tsecond, Tthird>
    {
        public Threeuple(Tfirst firstItem, Tsecond secondItem, Tthird thirdItem)
        {
            FirstItem = firstItem;
            SecondItem = secondItem;
            ThirdItem = thirdItem;
        }

        public Tfirst FirstItem { get; set; }
        public Tsecond SecondItem { get; set; }
        public Tthird ThirdItem { get; set; }

        public override string ToString()
        {
            return $"{FirstItem} -> {SecondItem} -> {ThirdItem}";
        }
    }
}
