namespace MobileRegistrationForm
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
            this.fieldName = new System.Windows.Forms.TextBox();
            this.fieldSurname = new System.Windows.Forms.TextBox();
            this.fieldEmail = new System.Windows.Forms.TextBox();
            this.fieldPassword = new System.Windows.Forms.TextBox();
            this.fieldPasswordRepeat = new System.Windows.Forms.TextBox();
            this.fieldAge = new System.Windows.Forms.NumericUpDown();
            this.buttonSignUp = new System.Windows.Forms.Button();
            this.checkShowPassword = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.fieldAge)).BeginInit();
            this.SuspendLayout();
            // 
            // fieldName
            // 
            this.fieldName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fieldName.Location = new System.Drawing.Point(12, 12);
            this.fieldName.Name = "fieldName";
            this.fieldName.Size = new System.Drawing.Size(369, 29);
            this.fieldName.TabIndex = 0;
            this.fieldName.Text = "Name";
            this.fieldName.Enter += new System.EventHandler(this.Field_Enter);
            this.fieldName.Leave += new System.EventHandler(this.Field_Leave);
            // 
            // fieldSurname
            // 
            this.fieldSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fieldSurname.Location = new System.Drawing.Point(11, 47);
            this.fieldSurname.Name = "fieldSurname";
            this.fieldSurname.Size = new System.Drawing.Size(369, 29);
            this.fieldSurname.TabIndex = 1;
            this.fieldSurname.Text = "Surname";
            this.fieldSurname.Enter += new System.EventHandler(this.Field_Enter);
            this.fieldSurname.Leave += new System.EventHandler(this.Field_Leave);
            // 
            // fieldEmail
            // 
            this.fieldEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fieldEmail.Location = new System.Drawing.Point(11, 82);
            this.fieldEmail.Name = "fieldEmail";
            this.fieldEmail.Size = new System.Drawing.Size(369, 29);
            this.fieldEmail.TabIndex = 2;
            this.fieldEmail.Text = "e-mail";
            this.fieldEmail.Enter += new System.EventHandler(this.Field_Enter);
            this.fieldEmail.Leave += new System.EventHandler(this.Field_Leave);
            // 
            // fieldPassword
            // 
            this.fieldPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fieldPassword.Location = new System.Drawing.Point(11, 152);
            this.fieldPassword.Name = "fieldPassword";
            this.fieldPassword.Size = new System.Drawing.Size(369, 29);
            this.fieldPassword.TabIndex = 3;
            this.fieldPassword.Text = "Password";
            this.fieldPassword.Enter += new System.EventHandler(this.Field_Enter);
            this.fieldPassword.Leave += new System.EventHandler(this.Field_Leave);
            // 
            // fieldPasswordRepeat
            // 
            this.fieldPasswordRepeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fieldPasswordRepeat.Location = new System.Drawing.Point(12, 187);
            this.fieldPasswordRepeat.Name = "fieldPasswordRepeat";
            this.fieldPasswordRepeat.Size = new System.Drawing.Size(369, 29);
            this.fieldPasswordRepeat.TabIndex = 4;
            this.fieldPasswordRepeat.Text = "Repeat Password";
            this.fieldPasswordRepeat.Enter += new System.EventHandler(this.Field_Enter);
            this.fieldPasswordRepeat.Leave += new System.EventHandler(this.Field_Leave);
            // 
            // fieldAge
            // 
            this.fieldAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fieldAge.Location = new System.Drawing.Point(12, 117);
            this.fieldAge.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.fieldAge.Minimum = new decimal(new int[] {
            14,
            0,
            0,
            0});
            this.fieldAge.Name = "fieldAge";
            this.fieldAge.Size = new System.Drawing.Size(69, 29);
            this.fieldAge.TabIndex = 5;
            this.fieldAge.Value = new decimal(new int[] {
            14,
            0,
            0,
            0});
            // 
            // buttonSignUp
            // 
            this.buttonSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSignUp.Location = new System.Drawing.Point(11, 222);
            this.buttonSignUp.Name = "buttonSignUp";
            this.buttonSignUp.Size = new System.Drawing.Size(369, 42);
            this.buttonSignUp.TabIndex = 6;
            this.buttonSignUp.Text = "Sign In";
            this.buttonSignUp.UseVisualStyleBackColor = true;
            // 
            // checkShowPassword
            // 
            this.checkShowPassword.AutoSize = true;
            this.checkShowPassword.Location = new System.Drawing.Point(11, 285);
            this.checkShowPassword.Name = "checkShowPassword";
            this.checkShowPassword.Size = new System.Drawing.Size(102, 17);
            this.checkShowPassword.TabIndex = 7;
            this.checkShowPassword.Text = "Show Password";
            this.checkShowPassword.UseVisualStyleBackColor = true;
            this.checkShowPassword.CheckedChanged += new System.EventHandler(this.checkShowPassword_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 450);
            this.Controls.Add(this.checkShowPassword);
            this.Controls.Add(this.buttonSignUp);
            this.Controls.Add(this.fieldAge);
            this.Controls.Add(this.fieldPasswordRepeat);
            this.Controls.Add(this.fieldPassword);
            this.Controls.Add(this.fieldEmail);
            this.Controls.Add(this.fieldSurname);
            this.Controls.Add(this.fieldName);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.fieldAge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fieldName;
        private System.Windows.Forms.TextBox fieldSurname;
        private System.Windows.Forms.TextBox fieldEmail;
        private System.Windows.Forms.TextBox fieldPassword;
        private System.Windows.Forms.TextBox fieldPasswordRepeat;
        private System.Windows.Forms.NumericUpDown fieldAge;
        private System.Windows.Forms.Button buttonSignUp;
        private System.Windows.Forms.CheckBox checkShowPassword;
    }
}

