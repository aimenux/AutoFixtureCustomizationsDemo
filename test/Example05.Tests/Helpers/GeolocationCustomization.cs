using AutoFixture;

namespace Example05.Tests.Helpers;

public sealed class GeolocationCustomization : ICustomization
{
    public void Customize(IFixture fixture)
    {
        var (longitude, latitude) = GetValidCoordinates();
        
        fixture.Customize<Geolocation>(composer =>
        {
            return composer
                .With(x => x.Longitude, longitude)
                .With(x => x.Latitude, latitude);
        });
    }
    
    private static (double Longitude, double Latitude) GetValidCoordinates()
    {
        var longitude = Random.Shared.Next(Constants.Longitude.Min, Constants.Longitude.Max);
        var latitude = Random.Shared.Next(Constants.Latitude.Min, Constants.Latitude.Max);
        return (longitude, latitude);
    }
}