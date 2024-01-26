namespace _732_2
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
            MakeSort = new Button();
            Input = new TextBox();
            Output = new Label();
            MakeSort1 = new Button();
            KeyWord = new TextBox();
            Output2 = new TextBox();
            Save = new Button();
            Read = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            Exit = new Button();
            SuspendLayout();
            // 
            // MakeSort
            // 
            MakeSort.Location = new Point(440, 144);
            MakeSort.Name = "MakeSort";
            MakeSort.Size = new Size(99, 23);
            MakeSort.TabIndex = 0;
            MakeSort.Text = "Зашифровать";
            MakeSort.UseVisualStyleBackColor = true;
            MakeSort.Click += MakeSort_Click;
            // 
            // Input
            // 
            Input.Location = new Point(12, 32);
            Input.Multiline = true;
            Input.Name = "Input";
            Input.ScrollBars = ScrollBars.Vertical;
            Input.Size = new Size(527, 80);
            Input.TabIndex = 1;
            // 
            // Output
            // 
            Output.Location = new Point(210, 223);
            Output.Name = "Output";
            Output.Size = new Size(100, 23);
            Output.TabIndex = 6;
            // 
            // MakeSort1
            // 
            MakeSort1.Location = new Point(315, 144);
            MakeSort1.Name = "MakeSort1";
            MakeSort1.Size = new Size(108, 23);
            MakeSort1.TabIndex = 3;
            MakeSort1.Text = "Расшифровать";
            MakeSort1.UseVisualStyleBackColor = true;
            MakeSort1.Click += MakeSort1_Click;
            // 
            // KeyWord
            // 
            KeyWord.Location = new Point(12, 144);
            KeyWord.Name = "KeyWord";
            KeyWord.Size = new Size(145, 23);
            KeyWord.TabIndex = 5;
            KeyWord.TextChanged += KeyWord_TextChanged;
            // 
            // Output2
            // 
            Output2.Location = new Point(12, 201);
            Output2.Multiline = true;
            Output2.Name = "Output2";
            Output2.ScrollBars = ScrollBars.Vertical;
            Output2.Size = new Size(527, 80);
            Output2.TabIndex = 7;
            // 
            // Save
            // 
            Save.Location = new Point(295, 287);
            Save.Name = "Save";
            Save.Size = new Size(75, 23);
            Save.TabIndex = 8;
            Save.Text = "Сохранить";
            Save.UseVisualStyleBackColor = true;
            Save.Click += Save_Click;
            // 
            // Read
            // 
            Read.Location = new Point(376, 287);
            Read.Name = "Read";
            Read.Size = new Size(163, 23);
            Read.TabIndex = 9;
            Read.Text = "Прочитать шифровку";
            Read.UseVisualStyleBackColor = true;
            Read.Click += Read_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 183);
            label1.Name = "label1";
            label1.Size = new Size(242, 15);
            label1.TabIndex = 10;
            label1.Text = "Расшифрованный\\зашифрованный текст:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 126);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 11;
            label2.Text = "Ключ:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 14);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 12;
            label3.Text = "Текст:";
            // 
            // Exit
            // 
            Exit.Location = new Point(12, 287);
            Exit.Name = "Exit";
            Exit.Size = new Size(81, 23);
            Exit.TabIndex = 13;
            Exit.Text = "Закрыть ";
            Exit.UseVisualStyleBackColor = true;
            Exit.Click += Exit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(551, 322);
            Controls.Add(Exit);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Read);
            Controls.Add(Save);
            Controls.Add(Output2);
            Controls.Add(KeyWord);
            Controls.Add(MakeSort1);
            Controls.Add(Output);
            Controls.Add(Input);
            Controls.Add(MakeSort);
            Name = "Form1";
            Text = "Шифр Виженера(кириллица)";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button MakeSort;
        private TextBox Input;
        private Label Output;
        private Button MakeSort1;
        private TextBox KeyWord;
        private TextBox Output2;
        private Button Save;
        private Button Read;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button Exit;
    }
}
