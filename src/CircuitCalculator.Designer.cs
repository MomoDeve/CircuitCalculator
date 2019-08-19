namespace CircuitCalculator
{
    partial class CircuitCalculator
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CircuitCalculator));
            this.ComponentsList = new System.Windows.Forms.RichTextBox();
            this.CraftRecursion = new System.Windows.Forms.CheckBox();
            this.MaxTierCircuits = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ResetButton = new System.Windows.Forms.Button();
            this.StackButton = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // ComponentsList
            // 
            this.ComponentsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ComponentsList.Location = new System.Drawing.Point(723, 11);
            this.ComponentsList.Name = "ComponentsList";
            this.ComponentsList.ReadOnly = true;
            this.ComponentsList.Size = new System.Drawing.Size(529, 658);
            this.ComponentsList.TabIndex = 12;
            this.ComponentsList.Text = "";
            // 
            // CraftRecursion
            // 
            this.CraftRecursion.AutoSize = true;
            this.CraftRecursion.Checked = true;
            this.CraftRecursion.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CraftRecursion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CraftRecursion.Location = new System.Drawing.Point(542, 13);
            this.CraftRecursion.Name = "CraftRecursion";
            this.CraftRecursion.Size = new System.Drawing.Size(164, 28);
            this.CraftRecursion.TabIndex = 13;
            this.CraftRecursion.Text = "Recursive Crafts";
            this.CraftRecursion.UseVisualStyleBackColor = true;
            this.CraftRecursion.CheckedChanged += new System.EventHandler(this.CraftRecursion_CheckedChanged);
            // 
            // MaxTierCircuits
            // 
            this.MaxTierCircuits.AutoSize = true;
            this.MaxTierCircuits.Checked = true;
            this.MaxTierCircuits.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MaxTierCircuits.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MaxTierCircuits.Location = new System.Drawing.Point(542, 42);
            this.MaxTierCircuits.Name = "MaxTierCircuits";
            this.MaxTierCircuits.Size = new System.Drawing.Size(170, 28);
            this.MaxTierCircuits.TabIndex = 14;
            this.MaxTierCircuits.Text = "Max-Tier Circuits";
            this.MaxTierCircuits.UseVisualStyleBackColor = true;
            this.MaxTierCircuits.CheckedChanged += new System.EventHandler(this.HighTierCircuits_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 645);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 24);
            this.label1.TabIndex = 15;
            this.label1.Text = "GTNH Circuit Calculator by Momo";
            // 
            // ResetButton
            // 
            this.ResetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResetButton.Location = new System.Drawing.Point(542, 110);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(164, 31);
            this.ResetButton.TabIndex = 16;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // StackButton
            // 
            this.StackButton.AutoSize = true;
            this.StackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StackButton.Location = new System.Drawing.Point(542, 76);
            this.StackButton.Name = "StackButton";
            this.StackButton.Size = new System.Drawing.Size(178, 28);
            this.StackButton.TabIndex = 17;
            this.StackButton.Text = "Count Item Stacks";
            this.StackButton.UseVisualStyleBackColor = true;
            this.StackButton.CheckedChanged += new System.EventHandler(this.StackButton_CheckedChanged);
            // 
            // CircuitCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.StackButton);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MaxTierCircuits);
            this.Controls.Add(this.CraftRecursion);
            this.Controls.Add(this.ComponentsList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CircuitCalculator";
            this.Text = "Circuit Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox ComponentsList;
        private System.Windows.Forms.CheckBox CraftRecursion;
        private System.Windows.Forms.CheckBox MaxTierCircuits;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.CheckBox StackButton;
    }
}

