

#region using statements

using DataAccessComponent.StoredProcedureManager.DeleteProcedures;
using DataAccessComponent.StoredProcedureManager.FetchProcedures;
using DataAccessComponent.StoredProcedureManager.InsertProcedures;
using DataAccessComponent.StoredProcedureManager.UpdateProcedures;
using ObjectLibrary.BusinessObjects;
using System;
using System.Data;
using System.Data.SqlClient;

#endregion


namespace DataAccessComponent.DataManager.Writers
{

    #region class FieldSetFieldWriter
    /// <summary>
    /// This class is used for converting a 'FieldSetField' object to
    /// the SqlParameter[] to perform the CRUD methods.
    /// </summary>
    public class FieldSetFieldWriter : FieldSetFieldWriterBase
    {

        #region Static Methods

            #region CreateDeleteFieldSetFieldStoredProcedure(FieldSetField fieldSetField)
            /// <summary>
            /// This method creates an instance of an
            /// 'DeleteFieldSetField'StoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'FieldSetField_Delete'.
            /// </summary>
            /// <param name="fieldSetField">The 'FieldSetField' to Delete.</param>
            /// <returns>An instance of a 'DeleteFieldSetFieldStoredProcedure' object.</returns>
            public static new DeleteFieldSetFieldStoredProcedure CreateDeleteFieldSetFieldStoredProcedure(FieldSetField fieldSetField)
            {
                // Initial Value
                DeleteFieldSetFieldStoredProcedure deleteFieldSetFieldStoredProcedure = new DeleteFieldSetFieldStoredProcedure();

                // If the fieldSetField object exists
                if ((fieldSetField != null) && (fieldSetField.DeleteAllForFieldSet) && (fieldSetField.HasFieldSetId))
                {
                    // Set the ProcedureName
                    deleteFieldSetFieldStoredProcedure.ProcedureName = "FieldSetField_DeleteAllForFieldSetId";

                    // Create the @FieldSetId parameter
                    deleteFieldSetFieldStoredProcedure.Parameters = SqlParameterHelper.CreateSqlParameters("@FieldSetId", fieldSetField.FieldSetId);
                }
                else
                {
                    // Now Create Parameters For The DeleteProc
                    deleteFieldSetFieldStoredProcedure.Parameters = CreatePrimaryKeyParameter(fieldSetField);
                }

                // return value
                return deleteFieldSetFieldStoredProcedure;
            }
            #endregion

        #endregion

    }
    #endregion

}
