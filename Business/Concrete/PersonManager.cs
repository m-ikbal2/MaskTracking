using Business.Abstract;
using Business.KPSPublic;
using Entities.Concrete;

namespace Business.Concrete;

public class PersonManager : IApplicantService
{
    public void ApplyForMask(Person person)
    {
    }

    public List<Person> GetList()
    {
        return null;
    }

    public bool CheckPerson(Person person)
    {
        KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
        return client
            .TCKimlikNoDogrulaAsync(
                new TCKimlikNoDogrulaRequest(new TCKimlikNoDogrulaRequestBody(person.nationalIdentity, person.firstName,
                    person.lastName, person.dateOfBirthDay)))
            .Result.Body.TCKimlikNoDogrulaResult;
    }
}