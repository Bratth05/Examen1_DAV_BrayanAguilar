using Examen1_BrayanAguilar_62051229.Models.Domain.Services;
using Microsoft.AspNetCore.Mvc;

public class FoodTrackController : Controller
{
    private readonly OrderService _service;

    public FoodTrackController(OrderService service)
    {
        _service = service;
    }

    public IActionResult Index()
    {
        return View();
    }
}

