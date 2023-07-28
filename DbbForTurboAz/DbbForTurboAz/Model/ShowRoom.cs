namespace DbbForTurboAz.Model
{
    public class ShowRoom
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Address { get; set; }
        public string PhoneNumber  { get; set; }
        public ICollection<Car> Cars { get; set; }
    }
}
