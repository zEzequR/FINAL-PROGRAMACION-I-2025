namespace FINAL_PROGRAMACIÓN_I
{
    partial class frmLogin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.winBg = new Bunifu.UI.WinForms.BunifuGradientPanel();
            this.bunifuSeparator3 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.passwrdHid = new Bunifu.UI.WinForms.BunifuToggleSwitch2();
            this.bunifuSeparator2 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.bunifuSeparator1 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.userInp = new Bunifu.UI.WinForms.BunifuTextBox();
            this.loginBtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.passwrdInp = new Bunifu.UI.WinForms.BunifuTextBox();
            this.passwrdTxt = new Bunifu.UI.WinForms.BunifuLabel();
            this.passwrdImg = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.userImg = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.userTxt = new Bunifu.UI.WinForms.BunifuLabel();
            this.wlcTxt = new Bunifu.UI.WinForms.BunifuLabel();
            this.winCtrlBoxDiv = new Bunifu.UI.WinForms.BunifuPanel();
            this.separator = new Bunifu.UI.WinForms.BunifuSeparator();
            this.WinCtrlBoxMin = new Bunifu.UI.WinForms.BunifuImageButton();
            this.WinCtrlBoxClose = new Bunifu.UI.WinForms.BunifuImageButton();
            this.WinCtrlBoxTxt = new Bunifu.UI.WinForms.BunifuLabel();
            this.WinCtrlBoxImg = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.ctrlBoxIndicator = new Bunifu.UI.WinForms.BunifuFormDrag();
            this.bunifuFormDock1 = new Bunifu.UI.WinForms.BunifuFormDock();
            this.winBg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passwrdImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userImg)).BeginInit();
            this.winCtrlBoxDiv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WinCtrlBoxImg)).BeginInit();
            this.SuspendLayout();
            // 
            // winBg
            // 
            this.winBg.BackColor = System.Drawing.Color.Transparent;
            this.winBg.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("winBg.BackgroundImage")));
            this.winBg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.winBg.BorderRadius = 10;
            this.winBg.Controls.Add(this.bunifuSeparator3);
            this.winBg.Controls.Add(this.passwrdHid);
            this.winBg.Controls.Add(this.bunifuSeparator2);
            this.winBg.Controls.Add(this.bunifuSeparator1);
            this.winBg.Controls.Add(this.userInp);
            this.winBg.Controls.Add(this.loginBtn);
            this.winBg.Controls.Add(this.passwrdInp);
            this.winBg.Controls.Add(this.passwrdTxt);
            this.winBg.Controls.Add(this.passwrdImg);
            this.winBg.Controls.Add(this.userImg);
            this.winBg.Controls.Add(this.userTxt);
            this.winBg.Controls.Add(this.wlcTxt);
            this.winBg.Controls.Add(this.winCtrlBoxDiv);
            this.winBg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.winBg.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.winBg.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.winBg.GradientTopLeft = System.Drawing.SystemColors.Desktop;
            this.winBg.GradientTopRight = System.Drawing.SystemColors.Desktop;
            this.winBg.Location = new System.Drawing.Point(0, 0);
            this.winBg.Name = "winBg";
            this.winBg.Quality = 10;
            this.winBg.Size = new System.Drawing.Size(509, 596);
            this.winBg.TabIndex = 1;
            // 
            // bunifuSeparator3
            // 
            this.bunifuSeparator3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuSeparator3.BackgroundImage")));
            this.bunifuSeparator3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuSeparator3.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
            this.bunifuSeparator3.LineColor = System.Drawing.Color.White;
            this.bunifuSeparator3.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.DoubleEdgeFaded;
            this.bunifuSeparator3.LineThickness = 1;
            this.bunifuSeparator3.Location = new System.Drawing.Point(37, 154);
            this.bunifuSeparator3.Name = "bunifuSeparator3";
            this.bunifuSeparator3.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.bunifuSeparator3.Size = new System.Drawing.Size(427, 10);
            this.bunifuSeparator3.TabIndex = 17;
            // 
            // passwrdHid
            // 
            this.passwrdHid.BackColor = System.Drawing.Color.Transparent;
            this.passwrdHid.Checked = false;
            this.passwrdHid.CheckedBackColor = System.Drawing.Color.Navy;
            this.passwrdHid.CheckedSwitchColor = System.Drawing.Color.White;
            this.passwrdHid.CheckedSwitchStyle = Bunifu.UI.WinForms.BunifuToggleSwitch2.SwitchStyles.Fill;
            this.passwrdHid.Location = new System.Drawing.Point(441, 401);
            this.passwrdHid.Name = "passwrdHid";
            this.passwrdHid.OutlineThickness = 2;
            this.passwrdHid.Size = new System.Drawing.Size(45, 24);
            this.passwrdHid.TabIndex = 16;
            this.passwrdHid.UncheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.passwrdHid.UncheckedSwitchColor = System.Drawing.Color.White;
            this.passwrdHid.UncheckedSwitchStyle = Bunifu.UI.WinForms.BunifuToggleSwitch2.SwitchStyles.Fill;
            this.passwrdHid.CheckedChanged += new System.EventHandler(this.passwrdHid_CheckedChanged);
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuSeparator2.BackgroundImage")));
            this.bunifuSeparator2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuSeparator2.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.White;
            this.bunifuSeparator2.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.DoubleEdgeFaded;
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(163, 383);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.bunifuSeparator2.Size = new System.Drawing.Size(294, 10);
            this.bunifuSeparator2.TabIndex = 15;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuSeparator1.BackgroundImage")));
            this.bunifuSeparator1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuSeparator1.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.White;
            this.bunifuSeparator1.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.DoubleEdgeFaded;
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(155, 230);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.bunifuSeparator1.Size = new System.Drawing.Size(294, 10);
            this.bunifuSeparator1.TabIndex = 5;
            // 
            // userInp
            // 
            this.userInp.AcceptsReturn = false;
            this.userInp.AcceptsTab = true;
            this.userInp.AnimationSpeed = 200;
            this.userInp.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.userInp.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.userInp.AutoSizeHeight = true;
            this.userInp.BackColor = System.Drawing.Color.Transparent;
            this.userInp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("userInp.BackgroundImage")));
            this.userInp.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.userInp.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.userInp.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.userInp.BorderColorIdle = System.Drawing.Color.Silver;
            this.userInp.BorderRadius = 20;
            this.userInp.BorderThickness = 1;
            this.userInp.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            this.userInp.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.userInp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.userInp.DefaultFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userInp.DefaultText = "";
            this.userInp.FillColor = System.Drawing.Color.White;
            this.userInp.HideSelection = true;
            this.userInp.IconLeft = null;
            this.userInp.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.userInp.IconPadding = 10;
            this.userInp.IconRight = null;
            this.userInp.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.userInp.Lines = new string[0];
            this.userInp.Location = new System.Drawing.Point(174, 243);
            this.userInp.MaxLength = 32767;
            this.userInp.MinimumSize = new System.Drawing.Size(1, 1);
            this.userInp.Modified = false;
            this.userInp.Multiline = false;
            this.userInp.Name = "userInp";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.userInp.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.userInp.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.userInp.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.userInp.OnIdleState = stateProperties4;
            this.userInp.Padding = new System.Windows.Forms.Padding(3);
            this.userInp.PasswordChar = '\0';
            this.userInp.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.userInp.PlaceholderText = "";
            this.userInp.ReadOnly = false;
            this.userInp.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.userInp.SelectedText = "";
            this.userInp.SelectionLength = 0;
            this.userInp.SelectionStart = 0;
            this.userInp.ShortcutsEnabled = true;
            this.userInp.Size = new System.Drawing.Size(264, 38);
            this.userInp.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.userInp.TabIndex = 14;
            this.userInp.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.userInp.TextMarginBottom = 0;
            this.userInp.TextMarginLeft = 3;
            this.userInp.TextMarginTop = 1;
            this.userInp.TextPlaceholder = "";
            this.userInp.UseSystemPasswordChar = false;
            this.userInp.WordWrap = true;
            // 
            // loginBtn
            // 
            this.loginBtn.AllowAnimations = true;
            this.loginBtn.AllowMouseEffects = true;
            this.loginBtn.AllowToggling = false;
            this.loginBtn.AnimationSpeed = 200;
            this.loginBtn.AutoGenerateColors = false;
            this.loginBtn.AutoRoundBorders = true;
            this.loginBtn.AutoSizeLeftIcon = true;
            this.loginBtn.AutoSizeRightIcon = true;
            this.loginBtn.BackColor = System.Drawing.Color.Transparent;
            this.loginBtn.BackColor1 = System.Drawing.Color.Navy;
            this.loginBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("loginBtn.BackgroundImage")));
            this.loginBtn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.loginBtn.ButtonText = "Iniciar sesión";
            this.loginBtn.ButtonTextMarginLeft = 0;
            this.loginBtn.ColorContrastOnClick = 45;
            this.loginBtn.ColorContrastOnHover = 45;
            this.loginBtn.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.loginBtn.CustomizableEdges = borderEdges1;
            this.loginBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.loginBtn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.loginBtn.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.loginBtn.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.loginBtn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.loginBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.ForeColor = System.Drawing.Color.White;
            this.loginBtn.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.loginBtn.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.loginBtn.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.loginBtn.IconMarginLeft = 11;
            this.loginBtn.IconPadding = 10;
            this.loginBtn.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.loginBtn.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.loginBtn.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.loginBtn.IconSize = 25;
            this.loginBtn.IdleBorderColor = System.Drawing.Color.Azure;
            this.loginBtn.IdleBorderRadius = 39;
            this.loginBtn.IdleBorderThickness = 1;
            this.loginBtn.IdleFillColor = System.Drawing.Color.Navy;
            this.loginBtn.IdleIconLeftImage = null;
            this.loginBtn.IdleIconRightImage = null;
            this.loginBtn.IndicateFocus = false;
            this.loginBtn.Location = new System.Drawing.Point(112, 476);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.loginBtn.OnDisabledState.BorderRadius = 60;
            this.loginBtn.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.loginBtn.OnDisabledState.BorderThickness = 1;
            this.loginBtn.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.loginBtn.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.loginBtn.OnDisabledState.IconLeftImage = null;
            this.loginBtn.OnDisabledState.IconRightImage = null;
            this.loginBtn.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.loginBtn.onHoverState.BorderRadius = 60;
            this.loginBtn.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.loginBtn.onHoverState.BorderThickness = 1;
            this.loginBtn.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.loginBtn.onHoverState.ForeColor = System.Drawing.Color.White;
            this.loginBtn.onHoverState.IconLeftImage = null;
            this.loginBtn.onHoverState.IconRightImage = null;
            this.loginBtn.OnIdleState.BorderColor = System.Drawing.Color.Azure;
            this.loginBtn.OnIdleState.BorderRadius = 60;
            this.loginBtn.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.loginBtn.OnIdleState.BorderThickness = 1;
            this.loginBtn.OnIdleState.FillColor = System.Drawing.Color.Navy;
            this.loginBtn.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.loginBtn.OnIdleState.IconLeftImage = null;
            this.loginBtn.OnIdleState.IconRightImage = null;
            this.loginBtn.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.loginBtn.OnPressedState.BorderRadius = 60;
            this.loginBtn.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.loginBtn.OnPressedState.BorderThickness = 1;
            this.loginBtn.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.loginBtn.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.loginBtn.OnPressedState.IconLeftImage = null;
            this.loginBtn.OnPressedState.IconRightImage = null;
            this.loginBtn.Size = new System.Drawing.Size(272, 41);
            this.loginBtn.TabIndex = 12;
            this.loginBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.loginBtn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.loginBtn.TextMarginLeft = 0;
            this.loginBtn.TextPadding = new System.Windows.Forms.Padding(0);
            this.loginBtn.UseDefaultRadiusAndThickness = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // passwrdInp
            // 
            this.passwrdInp.AcceptsReturn = false;
            this.passwrdInp.AcceptsTab = true;
            this.passwrdInp.AnimationSpeed = 200;
            this.passwrdInp.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.passwrdInp.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.passwrdInp.AutoSizeHeight = true;
            this.passwrdInp.BackColor = System.Drawing.Color.Transparent;
            this.passwrdInp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("passwrdInp.BackgroundImage")));
            this.passwrdInp.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.passwrdInp.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.passwrdInp.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.passwrdInp.BorderColorIdle = System.Drawing.Color.Silver;
            this.passwrdInp.BorderRadius = 20;
            this.passwrdInp.BorderThickness = 1;
            this.passwrdInp.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            this.passwrdInp.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.passwrdInp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwrdInp.DefaultFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwrdInp.DefaultText = "";
            this.passwrdInp.FillColor = System.Drawing.Color.White;
            this.passwrdInp.HideSelection = true;
            this.passwrdInp.IconLeft = null;
            this.passwrdInp.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.passwrdInp.IconPadding = 10;
            this.passwrdInp.IconRight = null;
            this.passwrdInp.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.passwrdInp.Lines = new string[0];
            this.passwrdInp.Location = new System.Drawing.Point(171, 395);
            this.passwrdInp.MaxLength = 32767;
            this.passwrdInp.MinimumSize = new System.Drawing.Size(1, 1);
            this.passwrdInp.Modified = false;
            this.passwrdInp.Multiline = false;
            this.passwrdInp.Name = "passwrdInp";
            stateProperties5.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.passwrdInp.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.passwrdInp.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.passwrdInp.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Silver;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.passwrdInp.OnIdleState = stateProperties8;
            this.passwrdInp.Padding = new System.Windows.Forms.Padding(3);
            this.passwrdInp.PasswordChar = '●';
            this.passwrdInp.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.passwrdInp.PlaceholderText = "";
            this.passwrdInp.ReadOnly = false;
            this.passwrdInp.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.passwrdInp.SelectedText = "";
            this.passwrdInp.SelectionLength = 0;
            this.passwrdInp.SelectionStart = 0;
            this.passwrdInp.ShortcutsEnabled = true;
            this.passwrdInp.Size = new System.Drawing.Size(264, 38);
            this.passwrdInp.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.passwrdInp.TabIndex = 11;
            this.passwrdInp.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.passwrdInp.TextMarginBottom = 0;
            this.passwrdInp.TextMarginLeft = 3;
            this.passwrdInp.TextMarginTop = 1;
            this.passwrdInp.TextPlaceholder = "";
            this.passwrdInp.UseSystemPasswordChar = false;
            this.passwrdInp.WordWrap = true;
            // 
            // passwrdTxt
            // 
            this.passwrdTxt.AllowParentOverrides = false;
            this.passwrdTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwrdTxt.AutoEllipsis = false;
            this.passwrdTxt.Cursor = System.Windows.Forms.Cursors.Default;
            this.passwrdTxt.CursorType = System.Windows.Forms.Cursors.Default;
            this.passwrdTxt.Font = new System.Drawing.Font("Century Gothic", 17F);
            this.passwrdTxt.ForeColor = System.Drawing.Color.White;
            this.passwrdTxt.Location = new System.Drawing.Point(184, 355);
            this.passwrdTxt.Name = "passwrdTxt";
            this.passwrdTxt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.passwrdTxt.Size = new System.Drawing.Size(245, 27);
            this.passwrdTxt.TabIndex = 10;
            this.passwrdTxt.Text = "Ingrese su contraseña";
            this.passwrdTxt.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.passwrdTxt.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // passwrdImg
            // 
            this.passwrdImg.AllowFocused = false;
            this.passwrdImg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwrdImg.AutoSizeHeight = true;
            this.passwrdImg.BorderRadius = 0;
            this.passwrdImg.Image = ((System.Drawing.Image)(resources.GetObject("passwrdImg.Image")));
            this.passwrdImg.IsCircle = false;
            this.passwrdImg.Location = new System.Drawing.Point(38, 331);
            this.passwrdImg.Name = "passwrdImg";
            this.passwrdImg.Size = new System.Drawing.Size(127, 127);
            this.passwrdImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.passwrdImg.TabIndex = 9;
            this.passwrdImg.TabStop = false;
            this.passwrdImg.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            // 
            // userImg
            // 
            this.userImg.AllowFocused = false;
            this.userImg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.userImg.AutoSizeHeight = true;
            this.userImg.BorderRadius = 0;
            this.userImg.Image = ((System.Drawing.Image)(resources.GetObject("userImg.Image")));
            this.userImg.IsCircle = false;
            this.userImg.Location = new System.Drawing.Point(38, 181);
            this.userImg.Name = "userImg";
            this.userImg.Size = new System.Drawing.Size(127, 127);
            this.userImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userImg.TabIndex = 5;
            this.userImg.TabStop = false;
            this.userImg.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            // 
            // userTxt
            // 
            this.userTxt.AllowParentOverrides = false;
            this.userTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.userTxt.AutoEllipsis = false;
            this.userTxt.Cursor = System.Windows.Forms.Cursors.Default;
            this.userTxt.CursorType = System.Windows.Forms.Cursors.Default;
            this.userTxt.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.userTxt.ForeColor = System.Drawing.Color.White;
            this.userTxt.Location = new System.Drawing.Point(196, 201);
            this.userTxt.Name = "userTxt";
            this.userTxt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.userTxt.Size = new System.Drawing.Size(210, 30);
            this.userTxt.TabIndex = 6;
            this.userTxt.Text = "Ingrese su usuario";
            this.userTxt.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.userTxt.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // wlcTxt
            // 
            this.wlcTxt.AllowParentOverrides = false;
            this.wlcTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.wlcTxt.AutoEllipsis = false;
            this.wlcTxt.Cursor = System.Windows.Forms.Cursors.Default;
            this.wlcTxt.CursorType = System.Windows.Forms.Cursors.Default;
            this.wlcTxt.Font = new System.Drawing.Font("Century Gothic", 28F);
            this.wlcTxt.ForeColor = System.Drawing.Color.White;
            this.wlcTxt.Location = new System.Drawing.Point(38, 112);
            this.wlcTxt.Name = "wlcTxt";
            this.wlcTxt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.wlcTxt.Size = new System.Drawing.Size(424, 44);
            this.wlcTxt.TabIndex = 5;
            this.wlcTxt.Text = "Bienvenido/a devuelta!";
            this.wlcTxt.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.wlcTxt.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
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
            this.winCtrlBoxDiv.Controls.Add(this.WinCtrlBoxMin);
            this.winCtrlBoxDiv.Controls.Add(this.WinCtrlBoxClose);
            this.winCtrlBoxDiv.Controls.Add(this.WinCtrlBoxTxt);
            this.winCtrlBoxDiv.Controls.Add(this.WinCtrlBoxImg);
            this.winCtrlBoxDiv.Dock = System.Windows.Forms.DockStyle.Top;
            this.winCtrlBoxDiv.Location = new System.Drawing.Point(0, 0);
            this.winCtrlBoxDiv.Name = "winCtrlBoxDiv";
            this.winCtrlBoxDiv.ShowBorders = true;
            this.winCtrlBoxDiv.Size = new System.Drawing.Size(509, 66);
            this.winCtrlBoxDiv.TabIndex = 0;
            // 
            // separator
            // 
            this.separator.BackColor = System.Drawing.Color.Transparent;
            this.separator.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("separator.BackgroundImage")));
            this.separator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.separator.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
            this.separator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.separator.LineColor = System.Drawing.Color.White;
            this.separator.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.DoubleEdgeFaded;
            this.separator.LineThickness = 1;
            this.separator.Location = new System.Drawing.Point(0, 52);
            this.separator.Name = "separator";
            this.separator.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.separator.Size = new System.Drawing.Size(509, 14);
            this.separator.TabIndex = 1;
            // 
            // WinCtrlBoxMin
            // 
            this.WinCtrlBoxMin.ActiveImage = null;
            this.WinCtrlBoxMin.AllowAnimations = true;
            this.WinCtrlBoxMin.AllowBuffering = false;
            this.WinCtrlBoxMin.AllowToggling = false;
            this.WinCtrlBoxMin.AllowZooming = false;
            this.WinCtrlBoxMin.AllowZoomingOnFocus = false;
            this.WinCtrlBoxMin.BackColor = System.Drawing.Color.Transparent;
            this.WinCtrlBoxMin.DialogResult = System.Windows.Forms.DialogResult.None;
            this.WinCtrlBoxMin.ErrorImage = ((System.Drawing.Image)(resources.GetObject("WinCtrlBoxMin.ErrorImage")));
            this.WinCtrlBoxMin.FadeWhenInactive = false;
            this.WinCtrlBoxMin.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.WinCtrlBoxMin.Image = ((System.Drawing.Image)(resources.GetObject("WinCtrlBoxMin.Image")));
            this.WinCtrlBoxMin.ImageActive = null;
            this.WinCtrlBoxMin.ImageLocation = null;
            this.WinCtrlBoxMin.ImageMargin = 20;
            this.WinCtrlBoxMin.ImageSize = new System.Drawing.Size(37, 36);
            this.WinCtrlBoxMin.ImageZoomSize = new System.Drawing.Size(57, 56);
            this.WinCtrlBoxMin.InitialImage = ((System.Drawing.Image)(resources.GetObject("WinCtrlBoxMin.InitialImage")));
            this.WinCtrlBoxMin.Location = new System.Drawing.Point(400, 0);
            this.WinCtrlBoxMin.Name = "WinCtrlBoxMin";
            this.WinCtrlBoxMin.Rotation = 0;
            this.WinCtrlBoxMin.ShowActiveImage = true;
            this.WinCtrlBoxMin.ShowCursorChanges = true;
            this.WinCtrlBoxMin.ShowImageBorders = true;
            this.WinCtrlBoxMin.ShowSizeMarkers = false;
            this.WinCtrlBoxMin.Size = new System.Drawing.Size(57, 56);
            this.WinCtrlBoxMin.TabIndex = 4;
            this.WinCtrlBoxMin.ToolTipText = "";
            this.WinCtrlBoxMin.WaitOnLoad = false;
            this.WinCtrlBoxMin.Zoom = 20;
            this.WinCtrlBoxMin.ZoomSpeed = 10;
            this.WinCtrlBoxMin.Click += new System.EventHandler(this.WinCtrlBoxMin_Click);
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
            this.WinCtrlBoxClose.Location = new System.Drawing.Point(452, 0);
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
            this.WinCtrlBoxTxt.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.WinCtrlBoxTxt.ForeColor = System.Drawing.Color.White;
            this.WinCtrlBoxTxt.Location = new System.Drawing.Point(63, 21);
            this.WinCtrlBoxTxt.Name = "WinCtrlBoxTxt";
            this.WinCtrlBoxTxt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.WinCtrlBoxTxt.Size = new System.Drawing.Size(250, 22);
            this.WinCtrlBoxTxt.TabIndex = 2;
            this.WinCtrlBoxTxt.Text = "Final Programación I - Login";
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
            this.WinCtrlBoxImg.Location = new System.Drawing.Point(10, 6);
            this.WinCtrlBoxImg.Name = "WinCtrlBoxImg";
            this.WinCtrlBoxImg.Size = new System.Drawing.Size(48, 48);
            this.WinCtrlBoxImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.WinCtrlBoxImg.TabIndex = 0;
            this.WinCtrlBoxImg.TabStop = false;
            this.WinCtrlBoxImg.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            // 
            // ctrlBoxIndicator
            // 
            this.ctrlBoxIndicator.AllowOpacityChangesWhileDragging = true;
            this.ctrlBoxIndicator.ContainerControl = this;
            this.ctrlBoxIndicator.DockIndicatorsOpacity = 0.5D;
            this.ctrlBoxIndicator.DockingIndicatorsColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(215)))), ((int)(((byte)(233)))));
            this.ctrlBoxIndicator.DockingOptions.DockAll = true;
            this.ctrlBoxIndicator.DockingOptions.DockBottomLeft = true;
            this.ctrlBoxIndicator.DockingOptions.DockBottomRight = true;
            this.ctrlBoxIndicator.DockingOptions.DockFullScreen = true;
            this.ctrlBoxIndicator.DockingOptions.DockLeft = true;
            this.ctrlBoxIndicator.DockingOptions.DockRight = true;
            this.ctrlBoxIndicator.DockingOptions.DockTopLeft = true;
            this.ctrlBoxIndicator.DockingOptions.DockTopRight = true;
            this.ctrlBoxIndicator.DragOpacity = 0.9D;
            this.ctrlBoxIndicator.Enabled = true;
            this.ctrlBoxIndicator.ParentForm = this;
            this.ctrlBoxIndicator.ShowCursorChanges = true;
            this.ctrlBoxIndicator.ShowDockingIndicators = true;
            this.ctrlBoxIndicator.TitleBarOptions.BunifuFormDrag = this.ctrlBoxIndicator;
            this.ctrlBoxIndicator.TitleBarOptions.DoubleClickToExpandWindow = false;
            this.ctrlBoxIndicator.TitleBarOptions.Enabled = true;
            this.ctrlBoxIndicator.TitleBarOptions.TitleBarControl = this.winCtrlBoxDiv;
            this.ctrlBoxIndicator.TitleBarOptions.UseBackColorOnDockingIndicators = false;
            // 
            // bunifuFormDock1
            // 
            this.bunifuFormDock1.AllowFormDragging = true;
            this.bunifuFormDock1.AllowFormDropShadow = true;
            this.bunifuFormDock1.AllowFormResizing = true;
            this.bunifuFormDock1.AllowHidingBottomRegion = true;
            this.bunifuFormDock1.AllowOpacityChangesWhileDragging = false;
            this.bunifuFormDock1.BorderOptions.BottomBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDock1.BorderOptions.BottomBorder.BorderThickness = 1;
            this.bunifuFormDock1.BorderOptions.BottomBorder.ShowBorder = true;
            this.bunifuFormDock1.BorderOptions.LeftBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDock1.BorderOptions.LeftBorder.BorderThickness = 1;
            this.bunifuFormDock1.BorderOptions.LeftBorder.ShowBorder = true;
            this.bunifuFormDock1.BorderOptions.RightBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDock1.BorderOptions.RightBorder.BorderThickness = 1;
            this.bunifuFormDock1.BorderOptions.RightBorder.ShowBorder = true;
            this.bunifuFormDock1.BorderOptions.TopBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDock1.BorderOptions.TopBorder.BorderThickness = 1;
            this.bunifuFormDock1.BorderOptions.TopBorder.ShowBorder = true;
            this.bunifuFormDock1.ContainerControl = this;
            this.bunifuFormDock1.DockingIndicatorsColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(215)))), ((int)(((byte)(233)))));
            this.bunifuFormDock1.DockingIndicatorsOpacity = 0.5D;
            this.bunifuFormDock1.DockingOptions.DockAll = true;
            this.bunifuFormDock1.DockingOptions.DockBottomLeft = true;
            this.bunifuFormDock1.DockingOptions.DockBottomRight = true;
            this.bunifuFormDock1.DockingOptions.DockFullScreen = true;
            this.bunifuFormDock1.DockingOptions.DockLeft = true;
            this.bunifuFormDock1.DockingOptions.DockRight = true;
            this.bunifuFormDock1.DockingOptions.DockTopLeft = true;
            this.bunifuFormDock1.DockingOptions.DockTopRight = true;
            this.bunifuFormDock1.FormDraggingOpacity = 0.9D;
            this.bunifuFormDock1.ParentForm = this;
            this.bunifuFormDock1.ShowCursorChanges = true;
            this.bunifuFormDock1.ShowDockingIndicators = true;
            this.bunifuFormDock1.TitleBarOptions.AllowFormDragging = true;
            this.bunifuFormDock1.TitleBarOptions.BunifuFormDock = this.bunifuFormDock1;
            this.bunifuFormDock1.TitleBarOptions.DoubleClickToExpandWindow = true;
            this.bunifuFormDock1.TitleBarOptions.TitleBarControl = null;
            this.bunifuFormDock1.TitleBarOptions.UseBackColorOnDockingIndicators = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 596);
            this.Controls.Add(this.winBg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Final Programación I - Login";
            this.winBg.ResumeLayout(false);
            this.winBg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passwrdImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userImg)).EndInit();
            this.winCtrlBoxDiv.ResumeLayout(false);
            this.winCtrlBoxDiv.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WinCtrlBoxImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.UI.WinForms.BunifuGradientPanel winBg;
        private Bunifu.UI.WinForms.BunifuPanel winCtrlBoxDiv;
        private Bunifu.UI.WinForms.BunifuPictureBox WinCtrlBoxImg;
        private Bunifu.UI.WinForms.BunifuLabel WinCtrlBoxTxt;
        private Bunifu.UI.WinForms.BunifuImageButton WinCtrlBoxClose;
        private Bunifu.UI.WinForms.BunifuImageButton WinCtrlBoxMin;
        private Bunifu.UI.WinForms.BunifuFormDrag ctrlBoxIndicator;
        private Bunifu.UI.WinForms.BunifuFormDock bunifuFormDock1;
        private Bunifu.UI.WinForms.BunifuSeparator separator;
        private Bunifu.UI.WinForms.BunifuLabel wlcTxt;
        private Bunifu.UI.WinForms.BunifuLabel userTxt;
        private Bunifu.UI.WinForms.BunifuPictureBox userImg;
        private Bunifu.UI.WinForms.BunifuTextBox passwrdInp;
        private Bunifu.UI.WinForms.BunifuLabel passwrdTxt;
        private Bunifu.UI.WinForms.BunifuPictureBox passwrdImg;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 loginBtn;
        private Bunifu.UI.WinForms.BunifuTextBox userInp;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator1;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator2;
        private Bunifu.UI.WinForms.BunifuToggleSwitch2 passwrdHid;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator3;
    }
}

