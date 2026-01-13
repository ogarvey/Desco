namespace Desco
{
    partial class MainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.renderControl1 = new Cobalt.RenderControl();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tscmbAssets = new System.Windows.Forms.ToolStripComboBox();
            this.tsbRenderAll = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // renderControl1
            // 
            this.renderControl1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.renderControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.renderControl1.Location = new System.Drawing.Point(0, 34);
            this.renderControl1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.renderControl1.Name = "renderControl1";
            this.renderControl1.Size = new System.Drawing.Size(1440, 841);
            this.renderControl1.TabIndex = 0;
            this.renderControl1.VSync = false;
            this.renderControl1.Render += new System.EventHandler<System.EventArgs>(this.renderControl1_Render);
            this.renderControl1.Load += new System.EventHandler(this.renderControl1_Load);
            this.renderControl1.Resize += new System.EventHandler(this.renderControl1_Resize);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tscmbAssets,
            this.tsbRenderAll,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.toolStrip1.Size = new System.Drawing.Size(1440, 34);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tscmbAssets
            // 
            this.tscmbAssets.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tscmbAssets.Name = "tscmbAssets";
            this.tscmbAssets.Size = new System.Drawing.Size(180, 34);
            // 
            // tsbRenderAll
            // 
            this.tsbRenderAll.Checked = true;
            this.tsbRenderAll.CheckOnClick = true;
            this.tsbRenderAll.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsbRenderAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbRenderAll.Image = ((System.Drawing.Image)(resources.GetObject("tsbRenderAll.Image")));
            this.tsbRenderAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRenderAll.Name = "tsbRenderAll";
            this.tsbRenderAll.Size = new System.Drawing.Size(96, 29);
            this.tsbRenderAll.Text = "Render All";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(91, 29);
            this.toolStripButton1.Text = "Open File";
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1440, 875);
            this.Controls.Add(this.renderControl1);
            this.Controls.Add(this.toolStrip1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Cobalt.RenderControl renderControl1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripComboBox tscmbAssets;
        private System.Windows.Forms.ToolStripButton tsbRenderAll;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

