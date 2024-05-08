using Zad7.DTOs;
using Zad7.Services;
using Microsoft.AspNetCore.Mvc;

namespace Zad7.Controllers;

[ApiController]
[Route("api/warehouses")]
public class WarehouseController(IDbService db) : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> GetWarehouseId(GetWarehouseDTO warehouseDto)
    {
        int id;
        try
        {
            id = await db.GetIdProductWarehouse(warehouseDto);
        }
        catch (ArgumentException e)
        {
            return NotFound(e.Message);
        }
        return Ok(id);
    }
}