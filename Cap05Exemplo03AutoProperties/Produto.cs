using System.Globalization;

namespace Cap05Exemplo03AutoProperties
{
    public class Produto
    {
        private string _nome;
        public double Preco { get; private set;}
        public int Quantidade { get; private set;}

        public Produto()
        {

        }

        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }
        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }

        /*
        public string GetNome()
        {
            return _nome;
        }

        public void SetNome(string nome)
        {
            if (nome != null && nome.Length > 1)
            {
                _nome = nome;
            }
        }

        public double GetPreco()
        {
            return _preco;
        }

        public double GetQuantidade()
        {
            return _quantidade;
        }
        
        public double Preco
        {
            get
            {
                return _preco;
            }
        }

        public int quantidade
        {
            get
            {
                return _quantidade;
            }
        }

        */

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int qte)
        {
            Quantidade += qte;
        }

        public void RemoverProdutos(int qte)
        {
            Quantidade -= qte;
        }

        public override string ToString()
        {
            return _nome
                + ", $ "
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " Unidades, Total: $ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}