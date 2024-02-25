using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using WAD._13344.Application.DTOs;

namespace WAD._13344.Application.Functions.Books.Query.GetAll
{
    public class GetAllBooksQuery : IRequest<List<BookDto>>
    {

    }
}
