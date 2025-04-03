namespace TinhDiemMonHoc.Models
{
    public class DiemMonHoc
    {
        public double DiemA { get; set; }
        public double DiemB { get; set; }
        public double DiemC { get; set; }

        public double TinhDiemTong()
        {
            return (DiemA * 0.3) + (DiemB * 0.3) + (DiemC * 0.4);
        }
    }
}
