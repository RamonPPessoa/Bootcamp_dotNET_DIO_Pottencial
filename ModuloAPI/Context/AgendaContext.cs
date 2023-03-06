using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ModuloAPI.Entities;
namespace ModuloAPI.Context
{
    public class AgendaContext : DbContext
    {

    
            // Recebe a conexão com o banco passando para o base/context que vai gerenciar a comunicação com o BD
     public AgendaContext(DbContextOptions<AgendaContext> options) : base(options)   
     {

     }

     public DbSet<Contato> Contatos { get; set; }
        
    }
}