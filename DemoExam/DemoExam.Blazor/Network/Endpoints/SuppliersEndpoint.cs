using Arbus.Network;
using DemoExam.Domain.Models;

namespace DemoExam.Blazor.Network.Endpoints;

public class SuppliersEndpoint() : ApiEndpoint<List<Supplier>>(HttpMethod.Get, "info/suppliers");