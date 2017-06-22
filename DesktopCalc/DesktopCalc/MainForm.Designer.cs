using System.Windows.Forms;

namespace DesktopCalc
{
    partial class DesktopCalc
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Wymagana metoda obsługi projektanta — nie należy modyfikować 
        /// zawartość tej metody z edytorem kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DesktopCalc));
            this.Result = new System.Windows.Forms.Label();
            this.num7 = new System.Windows.Forms.Button();
            this.num8 = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.num9 = new System.Windows.Forms.Button();
            this.num4 = new System.Windows.Forms.Button();
            this.num5 = new System.Windows.Forms.Button();
            this.num6 = new System.Windows.Forms.Button();
            this.mulBtn = new System.Windows.Forms.Button();
            this.num1 = new System.Windows.Forms.Button();
            this.num2 = new System.Windows.Forms.Button();
            this.num3 = new System.Windows.Forms.Button();
            this.subBtn = new System.Windows.Forms.Button();
            this.num0 = new System.Windows.Forms.Button();
            this.dotBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.divBtn = new System.Windows.Forms.Button();
            this.resultBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Result
            // 
            this.Result.BackColor = System.Drawing.Color.White;
            this.Result.DataBindings.Add(new System.Windows.Forms.Binding("Text", this, "InsertedValue", true));
            this.Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 38F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Result.Location = new System.Drawing.Point(12, 9);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(694, 141);
            this.Result.TabIndex = 0;
            this.Result.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // num7
            // 
            this.num7.BackColor = System.Drawing.SystemColors.Highlight;
            this.num7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.num7.ForeColor = System.Drawing.Color.White;
            this.num7.Location = new System.Drawing.Point(12, 174);
            this.num7.Name = "num7";
            this.num7.Size = new System.Drawing.Size(133, 119);
            this.num7.TabIndex = 1;
            this.num7.Text = "7";
            this.num7.UseVisualStyleBackColor = false;
            this.num7.Click += new System.EventHandler(this.num_Click);
            // 
            // num8
            // 
            this.num8.BackColor = System.Drawing.SystemColors.Highlight;
            this.num8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.num8.ForeColor = System.Drawing.Color.White;
            this.num8.Location = new System.Drawing.Point(195, 174);
            this.num8.Name = "num8";
            this.num8.Size = new System.Drawing.Size(133, 119);
            this.num8.TabIndex = 2;
            this.num8.Text = "8";
            this.num8.UseVisualStyleBackColor = false;
            this.num8.Click += new System.EventHandler(this.num_Click);
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addBtn.ForeColor = System.Drawing.Color.White;
            this.addBtn.Location = new System.Drawing.Point(573, 174);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(133, 119);
            this.addBtn.TabIndex = 3;
            this.addBtn.Text = "+";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.operationBtn_Click);
            // 
            // num9
            // 
            this.num9.BackColor = System.Drawing.SystemColors.Highlight;
            this.num9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.num9.ForeColor = System.Drawing.Color.White;
            this.num9.Location = new System.Drawing.Point(385, 174);
            this.num9.Name = "num9";
            this.num9.Size = new System.Drawing.Size(133, 119);
            this.num9.TabIndex = 4;
            this.num9.Text = "9";
            this.num9.UseVisualStyleBackColor = false;
            this.num9.Click += new System.EventHandler(this.num_Click);
            // 
            // num4
            // 
            this.num4.BackColor = System.Drawing.SystemColors.Highlight;
            this.num4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.num4.ForeColor = System.Drawing.Color.White;
            this.num4.Location = new System.Drawing.Point(12, 329);
            this.num4.Name = "num4";
            this.num4.Size = new System.Drawing.Size(133, 119);
            this.num4.TabIndex = 5;
            this.num4.Text = "4";
            this.num4.UseVisualStyleBackColor = false;
            this.num4.Click += new System.EventHandler(this.num_Click);
            // 
            // num5
            // 
            this.num5.BackColor = System.Drawing.SystemColors.Highlight;
            this.num5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.num5.ForeColor = System.Drawing.Color.White;
            this.num5.Location = new System.Drawing.Point(195, 329);
            this.num5.Name = "num5";
            this.num5.Size = new System.Drawing.Size(133, 119);
            this.num5.TabIndex = 6;
            this.num5.Text = "5";
            this.num5.UseVisualStyleBackColor = false;
            this.num5.Click += new System.EventHandler(this.num_Click);
            // 
            // num6
            // 
            this.num6.BackColor = System.Drawing.SystemColors.Highlight;
            this.num6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.num6.ForeColor = System.Drawing.Color.White;
            this.num6.Location = new System.Drawing.Point(385, 329);
            this.num6.Name = "num6";
            this.num6.Size = new System.Drawing.Size(133, 119);
            this.num6.TabIndex = 7;
            this.num6.Text = "6";
            this.num6.UseVisualStyleBackColor = false;
            this.num6.Click += new System.EventHandler(this.num_Click);
            // 
            // mulBtn
            // 
            this.mulBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.mulBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mulBtn.ForeColor = System.Drawing.Color.White;
            this.mulBtn.Location = new System.Drawing.Point(573, 329);
            this.mulBtn.Name = "mulBtn";
            this.mulBtn.Size = new System.Drawing.Size(133, 119);
            this.mulBtn.TabIndex = 8;
            this.mulBtn.Text = "*";
            this.mulBtn.UseVisualStyleBackColor = false;
            this.mulBtn.Click += new System.EventHandler(this.operationBtn_Click);
            // 
            // num1
            // 
            this.num1.BackColor = System.Drawing.SystemColors.Highlight;
            this.num1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.num1.ForeColor = System.Drawing.Color.White;
            this.num1.Location = new System.Drawing.Point(12, 483);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(133, 119);
            this.num1.TabIndex = 9;
            this.num1.Text = "1";
            this.num1.UseVisualStyleBackColor = false;
            this.num1.Click += new System.EventHandler(this.num_Click);
            // 
            // num2
            // 
            this.num2.BackColor = System.Drawing.SystemColors.Highlight;
            this.num2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.num2.ForeColor = System.Drawing.Color.White;
            this.num2.Location = new System.Drawing.Point(195, 483);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(133, 119);
            this.num2.TabIndex = 10;
            this.num2.Text = "2";
            this.num2.UseVisualStyleBackColor = false;
            this.num2.Click += new System.EventHandler(this.num_Click);
            // 
            // num3
            // 
            this.num3.BackColor = System.Drawing.SystemColors.Highlight;
            this.num3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.num3.ForeColor = System.Drawing.Color.White;
            this.num3.Location = new System.Drawing.Point(385, 483);
            this.num3.Name = "num3";
            this.num3.Size = new System.Drawing.Size(133, 119);
            this.num3.TabIndex = 11;
            this.num3.Text = "3";
            this.num3.UseVisualStyleBackColor = false;
            this.num3.Click += new System.EventHandler(this.num_Click);
            // 
            // subBtn
            // 
            this.subBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.subBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.subBtn.ForeColor = System.Drawing.Color.White;
            this.subBtn.Location = new System.Drawing.Point(573, 483);
            this.subBtn.Name = "subBtn";
            this.subBtn.Size = new System.Drawing.Size(133, 119);
            this.subBtn.TabIndex = 12;
            this.subBtn.Text = "-";
            this.subBtn.UseVisualStyleBackColor = false;
            this.subBtn.Click += new System.EventHandler(this.operationBtn_Click);
            // 
            // num0
            // 
            this.num0.BackColor = System.Drawing.SystemColors.Highlight;
            this.num0.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.num0.ForeColor = System.Drawing.Color.White;
            this.num0.Location = new System.Drawing.Point(12, 633);
            this.num0.Name = "num0";
            this.num0.Size = new System.Drawing.Size(133, 119);
            this.num0.TabIndex = 13;
            this.num0.Text = "0";
            this.num0.UseVisualStyleBackColor = false;
            this.num0.Click += new System.EventHandler(this.num_Click);
            // 
            // dotBtn
            // 
            this.dotBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.dotBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dotBtn.ForeColor = System.Drawing.Color.White;
            this.dotBtn.Location = new System.Drawing.Point(195, 633);
            this.dotBtn.Name = "dotBtn";
            this.dotBtn.Size = new System.Drawing.Size(133, 119);
            this.dotBtn.TabIndex = 14;
            this.dotBtn.Text = ",";
            this.dotBtn.UseVisualStyleBackColor = false;
            this.dotBtn.Click += new System.EventHandler(this.num_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.clearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.clearBtn.ForeColor = System.Drawing.Color.White;
            this.clearBtn.Location = new System.Drawing.Point(385, 633);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(133, 119);
            this.clearBtn.TabIndex = 15;
            this.clearBtn.Text = "C";
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.operationBtn_Click);
            // 
            // divBtn
            // 
            this.divBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.divBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.divBtn.ForeColor = System.Drawing.Color.White;
            this.divBtn.Location = new System.Drawing.Point(573, 633);
            this.divBtn.Name = "divBtn";
            this.divBtn.Size = new System.Drawing.Size(133, 119);
            this.divBtn.TabIndex = 16;
            this.divBtn.Text = "/";
            this.divBtn.UseVisualStyleBackColor = false;
            this.divBtn.Click += new System.EventHandler(this.operationBtn_Click);
            // 
            // resultBtn
            // 
            this.resultBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.resultBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.resultBtn.ForeColor = System.Drawing.Color.White;
            this.resultBtn.Location = new System.Drawing.Point(12, 789);
            this.resultBtn.Name = "resultBtn";
            this.resultBtn.Size = new System.Drawing.Size(694, 119);
            this.resultBtn.TabIndex = 17;
            this.resultBtn.Text = "=";
            this.resultBtn.UseVisualStyleBackColor = false;
            this.resultBtn.Click += new System.EventHandler(this.resultBtn_Click);
            // 
            // DesktopCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(720, 929);
            this.Controls.Add(this.resultBtn);
            this.Controls.Add(this.divBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.dotBtn);
            this.Controls.Add(this.num0);
            this.Controls.Add(this.subBtn);
            this.Controls.Add(this.num3);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.mulBtn);
            this.Controls.Add(this.num6);
            this.Controls.Add(this.num5);
            this.Controls.Add(this.num4);
            this.Controls.Add(this.num9);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.num8);
            this.Controls.Add(this.num7);
            this.Controls.Add(this.Result);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DesktopCalc";
            this.Text = "DesktopCalc";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.Button num7;
        private System.Windows.Forms.Button num8;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button num9;
        private System.Windows.Forms.Button num4;
        private System.Windows.Forms.Button num5;
        private System.Windows.Forms.Button num6;
        private System.Windows.Forms.Button mulBtn;
        private System.Windows.Forms.Button num1;
        private System.Windows.Forms.Button num2;
        private System.Windows.Forms.Button num3;
        private System.Windows.Forms.Button subBtn;
        private System.Windows.Forms.Button num0;
        private System.Windows.Forms.Button dotBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button divBtn;
        private System.Windows.Forms.Button resultBtn;
    }
}

