using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using System;

namespace Reflexil.Forms
{

    public partial class EditExceptionHandlerForm : ExceptionHandlerForm
	{
		
		//Form overrides dispose to clean up the component list.
		[System.Diagnostics.DebuggerNonUserCode()]protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}
		
		//Required by the Windows Form Designer
		private System.ComponentModel.Container components = null;
		
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
            this.ButUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButUpdate
            // 
            this.ButUpdate.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ButUpdate.Location = new System.Drawing.Point(401, 12);
            this.ButUpdate.Name = "ButUpdate";
            this.ButUpdate.Size = new System.Drawing.Size(129, 23);
            this.ButUpdate.TabIndex = 12;
            this.ButUpdate.Text = "Update";
            this.ButUpdate.UseVisualStyleBackColor = true;
            this.ButUpdate.Click += new System.EventHandler(this.ButUpdate_Click);
            // 
            // EditExceptionHandlerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(536, 203);
            this.Controls.Add(this.ButUpdate);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditExceptionHandlerForm";
            this.ShowInTaskbar = false;
            this.Text = "Edit existing exception handler";
            this.Load += new System.EventHandler(this.EditExceptionHandlerForm_Load);
            this.Controls.SetChildIndex(this.ButUpdate, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		internal System.Windows.Forms.Button ButUpdate;
		
	}
}
