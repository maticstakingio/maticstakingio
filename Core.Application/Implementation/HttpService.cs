using Core.Application.Interfaces;
using Core.Application.ViewModels.Report;
using Core.Utilities.Dtos;
using GraphQL;
using GraphQL.Client.Abstractions;
using GraphQL.Client.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Nethereum.JsonRpc.Client;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Core.Application.Implementation
{
    //https://www.yogihosting.com/aspnet-core-consume-api/#patch
    public class HttpService : IHttpService
    {
        private readonly ILogger<HttpService> _logger;
        private readonly IConfiguration _configuration; 


        public HttpService(ILogger<HttpService> logger, 
            IConfiguration configuration)
        { 
            _logger = logger;
            _configuration = configuration;


        }

        public async Task<GenericResult> GetAsync(string url)
        {
            try
            {
                using (var httpClient = new HttpClient())
                {
                    //httpClient.DefaultRequestHeaders.Add("TRON-PRO-API-KEY", CommonConstants.TRONApiKey);
                    using (var response = await httpClient.GetAsync(url))
                    {
                        if (response.StatusCode == System.Net.HttpStatusCode.OK)
                        {
                            string contentResponse = await response.Content.ReadAsStringAsync();
                            return new GenericResult(true, message: contentResponse);
                        }
                        else
                        {
                            return new GenericResult(false, message: response.StatusCode.ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                _logger.LogInformation("HttpService_GetAsync_Url: {0}", url);
                _logger.LogError("HttpService_GetAsync_Error: {0}", ex.Message);
                return new GenericResult(false, message: ex.Message);
            }
        }

        public async Task<GenericResult> PostAsync(string url, object parrams)
        {
            try
            {
                using (var httpClient = new HttpClient())
                {
                    //httpClient.DefaultRequestHeaders.Add("TRON-PRO-API-KEY", CommonConstants.TRONApiKey);

                    var dataJson = JsonConvert.SerializeObject(parrams);
                    var content = new StringContent(dataJson, Encoding.UTF8, "application/json");
                    using (var response = await httpClient.PostAsync(url, content))
                    {
                        if (response.StatusCode == System.Net.HttpStatusCode.OK)
                        {
                            var contentResponse = await response.Content.ReadAsStringAsync();
                            return new GenericResult(true, message: contentResponse);
                        }
                        else
                        {
                            return new GenericResult(false, message: response.StatusCode.ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                _logger.LogInformation("HttpService_PostAsync_Url: {0}", url);
                _logger.LogError("HttpService_PostAsync_Error: {0}", ex.Message);

                return new GenericResult(false, message: ex.Message);
            }
        }

         


    }

    public class GraphQLHttpRequestWithAuthSupport : GraphQLHttpRequest
    {
        public string Authorization { get;set;}

        public string AuthEmail { get; set; }

        public override HttpRequestMessage ToHttpRequestMessage(GraphQLHttpClientOptions options, IGraphQLJsonSerializer serializer)
        {
            
            var r = base.ToHttpRequestMessage(options, serializer);
            r.Headers.Add("Authorization", $"Bearer {Authorization}");
            r.Headers.Add("x-auth-email", AuthEmail);
            return r;
        }
    }
}
