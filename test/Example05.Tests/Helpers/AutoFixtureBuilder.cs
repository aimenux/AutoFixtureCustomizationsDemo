using AutoFixture;

namespace Example05.Tests.Helpers;

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

    public IFixture Create()
    {
        var fixture = new Fixture().Customize(new CompositeCustomization(_customizations));
        return fixture;
    }
}