using Azure;
using HubPro.Hub.API.DTOs.Request;
using HubPro.Hub.Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using static System.Net.WebRequestMethods;

namespace WebpAppHubPro.Controllers
{
    public class ClienteController : Controller
    {
        HttpClient _httpClient;
        public ClienteController()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri("https://localhost:7189/");
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

        }
        // GET: ClienteController
        public async Task<ActionResult> Index(int pg)
        {
            if (pg <= 0)
                    pg = 1;

            var reponse = await _httpClient.GetAsync("/api/cliente/BuscarVarios?pg="+pg);
            string content = await reponse.Content.ReadAsStringAsync();
            List<ClienteRequest> listaClientes = JsonConvert.DeserializeObject<List<ClienteRequest>>(content);
            return View("Index", listaClientes);
        }

        // GET: ClienteController/Create
        [HttpGet]
        public ActionResult Create()
        {
            return View("Create");
        }

        // POST: ClienteController/Create
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(ClienteRequest request)
        {
            var bodyJson = System.Text.Json.JsonSerializer.Serialize(request);
            var content = new StringContent(bodyJson, Encoding.UTF8, "application/json");
            try
            {
                var response = await _httpClient.PostAsync("/api/cliente", content);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ClienteController/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            var reponse = await _httpClient.GetAsync("/api/cliente/BuscarPorIdentificador?request="+id);
            string content = await reponse.Content.ReadAsStringAsync();
            ClienteRequest Cliente = JsonConvert.DeserializeObject<ClienteRequest>(content);
            return View("ClientEdit", Cliente);
        }

        // POST: ClienteController/Edit/5
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(ClienteRequest request)
        {
            var bodyJson = System.Text.Json.JsonSerializer.Serialize(request);
            var content = new StringContent(bodyJson, Encoding.UTF8, "application/json");
            try
            {
                var response = await _httpClient.PutAsync("/api/cliente", content);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // POST: ClienteController/Delete/5
        [HttpPost]
       // [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(int clienteId)
        {
            try
            {
                var reponse = await _httpClient.DeleteAsync("/api/cliente?id="+clienteId);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        [HttpGet]
        public async Task<ActionResult> Search([FromQuery] string busca)
        {
            try
            {
                var response = await _httpClient.GetAsync("/api/cliente/BuscarPorIdentificador?request="+ busca);
                string content = await response.Content.ReadAsStringAsync();
                ClienteRequest Cliente = JsonConvert.DeserializeObject<ClienteRequest>(content);
                return View("ClientEdit", Cliente);
            }
            catch
            {
                return RedirectToAction(nameof(Index));
            }
        }
    }
}
