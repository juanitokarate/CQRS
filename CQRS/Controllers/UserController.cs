using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CQRS.CQRScommands.Command;
using CQRS.CQRScommands.Responses;
using CQRS.CQRSmediatrcommands.Command;
using CQRS.CQRSqueries;
using CQRS.CQRSqueries.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace CQRS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserQueryService userQueryService;
        private readonly IEventHandler<CreateNewUserCommand, CreateNewUserResult> eventHandler;

        public UserController(IUserQueryService userQueryService, IEventHandler<CreateNewUserCommand, CreateNewUserResult> eventHandler)
        {
            this.userQueryService = userQueryService;
            this.eventHandler = eventHandler;
        }

        // GET api/values
        [HttpGet("GetAll")]
        public async Task<ActionResult<IEnumerable<UserDTO>>> GetAll()
        {
            try
            {
                var data = await userQueryService.GetAll();
                return Ok(data);
            }
            catch (Exception e)
            {
                return StatusCode(400, e);
            }
        }

        // GET api/values/5
        [HttpGet("GetById/{id}")]
        public async Task<ActionResult<UserDTO>> Get(int id)
        {
            
            try
            {
                var data =  await userQueryService.GetById(id);
                return Ok(data);
            }
            catch (Exception e)
            {

                return StatusCode(400, e);
            }
        }

        // POST api/values
        [HttpPost("Create")]
        public async Task<ActionResult<int>> Create([FromBody] CreateNewUserCommand command)
        {
            var result = await eventHandler.Handle(command);
            return Ok(result);
        }

        // PUT api/values/5
        [HttpPut("UpdateUserName/{id}")]
        public
        async
        Task<ActionResult<int>>
        UpdateUserName
        (int id, [FromBody] UpdateUsernameCommand comand)
        {

            return 1;
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
