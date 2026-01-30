namespace WthJeopardy.Models;

public sealed class JeopardyBoard
{
    public List<JeopardyCategory> Categories { get; set; } = new();
}

public sealed class JeopardyCategory
{
    public string Name { get; set; } = string.Empty;
    public List<JeopardyQuestion> Questions { get; set; } = new();
}

public sealed class JeopardyQuestion
{
    public int Value { get; set; }
    public string Prompt { get; set; } = string.Empty;
    public string Answer { get; set; } = string.Empty;
    public bool IsDailyDouble { get; set; }

    public string CategoryName { get; set; } = string.Empty;
    public bool IsAnswered { get; set; }
}
