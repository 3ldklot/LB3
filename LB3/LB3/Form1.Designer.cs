namespace LB3
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
            groupBoxChooseSifer = new GroupBox();
            radioButton1 = new RadioButton();
            radioButtonCesarShoose = new RadioButton();
            label1 = new Label();
            groupBoxCesarSifer = new GroupBox();
            buttonToDecryptCesar = new Button();
            buttonToEncryptCesar = new Button();
            label4 = new Label();
            textBoxEncrypted = new TextBox();
            label3 = new Label();
            textBoxDecrypted = new TextBox();
            textBoxCesarKey = new TextBox();
            label2 = new Label();
            textBoxKValue = new TextBox();
            labelInsertK = new Label();
            groupBoxPolybius = new GroupBox();
            buttonToDecrytpPolybius = new Button();
            textBoxEncryptedPolybius = new TextBox();
            buttonToEncryptPolybius = new Button();
            textBoxDecryptedPolybius = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            listBoxInfo = new ListBox();
            buttonExit = new Button();
            groupBoxChooseSifer.SuspendLayout();
            groupBoxCesarSifer.SuspendLayout();
            groupBoxPolybius.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxChooseSifer
            // 
            groupBoxChooseSifer.Controls.Add(radioButton1);
            groupBoxChooseSifer.Controls.Add(radioButtonCesarShoose);
            groupBoxChooseSifer.Controls.Add(label1);
            groupBoxChooseSifer.Location = new Point(14, 16);
            groupBoxChooseSifer.Margin = new Padding(3, 4, 3, 4);
            groupBoxChooseSifer.Name = "groupBoxChooseSifer";
            groupBoxChooseSifer.Padding = new Padding(3, 4, 3, 4);
            groupBoxChooseSifer.Size = new Size(431, 68);
            groupBoxChooseSifer.TabIndex = 2;
            groupBoxChooseSifer.TabStop = false;
            groupBoxChooseSifer.Text = "Выберите алгоритм шифрования";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(219, 29);
            radioButton1.Margin = new Padding(3, 4, 3, 4);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(153, 24);
            radioButton1.TabIndex = 3;
            radioButton1.TabStop = true;
            radioButton1.Text = "Квадрат Полибия";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButtonCesarShoose
            // 
            radioButtonCesarShoose.AutoSize = true;
            radioButtonCesarShoose.Location = new Point(7, 29);
            radioButtonCesarShoose.Margin = new Padding(3, 4, 3, 4);
            radioButtonCesarShoose.Name = "radioButtonCesarShoose";
            radioButtonCesarShoose.Size = new Size(127, 24);
            radioButtonCesarShoose.TabIndex = 1;
            radioButtonCesarShoose.TabStop = true;
            radioButtonCesarShoose.Text = "Шифр Цезаря";
            radioButtonCesarShoose.UseVisualStyleBackColor = true;
            radioButtonCesarShoose.CheckedChanged += radioButtonCesarShoose_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 25);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 0;
            // 
            // groupBoxCesarSifer
            // 
            groupBoxCesarSifer.Controls.Add(buttonToDecryptCesar);
            groupBoxCesarSifer.Controls.Add(buttonToEncryptCesar);
            groupBoxCesarSifer.Controls.Add(label4);
            groupBoxCesarSifer.Controls.Add(textBoxEncrypted);
            groupBoxCesarSifer.Controls.Add(label3);
            groupBoxCesarSifer.Controls.Add(textBoxDecrypted);
            groupBoxCesarSifer.Controls.Add(textBoxCesarKey);
            groupBoxCesarSifer.Controls.Add(label2);
            groupBoxCesarSifer.Controls.Add(textBoxKValue);
            groupBoxCesarSifer.Controls.Add(labelInsertK);
            groupBoxCesarSifer.Enabled = false;
            groupBoxCesarSifer.Location = new Point(14, 92);
            groupBoxCesarSifer.Margin = new Padding(3, 4, 3, 4);
            groupBoxCesarSifer.Name = "groupBoxCesarSifer";
            groupBoxCesarSifer.Padding = new Padding(3, 4, 3, 4);
            groupBoxCesarSifer.Size = new Size(200, 344);
            groupBoxCesarSifer.TabIndex = 3;
            groupBoxCesarSifer.TabStop = false;
            // 
            // buttonToDecryptCesar
            // 
            buttonToDecryptCesar.Location = new Point(7, 303);
            buttonToDecryptCesar.Margin = new Padding(3, 4, 3, 4);
            buttonToDecryptCesar.Name = "buttonToDecryptCesar";
            buttonToDecryptCesar.Size = new Size(185, 31);
            buttonToDecryptCesar.TabIndex = 9;
            buttonToDecryptCesar.Text = "Дешифровать";
            buttonToDecryptCesar.UseVisualStyleBackColor = true;
            buttonToDecryptCesar.Click += buttonToDecryptCesar_Click;
            // 
            // buttonToEncryptCesar
            // 
            buttonToEncryptCesar.Location = new Point(7, 264);
            buttonToEncryptCesar.Margin = new Padding(3, 4, 3, 4);
            buttonToEncryptCesar.Name = "buttonToEncryptCesar";
            buttonToEncryptCesar.Size = new Size(185, 31);
            buttonToEncryptCesar.TabIndex = 8;
            buttonToEncryptCesar.Text = "Зашифровать";
            buttonToEncryptCesar.UseVisualStyleBackColor = true;
            buttonToEncryptCesar.Click += buttonToEncryptCesar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 201);
            label4.Name = "label4";
            label4.Size = new Size(150, 20);
            label4.TabIndex = 7;
            label4.Text = "После шифрования:";
            // 
            // textBoxEncrypted
            // 
            textBoxEncrypted.Location = new Point(7, 225);
            textBoxEncrypted.Margin = new Padding(3, 4, 3, 4);
            textBoxEncrypted.Name = "textBoxEncrypted";
            textBoxEncrypted.Size = new Size(185, 27);
            textBoxEncrypted.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 143);
            label3.Name = "label3";
            label3.Size = new Size(107, 20);
            label3.TabIndex = 5;
            label3.Text = "Зашифровать:";
            // 
            // textBoxDecrypted
            // 
            textBoxDecrypted.Location = new Point(7, 167);
            textBoxDecrypted.Margin = new Padding(3, 4, 3, 4);
            textBoxDecrypted.Name = "textBoxDecrypted";
            textBoxDecrypted.Size = new Size(185, 27);
            textBoxDecrypted.TabIndex = 4;
            // 
            // textBoxCesarKey
            // 
            textBoxCesarKey.Location = new Point(7, 108);
            textBoxCesarKey.Margin = new Padding(3, 4, 3, 4);
            textBoxCesarKey.Name = "textBoxCesarKey";
            textBoxCesarKey.Size = new Size(185, 27);
            textBoxCesarKey.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 84);
            label2.Name = "label2";
            label2.Size = new Size(104, 20);
            label2.TabIndex = 2;
            label2.Text = "Введите ключ";
            // 
            // textBoxKValue
            // 
            textBoxKValue.Location = new Point(8, 49);
            textBoxKValue.Margin = new Padding(3, 4, 3, 4);
            textBoxKValue.Name = "textBoxKValue";
            textBoxKValue.Size = new Size(185, 27);
            textBoxKValue.TabIndex = 1;
            // 
            // labelInsertK
            // 
            labelInsertK.AutoSize = true;
            labelInsertK.Location = new Point(7, 25);
            labelInsertK.Name = "labelInsertK";
            labelInsertK.Size = new Size(187, 20);
            labelInsertK.TabIndex = 0;
            labelInsertK.Text = "Введите ниже значение k";
            // 
            // groupBoxPolybius
            // 
            groupBoxPolybius.Controls.Add(buttonToDecrytpPolybius);
            groupBoxPolybius.Controls.Add(textBoxEncryptedPolybius);
            groupBoxPolybius.Controls.Add(buttonToEncryptPolybius);
            groupBoxPolybius.Controls.Add(textBoxDecryptedPolybius);
            groupBoxPolybius.Controls.Add(label5);
            groupBoxPolybius.Controls.Add(label6);
            groupBoxPolybius.Enabled = false;
            groupBoxPolybius.Location = new Point(245, 92);
            groupBoxPolybius.Margin = new Padding(3, 4, 3, 4);
            groupBoxPolybius.Name = "groupBoxPolybius";
            groupBoxPolybius.Padding = new Padding(3, 4, 3, 4);
            groupBoxPolybius.Size = new Size(200, 232);
            groupBoxPolybius.TabIndex = 4;
            groupBoxPolybius.TabStop = false;
            // 
            // buttonToDecrytpPolybius
            // 
            buttonToDecrytpPolybius.Location = new Point(7, 185);
            buttonToDecrytpPolybius.Margin = new Padding(3, 4, 3, 4);
            buttonToDecrytpPolybius.Name = "buttonToDecrytpPolybius";
            buttonToDecrytpPolybius.Size = new Size(185, 31);
            buttonToDecrytpPolybius.TabIndex = 15;
            buttonToDecrytpPolybius.Text = "Дешифровать";
            buttonToDecrytpPolybius.UseVisualStyleBackColor = true;
            buttonToDecrytpPolybius.Click += buttonToDecrytpPolybius_Click;
            // 
            // textBoxEncryptedPolybius
            // 
            textBoxEncryptedPolybius.Location = new Point(7, 108);
            textBoxEncryptedPolybius.Margin = new Padding(3, 4, 3, 4);
            textBoxEncryptedPolybius.Name = "textBoxEncryptedPolybius";
            textBoxEncryptedPolybius.Size = new Size(185, 27);
            textBoxEncryptedPolybius.TabIndex = 12;
            // 
            // buttonToEncryptPolybius
            // 
            buttonToEncryptPolybius.Location = new Point(7, 147);
            buttonToEncryptPolybius.Margin = new Padding(3, 4, 3, 4);
            buttonToEncryptPolybius.Name = "buttonToEncryptPolybius";
            buttonToEncryptPolybius.Size = new Size(185, 31);
            buttonToEncryptPolybius.TabIndex = 14;
            buttonToEncryptPolybius.Text = "Зашифровать";
            buttonToEncryptPolybius.UseVisualStyleBackColor = true;
            buttonToEncryptPolybius.Click += buttonToEncryptPolybius_Click;
            // 
            // textBoxDecryptedPolybius
            // 
            textBoxDecryptedPolybius.Location = new Point(7, 49);
            textBoxDecryptedPolybius.Margin = new Padding(3, 4, 3, 4);
            textBoxDecryptedPolybius.Name = "textBoxDecryptedPolybius";
            textBoxDecryptedPolybius.Size = new Size(185, 27);
            textBoxDecryptedPolybius.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(8, 84);
            label5.Name = "label5";
            label5.Size = new Size(150, 20);
            label5.TabIndex = 13;
            label5.Text = "После шифрования:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(7, 25);
            label6.Name = "label6";
            label6.Size = new Size(107, 20);
            label6.TabIndex = 11;
            label6.Text = "Зашифровать:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(240, 341);
            label7.Name = "label7";
            label7.Size = new Size(0, 20);
            label7.TabIndex = 5;
            // 
            // listBoxInfo
            // 
            listBoxInfo.FormattingEnabled = true;
            listBoxInfo.ItemHeight = 20;
            listBoxInfo.Location = new Point(221, 332);
            listBoxInfo.Margin = new Padding(3, 4, 3, 4);
            listBoxInfo.Name = "listBoxInfo";
            listBoxInfo.Size = new Size(223, 104);
            listBoxInfo.TabIndex = 7;
            // 
            // buttonExit
            // 
            buttonExit.Location = new Point(375, 460);
            buttonExit.Margin = new Padding(3, 4, 3, 4);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(69, 31);
            buttonExit.TabIndex = 6;
            buttonExit.Text = "Выход";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(458, 507);
            Controls.Add(listBoxInfo);
            Controls.Add(buttonExit);
            Controls.Add(label7);
            Controls.Add(groupBoxPolybius);
            Controls.Add(groupBoxCesarSifer);
            Controls.Add(groupBoxChooseSifer);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Зашифруйка";
            groupBoxChooseSifer.ResumeLayout(false);
            groupBoxChooseSifer.PerformLayout();
            groupBoxCesarSifer.ResumeLayout(false);
            groupBoxCesarSifer.PerformLayout();
            groupBoxPolybius.ResumeLayout(false);
            groupBoxPolybius.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBoxChooseSifer;
        private RadioButton radioButton1;
        private RadioButton radioButtonCesarShoose;
        private Label label1;
        private GroupBox groupBoxCesarSifer;
        private GroupBox groupBoxPolybius;
        private TextBox textBoxCesarKey;
        private Label label2;
        private TextBox textBoxKValue;
        private Label labelInsertK;
        private Button buttonToDecryptCesar;
        private Button buttonToEncryptCesar;
        private Label label4;
        private TextBox textBoxEncrypted;
        private Label label3;
        private TextBox textBoxDecrypted;
        private Button buttonToDecrytpPolybius;
        private TextBox textBoxEncryptedPolybius;
        private Button buttonToEncryptPolybius;
        private TextBox textBoxDecryptedPolybius;
        private Label label5;
        private Label label6;
        private Label label7;
        private ListBox listBoxInfo;
        private Button buttonExit;
    }
}