using Company.Department.Domain;
using MediatR;
using System.Collections.Generic;

namespace Company.Department.Application.Queries
{
     public record GetDepartmentsQuery : IRequest<IEnumerable<DepartmentC>>;
}
