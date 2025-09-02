using System;
using System.Collections.Generic;

namespace studentlecture.Models;

public partial class Lecturer
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Subject { get; set; } = null!;

    public virtual ICollection<Student> Students { get; set; } = new List<Student>();
}
