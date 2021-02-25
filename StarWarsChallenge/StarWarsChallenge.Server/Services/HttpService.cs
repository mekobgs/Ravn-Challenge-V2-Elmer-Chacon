using Microsoft.AspNetCore.Components;
using System;
using System.Net.Http;

namespace StarWarsChallenge.Service.Service
{
    public class HttpService
    {
        public HttpService(HttpClient httpClient, NavigationManager navigationManager)
        {
            HttpClient = httpClient;
            NavigationManager = navigationManager;
            HttpClient.BaseAddress = new Uri(NavigationManager.BaseUri);
        }

        public HttpClient HttpClient { get; }
        public NavigationManager NavigationManager { get; }
    }
}

