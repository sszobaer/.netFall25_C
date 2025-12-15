using System;
using System.Collections.Generic;

namespace IntroEFDBFAPICore.EF.Models;

public partial class Course
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Code { get; set; } = null!;

    public int Credit { get; set; }

    public string Type { get; set; } = null!;

    public int DeptId { get; set; }

    public int Capacity { get; set; }

    public virtual ICollection<CourseStudent> CourseStudents { get; set; } = new List<CourseStudent>();

    public virtual Department Dept { get; set; } = null!;
}
