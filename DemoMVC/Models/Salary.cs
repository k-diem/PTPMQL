using System.ComponentModel.DataAnnotations;

public class SalaryModel
{
    [Required(ErrorMessage = "Họ tên không được để trống")]
    public string FullName { get; set; }

    [Required(ErrorMessage = "Lương cơ bản không được để trống")]
    public double BasicSalary { get; set; }

    [Required(ErrorMessage = "Hệ số lương không được để trống")]
    public double SalaryCoefficient { get; set; }

    [Required(ErrorMessage = "Phụ cấp không được để trống")]
    public double Allowance { get; set; }

    public double CalculatedSalary => BasicSalary * SalaryCoefficient + Allowance;
}
