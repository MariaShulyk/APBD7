using System.ComponentModel.DataAnnotations;

namespace Zad7.DTOs;

public record GetWarehouseDTO(
    [Required]int IdProduct, 
    [Required]int IdWarehouse, 
    [Required]int Amount, 
    [Required]DateTime CreatedTime
    );
