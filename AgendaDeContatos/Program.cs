using AgendaDeContatos.Enums.ETipoDeContato;
using AgendaDeContatos.Models.EstruturaContatos;
using AgendaDeContatos.Services.GerenciarContatos;

namespace AgendaDeContatos
{
    class Program
    {
        private static GerenciarContatos gerenciador = new GerenciarContatos();
        public static void AdicionarContatoNaEstrutura(string nomeContato, string telefoneContato, ETipoDeContato tipoContato)
        {

            var contato = new Contatos(
                nome: nomeContato,
                telefone: telefoneContato,
                eTipoDeContato: tipoContato
            );
            gerenciador.AdicionarContato(contato);
        }
        public static void Main()
        {

            AdicionarContatoNaEstrutura("Lucas", "51653429795", ETipoDeContato.Externo);
            AdicionarContatoNaEstrutura("Mateus", "51999556622", ETipoDeContato.Interno);
            AdicionarContatoNaEstrutura("Gabriel", "51345981897", ETipoDeContato.Interno);
            AdicionarContatoNaEstrutura("Rafael", "51975497489", ETipoDeContato.Externo);

            gerenciador.ListarContato();
            gerenciador.RemoverContato("Gabriel");
            gerenciador.BuscarContato("Lucas");
        }
    }
}