using CleanGrassAppWeb.Models;
using CleanGrassAppWeb.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CleanGrassAppWeb.Pages;

public class Create : PageModel
{
    private IGrassService _service;

    public Create(IGrassService serivce)
    {
        _service = serivce;
    }

    [BindProperty] public Servico Servico { get; set; }

    public IActionResult OnPost()
    {
        if (!ModelState.IsValid) return Page();
        //inclusão
        _service.Incluir(Servico);
        return RedirectToPage("/Index");
    }
}