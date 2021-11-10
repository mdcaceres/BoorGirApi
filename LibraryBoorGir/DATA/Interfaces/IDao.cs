using System.Data;

namespace LibraryBoorGir.Interfaces
{
    public interface IDao
    {
        int GetNext();
        DataTable ReturnTable(CommandType type, string CommandText);
        int BringInt(CommandType type, string CommandText, string ParamName, SqlDbType sqlType, ParameterDirection direction);
        DataTable ReturnTable(CommandType type, string CommandText, string name, object value);
    }
}
