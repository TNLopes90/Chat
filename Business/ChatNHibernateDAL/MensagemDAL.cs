using ChatIDAL;
using ChatModel;

namespace ChatNHibernateDAL
{
  public partial class MensagemDAL : IMensagemDAL
  {
    private CrudDAL<Mensagem> ioCrud = new CrudDAL<Mensagem>();

    public void Delete(Mensagem aoMensagem)
    {
      this.ioCrud.Delete(aoMensagem);
    }

    public void Insert(Mensagem aoMensagem)
    {
      this.ioCrud.Insert(aoMensagem);
    }

    public Mensagem Load(object aoKey)
    {
      return this.ioCrud.Load(aoKey);
    }

    public void Update(Mensagem aoMensagem)
    {
      this.ioCrud.Update(aoMensagem);
    }
  }
}
