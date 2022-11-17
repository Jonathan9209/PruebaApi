using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;


namespace nombremicroservicio.API.Controllers
{
    [ApiVersion("1")]
    // [Route(Constants.RouteVersion)]
    [Route("example")]
    [ApiController]
    public class ExampleController : ControllerBase
    {
        private readonly ILogger ILogger;


        public ExampleController(ILogger<ExampleController> iLogger )
        {
            this.ILogger = iLogger;
        }

        #region GET METHODS
        /// <summary>
        /// Ejemplo documentacion GET.
        /// </summary>
        /// <param name="id"></param>  
        [HttpGet]
        [Route("GET")]
        public IActionResult GetExample(int id)
        {
     
            return Ok();
       
        }
        #endregion GET METHODS

        #region  POST METHODS
        /// <summary>
        /// Ejemplo documentacion POST.
        /// </summary>
        /// <returns>A newly created TodoItem</returns>
        /// <response code="201">Returns the newly created item</response>
        /// <response code="400">If the item is null</response>   
        [HttpPost]
        [Route("POST")]
        public IActionResult PostExample()
        {
            return Ok("test");
        }
        #endregion POST METHODS
      
    }
}