

#region using statements

using DataAccessComponent.StoredProcedureManager.DeleteProcedures;
using DataAccessComponent.StoredProcedureManager.FetchProcedures;
using DataAccessComponent.StoredProcedureManager.InsertProcedures;
using DataAccessComponent.StoredProcedureManager.UpdateProcedures;
using DataJuggler.Net;
using System;

#endregion


namespace DataAccessComponent.StoredProcedureManager.FetchProcedures
{

    #region class FindDTNDatabaseStoredProcedure
    /// <summary>
    /// This class is used to Find a 'DTNDatabase' object.
    /// </summary>
    public class FindDTNDatabaseStoredProcedure : StoredProcedure
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'FindDTNDatabaseStoredProcedure' object.
        /// </summary>
        public FindDTNDatabaseStoredProcedure()
        {
            // Perform Initialization
            Init();
        }
        #endregion

        #region Methods

            #region Init()
            /// <summary>
            /// Set Procedure Properties
            /// </summary>
            private void Init()
            {
                // Set Properties For This Proc

                // Set ProcedureName
                this.ProcedureName = "DTNDatabase_Find";

                // Set tableName
                this.TableName = "DTNDatabase";
            }
            #endregion

        #endregion

        #region Properties

        #endregion

    }
    #endregion

}
