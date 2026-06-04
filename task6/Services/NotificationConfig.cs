namespace task6.Services
{
    public class NotificationConfig
    {
        public int DefaultNumberOfNotifications { get; set; } = 3;
        public string NotificationStyle { get; set; } = "Compact"; 

        public event Action? OnConfigChanged;
        public void NotifyStateChanged() => OnConfigChanged?.Invoke();
    }
}