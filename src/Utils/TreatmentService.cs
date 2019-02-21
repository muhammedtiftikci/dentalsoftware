using DentalSoftware.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;

namespace DentalSoftware.Utils
{
    public class TreatmentService
    {
        private DatabaseService _dbService;

        public TreatmentService(DatabaseService dbService)
        {
            _dbService = dbService;
        }

        public DataTable GetDataTable(int patientId)
        {
            string query = @"SELECT [ID]
                                   ,[CREATED_DATE] AS [DATE]
                                   ,[DESCRIPTION]
                                   ,[PRICE]
                                   ,[PAID]
                             FROM [TREATMENT]
                             WHERE [PATIENT_ID] = @id
                             ORDER BY [CREATED_DATE]";

            OleDbParameter pID = new OleDbParameter("@id", patientId);

            return _dbService.GetDataTable(query, pID);
        }

        public int Insert(Treatment model)
        {
            string query = @"INSERT INTO [TREATMENT] ([PATIENT_ID], [DESCRIPTION], [PRICE], [PAID])
                             VALUES (@PATIENT_ID,  @DESCRIPTION, @PRICE, @PAID)";

            OleDbParameter pPATIENT_ID = new OleDbParameter("@PATIENT_ID", model.PATIENT_ID);
            OleDbParameter pDATE = new OleDbParameter("@DATE", model.DATE);
            OleDbParameter pDESCRIPTION = new OleDbParameter("@DESCRIPTION", model.DESCRIPTION);
            OleDbParameter pPRICE = new OleDbParameter("@PRICE", model.PRICE);
            OleDbParameter pPAID = new OleDbParameter("@PAID", model.PAID);

            return _dbService.ExecuteNonQuery(query, pPATIENT_ID, pDESCRIPTION, pPRICE, pPAID);
        }

        public int Update(Treatment model)
        {
            string query = @"UPDATE [TREATMENT]
                             SET [CREATED_DATE] = @date,
                                 [DESCRIPTION] = @description,
                                 [PRICE] = @price,
                                 [PAID] = @paid
                             WHERE [ID] = @id";

            OleDbParameter pDATE = new OleDbParameter("@date", model.DATE);
            OleDbParameter pDESCRIPTION = new OleDbParameter("@description", model.DESCRIPTION);
            OleDbParameter pPRICE = new OleDbParameter("@price", model.PRICE);
            OleDbParameter pPAID = new OleDbParameter("@paid", model.PAID);
            OleDbParameter pID = new OleDbParameter("@id", model.ID);

            return _dbService.ExecuteNonQuery(query, pDATE, pDESCRIPTION, pPRICE, pPAID, pID);
        }
    }
}
