static class Badge
{
    public static string Print(int? id, string name, string? department)
    {
        if (id == null)
        {
            return department == null ? $"{name} - OWNER" : $"{name} - {department.ToUpper()}";
        }else if (department == null)
        {
            return $"[{id}] - {name} - OWNER";
        }
        return $"[{id}] - {name} - {department.ToUpper()}";
    }
}
