using BusinessLayer.Interface;
using BusinessLayer.Service;
using Microsoft.AspNetCore.Mvc;
using ModelLayer.Model;
using NLog;

namespace HelloGreetingApplication.Controllers
{

    /// <summary>
    /// Class Providing API for HelloGreeting
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class HelloGreetingController : ControllerBase
    {
        
        private static readonly Logger _logger = LogManager.GetCurrentClassLogger();
        private readonly IGreetingBL _greetingBL;

        public HelloGreetingController(IGreetingBL greetingBL) // Use the interface
        {
            _greetingBL = greetingBL;
        }

        /// <summary>
        /// Get method to get the Greeting Message
        /// </summary>
        /// <returns>"Hello World"</returns>
        [HttpGet]
        public IActionResult Get()
        {
            ResponseModel<String> responseModel = new ResponseModel<string>();

            responseModel.Success = true;
            responseModel.Message = "API Endpoint Hit";
            responseModel.Data = "Hello World";
            _logger.Info("Get Method Executed");
            return Ok(responseModel);
        }

        /// <summary>
        /// Post method to accept a custom greeting message
        /// </summary>
        /// <param name="requestModel">Greeting message from user</param>
        /// <returns>Confirmation response</returns>
        [HttpPost]
        public IActionResult Post(RequestModel requestModel)
        {
            ResponseModel<String> responseModel = new ResponseModel<string>();

            responseModel.Success = true;
            responseModel.Message = "API Endpoint Hit";
            responseModel.Data = $"Key: {requestModel.Key} , Value : {requestModel.Value} ";
            _logger.Info("Post Method Executed");
            return Ok(responseModel);


        }

        /// <summary>
        /// Put method to accept a custom greeting message
        /// </summary>
        /// <param name="requestModel">Greeting message from user</param>
        /// <returns>Confirmation response</returns>
        [HttpPut]
        public IActionResult Put(RequestModel requestModel)
        {
            ResponseModel<String> responseModel = new ResponseModel<string>();

            responseModel.Success = true;
            responseModel.Message = "API Endpoint Hit in Put Method";
            responseModel.Data = $"Key: {requestModel.Key} , Value : {requestModel.Value} ";
            _logger.Info("Put Method Executed");
            return Ok(responseModel);
            
        }

        /// <summary>
        /// Patch method to accept a custom greeting message
        /// </summary>
        /// <param name="requestModel">Greeting message from user</param>
        /// <returns>Confirmation response</returns>
        [HttpPatch]
        public IActionResult Patch(RequestModel requestModel)
        {
            ResponseModel<String> responseModel = new ResponseModel<string>();

            responseModel.Success = true;
            responseModel.Message = "API Endpoint Hit";
            responseModel.Data = $"Key: {requestModel.Key} , Value : {requestModel.Value} ";
            _logger.Info("Patch Method Executed");
            return Ok(responseModel);
        }

        /// <summary>
        /// Delete method to remove a greeting message
        /// </summary>
        [HttpDelete]
        public IActionResult Delete()
        {

            ResponseModel<String> responseModel = new ResponseModel<string>();

            responseModel.Success = true;
            responseModel.Message = "API Endpoint Hit";
            responseModel.Data = null ;
            _logger.Info("Detele Method Executed");
            return Ok(responseModel);
        }

        [HttpGet("greet")]
        public string get()
        {
           return _greetingBL.getGreetMessage();
        }
    }
}
