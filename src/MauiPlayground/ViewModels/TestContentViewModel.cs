namespace MauiPlayground.ViewModels;

public partial class TestContentViewModel : ObservableObject
{

    public IList<string> Alphabet => ["A", "B", "C"];

    public List<TestModel> Models { get; init; } = [
        new(1, 1, "Test1"),
        new(2, 2, "Test2")];

    public List<TestModel2> Models2 { get; init; } = [
        new() { Id = 1, CompanyId = 1, Name = "Test1" }];

    [RelayCommand]
    void Sample()
    {

    }
}

public record TestModel(int Id, int CompanyId, string Name);

public class TestModel2
{
    public int Id { get; set; }
    public int CompanyId { get; set; }
    public string Name { get; set; }
}
