namespace PTPMQL;

public class DaiLy
{
    
    public string SystemName { get; set; }

    public void DisplaySystem()
    {
        Console.WriteLine($"Hệ thống phân phối: {SystemName}");
    }
}

// DaiLy kế thừa HeThongPhanPhoi
public class Daily : HeThongPhanPhoi
{
    public int MaDaiLy { get; set; }
    public string TenDaiLy { get; set; }
    public string DiaChi { get; set; }
    public string NguoiDaiDien { get; set; }
    public string DienThoai { get; set; }
    public string MaTHPP { get; set; }

    public void DisplayDaiLy()
    {
        Console.WriteLine($"Ten: {TenDaiLy}, DiaChi: {DiaChi}, ID: {NguoiDaiDien}, SDT:{DienThoai}, Ma:{MaTHPP}");
    }
}

