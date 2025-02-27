using api_filmes_senai.Domains;

namespace api_filmes_senai.Interfaces
{
    /// <summary>
    /// Interface para Genero : Contrato
    /// Toda classe  que herdar (implementar) essa interface, devera implementar todos os métodos definidos aqui dentro
    /// </summary>
    public interface IGeneroRepository
    {
        //CRUD : Métodos
        //C : Create : Cadastrar um novo objeto
        //R : Read : Listar todos  os objetos
        //U : Update :  Alterar um objeto
        //D : Delete : Deleto ou excluo um objeto

        //Método = TipodeRetorno NomedoMetodo(Argumentos)

        void Cadastrar(Genero novoGenero);

        List<Genero> Listar();

        void Atualizar(Guid id, Genero genero);

        void Deletar(Guid id);

        Genero BucarPorId(Guid id);
    }
}
