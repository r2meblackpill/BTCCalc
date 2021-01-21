
namespace BitCoinCalculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.CurrencyMenu = new System.Windows.Forms.ComboBox();
            this.GetRatesBtn = new System.Windows.Forms.Button();
            this.AmountOfBts = new System.Windows.Forms.TextBox();
            this.Result = new System.Windows.Forms.TextBox();
            this.ResultLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CurrencyMenu
            // 
            this.CurrencyMenu.FormattingEnabled = true;
            this.CurrencyMenu.Items.AddRange(new object[] {
            "EUR",
            "USD",
            "GBP"});
            this.CurrencyMenu.Location = new System.Drawing.Point(39, 59);
            this.CurrencyMenu.Name = "CurrencyMenu";
            this.CurrencyMenu.Size = new System.Drawing.Size(146, 28);
            this.CurrencyMenu.TabIndex = 0;
            this.CurrencyMenu.Text = "Select Currency";
            // 
            // GetRatesBtn
            // 
            this.GetRatesBtn.Location = new System.Drawing.Point(216, 141);
            this.GetRatesBtn.Name = "GetRatesBtn";
            this.GetRatesBtn.Size = new System.Drawing.Size(127, 27);
            this.GetRatesBtn.TabIndex = 1;
            this.GetRatesBtn.Text = "Get Rates";
            this.GetRatesBtn.UseVisualStyleBackColor = true;
            this.GetRatesBtn.Click += new System.EventHandler(this.GetRatesBtn_Click);
            // 
            // AmountOfBts
            // 
            this.AmountOfBts.Location = new System.Drawing.Point(39, 141);
            this.AmountOfBts.Name = "AmountOfBts";
            this.AmountOfBts.PlaceholderText = "Amount Of Bitcoins";
            this.AmountOfBts.Size = new System.Drawing.Size(146, 27);
            this.AmountOfBts.TabIndex = 2;
            // 
            // Result
            // 
            this.Result.CausesValidation = false;
            this.Result.Location = new System.Drawing.Point(39, 215);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(146, 27);
            this.Result.TabIndex = 3;
            this.Result.Visible = false;
            // 
            // ResultLbl
            // 
            this.ResultLbl.AutoSize = true;
            this.ResultLbl.Location = new System.Drawing.Point(39, 181);
            this.ResultLbl.Name = "ResultLbl";
            this.ResultLbl.Size = new System.Drawing.Size(55, 20);
            this.ResultLbl.TabIndex = 4;
            this.ResultLbl.Text = "Results";
            this.ResultLbl.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 358);
            this.Controls.Add(this.ResultLbl);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.AmountOfBts);
            this.Controls.Add(this.GetRatesBtn);
            this.Controls.Add(this.CurrencyMenu);
            this.Name = "Form1";
            this.Text = "BitCoin Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CurrencyMenu;
        private System.Windows.Forms.Button GetRatesBtn;
        private System.Windows.Forms.TextBox AmountOfBts;
        private System.Windows.Forms.TextBox Result;
        private System.Windows.Forms.Label ResultLbl;
    }
}

