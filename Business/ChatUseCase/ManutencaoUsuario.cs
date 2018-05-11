using ChatBusiness;
using ChatDALFactory;
using ChatIDAL;
using ChatModel;
using System;

namespace ChatUseCase
{
  /// <summary>
  /// Responsável por fazer a interação entre a tabela Usuário e o banco de dados.
  /// </summary>
  public class ManutencaoUsuario
  {
    /// <summary>
    /// Inserir um usuário no banco.
    /// </summary>
    /// <param name="aoUsuario">Usuario</param>
    /// <returns>True se o usuário foi inserida.</returns>
    public object Insert(Usuario aoUsuario)
    {
      BUsuario loBUsuario = new BUsuario(aoUsuario);
      if (loBUsuario.UsuarioExiste())
        throw new Exception(String.Format("Já existe um usuário com o nickname {0}", aoUsuario.UsrDsNickname));
      IUsuarioDAL loUsuarioDAL = ConcreteDALFactory.CreateUsuarioDAL();
      loBUsuario.AtualizarData();
      loUsuarioDAL.Insert(aoUsuario);
      return true;
    }

    /// <summary>
    /// Atualizar uma usuário no banco.
    /// </summary>
    /// <param name="aoUsuario">Usuario</param>
    /// <returns>True se a usuário foi atualizada.</returns>
    public object Update(Usuario aoUsuario)
    {
      BUsuario loBUsuario = new BUsuario(aoUsuario);
      IUsuarioDAL loUsuarioDAL = ConcreteDALFactory.CreateUsuarioDAL();
      loBUsuario.AtualizarData();
      loUsuarioDAL.Update(aoUsuario);
      return true;
    }
  }
}
