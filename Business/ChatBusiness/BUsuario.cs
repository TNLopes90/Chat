using ChatDALFactory;
using ChatIDAL;
using ChatModel;
using System;

namespace ChatBusiness
{
  public class BUsuario : ChatBusinessObject<Usuario>
  {
    public BUsuario(Usuario aoUsuario)
      : base(aoUsuario)
    {
    }

    public void AtualizarData()
    {
      this.ioOwer.UsrDtAcesso = DateTime.Now;
    }

    public bool UsuarioExiste()
    {
      IUsuarioDAL loUsuarioDAL = ConcreteDALFactory.CreateUsuarioDAL();
      Usuario loUsuario = loUsuarioDAL.Load(this.ioOwer.UsrDsNickname);
      return loUsuarioDAL != null;
    }
  }
}
