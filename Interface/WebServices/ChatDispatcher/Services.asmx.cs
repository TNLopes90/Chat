using ChatModel;
using ChatUseCase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace ChatDispatcher
{
  /// <summary>
  /// Summary description for Services
  /// </summary>
  [WebService(Namespace = "http://tempuri.org/")]
  [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
  [System.ComponentModel.ToolboxItem(false)]
  // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
  // [System.Web.Script.Services.ScriptService]
  public class Services : System.Web.Services.WebService
  {
    [WebMethod]
    public object CadastrarUsuario(Usuario aoUsuario)
    {
      ManutencaoUsuario loManutencaoUsuario = new ManutencaoUsuario();
      return loManutencaoUsuario.Insert(aoUsuario);
    }

    [WebMethod]
    public object AtualizarUsuario(Usuario aoUsuario)
    {
      ManutencaoUsuario loManutencaoUsuario = new ManutencaoUsuario();
      return loManutencaoUsuario.Update(aoUsuario);
    }

    [WebMethod]
    public object CadastraMensagem(Mensagem aoMensagem)
    {
      ManutencaoMensagem loManutencaoMensagem = new ManutencaoMensagem();
      return loManutencaoMensagem.Insert(aoMensagem);
    }

    [WebMethod]
    public object AtualizarMensagem(Mensagem aoMensagem)
    {
      ManutencaoMensagem loManutencaoMensagem = new ManutencaoMensagem();
      return loManutencaoMensagem.Update(aoMensagem);
    }

  }
}
