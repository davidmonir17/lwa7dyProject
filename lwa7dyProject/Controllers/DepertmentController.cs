using Domain.DataTransferObject;
using Domain.DataTransferObject.AddDTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lwa7dyProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepertmentController : ControllerBase
    {
        private readonly IDepertmentService _depertmentService;

        public DepertmentController(IDepertmentService depertmentService)
        {
            _depertmentService = depertmentService;
        }

        [HttpGet]
        public IActionResult getDepertments()
        {
            var dep = _depertmentService.GetAllDepertments();
            if (dep == null)
                return BadRequest("no have that Depertment id");
            return Ok(dep);
        }

        [HttpGet("{id}", Name = "GetDeperdment")]
        public IActionResult getDepertmentById(int id)
        {
            var dep = _depertmentService.GetDepertment(id);
            if (dep == null)
                return BadRequest("no have that Depertment id");
            return Ok(dep);
        }

        [HttpPut]
        public IActionResult UpdateDepertment([FromBody] DepertmentDTO depertment)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Check valid Body");
            }
            var dep = _depertmentService.updateDepertment(depertment);
            return CreatedAtRoute("GetDeperdment", new { id = dep.Id }, dep);
        }

        [HttpPost]
        public IActionResult CreateDepertment([FromBody] DepertmentAddDTO addDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Check valid Body");
            }
            var dep = _depertmentService.AddDepertment(addDTO);
            if (dep == null)
                return NotFound();
            return CreatedAtRoute("GetDeperdment", new { Id = dep.Id }, dep);
        }
    }
}