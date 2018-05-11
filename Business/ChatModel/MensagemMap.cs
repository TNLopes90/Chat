using FluentNHibernate.Mapping;

namespace ChatModel
{
  /// <summary>
  /// Classe responsável por fazer o mapeamento entre o banco e o modelo lógico.
  /// Tabela Mensagem.
  /// </summary>
  public class MensagemMap : ClassMap<Mensagem>
  {
    /// <summary>
    /// Método de mapeamento.
    /// </summary>
    public MensagemMap()
    {
      Table("MEN_Mensagem");
      Id(m => m.MenIdMensagem).Unique().GeneratedBy.Identity().Column("MEN_id_mensagem");
      Map(m => m.MenDsMensagem).Column("MEN_ds_mensagem");
      Map(m => m.MenDtEnvio).Column("MEN_dt_envio");
      References<Usuario>(m => m.UsuarioEnvio)
        .Column("MEN_id_usuario_envio");
      References<Usuario>(m => m.UsuarioDestino)
        .Column("MEN_id_usuario_destino");
    }
  }
}
