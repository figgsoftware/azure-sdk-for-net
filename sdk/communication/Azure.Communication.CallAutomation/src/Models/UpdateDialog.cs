﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Azure.Communication.CallAutomation
{
    public class UpdateDialog
    {
        /// <summary>
        /// Creates a new instance of the UpdateDialogOptions.
        /// </summary>
        /// <param name="dialog"></param>
        public UpdateDialog(DialogUpdateBase dialog)
        {
            DialogId = Guid.NewGuid().ToString();
            Dialog = dialog;
        }
        /// <summary>
        /// Creates a new instance of the UpdateDialogOptions.
        /// </summary>
        /// <param name="dialogId"></param>
        /// <param name="dialog"></param>
        public UpdateDialog(string dialogId, DialogUpdateBase dialog)
        {
            DialogId = dialogId;
            Dialog = dialog;
        }
        /// <summary> Dialog Id</summary>
        public string DialogId { get; }
        /// <summary> Determines the type of the dialog. </summary>
        public DialogUpdateBase Dialog { get; }
        /// <summary> The value to identify context of the operation. </summary>
        public string OperationContext { get; set; }
    }
}
