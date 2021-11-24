
namespace DataConverter.Interfaces
{
    public interface IContact
    {
        int ID { get; }
        string Lastname { get; }
        string Firstname { get; }
        string Middlename { get; }
        string Phone { get; }
    }
}
