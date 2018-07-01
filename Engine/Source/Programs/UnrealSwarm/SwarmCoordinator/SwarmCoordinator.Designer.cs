// Copyright 1998-2018 Epic Games, Inc. All Rights Reserved.

namespace SwarmCoordinator
{
    partial class SwarmCoordinator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if( disposing && ( components != null ) )
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SwarmCoordinator));
            this.AgentGridView = new System.Windows.Forms.DataGridView();
            this.RestartAllAgentsButton = new System.Windows.Forms.Button();
            this.RestartCoordinatorButton = new System.Windows.Forms.Button();
            this.RestartQAAgentsButton = new System.Windows.Forms.Button();
            this.AgentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Version = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.State = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.IPAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastPingTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumLocalCores = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumRemoteCores = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.AgentGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // AgentGridView
            // 
            resources.ApplyResources(this.AgentGridView, "AgentGridView");
            this.AgentGridView.AllowUserToAddRows = false;
            this.AgentGridView.AllowUserToDeleteRows = false;
            this.AgentGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AgentName,
            this.GroupName,
            this.Version,
            this.State,
            this.IPAddress,
            this.LastPingTime,
            this.NumLocalCores,
            this.NumRemoteCores});
            this.AgentGridView.Name = "AgentGridView";
            // 
            // RestartAllAgentsButton
            // 
            resources.ApplyResources(this.RestartAllAgentsButton, "RestartAllAgentsButton");
            this.RestartAllAgentsButton.Name = "RestartAllAgentsButton";
            this.RestartAllAgentsButton.UseVisualStyleBackColor = true;
            this.RestartAllAgentsButton.Click += new System.EventHandler(this.RestartAllAgentsButton_Click);
            // 
            // RestartCoordinatorButton
            // 
            resources.ApplyResources(this.RestartCoordinatorButton, "RestartCoordinatorButton");
            this.RestartCoordinatorButton.Name = "RestartCoordinatorButton";
            this.RestartCoordinatorButton.UseVisualStyleBackColor = true;
            this.RestartCoordinatorButton.Click += new System.EventHandler(this.RestartCoordinatorButton_Click);
            // 
            // RestartQAAgentsButton
            // 
            resources.ApplyResources(this.RestartQAAgentsButton, "RestartQAAgentsButton");
            this.RestartQAAgentsButton.Name = "RestartQAAgentsButton";
            this.RestartQAAgentsButton.UseVisualStyleBackColor = true;
            this.RestartQAAgentsButton.Click += new System.EventHandler(this.RestartQAAgentsButton_Click);
            // 
            // AgentName
            // 
            this.AgentName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            resources.ApplyResources(this.AgentName, "AgentName");
            this.AgentName.Name = "AgentName";
            this.AgentName.ReadOnly = true;
            // 
            // GroupName
            // 
            this.GroupName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            resources.ApplyResources(this.GroupName, "GroupName");
            this.GroupName.Name = "GroupName";
            this.GroupName.ReadOnly = true;
            // 
            // Version
            // 
            this.Version.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            resources.ApplyResources(this.Version, "Version");
            this.Version.Name = "Version";
            this.Version.ReadOnly = true;
            // 
            // State
            // 
            this.State.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            resources.ApplyResources(this.State, "State");
            this.State.Name = "State";
            this.State.ReadOnly = true;
            // 
            // IPAddress
            // 
            this.IPAddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            resources.ApplyResources(this.IPAddress, "IPAddress");
            this.IPAddress.Name = "IPAddress";
            this.IPAddress.ReadOnly = true;
            // 
            // LastPingTime
            // 
            this.LastPingTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            resources.ApplyResources(this.LastPingTime, "LastPingTime");
            this.LastPingTime.Name = "LastPingTime";
            this.LastPingTime.ReadOnly = true;
            // 
            // NumLocalCores
            // 
            this.NumLocalCores.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            resources.ApplyResources(this.NumLocalCores, "NumLocalCores");
            this.NumLocalCores.Name = "NumLocalCores";
            this.NumLocalCores.ReadOnly = true;
            // 
            // NumRemoteCores
            // 
            this.NumRemoteCores.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            resources.ApplyResources(this.NumRemoteCores, "NumRemoteCores");
            this.NumRemoteCores.Name = "NumRemoteCores";
            // 
            // SwarmCoordinator
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RestartQAAgentsButton);
            this.Controls.Add(this.RestartCoordinatorButton);
            this.Controls.Add(this.RestartAllAgentsButton);
            this.Controls.Add(this.AgentGridView);
            this.Name = "SwarmCoordinator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SwarmCoordinator_Closing);
            ((System.ComponentModel.ISupportInitialize)(this.AgentGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView AgentGridView;
		private System.Windows.Forms.Button RestartAllAgentsButton;
		private System.Windows.Forms.Button RestartCoordinatorButton;
		private System.Windows.Forms.Button RestartQAAgentsButton;
		private System.Windows.Forms.DataGridViewTextBoxColumn AgentName;
		private System.Windows.Forms.DataGridViewTextBoxColumn GroupName;
		private System.Windows.Forms.DataGridViewTextBoxColumn Version;
		private System.Windows.Forms.DataGridViewComboBoxColumn State;
		private System.Windows.Forms.DataGridViewTextBoxColumn IPAddress;
		private System.Windows.Forms.DataGridViewTextBoxColumn LastPingTime;
		private System.Windows.Forms.DataGridViewTextBoxColumn NumLocalCores;
		private System.Windows.Forms.DataGridViewTextBoxColumn NumRemoteCores;
	}
}

