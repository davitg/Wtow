using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.IO;
using System.Reflection;
using System.Xml;
using Wtow.Data;
using Wtow.Domain;
using Wtow.Grabber.ApiClients;
using Wtow.Grabber.Domain;
using Wtow.Grabber.Grabbers;
using Wtow.Grabber.Infrastructure;
using Wtow.Service;

namespace Wtow.Grabber
{
    class Program
    {
        private static IConfigurationRoot _config;
        private static IMapper _mapper;
        private static readonly log4net.ILog _log = log4net.LogManager.GetLogger(typeof(Program));
        private static ITitleService _titleService;

        public static void Main(string[] args)
        {
            BuildLogger();
            BuildConfig();
            BuildMapper();
            BuildTitleService();

            var parser = new OmdbApiClient(_config, _mapper);
            var omdbGrabber = new OmdbGrabber(parser, _titleService, _log);

            for (int i = 0; i < 3; i++)
                omdbGrabber.GrabByImdbIds(args.Length > 0 ? args : ImdbIds.AmericanDadAllEpisodes);

            Console.WriteLine("Done!");
            Console.ReadLine();
        }

        private static void BuildLogger()
        {
            XmlDocument log4netConfig = new XmlDocument();
            log4netConfig.Load(File.OpenRead("log4net.config"));
            var repo = log4net.LogManager.CreateRepository(Assembly.GetEntryAssembly(), typeof(log4net.Repository.Hierarchy.Hierarchy));
            log4net.Config.XmlConfigurator.Configure(repo, log4netConfig["log4net"]);

            _log.Info("Application - Main is invoked");
        }

        private static void BuildConfig()
        {
            var builder = new ConfigurationBuilder()
                            .SetBasePath(Directory.GetCurrentDirectory())
                            .AddJsonFile("appsettings.json");

            _config = builder.Build();
        }

        private static void BuildMapper()
        {
            var config = new AutoMapperConfiguration().Configure();
            _mapper = config.CreateMapper();
        }

        private static void BuildTitleService()
        {
            var optionsBuilder = new DbContextOptionsBuilder<TitleContext>();
            optionsBuilder.UseSqlServer(_config["WtowConnectionString"]);
            var context = new TitleContext(optionsBuilder.Options);
            _titleService = new TitleService(context);
        }

    }
}
