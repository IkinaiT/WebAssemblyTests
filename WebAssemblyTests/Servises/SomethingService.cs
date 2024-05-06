using WebAssemblyTests.Settings;

namespace WebAssemblyTests.Servises
{
    public class SomethingService
    {
        string name;
        int age;

        public SomethingService(AppSettings appSettings)
        {
            name = appSettings.Name;
            age = appSettings.Age;
        }
    }
}
