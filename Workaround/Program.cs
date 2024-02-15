using Business.Concrete;
using Entities.Concrete;

class Program
{
    static void Main(string[] args)
    {
        Person person1 = new Person();
        person1.firstName = "MUHAMMED İKBAL";
        person1.lastName = "LAÇ";
        person1.dateOfBirthDay = 2003;
        person1.nationalIdentity = 12345678912;

        PttManager pttManager = new PttManager(new PersonManager());
        pttManager.GiveMask(person1);
    }
}   