namespace SandpitWPF.Services
{
    public interface IBasicConversionService
    {
        double KilogramsToPounds(double kilograms);
        double KilometersPerHourToMetersPerSecond(double speed);
        double MeterstoFeet(double meters);
    }
}