namespace Test2_Zkusebny.Models
{
    public class RegistraceUzivatel
    {
        public string Jmeno { get; set; } = "";
        public string Email { get; set; } = "";
        public DateTime DatumRegistrace { get; set; } = DateTime.Now;
        public decimal Vlozne { get; set; }
        public int StavZaplaceni { get; set; }
    }


    public enum StavZaplaceni
    {
        Nezaplaceno = 0,
        Zaplaceno = 1,
        Zruseno = 2
    }
}
