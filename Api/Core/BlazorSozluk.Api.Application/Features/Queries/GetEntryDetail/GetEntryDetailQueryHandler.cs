using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlazorSozlukCommon.ViewModels.Queries;
using BlazorSozluk.Api.Application.Interfaces.Repositories;

namespace BlazorSozluk.Api.Application.Features.Queries.GetEntryDetail
{
    public class GetEntryDetailQueryHandler : IRequestHandler<GetEntryDetailQuery, GetEntryCommentDetailViewModel>
    {
        private readonly IEntryRepository entryRepository;
        public GetEntryDetailQueryHandler(IEntryRepository entryRepository)
        {
            this.entryRepository = entryRepository;
        }
    }
}
