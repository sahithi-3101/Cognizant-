using Microsoft.AspNetCore.Mvc;
using EmployeeWebAPI.Filters;
using EmployeeWebAPI.Models;

namespace EmployeeWebAPI.Controllers;

[ApiController]
[Route("api/Emp")]
[CustomAuthFilter]
public class EmployeeController : ControllerBase
{
    private static readonly List<Employee> employees =
    [
        new Employee
        {
            Id = 1,
            Name = "John",
            Salary = 50000,
            Permanent = true,
            DateOfBirth = new DateTime(1998, 5, 10),
            Department = new Department
            {
                Id = 1,
                Name = "IT"
            },
            Skills = new List<Skill>
            {
                new Skill { Id = 1, Name = "C#" },
                new Skill { Id = 2, Name = "ASP.NET Core" }
            }
        },
        new Employee
        {
            Id = 2,
            Name = "Alice",
            Salary = 45000,
            Permanent = false,
            DateOfBirth = new DateTime(2000, 2, 15),
            Department = new Department
            {
                Id = 2,
                Name = "HR"
            },
            Skills = new List<Skill>
            {
                new Skill { Id = 3, Name = "Communication" },
                new Skill { Id = 4, Name = "Recruitment" }
            }
        }
    ];

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public ActionResult<IEnumerable<Employee>> GetEmployees()
    {
        return Ok(employees);
    }

    [HttpGet("{id}")]
    public ActionResult<Employee> GetEmployee(int id)
    {
        var employee = employees.FirstOrDefault(e => e.Id == id);

        if (employee == null)
        {
            return NotFound();
        }

        return Ok(employee);
    }

    [HttpPost]
    public ActionResult<Employee> AddEmployee([FromBody] Employee employee)
    {
        employee.Id = employees.Count == 0
            ? 1
            : employees.Max(e => e.Id) + 1;

        employees.Add(employee);

        return CreatedAtAction(
            nameof(GetEmployee),
            new { id = employee.Id },
            employee);
    }

    [HttpPut("{id}")]
    public ActionResult<Employee> UpdateEmployee(
        int id,
        [FromBody] Employee updatedEmployee)
    {
        if (id <= 0)
        {
            return BadRequest("Invalid employee id");
        }

        var employee = employees.FirstOrDefault(e => e.Id == id);

        if (employee == null)
        {
            return BadRequest("Invalid employee id");
        }

        employee.Name = updatedEmployee.Name;
        employee.Salary = updatedEmployee.Salary;
        employee.Permanent = updatedEmployee.Permanent;
        employee.Department = updatedEmployee.Department;
        employee.Skills = updatedEmployee.Skills;
        employee.DateOfBirth = updatedEmployee.DateOfBirth;

        return Ok(employee);
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteEmployee(int id)
    {
        var employee = employees.FirstOrDefault(e => e.Id == id);

        if (employee == null)
        {
            return NotFound();
        }

        employees.Remove(employee);

        return NoContent();
    }
}
