namespace mebeluveikals
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
            selectProductComboBox = new ComboBox();
            label1 = new Label();
            nameTextBox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            priceTextBox = new TextBox();
            label4 = new Label();
            hTextBox = new TextBox();
            label5 = new Label();
            wTextBox = new TextBox();
            label6 = new Label();
            descTextBox = new TextBox();
            label7 = new Label();
            lTextBox = new TextBox();
            selectBtn = new Button();
            addButton = new Button();
            editBtn = new Button();
            deleteBtn = new Button();
            SuspendLayout();
            // 
            // selectProductComboBox
            // 
            selectProductComboBox.FormattingEnabled = true;
            selectProductComboBox.Location = new Point(12, 38);
            selectProductComboBox.Name = "selectProductComboBox";
            selectProductComboBox.Size = new Size(312, 23);
            selectProductComboBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 1;
            label1.Text = "Izvēlies preci";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(12, 110);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(183, 23);
            nameTextBox.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 92);
            label2.Name = "label2";
            label2.Size = new Size(105, 15);
            label2.TabIndex = 3;
            label2.Text = "Preces nosaukums";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 155);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 5;
            label3.Text = "Cena";
            // 
            // priceTextBox
            // 
            priceTextBox.Location = new Point(12, 173);
            priceTextBox.Name = "priceTextBox";
            priceTextBox.Size = new Size(183, 23);
            priceTextBox.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(222, 92);
            label4.Name = "label4";
            label4.Size = new Size(61, 15);
            label4.TabIndex = 7;
            label4.Text = "Augstums";
            // 
            // hTextBox
            // 
            hTextBox.Location = new Point(222, 110);
            hTextBox.Name = "hTextBox";
            hTextBox.Size = new Size(183, 23);
            hTextBox.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(222, 155);
            label5.Name = "label5";
            label5.Size = new Size(50, 15);
            label5.TabIndex = 9;
            label5.Text = "Platums";
            // 
            // wTextBox
            // 
            wTextBox.Location = new Point(222, 173);
            wTextBox.Name = "wTextBox";
            wTextBox.Size = new Size(183, 23);
            wTextBox.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 218);
            label6.Name = "label6";
            label6.Size = new Size(52, 15);
            label6.TabIndex = 11;
            label6.Text = "Apraksts";
            // 
            // descTextBox
            // 
            descTextBox.Location = new Point(12, 236);
            descTextBox.Name = "descTextBox";
            descTextBox.Size = new Size(183, 23);
            descTextBox.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(222, 218);
            label7.Name = "label7";
            label7.Size = new Size(48, 15);
            label7.TabIndex = 13;
            label7.Text = "Garums";
            // 
            // lTextBox
            // 
            lTextBox.Location = new Point(222, 236);
            lTextBox.Name = "lTextBox";
            lTextBox.Size = new Size(183, 23);
            lTextBox.TabIndex = 12;
            // 
            // selectBtn
            // 
            selectBtn.Location = new Point(330, 37);
            selectBtn.Name = "selectBtn";
            selectBtn.Size = new Size(75, 24);
            selectBtn.TabIndex = 14;
            selectBtn.Text = "Izvēlēties";
            selectBtn.UseVisualStyleBackColor = true;
            selectBtn.Click += selectBtn_Click;
            // 
            // addButton
            // 
            addButton.Location = new Point(12, 298);
            addButton.Name = "addButton";
            addButton.Size = new Size(75, 24);
            addButton.TabIndex = 15;
            addButton.Text = "Pievienot";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // editBtn
            // 
            editBtn.Location = new Point(93, 298);
            editBtn.Name = "editBtn";
            editBtn.Size = new Size(75, 24);
            editBtn.TabIndex = 16;
            editBtn.Text = "Rediģēt";
            editBtn.UseVisualStyleBackColor = true;
            // 
            // deleteBtn
            // 
            deleteBtn.Location = new Point(174, 298);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(75, 24);
            deleteBtn.TabIndex = 17;
            deleteBtn.Text = "Dzēst";
            deleteBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(443, 354);
            Controls.Add(deleteBtn);
            Controls.Add(editBtn);
            Controls.Add(addButton);
            Controls.Add(selectBtn);
            Controls.Add(label7);
            Controls.Add(lTextBox);
            Controls.Add(label6);
            Controls.Add(descTextBox);
            Controls.Add(label5);
            Controls.Add(wTextBox);
            Controls.Add(label4);
            Controls.Add(hTextBox);
            Controls.Add(label3);
            Controls.Add(priceTextBox);
            Controls.Add(label2);
            Controls.Add(nameTextBox);
            Controls.Add(label1);
            Controls.Add(selectProductComboBox);
            MaximumSize = new Size(459, 393);
            MinimumSize = new Size(459, 393);
            Name = "Form1";
            Text = "Mēbeļu veikals";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox selectProductComboBox;
        private Label label1;
        private TextBox nameTextBox;
        private Label label2;
        private Label label3;
        private TextBox priceTextBox;
        private Label label4;
        private TextBox hTextBox;
        private Label label5;
        private TextBox wTextBox;
        private Label label6;
        private TextBox descTextBox;
        private Label label7;
        private TextBox lTextBox;
        private Button selectBtn;
        private Button addButton;
        private Button editBtn;
        private Button deleteBtn;
    }
}
