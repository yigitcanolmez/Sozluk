using BlazorSozluk.Api.Application.Features.Queries.GetEntries;
using BlazorSozluk.Api.Application.Features.Queries.GetEntries.GetMainPageEntries;
using BlazorSozlukCommon.ViewModels.RequestModels;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorSozluk.Api.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EntryController : BaseController
    {
        private readonly IMediator meditor;
        public EntryController(IMediator meditor)
        {
            this.meditor = meditor;
        }

        [HttpGet]
        public async Task<IActionResult> GetEntries([FromQuery]GetEntriesQuery query)
        {
            var entries = await meditor.Send(query);
            return Ok(entries);
        }
        [HttpGet]
        [Route("MainPageEntries")]
        public async Task<IActionResult> GetMainPageEntries(int page,int pageSize)
        {
            var entries = await meditor.Send(new GetMainPageEntriesQuery(UserID,page, pageSize));
            return Ok(entries);
        }





        [HttpPost]
        [Route("CreateEntry")]
        public async Task<IActionResult> CreateEntry([FromBody] CreateEntryCommand command)
        {
            var result = await meditor.Send(command);

            return Ok(result);
        }

        [HttpPost]
        [Route("CreateEntryComment")]
        public async Task<IActionResult> CreateEntryComment([FromBody] CreateEntryCommentCommand command)
        {
            
            var result = await meditor.Send(command);

            return Ok(result);
        }

    }
}
