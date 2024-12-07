using Finance.Models;

namespace Finance.Service.Revenue;

public interface IExpensiveTypeService
{
    public Task<ExpensiveType> GetById(int id);
    public Task<List<ExpensiveTypeDto>> GetAll();
    public Task<ExpensiveTypeDto> Create(ExpensiveTypeCreateDto dto);
    public Task<ExpensiveTypeDto> Update(int id, ExpensiveTypeCreateDto dto);
}
