using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_S.A.L__PRO_
{
    class Funcio
    {
        private string nome;
        private string aliadas;
        List<string> albVisi = new List<string>();

        public Funcio(string nome, string aliadas)
        {
            this.nome = nome;
            this.aliadas = aliadas;
            albVisi.Add(aliadas);

        }
        public string getNome()
        {
            return this.nome;
        }
        public string getAliadas()
        {
            return this.aliadas;
        }
        public void AlterAliadas(string novaAliada)
        {
            this.aliadas += novaAliada;
            albVisi.Add(novaAliada);
        }
    }
}
