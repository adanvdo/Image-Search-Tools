using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageSearchTools.Utilities
{
    public static class Logger
    {
        public static void LogException(string logPath, Exception e)
        {
            Logger.LogException(logPath, string.Empty, e, false, "No string passed to logger");
        }

        public static void LogException(string logPath, Exception e, bool showDialog)
        {
            Logger.LogException(logPath, string.Empty, e, showDialog, "No string passed to logger");
        }

        public static void LogException(string logPath, string message, Exception e, bool showDialog)
        {
            Logger.LogException(logPath, message, e, showDialog, "No string passed to logger");
        }

        public static void LogException(string logPath, string message, Exception e, bool showDialog, string sqlString)
        {
            StringBuilder sbExceptionDetails = new StringBuilder();
            FileInfo f;
            StreamWriter writer = null;
            bool success = false;
            try
            {
                f = new FileInfo(logPath);
                writer = f.AppendText();
                success = true;
            }
            catch (System.Security.SecurityException sec)
            {
                sbExceptionDetails.Append(sec.ToString());
            }
            catch (UnauthorizedAccessException auth)
            {
                sbExceptionDetails.Append(auth.ToString());
            }
            finally
            {
                MessageBox.Show(sbExceptionDetails.ToString());
            }

            Console.WriteLine(e.GetType().ToString());
            Console.WriteLine(message + ":  " + e.Message);
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append("---------------------------------------------------------------");
            sb.Append("\r\n");
            sb.Append("Date: ");
            sb.Append(DateTime.Now.ToShortDateString());
            sb.Append(" at ");
            sb.Append(DateTime.Now.ToLongTimeString());
            sb.Append("\r\n");
            sb.Append(e.GetType().ToString());
            sb.Append(" thrown by ");
            sb.Append(e.TargetSite == null ? "" : e.TargetSite.ToString());
            sb.Append(" in ");
            sb.Append(e.Source);
            sb.Append("\r\n");
            sb.Append(message);
            sb.Append(":  ");
            sb.Append(e.Message);
            sb.Append("\r\n");

            if (e.Data.Count > 0)
            {
                foreach (DictionaryEntry de in e.Data)
                {
                    sb.Append(de.Key.ToString() + ": ");
                    sb.Append(de.Value.ToString());
                    sb.Append("\r\n");
                }
            }

            sb.Append("\r\nStack Trace: \r\n");
            sb.Append(e.StackTrace);
            sb.Append("\r\n");

            if (e is System.Data.SqlClient.SqlException)
            {
                SqlException sqle = (SqlException)e;
                if (sqle.Errors.Count > 1)
                {
                    foreach (System.Data.SqlClient.SqlError err in sqle.Errors)
                    {
                        sb.Append(err.Message);
                    }
                }

                sb.Append("\r\nSql Details: \r\n");
                sb.Append(sqlString);
                sb.Append("\r\n");
            }

            // Process Inner Exceptions
            Exception innerException = e.InnerException;

            while (innerException != null)
            {
                sb.Append("\r\n");
                sb.Append("Inner Exception: ");
                sb.Append(innerException.Message);
                sb.Append("\r\nStackTrace: \r\n");
                sb.Append(innerException.StackTrace);
                sb.Append("\r\n");

                message += "\r\n" + e.InnerException;
                if (innerException is SqlException)
                {
                    SqlException sqle = (SqlException)innerException;
                    if (sqle.Errors.Count > 1)
                    {
                        foreach (SqlError err in sqle.Errors)
                        {
                            sb.Append(err.Message);
                        }
                    }
                }

                innerException = innerException.InnerException;
            }
            sb.Append("\r\n");

            if (writer != null)
            {
                writer.WriteLine(sb.ToString());
                writer.Close();
            }

            if (showDialog)
            {
                System.Windows.Forms.MessageBox.Show(message, "IST Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
