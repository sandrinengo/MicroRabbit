﻿using MicroRabbit.Banking.Application.Interfaces;
using MicroRabbit.Banking.Application.Services;
using MicroRabbit.Banking.Domain.Interfaces;
using MicroRabbit.Domain.Core.Bus;
using MicroRabbit.Infra.Bus;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices (IServiceCollection services)
        {
            //Domain Bus
            services.AddTransient<IEventBus, RabbitMQBus>();

            //Apolication Services
            services.AddTransient<IAccountService, AccountService>();

            //Data
            services.AddTransient<IAccountRepository, IAccountRepository>();
        }
    }
}
