using System;
using System.Data;
using System.Data.OleDb;

namespace DentalSoftware.Utils
{
    public class AppointmentService
    {
        private DatabaseService _dbService;

        public AppointmentService(DatabaseService dbService)
        {
            _dbService = dbService;
        }

        public DataTable GetDataTable(DateTime date)
        {
            string query = "SELECT [ROW_NUMBER], [NAME], [DESCRIPTION], [PHONE_NUMBER], [ROW_NUMBER], [COLOR_NAME], [COLOR_DESCRIPTION], [COLOR_PHONE_NUMBER] FROM APPOINTMENT WHERE [DATE] = @date ORDER BY [ROW_NUMBER]";

            OleDbParameter pDATE = new OleDbParameter("@date", date.Date);

            return _dbService.GetDataTable(query, pDATE);
        }

        public int InsertOrUpdate(DateTime date, byte rowNumber, string fieldName, object value)
        {
            string querySelect = "SELECT * FROM APPOINTMENT WHERE [DATE] = @date AND [ROW_NUMBER] = @rowNumber";

            OleDbParameter pDATE = new OleDbParameter("@date", date.Date);
            OleDbParameter pROW_NUMBER = new OleDbParameter("@rowNumber", rowNumber);
            OleDbParameter pFIELD = new OleDbParameter("@field", value);

            DataTable table = _dbService.GetDataTable(querySelect, pDATE, pROW_NUMBER);

            string query = string.Empty;
            OleDbParameter[] values = null;

            if (table.Rows.Count == 0)
            {
                query = $"INSERT INTO APPOINTMENT ([DATE], [ROW_NUMBER], [{fieldName}]) VALUES (@date, @rowNumber, @field)";

                values = new[] { pDATE, pROW_NUMBER, pFIELD };
            }
            else
            {
                query = $"UPDATE APPOINTMENT SET [{fieldName}] = @field WHERE [DATE] = @date AND [ROW_NUMBER] = @rowNumber";

                values = new[] { pFIELD, pDATE, pROW_NUMBER };
            }

            return _dbService.ExecuteNonQuery(query, values);
        }
    }
}
