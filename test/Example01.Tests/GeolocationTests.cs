using AutoFixture;
using Example01.Tests.Helpers;
using FluentAssertions;

namespace Example01.Tests;

public class GeolocationTests
{
    [Fact]
    public void Should_Generate_Valid_Geolocation()
    {
        // arrange
        var fixture = new Fixture().Customize(new GeolocationCustomization());
        
        // act
        var geolocation = fixture.Create<Geolocation>();

        // assert
        geolocation.Latitude.Should().BeInRange(Constants.Latitude.Min, Constants.Latitude.Max);
        geolocation.Longitude.Should().BeInRange(Constants.Longitude.Min, Constants.Longitude.Max);
    }
}