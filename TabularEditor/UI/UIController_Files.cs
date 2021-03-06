﻿using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TabularEditor.TOMWrapper;
using TabularEditor.UIServices;

namespace TabularEditor.UI
{
    public partial class UIController
    {
        public void File_Open(string fileName)
        {
            var oldFile = File_Current;
            var oldHandler = Handler;

            using (new Hourglass())
            {
                try
                {
                    Handler = new TabularModelHandler(fileName);
                    Handler.AutoFixup = Preferences.Current.FormulaFixup;
                    File_Current = Handler.Source;
                    File_SaveMode = Handler.SourceType;

                    LoadTabularModelToUI();
                    RecentFiles.Add(fileName);
                    UI.FormMain.PopulateRecentFilesList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error loading Model from disk", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Handler = oldHandler;
                    File_Current = oldFile;
                }
            }
        }

        public void File_New()
        {
            var cl = 1200;
#if CL1400
            var res = MessageBox.Show("Do you want to create a Compatibility Level 1400 model?\n(No = 1200, Yes = 1400).", "Compatibility Level", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (res == DialogResult.Cancel) return;
            if (res == DialogResult.Yes) cl = 1400;
#endif

            Handler = new TabularModelHandler(cl);

            Handler.AutoFixup = Preferences.Current.FormulaFixup;
            File_Current = null;
            File_SaveMode = Handler.SourceType;

            LoadTabularModelToUI();
        }

        /// <summary>
        /// Call this method before calling File_Open() or Database_Connect() to check whether the
        /// currently loaded model has unsaved changes.
        /// </summary>
        /// <returns>True if the currently loaded model has unsaved changed.</returns>
        public bool DiscardChangesCheck()
        {
            if (Handler != null && Handler.HasUnsavedChanges)
            {
                if (MessageBox.Show("You have made changes to the model which have not yet been saved. Continue without saving changes?", "Unsaved changes", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                    == DialogResult.Cancel) return true;
            }
            return false;
        }

        private void UndoManager_UndoActionAdded(object sender, EventArgs e)
        {
            UpdateUIText();
        }

        string File_Current;

        public void File_Open(bool fromFolder = false)
        {
            if (DiscardChangesCheck()) return;
            
            string fileName;
            if(fromFolder)
            {
                using (var dlg = new CommonOpenFileDialog() { IsFolderPicker = true })
                {
                    if (dlg.ShowDialog() == CommonFileDialogResult.Cancel) return;
                    fileName = dlg.FileName;
                }
            } else
            {
                if (UI.OpenBimDialog.ShowDialog() == DialogResult.Cancel) return;
                fileName = UI.OpenBimDialog.FileName;
            }

            File_Open(fileName);
        }

        public void File_SaveAs()
        {
            var res = UI.SaveBimDialog.ShowDialog();

            if (res == DialogResult.OK)
            {
                using (new Hourglass())
                {
                    UI.StatusLabel.Text = "Saving...";
                    Handler.SaveFile(UI.SaveBimDialog.FileName, Preferences.Current.GetSerializeOptions(false));

                    RecentFiles.Add(UI.SaveBimDialog.FileName);
                    UI.FormMain.PopulateRecentFilesList();

                    // If not connected to a database, change the current working file:
                    if (Handler.SourceType != ModelSourceType.Database)
                    {
                        File_Current = UI.SaveBimDialog.FileName;
                        File_SaveMode = ModelSourceType.File;
                    }

                    UpdateUIText();
                }
            }
        }

        public ModelSourceType File_SaveMode { get; private set; }

        public void File_SaveToFolder()
        {
            using (var fbd = new CommonOpenFileDialog() { IsFolderPicker = true })
            {
                var res = fbd.ShowDialog();
                if(res == CommonFileDialogResult.Ok && !string.IsNullOrWhiteSpace(fbd.FileName))
                {
                    UI.StatusLabel.Text = "Saving...";
                    Handler.SaveToFolder(fbd.FileName, Preferences.Current.GetSerializeOptions(true));

                    RecentFiles.Add(fbd.FileName);
                    UI.FormMain.PopulateRecentFilesList();

                    // If working with a file, change the current file pointer:
                    if (Handler.SourceType != ModelSourceType.Database)
                    {
                        File_SaveMode = ModelSourceType.Folder;
                        File_Current = fbd.FileName;
                    }

                    UpdateUIText();
                }
            }
        }

        public void Save()
        {
            if(File_Current == null && File_SaveMode == ModelSourceType.File)
            {
                File_SaveAs();
                return;
            }

            UI.StatusLabel.Text = "Saving...";

            if (File_SaveMode == ModelSourceType.Database)
            {
                Database_Save();
            }
            else
            {
                try
                {
                    if (File_SaveMode == ModelSourceType.Folder)
                        Handler.SaveToFolder(File_Current, Preferences.Current.GetSerializeOptions(true), true);
                    else
                        Handler.SaveFile(File_Current, Preferences.Current.GetSerializeOptions(false), true);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message, "Could not save metadata to file", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            UpdateUIText();
        }
    }
}
