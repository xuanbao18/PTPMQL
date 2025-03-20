using System.ComponentModel.DataAnnotations;

namespace PTPMQL;

public class Nhanvien
{
    [Key]
    public string Ma_NV { get; set; }
    public string FullName { get; set; }
    public string Address { get; set; }
}
