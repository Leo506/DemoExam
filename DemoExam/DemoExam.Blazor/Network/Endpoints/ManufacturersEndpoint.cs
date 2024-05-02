using Arbus.Network;
using DemoExam.Domain.Models;

namespace DemoExam.Blazor.Network.Endpoints;

public class ManufacturersEndpoint() : ApiEndpoint<List<Manufacturer>>(HttpMethod.Get, "info/manufacturers");