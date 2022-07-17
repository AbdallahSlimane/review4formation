namespace Data
{
    public interface IContactRepository
    {
        void SaveMessage(string nom, string email, string message);
    }
}