

#region using statements

using DataAccessComponent.StoredProcedureManager.DeleteProcedures;
using DataAccessComponent.StoredProcedureManager.FetchProcedures;
using DataAccessComponent.StoredProcedureManager.InsertProcedures;
using DataAccessComponent.StoredProcedureManager.UpdateProcedures;
using DataJuggler.Net;
using System;

#endregion


namespace DataAccessComponent.StoredProcedureManager.DeleteProcedures
{

    #region class DeleteProjectReferenceStoredProcedure
    /// <summary>
    /// This class is used to Delete a 'ProjectReference' object.
    /// </summary>
    public class DeleteProjectReferenceStoredProcedure : StoredProcedure
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'DeleteProjectReferenceStoredProcedure' object.
        /// </summary>
        public DeleteProjectReferenceStoredProcedure()
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
                this.ProcedureName = "ProjectReference_Delete";

                // Set tableName
                this.TableName = "ProjectReference";
            }
            #endregion

        #endregion

        #region Properties

        #endregion

    }
    #endregion

}
