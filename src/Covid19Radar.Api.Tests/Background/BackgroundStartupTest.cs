﻿using Covid19Radar.Api.DataAccess;
using Covid19Radar.Api.Models;
using Covid19Radar.Api.Services;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.DependencyModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Covid19Radar.Api.Tests.Background
{
    [TestClass]
    [TestCategory("Startup")]
    public class BackgroundStartupTest
    {
        [TestMethod]
        public void CreateMethod()
        {
            // preparation
            var startup = new Covid19Radar.Background.Startup();
        }

        [TestMethod]
        public void ConfigureMethod()
        {
            // preparation
            var startup = new Covid19Radar.Background.Startup();
            var builder = new Mock<IFunctionsHostBuilder>();
            var services = new Mock<Microsoft.Extensions.DependencyInjection.IServiceCollection>();
            var serviceDescriptors = new Mock<IEnumerator<ServiceDescriptor>>();
            services.Setup(_ => _.Add(It.IsAny<ServiceDescriptor>()));
            services.Setup(_ => _.GetEnumerator()).Returns(serviceDescriptors.Object);
            builder.Setup(_ => _.Services)
                .Returns(services.Object);

            // action
            startup.Configure(builder.Object);
            // assert
        }
    }
}
