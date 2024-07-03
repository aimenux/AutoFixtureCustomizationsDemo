using AutoFixture;
using Example04.Tests.Helpers;
using FluentAssertions;

namespace Example04.Tests;

public class AddressTests
{
    [Fact]
    public void Should_Generate_Valid_Address()
    {
        // arrange
        var fixture = new AutoFixtureBuilder().Create();
        
        // act
        var address = fixture.Create<Address>();

        // assert
        address.Country.Name.Should().BeOneOf(Constants.Countries);
        address.Geolocation.Latitude.Should().BeInRange(Constants.Latitude.Min, Constants.Latitude.Max);
        address.Geolocation.Longitude.Should().BeInRange(Constants.Longitude.Min, Constants.Longitude.Max);
    }
}