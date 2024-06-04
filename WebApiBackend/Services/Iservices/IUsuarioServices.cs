using Domain.Entities;

namespace WebApiBackend.Services.Iservices
{
    public interface IUsuarioServices
    {
        public Task<Response<List<Usuario>>> ObtenerUsuarios();
        public  Task<Response<Usuario>> Crear(UsuarioReponse request);
        public Task<Response<Usuario>> ById(int id);

        public Task<Response<Usuario>>Editar(int id, UsuarioReponse request);
        public Task<Response<bool>> Eliminar(int id);


    }
}
