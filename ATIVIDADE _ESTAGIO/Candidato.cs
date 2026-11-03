using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATIVIDADE__ESTAGIO
{
    internal class Candidato
    {
        public string Nome {  get; set; }
        public int Dia { get; set; }
        public int Mes { get; set; }
        public int Ano { get; set; }
        public string AreaDeAtuacao {  get; set; }
        public bool Matutino { get; set; }
        public bool Vespertino {  get; set; }
        public bool Noturno { get; set; }
        public string Escolaridade { get; set; }

        public Candidato()
        {
            this.Dia = 0;
            this.Mes = 0;   
            this.Ano = 0;
        }
        public DateTime DataNascimento => new DateTime(Ano, Mes, Dia);
        public string ToString()
        {
            string turnos = "";
            if (Matutino) turnos += "Matutino";
            if (Vespertino) turnos += "Verspertino";
            if (Noturno) turnos += "Noturno";




            return $"Nome: {Nome}\n" +
            $"Nascimento: {Dia}/{Mes}/{Ano}\n" +
            $"Área: {AreaDeAtuacao}\n" +
            $"Turno: {turnos}\n" +
            $"Escolaridade: {Escolaridade}";
        }
    }
}
