namespace Hospital_Management2.Services
{
    public interface IEmailServices
    {
        public void SendEmail(string emailTo, string recepientName, string subject, string body);
    }
}
