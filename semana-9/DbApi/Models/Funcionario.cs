using DbApi.Models;
namespace DbApi.Models;

public class Funcionario
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public Cliente Dados { get; set; }
    public string Funcao { get; set; }

}