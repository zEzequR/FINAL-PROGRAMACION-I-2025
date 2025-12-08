namespace FINAL_PROGRAMACIÓN_I.Formularios
{
    partial class frmReportes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportes));
            this.winCtrlBoxDiv = new Bunifu.UI.WinForms.BunifuPanel();
            this.separator = new Bunifu.UI.WinForms.BunifuSeparator();
            this.WinCtrlBoxClose = new Bunifu.UI.WinForms.BunifuImageButton();
            this.WinCtrlBoxTxt = new Bunifu.UI.WinForms.BunifuLabel();
            this.WinCtrlBoxImg = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.rptViewver = new Microsoft.Reporting.WinForms.ReportViewer();
            this.winCtrlBoxDiv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WinCtrlBoxImg)).BeginInit();
            this.SuspendLayout();
            // 
            // winCtrlBoxDiv
            // 
            this.winCtrlBoxDiv.BackgroundColor = System.Drawing.Color.Transparent;
            this.winCtrlBoxDiv.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("winCtrlBoxDiv.BackgroundImage")));
            this.winCtrlBoxDiv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.winCtrlBoxDiv.BorderColor = System.Drawing.Color.Transparent;
            this.winCtrlBoxDiv.BorderRadius = 3;
            this.winCtrlBoxDiv.BorderThickness = 1;
            this.winCtrlBoxDiv.Controls.Add(this.separator);
            this.winCtrlBoxDiv.Controls.Add(this.WinCtrlBoxClose);
            this.winCtrlBoxDiv.Controls.Add(this.WinCtrlBoxTxt);
            this.winCtrlBoxDiv.Controls.Add(this.WinCtrlBoxImg);
            this.winCtrlBoxDiv.Dock = System.Windows.Forms.DockStyle.Top;
            this.winCtrlBoxDiv.Location = new System.Drawing.Point(0, 0);
            this.winCtrlBoxDiv.Name = "winCtrlBoxDiv";
            this.winCtrlBoxDiv.ShowBorders = true;
            this.winCtrlBoxDiv.Size = new System.Drawing.Size(1203, 68);
            this.winCtrlBoxDiv.TabIndex = 2;
            // 
            // separator
            // 
            this.separator.BackColor = System.Drawing.Color.Transparent;
            this.separator.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("separator.BackgroundImage")));
            this.separator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.separator.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
            this.separator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.separator.LineColor = System.Drawing.Color.White;
            this.separator.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.RightEdgeFaded;
            this.separator.LineThickness = 1;
            this.separator.Location = new System.Drawing.Point(0, 54);
            this.separator.Name = "separator";
            this.separator.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.separator.Size = new System.Drawing.Size(1203, 14);
            this.separator.TabIndex = 1;
            // 
            // WinCtrlBoxClose
            // 
            this.WinCtrlBoxClose.ActiveImage = null;
            this.WinCtrlBoxClose.AllowAnimations = true;
            this.WinCtrlBoxClose.AllowBuffering = false;
            this.WinCtrlBoxClose.AllowToggling = false;
            this.WinCtrlBoxClose.AllowZooming = false;
            this.WinCtrlBoxClose.AllowZoomingOnFocus = false;
            this.WinCtrlBoxClose.BackColor = System.Drawing.Color.Transparent;
            this.WinCtrlBoxClose.DialogResult = System.Windows.Forms.DialogResult.None;
            this.WinCtrlBoxClose.ErrorImage = ((System.Drawing.Image)(resources.GetObject("WinCtrlBoxClose.ErrorImage")));
            this.WinCtrlBoxClose.FadeWhenInactive = false;
            this.WinCtrlBoxClose.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.WinCtrlBoxClose.Image = ((System.Drawing.Image)(resources.GetObject("WinCtrlBoxClose.Image")));
            this.WinCtrlBoxClose.ImageActive = null;
            this.WinCtrlBoxClose.ImageLocation = null;
            this.WinCtrlBoxClose.ImageMargin = 20;
            this.WinCtrlBoxClose.ImageSize = new System.Drawing.Size(37, 36);
            this.WinCtrlBoxClose.ImageZoomSize = new System.Drawing.Size(57, 56);
            this.WinCtrlBoxClose.InitialImage = ((System.Drawing.Image)(resources.GetObject("WinCtrlBoxClose.InitialImage")));
            this.WinCtrlBoxClose.Location = new System.Drawing.Point(1143, 3);
            this.WinCtrlBoxClose.Name = "WinCtrlBoxClose";
            this.WinCtrlBoxClose.Rotation = 0;
            this.WinCtrlBoxClose.ShowActiveImage = false;
            this.WinCtrlBoxClose.ShowCursorChanges = true;
            this.WinCtrlBoxClose.ShowImageBorders = true;
            this.WinCtrlBoxClose.ShowSizeMarkers = false;
            this.WinCtrlBoxClose.Size = new System.Drawing.Size(57, 56);
            this.WinCtrlBoxClose.TabIndex = 3;
            this.WinCtrlBoxClose.ToolTipText = "";
            this.WinCtrlBoxClose.WaitOnLoad = false;
            this.WinCtrlBoxClose.Zoom = 20;
            this.WinCtrlBoxClose.ZoomSpeed = 10;
            this.WinCtrlBoxClose.Click += new System.EventHandler(this.WinCtrlBoxClose_Click);
            // 
            // WinCtrlBoxTxt
            // 
            this.WinCtrlBoxTxt.AllowParentOverrides = false;
            this.WinCtrlBoxTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.WinCtrlBoxTxt.AutoEllipsis = false;
            this.WinCtrlBoxTxt.Cursor = System.Windows.Forms.Cursors.Default;
            this.WinCtrlBoxTxt.CursorType = System.Windows.Forms.Cursors.Default;
            this.WinCtrlBoxTxt.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.WinCtrlBoxTxt.ForeColor = System.Drawing.Color.White;
            this.WinCtrlBoxTxt.Location = new System.Drawing.Point(58, 18);
            this.WinCtrlBoxTxt.Name = "WinCtrlBoxTxt";
            this.WinCtrlBoxTxt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.WinCtrlBoxTxt.Size = new System.Drawing.Size(360, 30);
            this.WinCtrlBoxTxt.TabIndex = 2;
            this.WinCtrlBoxTxt.Text = "Final Programación I - Reporte";
            this.WinCtrlBoxTxt.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.WinCtrlBoxTxt.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // WinCtrlBoxImg
            // 
            this.WinCtrlBoxImg.AllowFocused = false;
            this.WinCtrlBoxImg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.WinCtrlBoxImg.AutoSizeHeight = true;
            this.WinCtrlBoxImg.BorderRadius = 0;
            this.WinCtrlBoxImg.Image = ((System.Drawing.Image)(resources.GetObject("WinCtrlBoxImg.Image")));
            this.WinCtrlBoxImg.IsCircle = false;
            this.WinCtrlBoxImg.Location = new System.Drawing.Point(4, 7);
            this.WinCtrlBoxImg.Name = "WinCtrlBoxImg";
            this.WinCtrlBoxImg.Size = new System.Drawing.Size(48, 48);
            this.WinCtrlBoxImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.WinCtrlBoxImg.TabIndex = 0;
            this.WinCtrlBoxImg.TabStop = false;
            this.WinCtrlBoxImg.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            // 
            // rptViewver
            // 
            this.rptViewver.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptViewver.Location = new System.Drawing.Point(0, 68);
            this.rptViewver.Name = "rptViewver";
            this.rptViewver.ServerReport.BearerToken = null;
            this.rptViewver.Size = new System.Drawing.Size(1203, 593);
            this.rptViewver.TabIndex = 3;
            // 
            // frmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1203, 661);
            this.Controls.Add(this.rptViewver);
            this.Controls.Add(this.winCtrlBoxDiv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReportes";
            this.Text = "frmReportes";
            this.Load += new System.EventHandler(this.frmReportes_Load);
            this.winCtrlBoxDiv.ResumeLayout(false);
            this.winCtrlBoxDiv.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WinCtrlBoxImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPanel winCtrlBoxDiv;
        private Bunifu.UI.WinForms.BunifuSeparator separator;
        private Bunifu.UI.WinForms.BunifuImageButton WinCtrlBoxClose;
        private Bunifu.UI.WinForms.BunifuLabel WinCtrlBoxTxt;
        private Bunifu.UI.WinForms.BunifuPictureBox WinCtrlBoxImg;
        private Microsoft.Reporting.WinForms.ReportViewer rptViewver;
    }
}