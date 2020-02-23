using RCSS.Domain.Entities;
using RCSS.Domain.Interfaces.Repositories;
using RCSS.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace RCSS.Domain.Services
{
    public class ArquivoService : IArquivoService
    {
        private readonly IArquivoRepository _arquivoRepository;

        public ArquivoService(IArquivoRepository arquivoRepository)
        {
            this._arquivoRepository = arquivoRepository;
        }

        public IEnumerable<Arquivo> GetAll()
        {
            return this._arquivoRepository.GetAll();
        }

        public Arquivo GetById(int idArquivo)
        {
            return this._arquivoRepository.GetById(idArquivo);
        }

        public Arquivo Save(Arquivo entity)
        {
            if (!entity.Validar())
                return entity;

            if (entity.Valid)
                this._arquivoRepository.Save(entity);

            return entity;
        }

        public Arquivo Update(Arquivo entity)
        {
            if (!entity.Validar())
                return entity;

            if (entity.Valid)
                this._arquivoRepository.Update(entity);

            return entity;
        }

        public void Delete(Arquivo entity)
        { 
            this._arquivoRepository.Delete(entity);
        }
    }
}
