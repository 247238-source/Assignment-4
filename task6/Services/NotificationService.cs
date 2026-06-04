namespace task6.Services
{
    public class NotificationService
    {
        private readonly NotificationConfig _config;
        public NotificationService(NotificationConfig config)
        {
            _config = config;
        }

        public async Task<List<string>> GetNotificationsAsync(int? numberOfNotifications = null)
        {
            int count = numberOfNotifications ?? _config.DefaultNumberOfNotifications;
            var notifications = new List<string>();

            await Task.Delay(100);

            for (int i = 1; i <= count; i++)
            {
                notifications.Add($"System Alert: You have a new message (#{i}).");
            }
            return notifications;
        }
    }
}