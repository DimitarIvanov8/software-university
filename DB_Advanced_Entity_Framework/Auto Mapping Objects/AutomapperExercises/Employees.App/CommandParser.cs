﻿using System;
using System.Linq;
using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using Employees.App.Command;

namespace Employees.App
{
    internal class CommandParser
    {
        public static ICommand Parse(IServiceProvider serviceProvider, string commandName)
        {
            var assembly = Assembly.GetExecutingAssembly();

            var commandTypes = assembly.GetTypes()
                .Where(t => t.GetInterfaces()
                .Contains(typeof(ICommand)));

            var commandType = commandTypes
                .SingleOrDefault(t => t.Name.ToLower() == $"{commandName.ToLower()}command");

            if (commandType == null)
            {
                throw new InvalidOperationException("Invalid command.");
            }

            var constructor = commandType.GetConstructors().First();

            var constructorParams = constructor
                .GetParameters()
                .Select(pi => pi.ParameterType)
                .ToArray();

            var constructorArgs = constructorParams
                .Select(serviceProvider.GetService)
                .ToArray();

            var command = (ICommand)constructor.Invoke(constructorArgs);

            return command;
        }
    }
}
