/* Copyright (c) 1996-2016, OPC Foundation. All rights reserved.

   The source code in this file is covered under a dual-license scenario:
     - RCL: for OPC Foundation members in good-standing
     - GPL V2: everybody else

   RCL license terms accompanied with this source code. See http://opcfoundation.org/License/RCL/1.00/

   GNU General Public License as published by the Free Software Foundation;
   version 2 of the License are accompanied with this source code. See http://opcfoundation.org/License/GPLv2

   This source code is distributed in the hope that it will be useful,
   but WITHOUT ANY WARRANTY; without even the implied warranty of
   MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
*/

namespace Opc.Ua.Gds
{
    partial class SetTypeDlg
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CancelBTN = new System.Windows.Forms.Button();
            this.OkBTN = new System.Windows.Forms.Button();
            this.BottomPN = new System.Windows.Forms.Panel();
            this.MainPN = new System.Windows.Forms.TableLayoutPanel();
            this.ErrorHandlingLB = new System.Windows.Forms.Label();
            this.ArrayDimensionsLB = new System.Windows.Forms.Label();
            this.StructureTypeLB = new System.Windows.Forms.Label();
            this.ArrayDimensionsTB = new System.Windows.Forms.TextBox();
            this.StructureTypeTB = new System.Windows.Forms.TextBox();
            this.ErrorHandlingCB = new System.Windows.Forms.ComboBox();
            this.BottomPN.SuspendLayout();
            this.MainPN.SuspendLayout();
            this.SuspendLayout();
            // 
            // CancelBTN
            // 
            this.CancelBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelBTN.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBTN.Location = new System.Drawing.Point(329, 4);
            this.CancelBTN.Name = "CancelBTN";
            this.CancelBTN.Size = new System.Drawing.Size(75, 23);
            this.CancelBTN.TabIndex = 0;
            this.CancelBTN.Text = "Cancel";
            this.CancelBTN.UseVisualStyleBackColor = true;
            // 
            // OkBTN
            // 
            this.OkBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.OkBTN.Location = new System.Drawing.Point(3, 4);
            this.OkBTN.Name = "OkBTN";
            this.OkBTN.Size = new System.Drawing.Size(75, 23);
            this.OkBTN.TabIndex = 1;
            this.OkBTN.Text = "OK";
            this.OkBTN.UseVisualStyleBackColor = true;
            this.OkBTN.Click += new System.EventHandler(this.OkBTN_Click);
            // 
            // BottomPN
            // 
            this.BottomPN.Controls.Add(this.OkBTN);
            this.BottomPN.Controls.Add(this.CancelBTN);
            this.BottomPN.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomPN.Location = new System.Drawing.Point(0, 74);
            this.BottomPN.Name = "BottomPN";
            this.BottomPN.Size = new System.Drawing.Size(406, 30);
            this.BottomPN.TabIndex = 0;
            // 
            // MainPN
            // 
            this.MainPN.AutoSize = true;
            this.MainPN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MainPN.ColumnCount = 3;
            this.MainPN.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.MainPN.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.MainPN.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.MainPN.Controls.Add(this.ErrorHandlingLB, 0, 3);
            this.MainPN.Controls.Add(this.ArrayDimensionsLB, 0, 2);
            this.MainPN.Controls.Add(this.StructureTypeLB, 0, 1);
            this.MainPN.Controls.Add(this.ArrayDimensionsTB, 1, 2);
            this.MainPN.Controls.Add(this.StructureTypeTB, 1, 1);
            this.MainPN.Controls.Add(this.ErrorHandlingCB, 1, 3);
            this.MainPN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPN.Location = new System.Drawing.Point(0, 0);
            this.MainPN.Name = "MainPN";
            this.MainPN.RowCount = 5;
            this.MainPN.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MainPN.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MainPN.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MainPN.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MainPN.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MainPN.Size = new System.Drawing.Size(406, 74);
            this.MainPN.TabIndex = 0;
            // 
            // ErrorHandlingLB
            // 
            this.ErrorHandlingLB.AutoSize = true;
            this.ErrorHandlingLB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ErrorHandlingLB.Location = new System.Drawing.Point(3, 48);
            this.ErrorHandlingLB.Name = "ErrorHandlingLB";
            this.ErrorHandlingLB.Size = new System.Drawing.Size(88, 24);
            this.ErrorHandlingLB.TabIndex = 7;
            this.ErrorHandlingLB.Text = "Error Handling";
            this.ErrorHandlingLB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ArrayDimensionsLB
            // 
            this.ArrayDimensionsLB.AutoSize = true;
            this.ArrayDimensionsLB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ArrayDimensionsLB.Location = new System.Drawing.Point(3, 24);
            this.ArrayDimensionsLB.Name = "ArrayDimensionsLB";
            this.ArrayDimensionsLB.Size = new System.Drawing.Size(88, 24);
            this.ArrayDimensionsLB.TabIndex = 5;
            this.ArrayDimensionsLB.Text = "Array Dimensions";
            this.ArrayDimensionsLB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // StructureTypeLB
            // 
            this.StructureTypeLB.AutoSize = true;
            this.StructureTypeLB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StructureTypeLB.Location = new System.Drawing.Point(3, 0);
            this.StructureTypeLB.Name = "StructureTypeLB";
            this.StructureTypeLB.Size = new System.Drawing.Size(88, 24);
            this.StructureTypeLB.TabIndex = 2;
            this.StructureTypeLB.Text = "Structure Type";
            this.StructureTypeLB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ArrayDimensionsTB
            // 
            this.ArrayDimensionsTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ArrayDimensionsTB.Location = new System.Drawing.Point(96, 26);
            this.ArrayDimensionsTB.Margin = new System.Windows.Forms.Padding(2);
            this.ArrayDimensionsTB.Name = "ArrayDimensionsTB";
            this.ArrayDimensionsTB.Size = new System.Drawing.Size(278, 20);
            this.ArrayDimensionsTB.TabIndex = 6;
            // 
            // StructureTypeTB
            // 
            this.StructureTypeTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StructureTypeTB.Location = new System.Drawing.Point(96, 2);
            this.StructureTypeTB.Margin = new System.Windows.Forms.Padding(2);
            this.StructureTypeTB.Name = "StructureTypeTB";
            this.StructureTypeTB.ReadOnly = true;
            this.StructureTypeTB.Size = new System.Drawing.Size(278, 20);
            this.StructureTypeTB.TabIndex = 3;
            // 
            // ErrorHandlingCB
            // 
            this.ErrorHandlingCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ErrorHandlingCB.FormattingEnabled = true;
            this.ErrorHandlingCB.Location = new System.Drawing.Point(96, 50);
            this.ErrorHandlingCB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 1);
            this.ErrorHandlingCB.Name = "ErrorHandlingCB";
            this.ErrorHandlingCB.Size = new System.Drawing.Size(153, 21);
            this.ErrorHandlingCB.TabIndex = 8;
            // 
            // SetTypeDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.CancelBTN;
            this.ClientSize = new System.Drawing.Size(406, 104);
            this.Controls.Add(this.MainPN);
            this.Controls.Add(this.BottomPN);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1000, 166);
            this.MinimumSize = new System.Drawing.Size(417, 100);
            this.Name = "SetTypeDlg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Set Data Type and Array Size";
            this.BottomPN.ResumeLayout(false);
            this.MainPN.ResumeLayout(false);
            this.MainPN.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelBTN;
        private System.Windows.Forms.Button OkBTN;
        private System.Windows.Forms.Panel BottomPN;
        private System.Windows.Forms.TextBox ArrayDimensionsTB;
        private System.Windows.Forms.TableLayoutPanel MainPN;
        private System.Windows.Forms.Label ErrorHandlingLB;
        private System.Windows.Forms.Label ArrayDimensionsLB;
        private System.Windows.Forms.Label StructureTypeLB;
        private System.Windows.Forms.TextBox StructureTypeTB;
        private System.Windows.Forms.ComboBox ErrorHandlingCB;
    }
}