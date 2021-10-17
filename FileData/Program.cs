using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using ThirdPartyTools;

namespace FileData
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            if (args != null && args.Length == 2)
            {
                try
                {
                    string command = args[0];
                    string filePath = args[1];

                    #region Task 1
                    Print.ConsolePrintMessage("Task 1 Output =>");
                    Print.ConsolePrintMessage("File Version is " + FileVersion.GetDetails(command, filePath));
                    #endregion

                    #region Task 2 - New Business Requirements
                    Print.ConsolePrintMessage("Task 2 Output =>");

                    // Configured first arguments in AppConfig file because of if any new customization occures then just need to update the config, No need to touch the host code.
                    string[] arrVersion = ConfigurationManager.AppSettings["VersionAgrs"].Split(',');
                    string[] arrSize = ConfigurationManager.AppSettings["SizeAgrs"].Split(',');

                    if (arrVersion.Contains(command))
                    {
                        Print.ConsolePrintMessage("File Version is " + FileVersion.GetDetails(command, filePath));
                    }
                    else if (arrSize.Contains(command))
                    {
                        Print.ConsolePrintMessage("File Size is " + FileSize.GetDetails(command, filePath));
                    }
                    else
                    {
                        //UnConfigured parameter received. Show proper message to the user.
                        Print.ConsolePrintMessage("Invalid Arguments Received.");
                    }
                    Console.ReadLine();
                    #endregion
                }
                catch (Exception)
                {
                    throw;
                }
            }
            else
            {
                //Unsupported parameters received. Show proper message to the user.
                Print.ConsolePrintMessage("Invalid Arguments Received.");
            }
        }
    }


    #region SOLID-SRP 
    class FileVersion
    {
        internal static string GetDetails(string command, string filePath)
        {
            FileDetails fileDetails = new FileDetails();
            return fileDetails.Version(filePath);
        }
    }

    class FileSize
    {
        internal static int GetDetails(string command, string filePath)
        {
            FileDetails fileDetails = new FileDetails();
            return fileDetails.Size(filePath);
        }
    }

    class Print
    {
        internal static void ConsolePrintMessage(object message)
        {
            Console.WriteLine(message);
        }
    }

    #endregion


}
