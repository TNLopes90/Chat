namespace ChatIDAL
{
  public interface ICrudDAL<T>
  {
    void Insert(T aoT);
    void Update(T aoT);
    void Delete(T aoT);
    T Load(object aoKey);
  }
}
