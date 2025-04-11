using AgendaDeContatos.Enums.ETipoDeContato;
using AgendaDeContatos.Models.EstruturaContatos;

namespace AgendaDeContatos.Services.GerenciarContatos
{
    public class GerenciarContatos
    {
        private List<Contatos> _listaContatos;

        public GerenciarContatos()
        {
            _listaContatos = new List<Contatos>();
        }

        public void AdicionarContato(Contatos contato)
        {
            _listaContatos.Add(contato);
        }

        public void ListarContato()
        {
            if (_listaContatos.Count == 0)
            {
                Console.WriteLine("Não há contatos cadastrados.");
                return;
            }
            foreach (var item in _listaContatos)
            {
                Console.WriteLine($"Nome: {item.Nome}");
                Console.WriteLine($"Nome: {item.Telefone}");
                Console.WriteLine($"Nome: {item.eTipoDeContato}");
                Console.WriteLine("<==========================>");
            }
        }

        public void RemoverContato(string nomeDoContato)
        {
            if (String.IsNullOrWhiteSpace(nomeDoContato))
            {
                Console.WriteLine($"Nome do contato não pode ser nulo ou vázio.");
            }
            else
            {
                var contatoEncontrado = _listaContatos.FirstOrDefault(contato => contato.Nome.Equals(nomeDoContato));
                if (contatoEncontrado != null)
                {
                    _listaContatos.Remove(contatoEncontrado);
                    Console.WriteLine($"Contato {nomeDoContato} removido com sucesso.");
                }
                else
                {
                    Console.WriteLine($"Contato {nomeDoContato} não encontrado.");
                }
            }
        }

        public void BuscarContato(string nomeDoContato)
        {
            var contatoEncontrado = _listaContatos.FirstOrDefault(contato => contato.Nome.Equals(nomeDoContato));
            if (contatoEncontrado != null)
            {
                Console.WriteLine($"Nome: {contatoEncontrado.Nome}");
                Console.WriteLine($"Nome: {contatoEncontrado.Telefone}");
                Console.WriteLine($"Nome: {contatoEncontrado.eTipoDeContato}");
                Console.WriteLine("<==========================>");
            }
            else
            {
                Console.WriteLine($"Contato não foi encontrado.");
            }
        }
    }
}