using AutoFixture;

namespace Example04.Tests.Helpers;

public sealed class CountryCustomization : ICustomization
{
    public void Customize(IFixture fixture)
    {
        var countryName = GetValidCountry();
        
        fixture.Customize<Country>(composer =>
        {
            return composer
                .With(x => x.Name, countryName);
        });
    }

    private static string GetValidCountry()
    {
        return Constants.Countries
            .OrderBy(_ => Guid.NewGuid())
            .First();
    }
}