using AutoMapper;
using IdentityService.Core.Entities;
using IdentityService.Core.Entities.Identity;
using System;
using Xunit;

namespace IdentityService.IntegrationTests.Common.Mappings
{
    public class MappingTests : IClassFixture<MappingTestsFixture>
    {
        private readonly IConfigurationProvider _configuration;
        //private readonly IMapper _mapper;

        public MappingTests(MappingTestsFixture fixture)
        {
            _configuration = fixture.ConfigurationProvider;
            //_mapper = fixture.Mapper;
        }

        [Fact]
        public void ShouldHaveValidConfiguration()
        {
            _configuration.AssertConfigurationIsValid();
        }

        //[Theory]
        //[InlineData(typeof(User), typeof(UserDto))]
        //public void ShouldSupportMappingFromSourceToDestination(Type source, Type destination)
        //{
        //    var instance = Activator.CreateInstance(source);

        //    _mapper.Map(instance, source, destination);
        //}
    }
}
