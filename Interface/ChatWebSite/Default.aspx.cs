using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;
using ChatModel;

public partial class _Default : Page
{
  protected void Page_Load(object sender, EventArgs e)
  {
    ChatDispatcher.ServicesSoapClient loServicesSoapClient = new ChatDispatcher.ServicesSoapClient();

    Usuario loUsuario1 = new Usuario();
    loUsuario1.UsrDsNickname = "thiago";
    loUsuario1.UsrDtAcesso = DateTime.Now;

    loServicesSoapClient.CadastrarUsuario(loUsuario1.ToService());

    //Usuario loUsuario2 = new Usuario();
    //loUsuario2.UsrDsNickname = "lopes";
    //loUsuario2.UsrDtAcesso = DateTime.Now;

    //Mensagem loMensagem = new Mensagem();
    //loMensagem.MenDsMensagem = "Olá!";
    //loMensagem.MenDtEnvio = DateTime.Now;
    //loMensagem.UsuarioEnvio = loUsuario1;
    //loMensagem.UsuarioDestino = loUsuario2;

    //loUsuarioDAL.Update(loUsuario1);
    //loUsuarioDAL.Update(loUsuario2);


  }
}

public static class Translation
{
  public static ChatDispatcher.Usuario ToService(this Usuario aoUsuario)
  {
    return new ChatDispatcher.Usuario
    {
      UsrDsNickname = aoUsuario.UsrDsNickname,
      UsrDtAcesso = aoUsuario.UsrDtAcesso
    };
  }

  public static ChatDispatcher.Mensagem ToService(this Mensagem aoMensagem)
  {
    return new ChatDispatcher.Mensagem
    {
      MenIdMensagem = aoMensagem.MenIdMensagem,
      MenDsMensagem = aoMensagem.MenDsMensagem,
      UsuarioEnvio = aoMensagem.UsuarioEnvio.ToService(),
      UsuarioDestino = aoMensagem.UsuarioDestino.ToService(),
      MenDtEnvio = aoMensagem.MenDtEnvio
    };
  }

}