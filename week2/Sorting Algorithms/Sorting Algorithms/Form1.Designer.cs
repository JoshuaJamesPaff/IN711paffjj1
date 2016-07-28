namespace Sorting_Algorithms
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
            this.listBoxUnsorted = new System.Windows.Forms.ListBox();
            this.listBoxSorted = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxArraySize = new System.Windows.Forms.TextBox();
            this.buttonCreateArray = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonBubble = new System.Windows.Forms.Button();
            this.buttonSelection = new System.Windows.Forms.Button();
            this.buttonInsertion = new System.Windows.Forms.Button();
            this.buttonMerge = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxUnsorted
            // 
            this.listBoxUnsorted.FormattingEnabled = true;
            this.listBoxUnsorted.Location = new System.Drawing.Point(12, 111);
            this.listBoxUnsorted.Name = "listBoxUnsorted";
            this.listBoxUnsorted.Size = new System.Drawing.Size(120, 342);
            this.listBoxUnsorted.TabIndex = 0;
            // 
            // listBoxSorted
            // 
            this.listBoxSorted.FormattingEnabled = true;
            this.listBoxSorted.Location = new System.Drawing.Point(391, 111);
            this.listBoxSorted.Name = "listBoxSorted";
            this.listBoxSorted.Size = new System.Drawing.Size(120, 342);
            this.listBoxSorted.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Unsorted data";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(388, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sorted data";
            // 
            // textBoxArraySize
            // 
            this.textBoxArraySize.Location = new System.Drawing.Point(89, 22);
            this.textBoxArraySize.Name = "textBoxArraySize";
            this.textBoxArraySize.Size = new System.Drawing.Size(90, 20);
            this.textBoxArraySize.TabIndex = 4;
            // 
            // buttonCreateArray
            // 
            this.buttonCreateArray.Location = new System.Drawing.Point(214, 19);
            this.buttonCreateArray.Name = "buttonCreateArray";
            this.buttonCreateArray.Size = new System.Drawing.Size(192, 23);
            this.buttonCreateArray.TabIndex = 5;
            this.buttonCreateArray.Text = "Create randomized array";
            this.buttonCreateArray.UseVisualStyleBackColor = true;
            this.buttonCreateArray.Click += new System.EventHandler(this.buttonCreateArray_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Array size";
            // 
            // buttonBubble
            // 
            this.buttonBubble.Location = new System.Drawing.Point(231, 140);
            this.buttonBubble.Name = "buttonBubble";
            this.buttonBubble.Size = new System.Drawing.Size(75, 23);
            this.buttonBubble.TabIndex = 7;
            this.buttonBubble.Text = "Bubble Sort";
            this.buttonBubble.UseVisualStyleBackColor = true;
            this.buttonBubble.Click += new System.EventHandler(this.buttonBubble_Click);
            // 
            // buttonSelection
            // 
            this.buttonSelection.Location = new System.Drawing.Point(214, 185);
            this.buttonSelection.Name = "buttonSelection";
            this.buttonSelection.Size = new System.Drawing.Size(103, 23);
            this.buttonSelection.TabIndex = 8;
            this.buttonSelection.Text = "Selection Sort";
            this.buttonSelection.UseVisualStyleBackColor = true;
            this.buttonSelection.Click += new System.EventHandler(this.buttonSelection_Click);
            // 
            // buttonInsertion
            // 
            this.buttonInsertion.Location = new System.Drawing.Point(213, 235);
            this.buttonInsertion.Name = "buttonInsertion";
            this.buttonInsertion.Size = new System.Drawing.Size(104, 23);
            this.buttonInsertion.TabIndex = 9;
            this.buttonInsertion.Text = "Insertion Sort";
            this.buttonInsertion.UseVisualStyleBackColor = true;
            this.buttonInsertion.Click += new System.EventHandler(this.buttonInsertion_Click);
            // 
            // buttonMerge
            // 
            this.buttonMerge.Location = new System.Drawing.Point(231, 288);
            this.buttonMerge.Name = "buttonMerge";
            this.buttonMerge.Size = new System.Drawing.Size(75, 23);
            this.buttonMerge.TabIndex = 10;
            this.buttonMerge.Text = "Merge Sort";
            this.buttonMerge.UseVisualStyleBackColor = true;
            this.buttonMerge.Click += new System.EventHandler(this.buttonMerge_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 465);
            this.Controls.Add(this.buttonMerge);
            this.Controls.Add(this.buttonInsertion);
            this.Controls.Add(this.buttonSelection);
            this.Controls.Add(this.buttonBubble);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonCreateArray);
            this.Controls.Add(this.textBoxArraySize);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxSorted);
            this.Controls.Add(this.listBoxUnsorted);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxUnsorted;
        private System.Windows.Forms.ListBox listBoxSorted;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxArraySize;
        private System.Windows.Forms.Button buttonCreateArray;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonBubble;
        private System.Windows.Forms.Button buttonSelection;
        private System.Windows.Forms.Button buttonInsertion;
        private System.Windows.Forms.Button buttonMerge;
    }
}

