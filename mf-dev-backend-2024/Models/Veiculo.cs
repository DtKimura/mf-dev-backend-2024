using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mf_dev_backend_2024.Models
{
    /// <summary>
    ///Linha abaixo é um data notation(permite configurar o modelo para que o framework use essas
    ///anotações para criação do banco de dados e as views). O data notation abaixo especifica para
    ///o framework a criação de uma tabela com o nome "Veiculos", caso não fosse declrado o nome da tabela,
    ///o framework pluralizaria o nome da classe, porém nas regras do idioma inglês
    /// </summary>

    [Table("Veiculos")]

    //Para criar uma classe, clicar com botão direito no Model, "adicionar e "Classe". Especificar o nome da classe
    // e criar. Adicionar manualmente as propriedades da classe com seus data notations;
    public class Veiculo
    {
        /// <summary>
        /// O data notation [Key] abaixo especifica que a propriedade Id é uma chave primária de
        /// auto incremento
        /// </summary>
        [Key]
        public int Id { get; set; }
        /// <summary>
        /// O data notation [Required] especifica que é obrigatório atribuir um valor ou dado
        /// a essa propriedade. Os nomes das propriedades estavam sublinhadas com um verde (um warnnig), isso 
        /// porque a propriedade não ser anulável. Para resolver isso, clicar duas vezes sobre o nome do proje, vai abrir as
        /// propriedades do projeto, alterar de nullable "enable" para "disable".
        /// </summary>
        [Required(ErrorMessage="Obrigatório informar o nome")]
        public string Nome  { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a placa")]
        public string Placa { get; set;}

        [Required(ErrorMessage = "Obrigatório informar o Ano de fabricação")]
        public int AnoFabricacao { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o Ano do modelo")]
        public int AnoModelo { get; set; }
    }
}
// Para conectar essae entidade e tabela a um banco de dados devemos clicar com o botão direito no nome do projeto, Gerenciador de pacotes
// Nuget(pacotes são as bibliotecas, é necessário incluir as bibliotecas de acosso ao banco de dados),
// escolher pacote Microsoft.EntityFrameworkCore.Tools
// Necessário também adicionar a biblioteca ou pacote Microsoft.EntityFrameworkCore.SqlServer, pois é o banco de dados que usaremos. Podemos baixar outros pacotes para diferentes
// bancos de dados, como Oracle e etc...
// Para checar os pacotes ou bibliotecas utilizadas no projeto o caminho é Dependências - Pacotes. Aí estarão
// todas as bibliotecas utilizadas pela aplicação
// Três bibliotecas são necessárias para aplicação:
// Tools: Gera a codificação para que, por linha de comando, seja possível criar e alterar o banco de dados direto pela aplicação
// SqlServer: Fazer impedância com SQL server
// Core:é a base de código para fazer o gerenciamento da aplicação