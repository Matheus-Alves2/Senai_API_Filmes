using api_filmes_senai.Domains;
using api_filmes_senai.Migrations;

namespace api_filmes_senai.Interfaces
{
    public interface IFilmeRepository
    {
        void Cdastrar(Filme novoFilme);

        List<Filme> Listar();

        void Atualizar(Guid id, Filme filme);

        void Deletar(Guid id);

        Filme BuscarPorId(Guid id);
        void Cdastrar(Controllers.Filme novoFilme);
        void Atualizar(Guid id,Filme filme);
    }
        public List<Filme> ListarPorGenero(Guid idGenero)
        {
            try
            {
                List<Filme> listaDeFimes = Db_Context.Filmes
                    .Include(g => g.Genero)
                    .Where(f => f.IdGenero == idGenero)
                    .Tolist();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
