using ApexRestaurant.Repository.Domain;
using ApexRestaurant.Services.SCustomer;
using Microsoft.AspNetCore.Mvc;

namespace ApexRestaurant.Api.Controllers
{
    [Route("api/[controller]")]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;
    
    public CustomerController(ICustomerService customerService)
    {
        _customerService = customerService;
    }

    [HttpGet]
    [Route("{id}")]
    public IActionResult Get([FromRoute] int id)
    {
        var customer = _customerService.GetById(id);

        if (customer == null)
        return NotFound();

        return Ok(customer);
    }

    [HttpGet]
    [Route("")]
    public IActionResult GetAll()
    {
        var customers = _customerService.GetAll();
        return Ok(customers);
    }

    [HttpPost]
    [Route("")]
    public IActionResult Post([FromBody] Customer model)
    {
        _customerService.Insert(model);
        return Ok();
    }


    [HttpPut]
    [Route("")]
    public IActionResult Put([FromBody] Customer model)
    {
        _customerService.Update(model);
        return Ok();
    }

    [HttpDelete]
    [Route("{id}")]
    public IActionResult Delete([FromRoute] int id)
    {
        var customer = _customerService.GetById(id);
        _customerService.Delete(customer);

        return Ok();
    }

    }

}