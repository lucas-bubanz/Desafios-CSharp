using AgendaDeContatos.Enums.ETipoDeContato;

namespace AgendaDeContatos.Models.EstruturaContatos
{
    public class Contatos
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }

        public ETipoDeContato eTipoDeContato { get; set; }

        public Contatos(string nome, string telefone, ETipoDeContato eTipoDeContato)
        {
            this.Nome = nome;
            this.Telefone = telefone;
            this.eTipoDeContato = eTipoDeContato;
        }
    }
}