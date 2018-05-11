using System;

namespace ChatModel
{
  /// <summary>
  /// Classe com os atributos da tabela Mensagem.
  /// </summary>
  public class Mensagem
  {
    /// <summary>
    /// Chave primária da tabela mensagem.
    /// </summary>
    private int menIdMensagem;
    /// <summary>
    /// Descrição da mensagem.
    /// </summary>
    private string menDsMensagem;
    /// <summary>
    /// Data de envio da mensagem.
    /// </summary>
    private DateTime menDtEnvio;
    /// <summary>
    /// Usuario que está enviando a mensagem.
    /// </summary>
    private Usuario usuarioEnvio;
    /// <summary>
    /// Usuário destinatário da mensagem.
    /// </summary>
    private Usuario usuarioDestino;

    /// <summary>
    /// Chave primária da tabela mensagem.
    /// </summary>
    public virtual int MenIdMensagem
    {
      get { return this.menIdMensagem; }
      set { this.menIdMensagem = value; }
    }

    /// <summary>
    /// Descrição da mensagem
    /// </summary>
    public virtual string MenDsMensagem
    {
      get { return this.menDsMensagem; }
      set { this.menDsMensagem = value; }
    }

    /// <summary>
    /// Data de envio da mensagem.
    /// </summary>
    public virtual DateTime MenDtEnvio
    {
      get { return this.menDtEnvio; }
      set { this.menDtEnvio = value; }
    }

    /// <summary>
    /// Usuário que está enviando a mensagem.
    /// </summary>
    public virtual Usuario UsuarioEnvio
    {
      get { return this.usuarioEnvio; }
      set { this.usuarioEnvio = value; }
    }

    /// <summary>
    /// Usuário destinatário da mensagem.
    /// </summary>
    public virtual Usuario UsuarioDestino
    {
      get { return this.usuarioDestino; }
      set { this.usuarioDestino = value; }
    }
  }
}
