namespace Collections8137Demo.Models.Bases
{
    public abstract class KayitBase
    {
        public int Id { get; set; } //= -1; // bu da kalıtımdan dolayı yapılabilir veya constructor üzerinden yapılabilir

        protected KayitBase()
        {
            Id = -1;
        }

        protected KayitBase(int id)
        {
            Id = id;
        }
    }
}
