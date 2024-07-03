using AutoFixture;

namespace Example04.Tests.Helpers;

public class AutoFixtureBuilder
{
    private ICustomization[] _customizations = 
    [
        new CountryCustomization(),
        new GeolocationCustomization()
    ];

    public AutoFixtureBuilder WithCustomizations(ICustomization[] customizations)
    {
        _customizations = customizations;
        return this;
    }

    public Fixture Create()
    {
        var fixture = new Fixture();

        foreach(var customization in _customizations)
        {
            fixture.Customize(customization);
        }

        return fixture;
    }
}