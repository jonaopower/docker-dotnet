using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Puc.Atividade7.Application.Models;

namespace Puc.Atividade7.Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TurmasController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return new ObjectResult(new ListaTurmas
                {
                    Turmas = new Turma[]
                    {
                        new Turma{
                            Id = 1,
                            Nome = "Arquitetura de Software Distribuído - Oferta 11",
                        },
                        new Turma{
                            Id = 2,
                            Nome = "Arquitetura de Software Distribuído - Oferta 12",
                        },
                    },
                });

                //return new ObjectResult(service.Get());
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpGet("{id}", Name = "GetTurma")]
        public IActionResult Get(int id)
        {
            try
            {
                return new ObjectResult(new Turma
                {
                    Id = 1,
                    Nome = "Arquitetura de Software Distribuído - Oferta 11",
                });
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