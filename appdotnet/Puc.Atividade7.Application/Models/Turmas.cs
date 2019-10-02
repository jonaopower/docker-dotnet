using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Puc.Atividade7.Application.Models
{
    public class ListaTurmas
    {
        public Turma[] Turmas { get; set; }
    }

    public class Turma
    {
        public int Id { get; set; }
        public string Nome { get; set; }
    }

    public class ListaDisciplinas
    {
        public Disciplina[] Disciplinas { get; set; }
    }

    public class Disciplina
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int TurmaId { get; set; }
    }
}
