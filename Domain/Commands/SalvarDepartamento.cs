using Domain.Entities;
using Domain.Interfaces.Erros;

namespace Domain.Commands
{
    public class SalvarDepartamento : Command
    {
        private readonly Departamento _departamento;

        public SalvarDepartamento(Departamento departamento) : base(departamento)
        {
            _departamento = departamento;
            var description = new ErrorDescription("Novo departamento criado.", new Warning());
            _departamento.Errors.Add(description);
        }

        /// <summary>
        /// Método que verifica se não tem erros ou se tem
        /// 
        /// </summary>
        public void RunCommand()
        {
            if (!Errors.HasErrors)
            {
                GravarCommand();
            }
            else
            {
                var error = new ErrorDescription("Registro não foi salvo", new Critical());
                _departamento.Errors.Add(error);
            }
        }

        private void GravarCommand()
        {
            var message = new ErrorDescription("Registro salvo", new Information());
            _departamento.Errors.Add(message);
        }
    }
}
