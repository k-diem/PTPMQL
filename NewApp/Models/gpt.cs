using System;

public class GiaiPhuongTrinh
{
    public static string GiaiPhuongTrinhBacNhat(double a, double b)
    {
        if (a == 0)
        {
            if (b == 0)
            {
                return "Phương trình có vô số nghiệm";
            }
            else
            {
                return "Phương trình vô nghiệm";
            }
        }
        else
        {
            double x = -b / a;
            return $"Nghiệm của phương trình là: x = {x}";
        }
    }

    public static string GiaiPhuongTrinhBacHai(double a, double b, double c)
    {
        if (a == 0)
        {
            return GiaiPhuongTrinhBacNhat(b, c);
        }

        double delta = b * b - 4 * a * c;

        if (delta < 0)
        {
            return "Phương trình vô nghiệm";
        }
        else if (delta == 0)
        {
            double x = -b / (2 * a);
            return $"Nghiệm kép của phương trình là: x = {x}";
        }
        else
        {
            double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
            return $"Nghiệm của phương trình là: x1 = {x1}, x2 = {x2}";
        }
    }
}
