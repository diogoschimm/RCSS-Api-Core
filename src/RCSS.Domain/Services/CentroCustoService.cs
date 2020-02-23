using RCSS.Domain.Entities;
using RCSS.Domain.Interfaces.Repositories;
using RCSS.Domain.Interfaces.Services;
using System.Collections.Generic;
using System.Linq;

namespace RCSS.Domain.Services
{
    public class CentroCustoService : ICentroCustoService
    {
        private readonly ICentroCustoRepository _centroCustoRepository;

        public CentroCustoService(ICentroCustoRepository centroCustoRepository)
        {
            this._centroCustoRepository = centroCustoRepository;
        }

        public IEnumerable<CentroCusto> GetAll()
        {
            return this._centroCustoRepository.GetAll();
        }

        public CentroCusto GetById(int idCentroCusto)
        {
            return this._centroCustoRepository.GetById(idCentroCusto);
        }

        public CentroCusto Save(CentroCusto entity)
        {
            if (!entity.Validar())
                return entity;

            var result = _centroCustoRepository.GetAll().Count(x => x.NomeCentroCusto == entity.NomeCentroCusto);
            if (result > 0)
                entity.AddNotification("Nome", "Já existe um centro de custo com esse nome");

            if (entity.Valid)
                this._centroCustoRepository.Save(entity);

            return entity;
        }

        public CentroCusto Update(CentroCusto entity)
        {
            if (!entity.Validar())
                return entity;

            if (entity.Valid)
                this._centroCustoRepository.Update(entity);

            return entity;
        }

        public void Delete(CentroCusto entity)
        {
            this._centroCustoRepository.Delete(entity);
        }
    }
}
