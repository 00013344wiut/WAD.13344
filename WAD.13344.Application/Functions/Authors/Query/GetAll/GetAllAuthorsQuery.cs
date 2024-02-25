using MediatR;
using WAD._13344.Application.DTOs;

namespace WAD._13344.Application.Functions.Authors.Query.GetAll
{
    public class GetAllAuthorsQuery : IRequest<List<AuthorDto>>
    {
    }
}
