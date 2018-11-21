using System;
using System.Data;
using System.Data.OleDb;

namespace DentalSoftware.Utils
{
    public class PatientService
    {
        private DatabaseService _dbService;

        public PatientService(DatabaseService dbService)
        {
            _dbService = dbService;
        }

        public DataTable GetDataTable()
        {
            string query = @"SELECT [ID]
                                   ,[NAME]
                                   ,[SURNAME]
                                   ,[ADDRESS]
                                   ,[PHONE_NUMBER]
                                   ,[BOOK_NAME]
                                   ,[BOOK_PAGE_NUMBER]
                                   ,[CREATED_DATE]
                                   ,[MODIFIED_DATE]
                                   ,IIF([TREATMENT].[BALANCE] IS NULL, 0, [TREATMENT].[BALANCE]) AS [BALANCE]
                             FROM PATIENT

                             LEFT JOIN (
                                 SELECT [PATIENT_ID]
                                       ,SUM([PRICE] - [PAID]) AS [BALANCE]
                                 FROM TREATMENT
                                 GROUP BY [PATIENT_ID]
                             ) TREATMENT ON TREATMENT.PATIENT_ID = PATIENT.ID

                             WHERE [ACTIVE] = @active

                             ORDER BY [SURNAME], [NAME]";

            OleDbParameter pACTIVE = new OleDbParameter("@active", true);

            return _dbService.GetDataTable(query, pACTIVE);
        }

        public string GetTeethMap(int patientId)
        {
            string query = "SELECT [TEETH_MAP] FROM PATIENT WHERE [ID] = @id";

            OleDbParameter pID = new OleDbParameter("@id", patientId);

            DataTable table = _dbService.GetDataTable(query, pID);

            return table.Rows[0][0].ToString();
        }

        public void SetTeethMap(int patientId, string teethMap)
        {
            string query = "UPDATE PATIENT SET [TEETH_MAP] = @teethMap WHERE [ID] = @id";

            OleDbParameter pTEETH_MAP = new OleDbParameter("@teethMap", teethMap);
            OleDbParameter pID = new OleDbParameter("@id", patientId);

            _dbService.ExecuteNonQuery(query, pTEETH_MAP, pID);
        }

        public int Insert()
        {
            throw new NotImplementedException();
        }

        public int Update()
        {
            throw new NotImplementedException();
        }

        public int Delete()
        {
            throw new NotImplementedException();
        }
    }
}
