using RCSS.Domain.Entities;
using RCSS.Domain.Interfaces.Repositories;
using RCSS.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace RCSS.Domain.Services
{
    public class MovimentoEstoqueService : IMovimentoEstoqueService
    {
        private readonly IMovimentoEstoqueRepository _movimentoEstoqueRepository;

        public MovimentoEstoqueService(IMovimentoEstoqueRepository movimentoEstoqueRepository)
        {
            this._movimentoEstoqueRepository = movimentoEstoqueRepository;
        }

        public IEnumerable<MovimentoEstoque> GetAll()
        {
            return this._movimentoEstoqueRepository.GetAll();
        }

        public MovimentoEstoque GetById(int idMovimentacao)
        {
            return this._movimentoEstoqueRepository.GetById(idMovimentacao);
        }

        public MovimentoEstoque Save(MovimentoEstoque entity)
        {
            if (!entity.Validar())
                return entity;

            if (entity.Valid)
                this._movimentoEstoqueRepository.Save(entity);

            return entity;
        }

        public MovimentoEstoque Update(MovimentoEstoque entity)
        {
            if (!entity.Validar())
                return entity;

            if (entity.Valid)
                this._movimentoEstoqueRepository.Update(entity);

            return entity;
        }

        public void Delete(MovimentoEstoque entity)
        {
            this._movimentoEstoqueRepository.Delete(entity);
        }
    }
}
