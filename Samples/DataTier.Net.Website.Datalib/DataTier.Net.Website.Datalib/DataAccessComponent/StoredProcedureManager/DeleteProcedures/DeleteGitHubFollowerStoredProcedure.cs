

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

    #region class DeleteGitHubFollowerStoredProcedure
    /// <summary>
    /// This class is used to Delete a 'GitHubFollower' object.
    /// </summary>
    public class DeleteGitHubFollowerStoredProcedure : StoredProcedure
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'DeleteGitHubFollowerStoredProcedure' object.
        /// </summary>
        public DeleteGitHubFollowerStoredProcedure()
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
                this.ProcedureName = "GitHubFollower_Delete";

                // Set tableName
                this.TableName = "GitHubFollower";
            }
            #endregion

        #endregion

        #region Properties

        #endregion

    }
    #endregion

}
