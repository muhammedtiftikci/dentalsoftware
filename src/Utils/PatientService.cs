using System;
using System.Data;
using System.Data.OleDb;
using DentalSoftware.Models;

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
            string query = @"SELECT TOP 100
                                    [ID]
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

        public DataTable Search(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                return GetDataTable();
            }

            string query = @"SELECT TOP 100
                                    [ID]
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

                             WHERE [ACTIVE] = @active AND
                                   ([NAME] LIKE @text OR [SURNAME] LIKE @text OR [ADDRESS] LIKE @text OR [PHONE_NUMBER] LIKE @text)

                             ORDER BY [SURNAME], [NAME]";

            OleDbParameter pACTIVE = new OleDbParameter("@active", true);
            OleDbParameter pTEXT = new OleDbParameter("@text", $"%{text.Replace("'", "''")}%");

            return _dbService.GetDataTable(query, pACTIVE, pTEXT);
        }

        public Patient First(int patientId)
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

                             WHERE [ID] = @ID";

            OleDbParameter pID = new OleDbParameter("@ID", patientId);

            DataTable table = _dbService.GetDataTable(query, pID);

            return new Patient()
            {
                ID = patientId,
                NAME = (string)table.Rows[0]["NAME"],
                SURNAME = (string)table.Rows[0]["SURNAME"],
                ADDRESS = (string)table.Rows[0]["ADDRESS"],
                PHONE_NUMBER = (string)table.Rows[0]["PHONE_NUMBER"],
                BOOK_NAME = (string)table.Rows[0]["BOOK_NAME"],
                BOOK_PAGE_NUMBER = (int)table.Rows[0]["BOOK_PAGE_NUMBER"],
            };
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

        public int Insert(Patient model)
        {
            string query = @"INSERT INTO [PATIENT] ([NAME], [SURNAME], [ADDRESS], [PHONE_NUMBER], [BOOK_NAME], [BOOK_PAGE_NUMBER])
                             VALUES (@NAME, @SURNAME, @ADDRESS, @PHONE_NUMBER, @BOOK_NAME, @BOOK_PAGE_NUMBER)";

            OleDbParameter pNAME = new OleDbParameter("@NAME", model.NAME);
            OleDbParameter pSURNAME = new OleDbParameter("@SURNAME", model.SURNAME);
            OleDbParameter pADDRESS = new OleDbParameter("@ADDRESS", model.ADDRESS);
            OleDbParameter pPHONE_NUMBER = new OleDbParameter("@PHONE_NUMBER", model.PHONE_NUMBER);
            OleDbParameter pBOOK_NAME = new OleDbParameter("@BOOK_NAME", model.BOOK_NAME);
            OleDbParameter pBOOK_PAGE_NUMBER = new OleDbParameter("@BOOK_PAGE_NUMBER", model.BOOK_PAGE_NUMBER);

            return _dbService.ExecuteNonQuery(query, pNAME, pSURNAME, pADDRESS, pPHONE_NUMBER, pBOOK_NAME, pBOOK_PAGE_NUMBER);
        }

        public int Update(Patient model)
        {
            string query = @"UPDATE [PATIENT]
                             SET [NAME] = @NAME,
                                 [SURNAME] = @SURNAME,
                                 [ADDRESS] = @ADDRESS,
                                 [PHONE_NUMBER] = @PHONE_NUMBER,
                                 [BOOK_NAME] = @BOOK_NAME,
                                 [BOOK_PAGE_NUMBER] = @BOOK_PAGE_NUMBER
                             WHERE [ID] = @ID";

            OleDbParameter pNAME = new OleDbParameter("@NAME", model.NAME);
            OleDbParameter pSURNAME = new OleDbParameter("@SURNAME", model.SURNAME);
            OleDbParameter pADDRESS = new OleDbParameter("@ADDRESS", model.ADDRESS);
            OleDbParameter pPHONE_NUMBER = new OleDbParameter("@PHONE_NUMBER", model.PHONE_NUMBER);
            OleDbParameter pBOOK_NAME = new OleDbParameter("@BOOK_NAME", model.BOOK_NAME);
            OleDbParameter pBOOK_PAGE_NUMBER = new OleDbParameter("@BOOK_PAGE_NUMBER", model.BOOK_PAGE_NUMBER);
            OleDbParameter pID = new OleDbParameter("@ID", model.ID);

            return _dbService.ExecuteNonQuery(query, pNAME, pSURNAME, pADDRESS, pPHONE_NUMBER, pBOOK_NAME, pBOOK_PAGE_NUMBER, pID);
        }

        public int Delete(int patientId)
        {
            string query = "UPDATE [PATIENT] SET [ACTIVE] = 0 WHERE [ID] = @ID";

            OleDbParameter pID = new OleDbParameter("@ID", patientId);

            return _dbService.ExecuteNonQuery(query, pID);
        }
    }
}
