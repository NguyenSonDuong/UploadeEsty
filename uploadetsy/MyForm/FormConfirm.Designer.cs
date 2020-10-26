using System;

namespace uploadetsy.MyForm
{
    partial class FormConfirm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConfirm));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.btnYes = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnNo = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.lblConten = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblTitle = new Bunifu.UI.WinForms.BunifuLabel();
            this.pcbError = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pcbError)).BeginInit();
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
            this.bunifuDragControl1.TargetControl = null;
            this.bunifuDragControl1.Vertical = true;
            // 
            // btnYes
            // 
            this.btnYes.AllowToggling = false;
            this.btnYes.AnimationSpeed = 200;
            this.btnYes.AutoGenerateColors = false;
            this.btnYes.BackColor = System.Drawing.Color.Transparent;
            this.btnYes.BackColor1 = System.Drawing.Color.White;
            this.btnYes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnYes.BackgroundImage")));
            this.btnYes.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnYes.ButtonText = "Yes";
            this.btnYes.ButtonTextMarginLeft = 0;
            this.btnYes.ColorContrastOnClick = 45;
            this.btnYes.ColorContrastOnHover = 45;
            this.btnYes.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnYes.CustomizableEdges = borderEdges1;
            this.btnYes.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnYes.DisabledBorderColor = System.Drawing.Color.Empty;
            this.btnYes.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnYes.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnYes.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnYes.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.btnYes.ForeColor = System.Drawing.Color.Black;
            this.btnYes.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btnYes.IconMarginLeft = 11;
            this.btnYes.IconPadding = 10;
            this.btnYes.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btnYes.IdleBorderColor = System.Drawing.Color.DarkGreen;
            this.btnYes.IdleBorderRadius = 10;
            this.btnYes.IdleBorderThickness = 2;
            this.btnYes.IdleFillColor = System.Drawing.Color.White;
            this.btnYes.IdleIconLeftImage = null;
            this.btnYes.IdleIconRightImage = null;
            this.btnYes.IndicateFocus = false;
            this.btnYes.Location = new System.Drawing.Point(213, 186);
            this.btnYes.Name = "btnYes";
            this.btnYes.onHoverState.BorderColor = System.Drawing.Color.DarkGreen;
            this.btnYes.onHoverState.BorderRadius = 10;
            this.btnYes.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnYes.onHoverState.BorderThickness = 2;
            this.btnYes.onHoverState.FillColor = System.Drawing.Color.DarkGreen;
            this.btnYes.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnYes.onHoverState.IconLeftImage = null;
            this.btnYes.onHoverState.IconRightImage = null;
            this.btnYes.OnIdleState.BorderColor = System.Drawing.Color.DarkGreen;
            this.btnYes.OnIdleState.BorderRadius = 10;
            this.btnYes.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnYes.OnIdleState.BorderThickness = 2;
            this.btnYes.OnIdleState.FillColor = System.Drawing.Color.White;
            this.btnYes.OnIdleState.ForeColor = System.Drawing.Color.Black;
            this.btnYes.OnIdleState.IconLeftImage = null;
            this.btnYes.OnIdleState.IconRightImage = null;
            this.btnYes.OnPressedState.BorderColor = System.Drawing.Color.Green;
            this.btnYes.OnPressedState.BorderRadius = 10;
            this.btnYes.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnYes.OnPressedState.BorderThickness = 2;
            this.btnYes.OnPressedState.FillColor = System.Drawing.Color.Green;
            this.btnYes.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnYes.OnPressedState.IconLeftImage = null;
            this.btnYes.OnPressedState.IconRightImage = null;
            this.btnYes.Size = new System.Drawing.Size(103, 31);
            this.btnYes.TabIndex = 16;
            this.btnYes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnYes.TextMarginLeft = 0;
            this.btnYes.UseDefaultRadiusAndThickness = true;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // btnNo
            // 
            this.btnNo.AllowToggling = false;
            this.btnNo.AnimationSpeed = 200;
            this.btnNo.AutoGenerateColors = false;
            this.btnNo.BackColor = System.Drawing.Color.Transparent;
            this.btnNo.BackColor1 = System.Drawing.Color.White;
            this.btnNo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNo.BackgroundImage")));
            this.btnNo.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnNo.ButtonText = "No";
            this.btnNo.ButtonTextMarginLeft = 0;
            this.btnNo.ColorContrastOnClick = 45;
            this.btnNo.ColorContrastOnHover = 45;
            this.btnNo.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnNo.CustomizableEdges = borderEdges2;
            this.btnNo.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnNo.DisabledBorderColor = System.Drawing.Color.Empty;
            this.btnNo.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnNo.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnNo.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnNo.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.btnNo.ForeColor = System.Drawing.Color.Black;
            this.btnNo.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btnNo.IconMarginLeft = 11;
            this.btnNo.IconPadding = 10;
            this.btnNo.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btnNo.IdleBorderColor = System.Drawing.Color.Firebrick;
            this.btnNo.IdleBorderRadius = 10;
            this.btnNo.IdleBorderThickness = 2;
            this.btnNo.IdleFillColor = System.Drawing.Color.White;
            this.btnNo.IdleIconLeftImage = null;
            this.btnNo.IdleIconRightImage = null;
            this.btnNo.IndicateFocus = false;
            this.btnNo.Location = new System.Drawing.Point(104, 186);
            this.btnNo.Name = "btnNo";
            this.btnNo.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnNo.onHoverState.BorderRadius = 10;
            this.btnNo.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnNo.onHoverState.BorderThickness = 2;
            this.btnNo.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnNo.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnNo.onHoverState.IconLeftImage = null;
            this.btnNo.onHoverState.IconRightImage = null;
            this.btnNo.OnIdleState.BorderColor = System.Drawing.Color.Firebrick;
            this.btnNo.OnIdleState.BorderRadius = 10;
            this.btnNo.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnNo.OnIdleState.BorderThickness = 2;
            this.btnNo.OnIdleState.FillColor = System.Drawing.Color.White;
            this.btnNo.OnIdleState.ForeColor = System.Drawing.Color.Black;
            this.btnNo.OnIdleState.IconLeftImage = null;
            this.btnNo.OnIdleState.IconRightImage = null;
            this.btnNo.OnPressedState.BorderColor = System.Drawing.Color.Maroon;
            this.btnNo.OnPressedState.BorderRadius = 10;
            this.btnNo.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnNo.OnPressedState.BorderThickness = 2;
            this.btnNo.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnNo.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnNo.OnPressedState.IconLeftImage = null;
            this.btnNo.OnPressedState.IconRightImage = null;
            this.btnNo.Size = new System.Drawing.Size(103, 31);
            this.btnNo.TabIndex = 17;
            this.btnNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNo.TextMarginLeft = 0;
            this.btnNo.UseDefaultRadiusAndThickness = true;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // lblConten
            // 
            this.lblConten.AutoEllipsis = false;
            this.lblConten.AutoSize = false;
            this.lblConten.CursorType = null;
            this.lblConten.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.lblConten.Location = new System.Drawing.Point(14, 155);
            this.lblConten.Name = "lblConten";
            this.lblConten.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblConten.Size = new System.Drawing.Size(392, 25);
            this.lblConten.TabIndex = 14;
            this.lblConten.Text = "bunifuLabel1";
            this.lblConten.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblConten.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoEllipsis = false;
            this.lblTitle.AutoSize = false;
            this.lblTitle.CursorType = null;
            this.lblTitle.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(14, 108);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTitle.Size = new System.Drawing.Size(392, 31);
            this.lblTitle.TabIndex = 15;
            this.lblTitle.Text = "Great!";
            this.lblTitle.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // pcbError
            // 
            this.pcbError.Image = ((System.Drawing.Image)(resources.GetObject("pcbError.Image")));
            this.pcbError.Location = new System.Drawing.Point(192, 43);
            this.pcbError.Name = "pcbError";
            this.pcbError.Size = new System.Drawing.Size(48, 48);
            this.pcbError.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbError.TabIndex = 13;
            this.pcbError.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(414, 26);
            this.panel1.TabIndex = 18;
            // 
            // FormConfirm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(414, 240);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.lblConten);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pcbError);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormConfirm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormConfirm";
            ((System.ComponentModel.ISupportInitialize)(this.pcbError)).EndInit();
            this.ResumeLayout(false);

        }

      

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnYes;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnNo;
        private Bunifu.UI.WinForms.BunifuLabel lblConten;
        private Bunifu.UI.WinForms.BunifuLabel lblTitle;
        private System.Windows.Forms.PictureBox pcbError;
        private System.Windows.Forms.Panel panel1;
    }
}