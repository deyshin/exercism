using System;

public class SpaceAge
{
    private double Seconds;
    private double ReferenceYearInSeconds = 31557600;

    public SpaceAge(long seconds)
    {
        Seconds = (double)seconds;
    }

    public double OnEarth()
    {
        return ApplyOrbitalPeriodCompensation(1);
    }

    public double OnMercury()
    {
        return ApplyOrbitalPeriodCompensation(0.2408467);
    }

    public double OnVenus()
    {
        return ApplyOrbitalPeriodCompensation(0.61519726);
    }

    public double OnMars()
    {
        return ApplyOrbitalPeriodCompensation(1.8808158);
    }

    public double OnJupiter()
    {
        return ApplyOrbitalPeriodCompensation(11.862615);
    }

    public double OnSaturn()
    {
        return ApplyOrbitalPeriodCompensation(29.447498);
    }

    public double OnUranus()
    {
        return ApplyOrbitalPeriodCompensation(84.016846);
    }

    public double OnNeptune()
    {
        return ApplyOrbitalPeriodCompensation(164.79132);
    }

    private double ApplyOrbitalPeriodCompensation(double yearRatio)
    {
        var earthYear = Seconds/ReferenceYearInSeconds;
        var convertedYear = earthYear / yearRatio;

        return Math.Round(convertedYear, 2);
    }
}