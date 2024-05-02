using Arbus.Network;

namespace DemoExam.Blazor.Network.Endpoints;

public class CategoriesEndpoint() : ApiEndpoint<List<string>>(HttpMethod.Get, "info/categories");