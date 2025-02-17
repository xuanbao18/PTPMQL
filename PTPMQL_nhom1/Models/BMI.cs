namespace PTPMQL;

public class BMI
{
    public string Gender { get; set; }
    public double Height { get; set; } 
    public double Weight { get; set; } 

    public double CalculateBMI()
    {
        if (Height <= 0)
        {
            throw new ArgumentException("Chiều cao phải lớn hơn 0");
        }
        return Math.Round(Weight / (Height * Height), 2);
    }

    public string ClassifyBMI()
    {
        double bmi = CalculateBMI();
        if (bmi < 18.5)
        {
            return "Gầy";
        }
        else if (bmi < 24.9)
        {
            return "Bình thường";
        }
        else if (bmi < 29.9)
        {
            return "Thừa cân";
        }
        else
        {
            return "Béo phì";
        }
    }
}