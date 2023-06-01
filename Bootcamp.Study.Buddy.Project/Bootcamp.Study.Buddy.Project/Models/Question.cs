using System;
using System.Collections.Generic;

namespace Bootcamp.Study.Buddy.Project.Models;

public partial class Question
{
    public int Id { get; set; }

    public string? QuestionTitle { get; set; }

    public string? Answer { get; set; }
}
