using ServiceCountries;

namespace MvcCoreClienteWCF.Services
{
    public class ServicesCountries
    {
        CountryInfoServiceSoapTypeClient client;

        public ServicesCountries()
        {
            this.client =
                new CountryInfoServiceSoapTypeClient
                (CountryInfoServiceSoapTypeClient.EndpointConfiguration.CountryInfoServiceSoap);
        }
        public async Task<tCountryCodeAndName[]> GetCountriesAsync()
        {
            ListOfCountryNamesByNameResponse response =
                await this.client.ListOfCountryNamesByNameAsync();
            tCountryCodeAndName[] datos =
                response.Body.ListOfCountryNamesByNameResult;
            return datos;
        }

        public async Task<tCountryInfo> GetCountryInfoAsync(string isoCode)
        {
            FullCountryInfoResponse response =
                await this.client.FullCountryInfoAsync(isoCode);
            tCountryInfo country = response.Body.FullCountryInfoResult;
            return country;
        }
    }
}
