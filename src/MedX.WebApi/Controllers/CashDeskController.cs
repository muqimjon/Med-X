﻿using MedX.Service.Interfaces;
using MedX.Desktop.Models;
using Microsoft.AspNetCore.Mvc;

namespace MedX.Desktop.Controllers;

public class CashDeskController : BaseController
{
    private readonly ICashDeskService service;
    public CashDeskController(ICashDeskService service)
    {
        this.service = service;
    }

    [HttpGet("get-balance")]
    public async Task<IActionResult> GetBalance()
    {
        return Ok(new Response
        {
            StatusCode = 200,
            Message = "Success",
            Data = await service.GetLastCashDeskAsync()
        });
    }
}
