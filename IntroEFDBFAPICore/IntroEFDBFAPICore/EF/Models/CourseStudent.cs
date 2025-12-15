using System;
using System.Collections.Generic;

namespace IntroEFDBFAPICore.EF.Models;

public partial class CourseStudent
{
    public int Id { get; set; }

    public int Sid { get; set; }

    public int Cid { get; set; }

    public int RegId { get; set; }

    public virtual Course CidNavigation { get; set; } = null!;

    public virtual Registration Reg { get; set; } = null!;

    public virtual Student SidNavigation { get; set; } = null!;
}
