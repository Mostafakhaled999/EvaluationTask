using EvaluationTask.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EvaluationTask.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShipmentController : ControllerBase
    {
        private readonly DataContext _dataContext;

        public ShipmentController(DataContext context)
        {
            _dataContext = context;
        }
        [HttpGet]
        public async Task<ActionResult<List<Shipment>>> getShipment()
        {
            return Ok(await _dataContext.Shipment.ToListAsync());
        }

        [HttpPost]
        public async Task<ActionResult<List<Shipment>>> createShipment(Shipment shipment)
        {
            _dataContext.Shipment.Add(shipment);
            await _dataContext.SaveChangesAsync();
            return Ok(await _dataContext.Shipment.ToListAsync());
        }

        [HttpPut]
        public async Task<ActionResult<List<Shipment>>> updateShipment(Shipment shipment)
        {
            var dbShipment = await _dataContext.Shipment.FindAsync(shipment.id);
            if(dbShipment == null)
            {
                return BadRequest("Shipment was not found");
            }

            dbShipment.name = shipment.name;
            dbShipment.fromDate = shipment.fromDate;
            dbShipment.toDate = shipment.toDate;
            dbShipment.noBoxes = shipment.noBoxes;

            await _dataContext.SaveChangesAsync();

            return Ok(await _dataContext.Shipment.ToListAsync());
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Shipment>>> deleteShipment(int id)
        {
            var dbShipment = await _dataContext.Shipment.FindAsync(id);
            if (dbShipment == null)
            {
                return BadRequest("Shipment was not found");
            }

            _dataContext.Shipment.Remove(dbShipment);
            await _dataContext.SaveChangesAsync();
            return Ok(await _dataContext.Shipment.ToListAsync());
        }
    }
}