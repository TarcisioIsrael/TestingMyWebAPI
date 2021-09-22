using FluentAssertions;
using Microsoft.EntityFrameworkCore;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Tomappto.Api.Test.Extensions;
using Tomappto.Domain.Aggregates.TomatoAggregate;
using Tomappto.Domain.Repositories;

namespace Tomappto.Api.Test
{
    public class TomapptoApiShould
    {
        private ApiWebApplicationFactory<Tomappto.Api.Startup> testServerFactory;
        Mock<DbSet<Tomato>> mDataSet = new Mock<DbSet<Tomato>>();
        Mock<ITomatoesRepository> mRepository =new Mock<ITomatoesRepository>();
        private HttpClient httpClient;

        public TomapptoApiShould()
        {

            var data = new List<Tomato>
            {
                new Tomato(DateTime.Now,"Unit Test Person 1"),
                new Tomato(DateTime.Now,"Unit Test Person 2"),
            }.AsQueryable();

            mDataSet.As<IQueryable<Tomato>>().Setup(m => m.Provider).Returns(data.Provider);
            mDataSet.As<IQueryable<Tomato>>().Setup(m => m.Expression).Returns(data.Expression);
            mDataSet.As<IQueryable<Tomato>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mDataSet.As<IQueryable<Tomato>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            mRepository.Setup(s => s.GetTomatoes()).Returns(mDataSet.Object);

            testServerFactory = new(services =>
            {
                services.Replace<ITomatoesRepository>(mRepository.Object);
            });


            httpClient = testServerFactory.CreateClient();

        }

        [Test]
        public async Task ReturnTomatoes() 
        {

            var mResponse = await httpClient.GetAsync("/tomatoes");

            mResponse.StatusCode.Should().Be(System.Net.HttpStatusCode.OK);

            var mResponseBody = await mResponse.Content.ReadAsStringAsync();

            mResponseBody.Should().Contain("Unit Test Person 1");
            mResponseBody.Should().Contain("Unit Test Person 2");

        }

    }
}
