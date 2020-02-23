using RCSS.Domain.Entities;
using RCSS.Domain.Interfaces.Repositories;
using RCSS.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace RCSS.Domain.Services
{
    public class ItemMovimentoService : IItemMovimentoService
    {
        private readonly IItemMovimentoRepository _itemMovimentoRepository;

        public ItemMovimentoService(IItemMovimentoRepository itemMovimentoRepository)
        {
            this._itemMovimentoRepository = itemMovimentoRepository;
        }

        public IEnumerable<ItemMovimento> GetByMovimento(int idMovimento)
        {
            return this._itemMovimentoRepository.GetByMovimento(idMovimento);
        }

        public ItemMovimento GetById(int idItemMovimento)
        {
            return this._itemMovimentoRepository.GetById(idItemMovimento);
        }

        public ItemMovimento Save(ItemMovimento entity)
        {
            if (!entity.Validar())
                return entity;

            if (entity.Valid)
                this._itemMovimentoRepository.Save(entity);

            return entity;
        }

        public ItemMovimento Update(ItemMovimento entity)
        {
            if (!entity.Validar())
                return entity;

            if (entity.Valid)
                this._itemMovimentoRepository.Update(entity);

            return entity;
        }

        public void Delete(ItemMovimento entity)
        {
            this._itemMovimentoRepository.Delete(entity);
        }
    }
}
