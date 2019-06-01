

#region using statements

using System;
using System.Collections.Generic;
using System.Text;
using ApplicationLogicComponent.Controllers;

#endregion


namespace ApplicationLogicComponent.Exceptions
{

    #region class ProcedureTableNameNotSetException : CustomException
    /// <summary>
    /// This exception is thrown when a method requires an open project
    /// and the method is called with out an open project. This is
    /// more for the developer, these should all be caught before releasing.
    /// </summary>
    public class NoProjectSelectedException : CustomException
    {

        #region Private Variables
        private string displayText;
        private Exception exception;
        private string knowledgeBaseArticleID;
        private bool knownIssue;
        private string methodName;
        private string objectName;
        private bool showToUser;
        private string status;
        private int userID;
        #endregion

        #region Constructor
        /// <summary>
        /// Creates a new NoProjectSelectedException instance.
        /// </summary>
        public NoProjectSelectedException(string methodNameArg, string objectNameArg, Exception exceptionArg)
        {
            // Set Properties
            this.MethodName = methodNameArg;
            this.ObjectName = objectNameArg;
            this.Exception = exceptionArg;

            // Perform Initializations
            Init();
        }
        #endregion

        #region Methods

        #region Init()
        /// <summary>
        /// Performs any initializations for this object.
        /// </summary>
        private void Init()
        {
            // Create variables used to create an instance of an InvalidConfigurationException
            this.DisplayText = "This method requires an open project.";
            this.KnowledgeBaseArticleID = null;
            this.KnownIssue = true;
            this.Status = "You are seeing this message because a developer made an error. This error has been reported and logged. A fix should be available in the near future.";
            this.ShowToUser = true;

            // If this errror happens before authentication, the userID will be 0.
            // To Do: Store Last UserID in the App.Config file after a successful
            // login. Also can easily grab machine name. Send an email to an
            // IT person, support person, me (Corby) if necessary
            this.UserID = 0;
        }
        #endregion

        #endregion

        #region Properties

        #region DisplayText
        /// <summary>
        /// The text to display for this error.
        /// </summary>
        public override string DisplayText
        {
            get { return displayText; }
            set { displayText = value; }
        }
        #endregion

        #region InnerException
        /// <summary>
        /// The System.Exception that caused this error.
        /// </summary>
        public override Exception Exception
        {
            get { return exception; }
            set { exception = value; }
        }
        #endregion

        #region KnowledgeBaseArticleID
        /// <summary>
        /// If known this value will be the ID
        /// of the knowledge base article for this issue.
        /// </summary>
        public override string KnowledgeBaseArticleID
        {
            get { return knowledgeBaseArticleID; }
            set { knowledgeBaseArticleID = value; }
        }
        #endregion

        #region KnownIssue
        /// <summary>
        /// Is this issue a known issue or not
        /// </summary>
        public override bool KnownIssue
        {
            get { return knownIssue; }
            set { knownIssue = value; }
        }
        #endregion

        #region MethodName
        /// <summary>
        /// The name of the method where this error occurred.
        /// </summary>
        public override string MethodName
        {
            get { return methodName; }
            set { methodName = value; }
        }
        #endregion

        #region ObjectName
        /// <summary>
        /// The name of the class, control, or form where the error occurred.
        /// </summary>
        public override string ObjectName
        {
            get { return objectName; }
            set { objectName = value; }
        }
        #endregion

        #region ShowToUser
        /// <summary>
        /// Should this exception be shown to the user or not.
        /// (Yes in this case).
        /// </summary>
        public override bool ShowToUser
        {
            get { return showToUser; }
            set { showToUser = value; }
        }
        #endregion

        #region Status
        /// <summary>
        /// The status of this issue.
        /// </summary>
        public override string Status
        {
            get { return status; }
            set { status = value; }
        }
        #endregion

        #region UserID
        /// <summary>
        /// ID of user this error happened to
        /// </summary>
        public override int UserID
        {
            get { return userID; }
            set { userID = value; }
        }
        #endregion

        #endregion

    }
    #endregion

}
