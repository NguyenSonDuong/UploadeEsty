namespace uploadetsy.MyForm
{
    partial class FormMess
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMess));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panelAleft = new System.Windows.Forms.Panel();
            this.pcbError = new System.Windows.Forms.PictureBox();
            this.pcbSuccess = new System.Windows.Forms.PictureBox();
            this.lblTitle = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblConten = new Bunifu.UI.WinForms.BunifuLabel();
            this.btnClose = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.panelAleft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSuccess)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // panelAleft
            // 
            this.panelAleft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(76)))), ((int)(((byte)(94)))));
            this.panelAleft.Controls.Add(this.pcbSuccess);
            this.panelAleft.Controls.Add(this.pcbError);
            this.panelAleft.Location = new System.Drawing.Point(-1, -1);
            this.panelAleft.Name = "panelAleft";
            this.panelAleft.Size = new System.Drawing.Size(418, 54);
            this.panelAleft.TabIndex = 0;
            // 
            // pcbError
            // 
            this.pcbError.Image = ((System.Drawing.Image)(resources.GetObject("pcbError.Image")));
            this.pcbError.Location = new System.Drawing.Point(195, 5);
            this.pcbError.Name = "pcbError";
            this.pcbError.Size = new System.Drawing.Size(40, 40);
            this.pcbError.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbError.TabIndex = 0;
            this.pcbError.TabStop = false;
            // 
            // pcbSuccess
            // 
            this.pcbSuccess.Image = ((System.Drawing.Image)(resources.GetObject("pcbSuccess.Image")));
            this.pcbSuccess.Location = new System.Drawing.Point(195, 5);
            this.pcbSuccess.Name = "pcbSuccess";
            this.pcbSuccess.Size = new System.Drawing.Size(40, 40);
            this.pcbSuccess.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbSuccess.TabIndex = 0;
            this.pcbSuccess.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoEllipsis = false;
            this.lblTitle.AutoSize = false;
            this.lblTitle.AutoSizeHeightOnly = true;
            this.lblTitle.CursorType = null;
            this.lblTitle.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(12, 73);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTitle.Size = new System.Drawing.Size(392, 28);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Great!a";
            this.lblTitle.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lblConten
            // 
            this.lblConten.AutoEllipsis = false;
            this.lblConten.AutoSize = false;
            this.lblConten.CursorType = null;
            this.lblConten.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.lblConten.ForeColor = System.Drawing.Color.Black;
            this.lblConten.Location = new System.Drawing.Point(12, 107);
            this.lblConten.Name = "lblConten";
            this.lblConten.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblConten.Size = new System.Drawing.Size(392, 63);
            this.lblConten.TabIndex = 2;
            this.lblConten.Text = "asdasd á  ád";
            this.lblConten.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblConten.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // btnClose
            // 
            this.btnClose.AllowToggling = false;
            this.btnClose.AnimationSpeed = 200;
            this.btnClose.AutoGenerateColors = false;
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackColor1 = System.Drawing.Color.White;
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnClose.ButtonText = "Close";
            this.btnClose.ButtonTextMarginLeft = 0;
            this.btnClose.ColorContrastOnClick = 45;
            this.btnClose.ColorContrastOnHover = 45;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnClose.CustomizableEdges = borderEdges1;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnClose.DisabledBorderColor = System.Drawing.Color.Empty;
            this.btnClose.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnClose.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnClose.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnClose.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.IconMarginLeft = 11;
            this.btnClose.IconPadding = 10;
            this.btnClose.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.IdleBorderColor = System.Drawing.Color.Maroon;
            this.btnClose.IdleBorderRadius = 30;
            this.btnClose.IdleBorderThickness = 2;
            this.btnClose.IdleFillColor = System.Drawing.Color.White;
            this.btnClose.IdleIconLeftImage = null;
            this.btnClose.IdleIconRightImage = null;
            this.btnClose.IndicateFocus = false;
            this.btnClose.Location = new System.Drawing.Point(161, 196);
            this.btnClose.Name = "btnClose";
            this.btnClose.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnClose.onHoverState.BorderRadius = 30;
            this.btnClose.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnClose.onHoverState.BorderThickness = 2;
            this.btnClose.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnClose.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnClose.onHoverState.IconLeftImage = null;
            this.btnClose.onHoverState.IconRightImage = null;
            this.btnClose.OnIdleState.BorderColor = System.Drawing.Color.Maroon;
            this.btnClose.OnIdleState.BorderRadius = 30;
            this.btnClose.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnClose.OnIdleState.BorderThickness = 2;
            this.btnClose.OnIdleState.FillColor = System.Drawing.Color.White;
            this.btnClose.OnIdleState.ForeColor = System.Drawing.Color.Black;
            this.btnClose.OnIdleState.IconLeftImage = null;
            this.btnClose.OnIdleState.IconRightImage = null;
            this.btnClose.OnPressedState.BorderColor = System.Drawing.Color.Maroon;
            this.btnClose.OnPressedState.BorderRadius = 30;
            this.btnClose.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnClose.OnPressedState.BorderThickness = 2;
            this.btnClose.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnClose.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnClose.OnPressedState.IconLeftImage = null;
            this.btnClose.OnPressedState.IconRightImage = null;
            this.btnClose.Size = new System.Drawing.Size(103, 35);
            this.btnClose.TabIndex = 3;
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClose.TextMarginLeft = 0;
            this.btnClose.UseDefaultRadiusAndThickness = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FormMess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(416, 256);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblConten);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.panelAleft);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMess";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Message";
            this.panelAleft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSuccess)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel panelAleft;
        private Bunifu.UI.WinForms.BunifuLabel lblConten;
        private Bunifu.UI.WinForms.BunifuLabel lblTitle;
        private System.Windows.Forms.PictureBox pcbSuccess;
        private System.Windows.Forms.PictureBox pcbError;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnClose;
    }
}