using System;
using System.Collections.Generic;

namespace IntroEFDBFAPICore.EF.Models;

public partial class Registration
{
    public int Id { get; set; }

    public DateTime Date { get; set; }

    public string Status { get; set; } = null!;

    public int StudentId { get; set; }

    public virtual ICollection<CourseStudent> CourseStudents { get; set; } = new List<CourseStudent>();

    public virtual Student Student { get; set; } = null!;
}
