﻿using SuchByte.MacroDeck.GUI.CustomControls;

namespace SuchByte.MacroDeck.GUI
{
    partial class ActionConfigurator
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
            this.btnApply = new SuchByte.MacroDeck.GUI.CustomControls.ButtonPrimary();
            this.actionList = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.configurationPanel = new System.Windows.Forms.Panel();
            this.lblSelectToBegin = new System.Windows.Forms.Label();
            this.pluginSearch = new SuchByte.MacroDeck.GUI.CustomControls.RoundedTextBox();
            this.pluginList = new System.Windows.Forms.ListView();
            this.configurationPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnApply
            // 
            this.btnApply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnApply.BorderRadius = 8;
            this.btnApply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApply.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnApply.ForeColor = System.Drawing.Color.White;
            this.btnApply.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(89)))), ((int)(((byte)(184)))));
            this.btnApply.Icon = null;
            this.btnApply.Location = new System.Drawing.Point(648, 594);
            this.btnApply.Name = "btnApply";
            this.btnApply.Progress = 0;
            this.btnApply.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(94)))));
            this.btnApply.Size = new System.Drawing.Size(75, 25);
            this.btnApply.TabIndex = 1;
            this.btnApply.Text = "Ok";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.BtnApply_Click);
            // 
            // actionList
            // 
            this.actionList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.actionList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.actionList.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.actionList.ForeColor = System.Drawing.Color.White;
            this.actionList.FormattingEnabled = true;
            this.actionList.ItemHeight = 19;
            this.actionList.Location = new System.Drawing.Point(271, 53);
            this.actionList.Name = "actionList";
            this.actionList.Size = new System.Drawing.Size(252, 247);
            this.actionList.TabIndex = 0;
            this.actionList.SelectedIndexChanged += new System.EventHandler(this.ActionList_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(270, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Action";
            // 
            // labelDescription
            // 
            this.labelDescription.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDescription.ForeColor = System.Drawing.Color.White;
            this.labelDescription.Location = new System.Drawing.Point(529, 53);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(191, 247);
            this.labelDescription.TabIndex = 3;
            // 
            // configurationPanel
            // 
            this.configurationPanel.Controls.Add(this.lblSelectToBegin);
            this.configurationPanel.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.configurationPanel.Location = new System.Drawing.Point(8, 318);
            this.configurationPanel.Name = "configurationPanel";
            this.configurationPanel.Size = new System.Drawing.Size(715, 270);
            this.configurationPanel.TabIndex = 9;
            // 
            // lblSelectToBegin
            // 
            this.lblSelectToBegin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSelectToBegin.Location = new System.Drawing.Point(0, 0);
            this.lblSelectToBegin.Name = "lblSelectToBegin";
            this.lblSelectToBegin.Size = new System.Drawing.Size(715, 270);
            this.lblSelectToBegin.TabIndex = 0;
            this.lblSelectToBegin.Text = "Select a plugin and a action to begin";
            this.lblSelectToBegin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pluginSearch
            // 
            this.pluginSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.pluginSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pluginSearch.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pluginSearch.ForeColor = System.Drawing.Color.White;
            this.pluginSearch.Icon = global::SuchByte.MacroDeck.Properties.Resources.magnifying_glass;
            this.pluginSearch.Location = new System.Drawing.Point(13, 10);
            this.pluginSearch.Multiline = false;
            this.pluginSearch.Name = "pluginSearch";
            this.pluginSearch.Padding = new System.Windows.Forms.Padding(30, 5, 5, 8);
            this.pluginSearch.PasswordChar = false;
            this.pluginSearch.PlaceHolderColor = System.Drawing.Color.Gray;
            this.pluginSearch.PlaceHolderText = "";
            this.pluginSearch.ReadOnly = false;
            this.pluginSearch.SelectionStart = 0;
            this.pluginSearch.Size = new System.Drawing.Size(252, 33);
            this.pluginSearch.TabIndex = 10;
            this.pluginSearch.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.pluginSearch.TextChanged += new System.EventHandler(this.PluginSearch_TextChanged);
            // 
            // pluginList
            // 
            this.pluginList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.pluginList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pluginList.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pluginList.ForeColor = System.Drawing.Color.White;
            this.pluginList.FullRowSelect = true;
            this.pluginList.HideSelection = false;
            this.pluginList.Location = new System.Drawing.Point(13, 53);
            this.pluginList.MultiSelect = false;
            this.pluginList.Name = "pluginList";
            this.pluginList.Size = new System.Drawing.Size(252, 249);
            this.pluginList.TabIndex = 12;
            this.pluginList.UseCompatibleStateImageBehavior = false;
            this.pluginList.View = System.Windows.Forms.View.SmallIcon;
            this.pluginList.SelectedIndexChanged += new System.EventHandler(this.PluginList_SelectedIndexChanged);
            // 
            // ActionConfigurator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(731, 629);
            this.Controls.Add(this.pluginList);
            this.Controls.Add(this.pluginSearch);
            this.Controls.Add(this.configurationPanel);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.actionList);
            this.Controls.Add(this.btnApply);
            this.Name = "ActionConfigurator";
            this.Text = "Macro Deck :: Configure action";
            this.Load += new System.EventHandler(this.ActionConfigurator_Load);
            this.Controls.SetChildIndex(this.btnApply, 0);
            this.Controls.SetChildIndex(this.actionList, 0);
            this.Controls.SetChildIndex(this.labelDescription, 0);
            this.Controls.SetChildIndex(this.configurationPanel, 0);
            this.Controls.SetChildIndex(this.pluginSearch, 0);
            this.Controls.SetChildIndex(this.pluginList, 0);
            this.configurationPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private CustomControls.ButtonPrimary btnApply;
        private System.Windows.Forms.ListBox actionList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Panel configurationPanel;
        private System.Windows.Forms.Label lblSelectToBegin;
        private RoundedTextBox pluginSearch;
        private System.Windows.Forms.ListView pluginList;
    }
}