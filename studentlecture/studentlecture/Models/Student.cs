using System;
using System.Collections.Generic;

namespace studentlecture.Models;

public partial class Student
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string RollNum { get; set; } = null!;

    public int? TaughtByLecturerId { get; set; }

    public virtual Lecturer? TaughtByLecturer { get; set; }
}
