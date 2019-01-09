﻿using everis.SimpleProject.Domain.Models;
using everis.SimpleProject.Domain.Service;
using everis.SimpleProject.Domain.Services;
using Microsoft.AspNetCore.Mvc;
using System;

namespace everis.SimpleProject.API.Controllers
{
    public class ChangeController : BaseController<Change>
    {
        [HttpGet("[action]")]
        public virtual IActionResult BuscarListaPorId([FromServices]IChangeService svc, Change obj)
        {
            try
            {
                var retorno = new Retorno()
                {
                    Codigo = 200,
                    Data = svc.ObterListaPorId(obj)
                };
                return Ok(retorno);

            }
            catch (Exception ex)
            {
                return BadRequest(new Retorno()
                {
                    Codigo = 500,
                    Mensagem = ex.Message
                });
            }
        }
    }
}
