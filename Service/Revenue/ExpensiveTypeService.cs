using AutoMapper;
using Finance.Models;
using Finance.Service.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;

namespace Finance.Service.Revenue;

public class ExpensiveTypeService : IExpensiveTypeService
{
    private readonly IGenericRepository<ExpensiveType> _repository;
    private readonly IMapper _mapper;

    public ExpensiveTypeService(IGenericRepository<ExpensiveType> repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<ExpensiveTypeDto> GetById(int id)
    {
        return _mapper.Map<ExpensiveTypeDto>(await _repository.GetById(id));
    }

    public async Task<List<ExpensiveTypeDto>> GetAll()
    {
        var entities = await _repository.GetAll().ToListAsync();
        return _mapper.Map<List<ExpensiveTypeDto>>(entities);
    }

    public async Task<ExpensiveTypeDto> Create(ExpensiveTypeDto expensiveTypeDto)
    {
        var entity = _mapper.Map<ExpensiveType>(expensiveTypeDto);

        var createdEntity = await _repository.Create(entity);

        return _mapper.Map<ExpensiveTypeDto>(createdEntity);
    }

    public async Task<ExpensiveTypeDto> Update(ExpensiveTypeDto expensiveTypeDto)
    {
        var entity = await _repository.GetById(expensiveTypeDto.Id);
        entity.Name = expensiveTypeDto.Name;
        entity.Expenses = expensiveTypeDto.Expenses;

        var updatedEntity = await _repository.Update(entity);

        return _mapper.Map<ExpensiveTypeDto>(updatedEntity);
    }
}
