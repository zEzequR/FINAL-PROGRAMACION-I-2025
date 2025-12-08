namespace FINAL_PROGRAMACIÓN_I.Formularios
{
    partial class frmConsultarVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultarVentas));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            this.winBg = new Bunifu.UI.WinForms.BunifuGradientPanel();
            this.btnImprimir = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.verXUsuarioCheckBox = new Bunifu.UI.WinForms.BunifuCheckBox();
            this.verXClienteCheckBox = new Bunifu.UI.WinForms.BunifuCheckBox();
            this.verXFechaCheckBox = new Bunifu.UI.WinForms.BunifuCheckBox();
            this.verXIDVtaCheckBox = new Bunifu.UI.WinForms.BunifuCheckBox();
            this.userSelect = new System.Windows.Forms.ComboBox();
            this.idVtaSelect = new System.Windows.Forms.ComboBox();
            this.clientSelect = new System.Windows.Forms.ComboBox();
            this.importeVtaInp = new Bunifu.UI.WinForms.BunifuTextBox();
            this.userTxt = new Bunifu.UI.WinForms.BunifuLabel();
            this.importeTxt = new Bunifu.UI.WinForms.BunifuLabel();
            this.clienteTxt = new Bunifu.UI.WinForms.BunifuLabel();
            this.fechaVtaInp = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.fechaVtaTxt = new Bunifu.UI.WinForms.BunifuLabel();
            this.idVtaTxt = new Bunifu.UI.WinForms.BunifuLabel();
            this.detalleVtaTxt = new Bunifu.UI.WinForms.BunifuLabel();
            this.VentaTable = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.confirmBtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.DetVtaSep = new Bunifu.UI.WinForms.BunifuSeparator();
            this.winBg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnImprimir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VentaTable)).BeginInit();
            this.SuspendLayout();
            // 
            // winBg
            // 
            this.winBg.BackColor = System.Drawing.Color.Transparent;
            this.winBg.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("winBg.BackgroundImage")));
            this.winBg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.winBg.BorderRadius = 10;
            this.winBg.Controls.Add(this.btnImprimir);
            this.winBg.Controls.Add(this.verXUsuarioCheckBox);
            this.winBg.Controls.Add(this.verXClienteCheckBox);
            this.winBg.Controls.Add(this.verXFechaCheckBox);
            this.winBg.Controls.Add(this.verXIDVtaCheckBox);
            this.winBg.Controls.Add(this.userSelect);
            this.winBg.Controls.Add(this.idVtaSelect);
            this.winBg.Controls.Add(this.clientSelect);
            this.winBg.Controls.Add(this.importeVtaInp);
            this.winBg.Controls.Add(this.userTxt);
            this.winBg.Controls.Add(this.importeTxt);
            this.winBg.Controls.Add(this.clienteTxt);
            this.winBg.Controls.Add(this.fechaVtaInp);
            this.winBg.Controls.Add(this.fechaVtaTxt);
            this.winBg.Controls.Add(this.idVtaTxt);
            this.winBg.Controls.Add(this.detalleVtaTxt);
            this.winBg.Controls.Add(this.VentaTable);
            this.winBg.Controls.Add(this.confirmBtn);
            this.winBg.Controls.Add(this.DetVtaSep);
            this.winBg.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.winBg.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.winBg.GradientTopLeft = System.Drawing.SystemColors.Desktop;
            this.winBg.GradientTopRight = System.Drawing.SystemColors.Desktop;
            this.winBg.Location = new System.Drawing.Point(-9, -9);
            this.winBg.Name = "winBg";
            this.winBg.Quality = 10;
            this.winBg.Size = new System.Drawing.Size(1020, 585);
            this.winBg.TabIndex = 4;
            // 
            // btnImprimir
            // 
            this.btnImprimir.AllowFocused = false;
            this.btnImprimir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnImprimir.AutoSizeHeight = true;
            this.btnImprimir.BorderRadius = 0;
            this.btnImprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImprimir.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimir.Image")));
            this.btnImprimir.IsCircle = true;
            this.btnImprimir.Location = new System.Drawing.Point(941, 15);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(45, 45);
            this.btnImprimir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnImprimir.TabIndex = 70;
            this.btnImprimir.TabStop = false;
            this.btnImprimir.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            this.btnImprimir.Visible = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // verXUsuarioCheckBox
            // 
            this.verXUsuarioCheckBox.AllowBindingControlAnimation = true;
            this.verXUsuarioCheckBox.AllowBindingControlColorChanges = false;
            this.verXUsuarioCheckBox.AllowBindingControlLocation = true;
            this.verXUsuarioCheckBox.AllowCheckBoxAnimation = false;
            this.verXUsuarioCheckBox.AllowCheckmarkAnimation = true;
            this.verXUsuarioCheckBox.AllowOnHoverStates = true;
            this.verXUsuarioCheckBox.AutoCheck = true;
            this.verXUsuarioCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.verXUsuarioCheckBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("verXUsuarioCheckBox.BackgroundImage")));
            this.verXUsuarioCheckBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.verXUsuarioCheckBox.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right;
            this.verXUsuarioCheckBox.BorderRadius = 12;
            this.verXUsuarioCheckBox.Checked = false;
            this.verXUsuarioCheckBox.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Unchecked;
            this.verXUsuarioCheckBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.verXUsuarioCheckBox.CustomCheckmarkImage = null;
            this.verXUsuarioCheckBox.Location = new System.Drawing.Point(819, 57);
            this.verXUsuarioCheckBox.MinimumSize = new System.Drawing.Size(17, 17);
            this.verXUsuarioCheckBox.Name = "verXUsuarioCheckBox";
            this.verXUsuarioCheckBox.OnCheck.BorderColor = System.Drawing.Color.DodgerBlue;
            this.verXUsuarioCheckBox.OnCheck.BorderRadius = 12;
            this.verXUsuarioCheckBox.OnCheck.BorderThickness = 2;
            this.verXUsuarioCheckBox.OnCheck.CheckBoxColor = System.Drawing.Color.DodgerBlue;
            this.verXUsuarioCheckBox.OnCheck.CheckmarkColor = System.Drawing.Color.White;
            this.verXUsuarioCheckBox.OnCheck.CheckmarkThickness = 2;
            this.verXUsuarioCheckBox.OnDisable.BorderColor = System.Drawing.Color.LightGray;
            this.verXUsuarioCheckBox.OnDisable.BorderRadius = 12;
            this.verXUsuarioCheckBox.OnDisable.BorderThickness = 2;
            this.verXUsuarioCheckBox.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent;
            this.verXUsuarioCheckBox.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray;
            this.verXUsuarioCheckBox.OnDisable.CheckmarkThickness = 2;
            this.verXUsuarioCheckBox.OnHoverChecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.verXUsuarioCheckBox.OnHoverChecked.BorderRadius = 12;
            this.verXUsuarioCheckBox.OnHoverChecked.BorderThickness = 2;
            this.verXUsuarioCheckBox.OnHoverChecked.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.verXUsuarioCheckBox.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White;
            this.verXUsuarioCheckBox.OnHoverChecked.CheckmarkThickness = 2;
            this.verXUsuarioCheckBox.OnHoverUnchecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.verXUsuarioCheckBox.OnHoverUnchecked.BorderRadius = 12;
            this.verXUsuarioCheckBox.OnHoverUnchecked.BorderThickness = 1;
            this.verXUsuarioCheckBox.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent;
            this.verXUsuarioCheckBox.OnUncheck.BorderColor = System.Drawing.Color.DarkGray;
            this.verXUsuarioCheckBox.OnUncheck.BorderRadius = 12;
            this.verXUsuarioCheckBox.OnUncheck.BorderThickness = 1;
            this.verXUsuarioCheckBox.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent;
            this.verXUsuarioCheckBox.Size = new System.Drawing.Size(30, 30);
            this.verXUsuarioCheckBox.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu;
            this.verXUsuarioCheckBox.TabIndex = 83;
            this.verXUsuarioCheckBox.ThreeState = false;
            this.verXUsuarioCheckBox.ToolTipText = null;
            // 
            // verXClienteCheckBox
            // 
            this.verXClienteCheckBox.AllowBindingControlAnimation = true;
            this.verXClienteCheckBox.AllowBindingControlColorChanges = false;
            this.verXClienteCheckBox.AllowBindingControlLocation = true;
            this.verXClienteCheckBox.AllowCheckBoxAnimation = false;
            this.verXClienteCheckBox.AllowCheckmarkAnimation = true;
            this.verXClienteCheckBox.AllowOnHoverStates = true;
            this.verXClienteCheckBox.AutoCheck = true;
            this.verXClienteCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.verXClienteCheckBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("verXClienteCheckBox.BackgroundImage")));
            this.verXClienteCheckBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.verXClienteCheckBox.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right;
            this.verXClienteCheckBox.BorderRadius = 12;
            this.verXClienteCheckBox.Checked = false;
            this.verXClienteCheckBox.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Unchecked;
            this.verXClienteCheckBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.verXClienteCheckBox.CustomCheckmarkImage = null;
            this.verXClienteCheckBox.Location = new System.Drawing.Point(397, 57);
            this.verXClienteCheckBox.MinimumSize = new System.Drawing.Size(17, 17);
            this.verXClienteCheckBox.Name = "verXClienteCheckBox";
            this.verXClienteCheckBox.OnCheck.BorderColor = System.Drawing.Color.DodgerBlue;
            this.verXClienteCheckBox.OnCheck.BorderRadius = 12;
            this.verXClienteCheckBox.OnCheck.BorderThickness = 2;
            this.verXClienteCheckBox.OnCheck.CheckBoxColor = System.Drawing.Color.DodgerBlue;
            this.verXClienteCheckBox.OnCheck.CheckmarkColor = System.Drawing.Color.White;
            this.verXClienteCheckBox.OnCheck.CheckmarkThickness = 2;
            this.verXClienteCheckBox.OnDisable.BorderColor = System.Drawing.Color.LightGray;
            this.verXClienteCheckBox.OnDisable.BorderRadius = 12;
            this.verXClienteCheckBox.OnDisable.BorderThickness = 2;
            this.verXClienteCheckBox.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent;
            this.verXClienteCheckBox.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray;
            this.verXClienteCheckBox.OnDisable.CheckmarkThickness = 2;
            this.verXClienteCheckBox.OnHoverChecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.verXClienteCheckBox.OnHoverChecked.BorderRadius = 12;
            this.verXClienteCheckBox.OnHoverChecked.BorderThickness = 2;
            this.verXClienteCheckBox.OnHoverChecked.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.verXClienteCheckBox.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White;
            this.verXClienteCheckBox.OnHoverChecked.CheckmarkThickness = 2;
            this.verXClienteCheckBox.OnHoverUnchecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.verXClienteCheckBox.OnHoverUnchecked.BorderRadius = 12;
            this.verXClienteCheckBox.OnHoverUnchecked.BorderThickness = 1;
            this.verXClienteCheckBox.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent;
            this.verXClienteCheckBox.OnUncheck.BorderColor = System.Drawing.Color.DarkGray;
            this.verXClienteCheckBox.OnUncheck.BorderRadius = 12;
            this.verXClienteCheckBox.OnUncheck.BorderThickness = 1;
            this.verXClienteCheckBox.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent;
            this.verXClienteCheckBox.Size = new System.Drawing.Size(30, 30);
            this.verXClienteCheckBox.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu;
            this.verXClienteCheckBox.TabIndex = 81;
            this.verXClienteCheckBox.ThreeState = false;
            this.verXClienteCheckBox.ToolTipText = null;
            // 
            // verXFechaCheckBox
            // 
            this.verXFechaCheckBox.AllowBindingControlAnimation = true;
            this.verXFechaCheckBox.AllowBindingControlColorChanges = false;
            this.verXFechaCheckBox.AllowBindingControlLocation = true;
            this.verXFechaCheckBox.AllowCheckBoxAnimation = false;
            this.verXFechaCheckBox.AllowCheckmarkAnimation = true;
            this.verXFechaCheckBox.AllowOnHoverStates = true;
            this.verXFechaCheckBox.AutoCheck = true;
            this.verXFechaCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.verXFechaCheckBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("verXFechaCheckBox.BackgroundImage")));
            this.verXFechaCheckBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.verXFechaCheckBox.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right;
            this.verXFechaCheckBox.BorderRadius = 12;
            this.verXFechaCheckBox.Checked = false;
            this.verXFechaCheckBox.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Unchecked;
            this.verXFechaCheckBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.verXFechaCheckBox.CustomCheckmarkImage = null;
            this.verXFechaCheckBox.Location = new System.Drawing.Point(190, 57);
            this.verXFechaCheckBox.MinimumSize = new System.Drawing.Size(17, 17);
            this.verXFechaCheckBox.Name = "verXFechaCheckBox";
            this.verXFechaCheckBox.OnCheck.BorderColor = System.Drawing.Color.DodgerBlue;
            this.verXFechaCheckBox.OnCheck.BorderRadius = 12;
            this.verXFechaCheckBox.OnCheck.BorderThickness = 2;
            this.verXFechaCheckBox.OnCheck.CheckBoxColor = System.Drawing.Color.DodgerBlue;
            this.verXFechaCheckBox.OnCheck.CheckmarkColor = System.Drawing.Color.White;
            this.verXFechaCheckBox.OnCheck.CheckmarkThickness = 2;
            this.verXFechaCheckBox.OnDisable.BorderColor = System.Drawing.Color.LightGray;
            this.verXFechaCheckBox.OnDisable.BorderRadius = 12;
            this.verXFechaCheckBox.OnDisable.BorderThickness = 2;
            this.verXFechaCheckBox.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent;
            this.verXFechaCheckBox.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray;
            this.verXFechaCheckBox.OnDisable.CheckmarkThickness = 2;
            this.verXFechaCheckBox.OnHoverChecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.verXFechaCheckBox.OnHoverChecked.BorderRadius = 12;
            this.verXFechaCheckBox.OnHoverChecked.BorderThickness = 2;
            this.verXFechaCheckBox.OnHoverChecked.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.verXFechaCheckBox.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White;
            this.verXFechaCheckBox.OnHoverChecked.CheckmarkThickness = 2;
            this.verXFechaCheckBox.OnHoverUnchecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.verXFechaCheckBox.OnHoverUnchecked.BorderRadius = 12;
            this.verXFechaCheckBox.OnHoverUnchecked.BorderThickness = 1;
            this.verXFechaCheckBox.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent;
            this.verXFechaCheckBox.OnUncheck.BorderColor = System.Drawing.Color.DarkGray;
            this.verXFechaCheckBox.OnUncheck.BorderRadius = 12;
            this.verXFechaCheckBox.OnUncheck.BorderThickness = 1;
            this.verXFechaCheckBox.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent;
            this.verXFechaCheckBox.Size = new System.Drawing.Size(30, 30);
            this.verXFechaCheckBox.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu;
            this.verXFechaCheckBox.TabIndex = 80;
            this.verXFechaCheckBox.ThreeState = false;
            this.verXFechaCheckBox.ToolTipText = null;
            // 
            // verXIDVtaCheckBox
            // 
            this.verXIDVtaCheckBox.AllowBindingControlAnimation = true;
            this.verXIDVtaCheckBox.AllowBindingControlColorChanges = false;
            this.verXIDVtaCheckBox.AllowBindingControlLocation = true;
            this.verXIDVtaCheckBox.AllowCheckBoxAnimation = false;
            this.verXIDVtaCheckBox.AllowCheckmarkAnimation = true;
            this.verXIDVtaCheckBox.AllowOnHoverStates = true;
            this.verXIDVtaCheckBox.AutoCheck = true;
            this.verXIDVtaCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.verXIDVtaCheckBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("verXIDVtaCheckBox.BackgroundImage")));
            this.verXIDVtaCheckBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.verXIDVtaCheckBox.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right;
            this.verXIDVtaCheckBox.BorderRadius = 12;
            this.verXIDVtaCheckBox.Checked = false;
            this.verXIDVtaCheckBox.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Unchecked;
            this.verXIDVtaCheckBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.verXIDVtaCheckBox.CustomCheckmarkImage = null;
            this.verXIDVtaCheckBox.Location = new System.Drawing.Point(65, 57);
            this.verXIDVtaCheckBox.MinimumSize = new System.Drawing.Size(17, 17);
            this.verXIDVtaCheckBox.Name = "verXIDVtaCheckBox";
            this.verXIDVtaCheckBox.OnCheck.BorderColor = System.Drawing.Color.DodgerBlue;
            this.verXIDVtaCheckBox.OnCheck.BorderRadius = 12;
            this.verXIDVtaCheckBox.OnCheck.BorderThickness = 2;
            this.verXIDVtaCheckBox.OnCheck.CheckBoxColor = System.Drawing.Color.DodgerBlue;
            this.verXIDVtaCheckBox.OnCheck.CheckmarkColor = System.Drawing.Color.White;
            this.verXIDVtaCheckBox.OnCheck.CheckmarkThickness = 2;
            this.verXIDVtaCheckBox.OnDisable.BorderColor = System.Drawing.Color.LightGray;
            this.verXIDVtaCheckBox.OnDisable.BorderRadius = 12;
            this.verXIDVtaCheckBox.OnDisable.BorderThickness = 2;
            this.verXIDVtaCheckBox.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent;
            this.verXIDVtaCheckBox.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray;
            this.verXIDVtaCheckBox.OnDisable.CheckmarkThickness = 2;
            this.verXIDVtaCheckBox.OnHoverChecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.verXIDVtaCheckBox.OnHoverChecked.BorderRadius = 12;
            this.verXIDVtaCheckBox.OnHoverChecked.BorderThickness = 2;
            this.verXIDVtaCheckBox.OnHoverChecked.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.verXIDVtaCheckBox.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White;
            this.verXIDVtaCheckBox.OnHoverChecked.CheckmarkThickness = 2;
            this.verXIDVtaCheckBox.OnHoverUnchecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.verXIDVtaCheckBox.OnHoverUnchecked.BorderRadius = 12;
            this.verXIDVtaCheckBox.OnHoverUnchecked.BorderThickness = 1;
            this.verXIDVtaCheckBox.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent;
            this.verXIDVtaCheckBox.OnUncheck.BorderColor = System.Drawing.Color.DarkGray;
            this.verXIDVtaCheckBox.OnUncheck.BorderRadius = 12;
            this.verXIDVtaCheckBox.OnUncheck.BorderThickness = 1;
            this.verXIDVtaCheckBox.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent;
            this.verXIDVtaCheckBox.Size = new System.Drawing.Size(30, 30);
            this.verXIDVtaCheckBox.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu;
            this.verXIDVtaCheckBox.TabIndex = 0;
            this.verXIDVtaCheckBox.ThreeState = false;
            this.verXIDVtaCheckBox.ToolTipText = null;
            // 
            // userSelect
            // 
            this.userSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.userSelect.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userSelect.FormattingEnabled = true;
            this.userSelect.Location = new System.Drawing.Point(839, 28);
            this.userSelect.Name = "userSelect";
            this.userSelect.Size = new System.Drawing.Size(58, 24);
            this.userSelect.TabIndex = 79;
            // 
            // idVtaSelect
            // 
            this.idVtaSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.idVtaSelect.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idVtaSelect.FormattingEnabled = true;
            this.idVtaSelect.Location = new System.Drawing.Point(65, 27);
            this.idVtaSelect.Name = "idVtaSelect";
            this.idVtaSelect.Size = new System.Drawing.Size(46, 24);
            this.idVtaSelect.TabIndex = 78;
            // 
            // clientSelect
            // 
            this.clientSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.clientSelect.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientSelect.FormattingEnabled = true;
            this.clientSelect.Location = new System.Drawing.Point(416, 27);
            this.clientSelect.Name = "clientSelect";
            this.clientSelect.Size = new System.Drawing.Size(103, 24);
            this.clientSelect.TabIndex = 77;
            // 
            // importeVtaInp
            // 
            this.importeVtaInp.AcceptsReturn = false;
            this.importeVtaInp.AcceptsTab = true;
            this.importeVtaInp.AnimationSpeed = 200;
            this.importeVtaInp.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.importeVtaInp.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.importeVtaInp.AutoSizeHeight = true;
            this.importeVtaInp.BackColor = System.Drawing.Color.Transparent;
            this.importeVtaInp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("importeVtaInp.BackgroundImage")));
            this.importeVtaInp.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.importeVtaInp.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.importeVtaInp.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.importeVtaInp.BorderColorIdle = System.Drawing.Color.Silver;
            this.importeVtaInp.BorderRadius = 20;
            this.importeVtaInp.BorderThickness = 1;
            this.importeVtaInp.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            this.importeVtaInp.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.importeVtaInp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.importeVtaInp.DefaultFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importeVtaInp.DefaultText = "0";
            this.importeVtaInp.Enabled = false;
            this.importeVtaInp.FillColor = System.Drawing.Color.White;
            this.importeVtaInp.HideSelection = true;
            this.importeVtaInp.IconLeft = null;
            this.importeVtaInp.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.importeVtaInp.IconPadding = 10;
            this.importeVtaInp.IconRight = null;
            this.importeVtaInp.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.importeVtaInp.Lines = new string[] {
        "0"};
            this.importeVtaInp.Location = new System.Drawing.Point(632, 22);
            this.importeVtaInp.MaxLength = 32767;
            this.importeVtaInp.MinimumSize = new System.Drawing.Size(1, 1);
            this.importeVtaInp.Modified = false;
            this.importeVtaInp.Multiline = false;
            this.importeVtaInp.Name = "importeVtaInp";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.importeVtaInp.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.importeVtaInp.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.importeVtaInp.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.importeVtaInp.OnIdleState = stateProperties4;
            this.importeVtaInp.Padding = new System.Windows.Forms.Padding(3);
            this.importeVtaInp.PasswordChar = '\0';
            this.importeVtaInp.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.importeVtaInp.PlaceholderText = "";
            this.importeVtaInp.ReadOnly = true;
            this.importeVtaInp.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.importeVtaInp.SelectedText = "";
            this.importeVtaInp.SelectionLength = 0;
            this.importeVtaInp.SelectionStart = 1;
            this.importeVtaInp.ShortcutsEnabled = true;
            this.importeVtaInp.Size = new System.Drawing.Size(110, 32);
            this.importeVtaInp.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.importeVtaInp.TabIndex = 76;
            this.importeVtaInp.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.importeVtaInp.TextMarginBottom = 0;
            this.importeVtaInp.TextMarginLeft = 3;
            this.importeVtaInp.TextMarginTop = 1;
            this.importeVtaInp.TextPlaceholder = "";
            this.importeVtaInp.UseSystemPasswordChar = false;
            this.importeVtaInp.WordWrap = true;
            // 
            // userTxt
            // 
            this.userTxt.AllowParentOverrides = false;
            this.userTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.userTxt.AutoEllipsis = false;
            this.userTxt.Cursor = System.Windows.Forms.Cursors.Default;
            this.userTxt.CursorType = System.Windows.Forms.Cursors.Default;
            this.userTxt.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.userTxt.ForeColor = System.Drawing.Color.White;
            this.userTxt.Location = new System.Drawing.Point(756, 26);
            this.userTxt.Name = "userTxt";
            this.userTxt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.userTxt.Size = new System.Drawing.Size(76, 24);
            this.userTxt.TabIndex = 74;
            this.userTxt.Text = "Usuario:";
            this.userTxt.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.userTxt.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // importeTxt
            // 
            this.importeTxt.AllowParentOverrides = false;
            this.importeTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.importeTxt.AutoEllipsis = false;
            this.importeTxt.Cursor = System.Windows.Forms.Cursors.Default;
            this.importeTxt.CursorType = System.Windows.Forms.Cursors.Default;
            this.importeTxt.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.importeTxt.ForeColor = System.Drawing.Color.White;
            this.importeTxt.Location = new System.Drawing.Point(540, 25);
            this.importeTxt.Name = "importeTxt";
            this.importeTxt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.importeTxt.Size = new System.Drawing.Size(86, 24);
            this.importeTxt.TabIndex = 73;
            this.importeTxt.Text = "Importe:";
            this.importeTxt.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.importeTxt.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // clienteTxt
            // 
            this.clienteTxt.AllowParentOverrides = false;
            this.clienteTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.clienteTxt.AutoEllipsis = false;
            this.clienteTxt.Cursor = System.Windows.Forms.Cursors.Default;
            this.clienteTxt.CursorType = System.Windows.Forms.Cursors.Default;
            this.clienteTxt.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.clienteTxt.ForeColor = System.Drawing.Color.White;
            this.clienteTxt.Location = new System.Drawing.Point(331, 25);
            this.clienteTxt.Name = "clienteTxt";
            this.clienteTxt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.clienteTxt.Size = new System.Drawing.Size(78, 24);
            this.clienteTxt.TabIndex = 72;
            this.clienteTxt.Text = "Cliente:";
            this.clienteTxt.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.clienteTxt.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // fechaVtaInp
            // 
            this.fechaVtaInp.BackColor = System.Drawing.Color.Transparent;
            this.fechaVtaInp.BorderColor = System.Drawing.Color.DodgerBlue;
            this.fechaVtaInp.BorderRadius = 17;
            this.fechaVtaInp.Color = System.Drawing.Color.DodgerBlue;
            this.fechaVtaInp.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin;
            this.fechaVtaInp.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.fechaVtaInp.DisabledColor = System.Drawing.Color.Gray;
            this.fechaVtaInp.DisplayWeekNumbers = false;
            this.fechaVtaInp.DPHeight = 0;
            this.fechaVtaInp.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.fechaVtaInp.FillDatePicker = false;
            this.fechaVtaInp.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.fechaVtaInp.ForeColor = System.Drawing.Color.Black;
            this.fechaVtaInp.Icon = ((System.Drawing.Image)(resources.GetObject("fechaVtaInp.Icon")));
            this.fechaVtaInp.IconColor = System.Drawing.Color.DodgerBlue;
            this.fechaVtaInp.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.fechaVtaInp.LeftTextMargin = 5;
            this.fechaVtaInp.Location = new System.Drawing.Point(205, 21);
            this.fechaVtaInp.MinimumSize = new System.Drawing.Size(4, 32);
            this.fechaVtaInp.Name = "fechaVtaInp";
            this.fechaVtaInp.Size = new System.Drawing.Size(108, 32);
            this.fechaVtaInp.TabIndex = 71;
            // 
            // fechaVtaTxt
            // 
            this.fechaVtaTxt.AllowParentOverrides = false;
            this.fechaVtaTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fechaVtaTxt.AutoEllipsis = false;
            this.fechaVtaTxt.Cursor = System.Windows.Forms.Cursors.Default;
            this.fechaVtaTxt.CursorType = System.Windows.Forms.Cursors.Default;
            this.fechaVtaTxt.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.fechaVtaTxt.ForeColor = System.Drawing.Color.White;
            this.fechaVtaTxt.Location = new System.Drawing.Point(129, 25);
            this.fechaVtaTxt.Name = "fechaVtaTxt";
            this.fechaVtaTxt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fechaVtaTxt.Size = new System.Drawing.Size(70, 24);
            this.fechaVtaTxt.TabIndex = 70;
            this.fechaVtaTxt.Text = "Fecha:";
            this.fechaVtaTxt.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.fechaVtaTxt.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // idVtaTxt
            // 
            this.idVtaTxt.AllowParentOverrides = false;
            this.idVtaTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.idVtaTxt.AutoEllipsis = false;
            this.idVtaTxt.Cursor = System.Windows.Forms.Cursors.Default;
            this.idVtaTxt.CursorType = System.Windows.Forms.Cursors.Default;
            this.idVtaTxt.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.idVtaTxt.ForeColor = System.Drawing.Color.White;
            this.idVtaTxt.Location = new System.Drawing.Point(37, 25);
            this.idVtaTxt.Name = "idVtaTxt";
            this.idVtaTxt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.idVtaTxt.Size = new System.Drawing.Size(21, 24);
            this.idVtaTxt.TabIndex = 68;
            this.idVtaTxt.Text = "ID";
            this.idVtaTxt.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.idVtaTxt.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // detalleVtaTxt
            // 
            this.detalleVtaTxt.AllowParentOverrides = false;
            this.detalleVtaTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.detalleVtaTxt.AutoEllipsis = false;
            this.detalleVtaTxt.Cursor = System.Windows.Forms.Cursors.Default;
            this.detalleVtaTxt.CursorType = System.Windows.Forms.Cursors.Default;
            this.detalleVtaTxt.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.detalleVtaTxt.ForeColor = System.Drawing.Color.White;
            this.detalleVtaTxt.Location = new System.Drawing.Point(480, 115);
            this.detalleVtaTxt.Name = "detalleVtaTxt";
            this.detalleVtaTxt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.detalleVtaTxt.Size = new System.Drawing.Size(63, 24);
            this.detalleVtaTxt.TabIndex = 56;
            this.detalleVtaTxt.Text = "Venta";
            this.detalleVtaTxt.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.detalleVtaTxt.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // VentaTable
            // 
            this.VentaTable.AllowCustomTheming = false;
            this.VentaTable.AllowUserToAddRows = false;
            this.VentaTable.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.VentaTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.VentaTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.VentaTable.BackgroundColor = System.Drawing.Color.Black;
            this.VentaTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.VentaTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.VentaTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.VentaTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.VentaTable.ColumnHeadersHeight = 40;
            this.VentaTable.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(223)))));
            this.VentaTable.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.VentaTable.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.VentaTable.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(178)))));
            this.VentaTable.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.VentaTable.CurrentTheme.BackColor = System.Drawing.Color.Navy;
            this.VentaTable.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(178)))), ((int)(((byte)(216)))));
            this.VentaTable.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.Navy;
            this.VentaTable.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.VentaTable.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.VentaTable.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(102)))));
            this.VentaTable.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.VentaTable.CurrentTheme.Name = null;
            this.VentaTable.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(229)))));
            this.VentaTable.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.VentaTable.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.VentaTable.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(178)))));
            this.VentaTable.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(229)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(178)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.VentaTable.DefaultCellStyle = dataGridViewCellStyle3;
            this.VentaTable.EnableHeadersVisualStyles = false;
            this.VentaTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(178)))), ((int)(((byte)(216)))));
            this.VentaTable.HeaderBackColor = System.Drawing.Color.Navy;
            this.VentaTable.HeaderBgColor = System.Drawing.Color.Empty;
            this.VentaTable.HeaderForeColor = System.Drawing.Color.White;
            this.VentaTable.Location = new System.Drawing.Point(18, 145);
            this.VentaTable.MultiSelect = false;
            this.VentaTable.Name = "VentaTable";
            this.VentaTable.ReadOnly = true;
            this.VentaTable.RowHeadersVisible = false;
            this.VentaTable.RowHeadersWidth = 62;
            this.VentaTable.RowTemplate.Height = 40;
            this.VentaTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.VentaTable.Size = new System.Drawing.Size(986, 424);
            this.VentaTable.TabIndex = 1;
            this.VentaTable.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Navy;
            // 
            // confirmBtn
            // 
            this.confirmBtn.AllowAnimations = true;
            this.confirmBtn.AllowMouseEffects = true;
            this.confirmBtn.AllowToggling = false;
            this.confirmBtn.AnimationSpeed = 200;
            this.confirmBtn.AutoGenerateColors = false;
            this.confirmBtn.AutoRoundBorders = true;
            this.confirmBtn.AutoSizeLeftIcon = true;
            this.confirmBtn.AutoSizeRightIcon = true;
            this.confirmBtn.BackColor = System.Drawing.Color.Transparent;
            this.confirmBtn.BackColor1 = System.Drawing.Color.Navy;
            this.confirmBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("confirmBtn.BackgroundImage")));
            this.confirmBtn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.confirmBtn.ButtonText = "Buscar";
            this.confirmBtn.ButtonTextMarginLeft = 0;
            this.confirmBtn.ColorContrastOnClick = 45;
            this.confirmBtn.ColorContrastOnHover = 45;
            this.confirmBtn.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.confirmBtn.CustomizableEdges = borderEdges1;
            this.confirmBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.confirmBtn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.confirmBtn.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.confirmBtn.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.confirmBtn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.confirmBtn.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.confirmBtn.ForeColor = System.Drawing.Color.White;
            this.confirmBtn.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.confirmBtn.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.confirmBtn.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.confirmBtn.IconMarginLeft = 11;
            this.confirmBtn.IconPadding = 10;
            this.confirmBtn.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.confirmBtn.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.confirmBtn.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.confirmBtn.IconSize = 25;
            this.confirmBtn.IdleBorderColor = System.Drawing.Color.Azure;
            this.confirmBtn.IdleBorderRadius = 28;
            this.confirmBtn.IdleBorderThickness = 1;
            this.confirmBtn.IdleFillColor = System.Drawing.Color.Navy;
            this.confirmBtn.IdleIconLeftImage = null;
            this.confirmBtn.IdleIconRightImage = null;
            this.confirmBtn.IndicateFocus = false;
            this.confirmBtn.Location = new System.Drawing.Point(902, 66);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.confirmBtn.OnDisabledState.BorderRadius = 60;
            this.confirmBtn.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.confirmBtn.OnDisabledState.BorderThickness = 1;
            this.confirmBtn.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.confirmBtn.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.confirmBtn.OnDisabledState.IconLeftImage = null;
            this.confirmBtn.OnDisabledState.IconRightImage = null;
            this.confirmBtn.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.confirmBtn.onHoverState.BorderRadius = 60;
            this.confirmBtn.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.confirmBtn.onHoverState.BorderThickness = 1;
            this.confirmBtn.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.confirmBtn.onHoverState.ForeColor = System.Drawing.Color.White;
            this.confirmBtn.onHoverState.IconLeftImage = null;
            this.confirmBtn.onHoverState.IconRightImage = null;
            this.confirmBtn.OnIdleState.BorderColor = System.Drawing.Color.Azure;
            this.confirmBtn.OnIdleState.BorderRadius = 60;
            this.confirmBtn.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.confirmBtn.OnIdleState.BorderThickness = 1;
            this.confirmBtn.OnIdleState.FillColor = System.Drawing.Color.Navy;
            this.confirmBtn.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.confirmBtn.OnIdleState.IconLeftImage = null;
            this.confirmBtn.OnIdleState.IconRightImage = null;
            this.confirmBtn.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.confirmBtn.OnPressedState.BorderRadius = 60;
            this.confirmBtn.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.confirmBtn.OnPressedState.BorderThickness = 1;
            this.confirmBtn.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.confirmBtn.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.confirmBtn.OnPressedState.IconLeftImage = null;
            this.confirmBtn.OnPressedState.IconRightImage = null;
            this.confirmBtn.Size = new System.Drawing.Size(98, 30);
            this.confirmBtn.TabIndex = 42;
            this.confirmBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.confirmBtn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.confirmBtn.TextMarginLeft = 0;
            this.confirmBtn.TextPadding = new System.Windows.Forms.Padding(0);
            this.confirmBtn.UseDefaultRadiusAndThickness = true;
            this.confirmBtn.Click += new System.EventHandler(this.confirmBtn_Click);
            // 
            // DetVtaSep
            // 
            this.DetVtaSep.BackColor = System.Drawing.Color.Transparent;
            this.DetVtaSep.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DetVtaSep.BackgroundImage")));
            this.DetVtaSep.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DetVtaSep.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
            this.DetVtaSep.LineColor = System.Drawing.Color.White;
            this.DetVtaSep.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.DoubleEdgeFaded;
            this.DetVtaSep.LineThickness = 1;
            this.DetVtaSep.Location = new System.Drawing.Point(9, 97);
            this.DetVtaSep.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DetVtaSep.Name = "DetVtaSep";
            this.DetVtaSep.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.DetVtaSep.Size = new System.Drawing.Size(1003, 15);
            this.DetVtaSep.TabIndex = 41;
            // 
            // frmConsultarVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 567);
            this.Controls.Add(this.winBg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmConsultarVentas";
            this.Text = "frmConsultarVentas";
            this.Load += new System.EventHandler(this.frmConsultarVentas_Load);
            this.winBg.ResumeLayout(false);
            this.winBg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnImprimir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VentaTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuGradientPanel winBg;
        private Bunifu.UI.WinForms.BunifuLabel detalleVtaTxt;
        private Bunifu.UI.WinForms.BunifuDataGridView VentaTable;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 confirmBtn;
        private Bunifu.UI.WinForms.BunifuSeparator DetVtaSep;
        private System.Windows.Forms.ComboBox clientSelect;
        private Bunifu.UI.WinForms.BunifuTextBox importeVtaInp;
        private Bunifu.UI.WinForms.BunifuLabel userTxt;
        private Bunifu.UI.WinForms.BunifuLabel importeTxt;
        private Bunifu.UI.WinForms.BunifuLabel clienteTxt;
        private Bunifu.UI.WinForms.BunifuDatePicker fechaVtaInp;
        private Bunifu.UI.WinForms.BunifuLabel fechaVtaTxt;
        private Bunifu.UI.WinForms.BunifuLabel idVtaTxt;
        private System.Windows.Forms.ComboBox idVtaSelect;
        private System.Windows.Forms.ComboBox userSelect;
        private Bunifu.UI.WinForms.BunifuCheckBox verXUsuarioCheckBox;
        private Bunifu.UI.WinForms.BunifuCheckBox verXClienteCheckBox;
        private Bunifu.UI.WinForms.BunifuCheckBox verXFechaCheckBox;
        private Bunifu.UI.WinForms.BunifuCheckBox verXIDVtaCheckBox;
        private Bunifu.UI.WinForms.BunifuPictureBox btnImprimir;
    }
}