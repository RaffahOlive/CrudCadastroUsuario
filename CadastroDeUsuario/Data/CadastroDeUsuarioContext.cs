#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CadastroDeUsuario.Models;

namespace CadastroDeUsuario.Data
{
    public class CadastroDeUsuarioContext : DbContext
    {
        public CadastroDeUsuarioContext (DbContextOptions<CadastroDeUsuarioContext> options)
            : base(options)
        {
        }

        public DbSet<CadastroDeUsuario.Models.Department> Department { get; set; }
    }
}
