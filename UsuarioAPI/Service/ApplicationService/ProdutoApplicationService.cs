using System;
using System.Collections.Generic;
using System.Text;

namespace Produto.Service.ApplicationService
{
    public class ProdutoApplicationService
    {
        private readonly ProdutoUnitOfWork _uow;

        public ProdutoApplicationService(ProdutoUnitOfWork uow)
        {
            _uow = uow;
        }

        public ProdutoDto GetById(int id)
        {
            var query = _uow.ProdutoRepository.GetById(id);

            var dto = query.Select(x => new ProdutoDto
            {
                Id = x.Id,
                Nome = x.Nome,
                Idade = x.Idade,
            }).FirstOrDefault();

            return dto;
        }


        public List<ProdutoDto> GetAll()
        {
            var query = _uow.ProdutoRepository.GetAll();

            var dto = query.Select(x => new ProdutoDto
            {
                Id = x.Id,
                Nome = x.Nome,
                Idade = x.Idade,
                Sexo = x.Sexo,
                IdCidade = x.IdCidade
            }).ToList();

            return dto;
        }

        public void Update(ProdutoDto dto, int id)
        {
            var query = _uow.ProdutoRepository.GetById(id);

            var aluno = query.FirstOrDefault();

            aluno.Idade = dto.Idade;
            _uow.Commit();

        }

        public void Delete(int id)
        {
            var query = _uow.ProdutoRepository.GetById(id);
            var usuario = query.FirstOrDefault();

            _uow.ProdutoRepository.Delete(usuario);
            _uow.Commit();

        }

        public void Insert(ProdutoDto dto)
        {
            var usuariodb = new ProdutoDB
            {
                Nome = dto.Nome,
                Idade = dto.Idade,
                Sexo = dto.Sexo,
                IdCidade = dto.IdCidade
            };

            _uow.ProdutoRepository.Add(usuariodb);
            _uow.Commit();

        }
    }
}
