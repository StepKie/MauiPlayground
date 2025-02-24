namespace MauiPlayground.ViewModels;

public partial class TestContentViewModel : ObservableObject
{
    public class TestModel2
    {
        public int Id { get; set; }
        public int CompanyId { get; set; }
        public string Name { get; set; }
    }

    public IList<string> Alphabet => new List<string> { "A", "B", "C" };

    public record TestModel(int Id, int CompanyId, string Name);
    public List<TestModel> Models { get; init; } = new() { new(1, 1, "Test1"), new TestModel(2, 2, "Test2") };
    public List<TestModel2> Models2 { get; init; } = new() { new TestModel2 { Id = 1, CompanyId = 1, Name = "Test1" }};

    [RelayCommand]
    void Sample()
    {

    }
}
