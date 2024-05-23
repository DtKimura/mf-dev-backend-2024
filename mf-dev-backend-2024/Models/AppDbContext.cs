using Microsoft.EntityFrameworkCore;

namespace mf_dev_backend_2024.Models
{
    /// <summary>
    /// A classe AppDbContext é uma classe de contexto que tem o objetivo de fazer a configuração do entityframework
    /// pra gerar tabela e fazer as tabelas. Como se fosse um utilitário responsável por pegar todas as classes que configurei
    /// e gerar as tabelas do banco de dados
    /// </summary
    

    /// Ao inserir a sintaxe abaixo, a classe AppDbContext herda todas as características e propriedades de DbContext
    /// desse modo, é configurando o contexto da aplicação usando o entityframework, gerenciar o contexto.
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        /// <summary>
        /// É necessáio especificar qual o banco de dados. Isso éfeito através da sintaxe abaixo
        /// tipo de dado é DBSet. Toda entidade nova criada, deverá ser incluida aqui para que seja especificado qual
        /// a tabela será associada a qual entidade
        /// </summary>
        public DbSet<Veiculo> Veiculos { get; set; }
    }
}

// É necessário uma string de conexão. Incluir a sring de conexão no arquivo appsettings
