using FluentNHibernate.Mapping;

namespace ChatModel
{
  /// <summary>
  /// Classe responsável por fazer o mapeamento entre o banco e o modelo lógico.
  /// Tabela Usuário.
  /// </summary>
  public class UsuarioMap : ClassMap<Usuario>
  {
    /// <summary>
    /// Método de mapeamento.
    /// </summary>
    public UsuarioMap()
    {
      Table("USR_Usuario");
      Id(u => u.UsrDsNickname).Unique().Not.Nullable().Column("USR_ds_nickname");
      Map(u => u.UsrDtAcesso).Column("USR_dt_acesso");
    }
  }
}
