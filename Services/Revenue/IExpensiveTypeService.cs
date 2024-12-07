using Finance.Models;

namespace Finance.Service.Revenue;

public interface IExpensiveTypeService
{
    public Task<ExpensiveTypeDto> GetById(int id);
    public Task<List<ExpensiveTypeDto>> GetAll();
    public Task<ExpensiveTypeDto> Create(ExpensiveTypeDto dto);
    public Task<ExpensiveTypeDto> Update(ExpensiveTypeDto dto);
}
