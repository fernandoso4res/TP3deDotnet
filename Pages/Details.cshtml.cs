using CleanGrassAppWeb.Models;
using CleanGrassAppWeb.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CleanGrassAppWeb.Pages;

public class Details : PageModel
{
    private IGrassService _service;

    public Details(IGrassService service)
    {
        _service = service;
    }

    public Servico Servico { get; private set; }

    public IActionResult OnGet(int id)
    {
        Servico = _service.Obter(id);

        if (Servico == null) return NotFound();

        return Page();
    }
}