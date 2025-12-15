using System;
using System.Collections.Generic;

namespace IntroEFDBFAPICore.EF.Models;

public partial class Employee
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string EmpId { get; set; } = null!;

    public string Designation { get; set; } = null!;
}
