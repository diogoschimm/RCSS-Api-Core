using RCSS.Domain.Entities;
using RCSS.Domain.Interfaces.Repositories;
using RCSS.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace RCSS.Domain.Services
{
    public class MovimentoService : IMovimentoService
    {
        private readonly IMovimentoRepository _movimentoRepository;

        public MovimentoService(IMovimentoRepository movimentoRepository)
        {
            this._movimentoRepository = movimentoRepository;
        }

        public IEnumerable<Movimento> GetByAnoMes(int ano, int mes)
        {
            return this._movimentoRepository.GetByAnoMes(ano, mes);
        }

        public Movimento GetById(int idMovimento)
        {
            return this._movimentoRepository.GetById(idMovimento);
        }

        public Movimento Save(Movimento entity)
        {
            if (!entity.Validar())
                return entity;

            if (entity.Valid)
                this._movimentoRepository.Save(entity);

            return entity;
        }

        public Movimento Update(Movimento entity)
        {
            if (!entity.Validar())
                return entity;

            if (entity.Valid)
                this._movimentoRepository.Update(entity);

            return entity;
        }

        public void Delete(Movimento entity)
        {
            this._movimentoRepository.Delete(entity);
        }
    }
}
