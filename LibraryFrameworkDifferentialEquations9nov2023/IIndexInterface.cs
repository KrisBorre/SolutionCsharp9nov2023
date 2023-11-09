namespace LibraryFrameworkDifferentialEquations9nov2023
{
    // Indexer on an interface:
    public interface IIndexInterface<T>
    {
        // Indexer declaration:
        T this[int index]
        {
            get;
            set;
        }
    }
}
