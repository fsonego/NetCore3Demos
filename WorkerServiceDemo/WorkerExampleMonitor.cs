using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

//namespace WorkerServiceDemo
//{
//    public class Worker : BackgroundService
//    {
//        private readonly ILogger<Worker> _logger;
//        private HttpClient client;

//        public Worker(ILogger<Worker> logger)
//        {
//            _logger = logger;
//        }

//        public override Task StartAsync(CancellationToken cancellationToken)
//        {
//            client = new HttpClient();
//            return base.StartAsync(cancellationToken);
//        }

//        public override Task StopAsync(CancellationToken cancellationToken)
//        {
//            client.Dispose();
//            return base.StopAsync(cancellationToken);
//        }

//        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
//        {
//            while (!stoppingToken.IsCancellationRequested)
//            {                
//                var result = await client.GetAsync("http://withoutdebugger.com/");

//                if (result.IsSuccessStatusCode)
//                {
//                    _logger.LogInformation("El sitio esta funcionando", result.StatusCode);
//                }
//                else {
//                    _logger.LogError("El sitio esta caido", result.StatusCode);
//                }
//                await Task.Delay(10000, stoppingToken);
//            }
//        }
//    }
//}
