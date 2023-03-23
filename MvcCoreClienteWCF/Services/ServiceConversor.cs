using ServiceReferenceConversor;

namespace MvcCoreClienteWCF.Services
{
    public class ServiceConversor
    {
        NumberConversionSoapTypeClient client;

        public ServiceConversor()
        {
            this.client = 
                new NumberConversionSoapTypeClient
                (NumberConversionSoapTypeClient.EndpointConfiguration.NumberConversionSoap);
        }
    }
}
