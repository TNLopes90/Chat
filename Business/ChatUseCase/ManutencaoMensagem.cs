using ChatDALFactory;
using ChatIDAL;
using ChatModel;

namespace ChatUseCase
{
  /// <summary>
  /// Responsável por fazer a interação entre a tabela Mensagem e o banco de dados.
  /// </summary>
  public class ManutencaoMensagem
  {
    /// <summary>
    /// Inserir uma mensagem no banco.
    /// </summary>
    /// <param name="aoMensagem">Mensagem</param>
    /// <returns>True se a mensagem foi inserida.</returns>
    public object Insert(Mensagem aoMensagem)
    {
      IMensagemDAL loMensagemDAL = ConcreteDALFactory.CreateMensagemDAL();
      loMensagemDAL.Insert(aoMensagem);
      return true;
    }

    /// <summary>
    /// Atualizar uma mensagem no banco.
    /// </summary>
    /// <param name="aoMensagem">Mensagem</param>
    /// <returns>True se a mensagem foi atualizada.</returns>
    public object Update(Mensagem aoMensagem)
    {
      IMensagemDAL loMensagemDAL = ConcreteDALFactory.CreateMensagemDAL();
      loMensagemDAL.Update(aoMensagem);
      return true;
    }
  }
}
