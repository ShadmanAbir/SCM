using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SCM.Interfaces;
using SCM.Model.Items;
using SCM.ViewModel.Requisitions;

namespace SCM.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RequisitionController : ControllerBase
    {
        private readonly IRequisitionService _requisitionService;

        public RequisitionController(IRequisitionService requisitionService)
        {
            _requisitionService = requisitionService;
        }

        // GET: api/Requisition
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RequisitionMasterViewModel>>> GetRequisitionOfUser()
        {
            return Ok(await _requisitionService.GetAllRequisitionOfUser());
        }

        // GET: api/Requisition/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RequisitionMasterViewModel>> GetRequisitionByID(int id)
        {
            return Ok(await _requisitionService.GetRequisitionByID(id));
        }

        // PUT: api/Requisition/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRequisitionMaster(int id, RequisitionMasterViewModel reqVM)
        {
            return Ok(await _requisitionService.UpdateRequisition(id, reqVM));
        }

        // POST: api/Requisition
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<RequisitionMasterViewModel>> PostRequisitionMaster(RequisitionMasterViewModel reqVM)
        {
            return Ok(await _requisitionService.AddRequisition(reqVM));
        }

        // DELETE: api/Requisition/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRequisitionMaster(int id)
        {
            return Ok(await _requisitionService.Removerequisition(id));
        }
    }
}
