using Microsoft.EntityFrameworkCore;
using RCSS.Domain.Dtos;
using RCSS.Domain.Interfaces.UnitOfWork;
using RCSS.Infra.Data.Contexts; 

namespace RCSS.Infra.Data.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ProjetoRcssContext _context;

        public UnitOfWork(ProjetoRcssContext context)
        {
            this._context = context;
        }

        public RetornoPadrao Commit()
        {
            try
            {
                this._context.SaveChanges();

                var retornoUnitOfWork = new RetornoPadrao { Sucesso = true };
                retornoUnitOfWork.Mensagens.Add("Operação realizada com sucesso");
                return retornoUnitOfWork;
            }
            catch (DbUpdateException ex)
            {
                var retornoUnitOfWork = new RetornoPadrao { Sucesso = false };
                retornoUnitOfWork.Mensagens.Add(ex.Message);
                if (ex.InnerException != null)
                    retornoUnitOfWork.Mensagens.Add(ex.InnerException.Message);

                return retornoUnitOfWork;
            }
        }
    }
}
