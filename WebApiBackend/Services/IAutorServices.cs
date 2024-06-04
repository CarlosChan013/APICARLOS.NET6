using Domain.Entities;

namespace WebApiBackend.Services
{
    public interface IAutorServices
    {
        public  Task<Response<List<Autor>>> GetAutores();
        public Task<Response<Autor>> Create(Autor C);




    }
}
