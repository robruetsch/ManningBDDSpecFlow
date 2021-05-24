using Xunit;
using AutoMapper;
using ShoppingCartService.Mapping;

// Add assembly level trait for all tests in this assembly
[assembly: AssemblyTrait("Build", "CI")]

namespace ShoppingCartServiceTests
{
    
    // Put common infrastructure in here
    // Never, ever put test logic or initialize tested classes in this class
    public abstract class TestBase
    {
        protected TestBase()
        {
            // Ideally do not write any test related logic here
            // Only infrastructure and environment setup

            var config = new MapperConfiguration(cfg => cfg.AddProfile(new MappingProfile()));

            Mapper = config.CreateMapper();
        }

        protected IMapper Mapper { get; }
    }
}