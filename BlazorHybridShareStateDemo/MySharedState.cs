namespace BlazorHybridShareStateDemo
{
    public class MySharedState
    {
        public int CurrentCount { get; private set; }

        public event EventHandler CountChanged;

        public void IncrementCount()
        {
            CurrentCount++;
            CountChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}
