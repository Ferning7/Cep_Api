using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultaCep
{
    public class Endereco
    {
        private string cep;
        private string logradouro;
        private string complemento;
        private string bairro;
        private string cidade;
        private string uf;

        public string Cep
        {
            get { return cep; }
            set { cep = value; }
        }
        public string Logradouro
        {
            get { return logradouro; }
            set { logradouro = value; }
        }
        public string Complemento
        {
            get { return complemento; }
            set { complemento = value; }
        }
        public string Bairro
        {
            get { return bairro; }
            set { bairro = value; }
        }
        public string Cidade
        {
            get { return cidade; }
            set { cidade = value; }
        }
        public string Uf
        {
            get { return uf; }
            set { uf = value; }
        }
        

    }

}
