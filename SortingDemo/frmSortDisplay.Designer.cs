namespace SortingDemo
{
    partial class frmSortDisplay
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
            this.btnInsertionSort = new System.Windows.Forms.Button();
            this.btnQuickSort = new System.Windows.Forms.Button();
            this.btnRadixSort = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblSortingOutput = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInsertionSort
            // 
            this.btnInsertionSort.Location = new System.Drawing.Point(28, 33);
            this.btnInsertionSort.Name = "btnInsertionSort";
            this.btnInsertionSort.Size = new System.Drawing.Size(163, 50);
            this.btnInsertionSort.TabIndex = 0;
            this.btnInsertionSort.Text = "InsertionSort";
            this.btnInsertionSort.UseVisualStyleBackColor = true;
            // 
            // btnQuickSort
            // 
            this.btnQuickSort.Location = new System.Drawing.Point(28, 163);
            this.btnQuickSort.Name = "btnQuickSort";
            this.btnQuickSort.Size = new System.Drawing.Size(163, 50);
            this.btnQuickSort.TabIndex = 1;
            this.btnQuickSort.Text = "QuickSort";
            this.btnQuickSort.UseVisualStyleBackColor = true;
            // 
            // btnRadixSort
            // 
            this.btnRadixSort.Location = new System.Drawing.Point(28, 228);
            this.btnRadixSort.Name = "btnRadixSort";
            this.btnRadixSort.Size = new System.Drawing.Size(163, 50);
            this.btnRadixSort.TabIndex = 2;
            this.btnRadixSort.Text = "Radix Sort";
            this.btnRadixSort.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(28, 293);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 50);
            this.button1.TabIndex = 3;
            this.button1.Text = "Counting Sort";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lblSortingOutput
            // 
            this.lblSortingOutput.BackColor = System.Drawing.Color.White;
            this.lblSortingOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSortingOutput.Location = new System.Drawing.Point(215, 30);
            this.lblSortingOutput.Name = "lblSortingOutput";
            this.lblSortingOutput.Size = new System.Drawing.Size(553, 325);
            this.lblSortingOutput.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(28, 98);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(163, 50);
            this.button2.TabIndex = 5;
            this.button2.Text = "MergeSort";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // frmSortDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblSortingOutput);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnRadixSort);
            this.Controls.Add(this.btnQuickSort);
            this.Controls.Add(this.btnInsertionSort);
            this.Name = "frmSortDisplay";
            this.Text = "Sorter";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInsertionSort;
        private System.Windows.Forms.Button btnQuickSort;
        private System.Windows.Forms.Button btnRadixSort;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblSortingOutput;
        private System.Windows.Forms.Button button2;
    }
}

