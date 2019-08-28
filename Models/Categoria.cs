using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TrabajoD.Models
{
  public class Categoria
  {
  [Key]
    public int ProductoId { get; set; }
    public string Titulo { get; set; }
    public IEnumerable <Productos> Producto { get; set; }
                   
  }
}