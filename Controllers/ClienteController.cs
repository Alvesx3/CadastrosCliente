using CadastrosCliente.Models;
using CadastrosCliente.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CadastrosCliente.Controllers
{
    public class ClienteController: BaseController<ClienteModel, ClienteRepository>
    {
        public ClienteController() : base(new ClienteRepository())
        {

        }
    }
}
