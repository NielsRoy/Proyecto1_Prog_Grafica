namespace ProyectoOpenTk
{
    partial class Form1
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
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Nodo10");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Nodo11");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Nodo1", new System.Windows.Forms.TreeNode[] {
            treeNode8,
            treeNode9});
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Nodo12");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Nodo13");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Nodo2", new System.Windows.Forms.TreeNode[] {
            treeNode11,
            treeNode12});
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Escenario", new System.Windows.Forms.TreeNode[] {
            treeNode10,
            treeNode13});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 34);
            this.treeView1.Name = "treeView1";
            treeNode8.Name = "Nodo10";
            treeNode8.Text = "Nodo10";
            treeNode9.Name = "Nodo11";
            treeNode9.Text = "Nodo11";
            treeNode10.Name = "Nodo1";
            treeNode10.Tag = "";
            treeNode10.Text = "Nodo1";
            treeNode11.Name = "Nodo12";
            treeNode11.Text = "Nodo12";
            treeNode12.Checked = true;
            treeNode12.Name = "Nodo13";
            treeNode12.Text = "Nodo13";
            treeNode13.Name = "Nodo2";
            treeNode13.Text = "Nodo2";
            treeNode14.Checked = true;
            treeNode14.Name = "Nodo0";
            treeNode14.Text = "Escenario";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode14});
            this.treeView1.Size = new System.Drawing.Size(143, 183);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.treeView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
    }
}