using System;

namespace ChatModel
{
  /// <summary>
  /// Classe com os atributos da tabela Usuário.
  /// </summary>
  public class Usuario
  {
    /// <summary>
    /// Chave primária da tabela usuário
    /// </summary>
    private string usrDsNickname;
    /// <summary>
    /// Data de acesso do usuário
    /// </summary>
    private DateTime usrDtAcesso;

    /// <summary>
    /// Chave primária da tabela usuário. Nickname do usuário.
    /// </summary>
    public virtual string UsrDsNickname
    {
      get { return this.usrDsNickname; }
      set { this.usrDsNickname = value; }
    }

    /// <summary>
    /// Data de acesso do usuário.
    /// </summary>
    public virtual DateTime UsrDtAcesso
    {
      get { return this.usrDtAcesso; }
      set { this.usrDtAcesso = value; }
    }
  }
}
