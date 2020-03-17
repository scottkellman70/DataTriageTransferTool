using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataTriageTransferTool
{
    static class Messaging
    {
        private static readonly string appName = "SOF DT3";

        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public static MsgBoxResult ShowInfoMessageBox(string message)
        {
            MessageBox.Show(message, appName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            return MsgBoxResult.Ok;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        public static void ShowErrorMessageBox(string message)
        {
            MessageBox.Show(message, appName, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        public static void ShowWarnMessageBox(string message)
        {
            MessageBox.Show(message, appName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
