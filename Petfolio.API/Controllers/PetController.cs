using Microsoft.AspNetCore.Mvc;
using Petfolio.Communication.Requests;
using Petfolio.Communication.Responses;
using PetfolioApplication.UseCases.Pet.GetAll;
using PetfolioApplication.UseCases.Pet.GetById;
using PetfolioApplication.UseCases.Pet.Register;
using PetfolioApplication.UseCases.Pet.Update;


namespace Petfolio.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PetController : ControllerBase
{
    [HttpPost]
    [ProducesResponseType(typeof(ResponseRegisteredPetJson), StatusCodes.Status201Created)]
    [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status400BadRequest)]


    public IActionResult Register([FromBody] RequestPetJson request)
    {
        var response = new RegisterPetUseCase().Execute(request); 

        return Created(string.Empty, response);    
    }

    [HttpPut]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status400BadRequest)]
    public IActionResult Update([FromRoute] int id, [FromBody] RequestPetJson request )
    {      
        var usecase = new UpdatePetUseCase();
        usecase.Execute(id, request);
        return NoContent();
    }

    [HttpGet]
    [ProducesResponseType(typeof(ResponseAllPetJson), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult GetAll()
    {
        var useCase = new GetAllPetsUseCase();

        var response = useCase.Execute();

        if (response.Pets.Any())
        {
            return Ok(response);
        }

        return NoContent();
    }

    [HttpGet]
    [ProducesResponseType(typeof(ResponsePetJson), StatusCodes.Status200OK)]]
    [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status404NotFound)]

    public IActionResult Get(int id)
    {

        var useCase = new GetByIdUseCase();

        var response =useCase.Execute(id);

        return Ok(response);
    }





}
