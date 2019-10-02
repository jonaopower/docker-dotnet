using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Puc.Atividade7.Application.Models;

namespace Puc.Atividade7.Application.Controllers
{
    [Route("api/Turmas/{turmaId}/[controller]")]
    [ApiController]
    public class DisciplinasController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get(int turmaId)
        {
            var disciplinas = new Disciplina[]
            {
                new Disciplina
                {
                    Id = 1,
                    Nome = "APA",
                    TurmaId = 1,
                },
                new Disciplina
                {
                    Id = 2,
                    Nome = "APE",
                    TurmaId = 1,
                },
                new Disciplina
                {
                    Id = 3,
                    Nome = "API",
                    TurmaId = 2,
                }
            };

            try
            {
                return new ObjectResult(disciplinas.Where(d => d.TurmaId == turmaId));
                //return new ObjectResult(service.Get(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpGet("{disciplinaId}", Name = "GetDisciplina")]
        public IActionResult Get(int turmaId, int disciplinaId)
        {
            var disciplinas = new Disciplina[]
            {
                new Disciplina
                {
                    Id = 1,
                    Nome = "APA",
                    TurmaId = 1,
                },
                new Disciplina
                {
                    Id = 2,
                    Nome = "APE",
                    TurmaId = 1,
                },
                new Disciplina
                {
                    Id = 3,
                    Nome = "API",
                    TurmaId = 1,
                }
            };

            try
            {
                return new ObjectResult(disciplinas.FirstOrDefault(d => d.Id == disciplinaId && d.TurmaId == turmaId));
                //return new ObjectResult(service.Get(id));
            }
            catch (ArgumentException ex)
            {
                return NotFound(ex);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}