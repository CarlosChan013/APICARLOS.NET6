using Dapper;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Data;
using WebApiBackend.Context;

namespace WebApiBackend.Services
{
    public class AutorServices : IAutorServices
    {
        private readonly ApplicationDbContext _context;

        public AutorServices(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Response<List<Autor>>> GetAutores()
        {
            try
            {
                List<Autor> response = new List<Autor>();
                var result = await _context.Database.GetDbConnection().QueryAsync<Autor>("SpGetAutores", new { }, commandType: CommandType.StoredProcedure);
                response = result.ToList();
                return new Response<List<Autor>>(response);
            }
            catch (Exception ex)
            {
                throw new Exception("Succedio un error :c" + ex.Message);
            }
        }
        public async Task<Response<Autor>> Create(Autor C)
        {
            try
            {
                Autor autor = new Autor();
                var response = await _context.Database.GetDbConnection().QueryAsync<Autor>("SpCreateAutor", new {C.AutorName, C.Nacionalidad }, commandType: CommandType.StoredProcedure);
                foreach (var item in response)
                {
                    autor.AutorName = item.AutorName;
                    autor.Nacionalidad = item.Nacionalidad;
                }
                return new Response<Autor>(autor);
            }
            catch (Exception ex)
            {
                throw new Exception("Ayuda :c" + ex.Message);
            }
        }


    }
}
