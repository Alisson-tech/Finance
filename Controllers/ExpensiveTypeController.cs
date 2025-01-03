﻿using Finance.Exceptions;
using Finance.Service.Revenue;
using Microsoft.AspNetCore.Mvc;

namespace Finance.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ExpensiveTypeController : Controller
{
    public readonly IExpensiveTypeService _expensiveTypeService;

    public ExpensiveTypeController(IExpensiveTypeService expensiveTypeService)
    {
        _expensiveTypeService = expensiveTypeService;
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        try 
        {
            var expensiveType = await _expensiveTypeService.GetById(id);
            return Ok(expensiveType);
        }
        catch (FinanceNotFoundException ex)
        {
            return NotFound(ex.Message);
        }
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        return Ok(await _expensiveTypeService.GetAll());
 
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] ExpensiveTypeDto expensiveTypeDto)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        var createdExpensiveType = await _expensiveTypeService.Create(expensiveTypeDto);
        return CreatedAtAction(nameof(GetById), new { id = createdExpensiveType.Name }, createdExpensiveType);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, [FromBody] ExpensiveTypeDto expensiveTypeDto)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        var updatedExpensiveType = await _expensiveTypeService.Update(id, expensiveTypeDto);
        return Ok(updatedExpensiveType);
    }
}
