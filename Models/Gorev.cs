namespace GunlukGorevApp.Models
{
    public class Gorev
    {
        public int Id { get; set; }
        public string Baslik { get; set; } = string.Empty;
        public bool TamamlandiMi { get; set; } = false;
        public DateTime OlusturmaTarihi { get; set; } = DateTime.Now;
    }
}