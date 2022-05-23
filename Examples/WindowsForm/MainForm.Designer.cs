using Alex75.JsonViewer.WindowsForm;

namespace WindowsForm
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.loadJsonButton_1 = new System.Windows.Forms.Button();
            this.topPanel = new System.Windows.Forms.Panel();
            this.loadJsonButton_2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.jsonTreeView = new Alex75.JsonViewer.WindowsForm.JsonTreeView();
            this.jsonTreeView1 = new Alex75.JsonViewer.WindowsForm.JsonTreeView();
            this.topPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // loadJsonButton_1
            // 
            this.loadJsonButton_1.Location = new System.Drawing.Point(4, 4);
            this.loadJsonButton_1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.loadJsonButton_1.Name = "loadJsonButton_1";
            this.loadJsonButton_1.Size = new System.Drawing.Size(212, 71);
            this.loadJsonButton_1.TabIndex = 1;
            this.loadJsonButton_1.Text = "Load JSON 01";
            this.loadJsonButton_1.UseVisualStyleBackColor = true;
            this.loadJsonButton_1.Click += new System.EventHandler(this.loadJsonButton_1_Click);
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.loadJsonButton_2);
            this.topPanel.Controls.Add(this.loadJsonButton_1);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(724, 85);
            this.topPanel.TabIndex = 2;
            // 
            // loadJsonButton_2
            // 
            this.loadJsonButton_2.Location = new System.Drawing.Point(224, 4);
            this.loadJsonButton_2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.loadJsonButton_2.Name = "loadJsonButton_2";
            this.loadJsonButton_2.Size = new System.Drawing.Size(212, 71);
            this.loadJsonButton_2.TabIndex = 2;
            this.loadJsonButton_2.Text = "Load JSON 02";
            this.loadJsonButton_2.UseVisualStyleBackColor = true;
            this.loadJsonButton_2.Click += new System.EventHandler(this.loadJsonButton_2_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.jsonTreeView);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 85);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(724, 623);
            this.panel1.TabIndex = 3;
            // 
            // jsonTreeView
            // 
            this.jsonTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.jsonTreeView.FullRowSelect = true;
            this.jsonTreeView.ImageIndex = 0;
            this.jsonTreeView.Location = new System.Drawing.Point(0, 0);
            this.jsonTreeView.Margin = new System.Windows.Forms.Padding(4);
            this.jsonTreeView.Name = "jsonTreeView";
            this.jsonTreeView.SelectedImageIndex = 0;
            this.jsonTreeView.Size = new System.Drawing.Size(724, 623);
            this.jsonTreeView.TabIndex = 0;
            // 
            // jsonTreeView1
            // 
            this.jsonTreeView1.FullRowSelect = true;
            this.jsonTreeView1.ImageIndex = 0;
            this.jsonTreeView1.Location = new System.Drawing.Point(0, 0);
            this.jsonTreeView1.Name = "jsonTreeView1";
            this.jsonTreeView1.SelectedImageIndex = 0;
            this.jsonTreeView1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 708);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.topPanel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.Text = "Example";
            this.topPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private JsonTreeView jsonTreeView;
        private System.Windows.Forms.Button loadJsonButton_1;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button loadJsonButton_2;
        private JsonTreeView jsonTreeView1;
    }
}

