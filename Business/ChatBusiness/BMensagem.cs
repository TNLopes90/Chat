using ChatModel;

namespace ChatBusiness
{
  public class BMensagem : ChatBusinessObject<Mensagem>
  {
    public BMensagem(Mensagem aoMensagem)
      : base(aoMensagem)
    {
    }
  }
}
