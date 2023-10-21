using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp
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
            carBrand = new TextBox();
            carModel = new TextBox();
            carYear = new TextBox();
            carInspectionYear = new TextBox();
            carOwner = new TextBox();
            button1 = new Button();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button2 = new Button();
            carIssueFine = new TextBox();
            label6 = new Label();
            button3 = new Button();
            button4 = new Button();
            carNewOwner = new TextBox();
            label7 = new Label();
            button5 = new Button();
            amountIssuePay = new TextBox();
            label8 = new Label();
            button6 = new Button();
            button7 = new Button();
            newYeartTech = new TextBox();
            label9 = new Label();
            SuspendLayout();
            // 
            // carBrand
            // 
            carBrand.Location = new Point(12, 40);
            carBrand.Name = "carBrand";
            carBrand.Size = new Size(146, 26);
            carBrand.TabIndex = 0;
            // 
            // carModel
            // 
            carModel.Location = new Point(12, 91);
            carModel.Name = "carModel";
            carModel.Size = new Size(146, 26);
            carModel.TabIndex = 1;
            // 
            // carYear
            // 
            carYear.Location = new Point(12, 149);
            carYear.Name = "carYear";
            carYear.Size = new Size(146, 26);
            carYear.TabIndex = 2;
            // 
            // carInspectionYear
            // 
            carInspectionYear.Location = new Point(12, 201);
            carInspectionYear.Name = "carInspectionYear";
            carInspectionYear.Size = new Size(146, 26);
            carInspectionYear.TabIndex = 3;
            // 
            // carOwner
            // 
            carOwner.Location = new Point(12, 254);
            carOwner.Name = "carOwner";
            carOwner.Size = new Size(146, 26);
            carOwner.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(12, 305);
            button1.Name = "button1";
            button1.Size = new Size(146, 30);
            button1.TabIndex = 5;
            button1.Text = "Создать авто";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnCreateCar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 18);
            label2.Name = "label2";
            label2.Size = new Size(98, 19);
            label2.TabIndex = 7;
            label2.Text = "Бренд машины";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 69);
            label1.Name = "label1";
            label1.Size = new Size(117, 19);
            label1.TabIndex = 8;
            label1.Text = "Модель машины";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 127);
            label3.Name = "label3";
            label3.Size = new Size(90, 19);
            label3.TabIndex = 9;
            label3.Text = "Год машины";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 179);
            label4.Name = "label4";
            label4.Size = new Size(111, 19);
            label4.TabIndex = 10;
            label4.Text = "Год тех.осмотра";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(44, 232);
            label5.Name = "label5";
            label5.Size = new Size(68, 19);
            label5.TabIndex = 11;
            label5.Text = "Владелец";
            // 
            // button2
            // 
            button2.Location = new Point(245, 305);
            button2.Name = "button2";
            button2.Size = new Size(180, 30);
            button2.TabIndex = 12;
            button2.Text = "Пройти тех. осмотр";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnPassTechInspection_Click;
            // 
            // carIssueFine
            // 
            carIssueFine.Location = new Point(183, 39);
            carIssueFine.Name = "carIssueFine";
            carIssueFine.Size = new Size(146, 26);
            carIssueFine.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(199, 18);
            label6.Name = "label6";
            label6.Size = new Size(105, 19);
            label6.TabIndex = 14;
            label6.Text = "Сумма штрафа";
            // 
            // button3
            // 
            button3.Location = new Point(183, 71);
            button3.Name = "button3";
            button3.Size = new Size(150, 30);
            button3.TabIndex = 15;
            button3.Text = "Выписать штраф";
            button3.UseVisualStyleBackColor = true;
            button3.Click += btnIssueFine_Click;
            // 
            // button4
            // 
            button4.Location = new Point(363, 71);
            button4.Name = "button4";
            button4.Size = new Size(188, 30);
            button4.TabIndex = 16;
            button4.Text = "Продать автомобиль";
            button4.UseVisualStyleBackColor = true;
            button4.Click += btnSellCar_Click;
            // 
            // carNewOwner
            // 
            carNewOwner.Location = new Point(363, 39);
            carNewOwner.Name = "carNewOwner";
            carNewOwner.Size = new Size(188, 26);
            carNewOwner.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(396, 17);
            label7.Name = "label7";
            label7.Size = new Size(114, 19);
            label7.TabIndex = 18;
            label7.Text = "Новый владелец";
            // 
            // button5
            // 
            button5.Location = new Point(220, 412);
            button5.Name = "button5";
            button5.Size = new Size(188, 30);
            button5.TabIndex = 19;
            button5.Text = "Информация по машине";
            button5.UseVisualStyleBackColor = true;
            button5.Click += btnGetCarInfo_Click;
            // 
            // amountIssuePay
            // 
            amountIssuePay.Location = new Point(575, 40);
            amountIssuePay.Name = "amountIssuePay";
            amountIssuePay.Size = new Size(188, 30);
            amountIssuePay.TabIndex = 20;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(582, 17);
            label8.Name = "label8";
            label8.Size = new Size(181, 19);
            label8.TabIndex = 21;
            label8.Text = "Сумма для оплаты штрафа";
            // 
            // button6
            // 
            button6.Location = new Point(575, 72);
            button6.Name = "button6";
            button6.Size = new Size(188, 30);
            button6.TabIndex = 22;
            button6.Text = "Погасить сумму штрафа";
            button6.UseVisualStyleBackColor = true;
            button6.Click += btnPayFine_Click;
            // 
            // button7
            // 
            button7.Location = new Point(428, 412);
            button7.Name = "button7";
            button7.Size = new Size(200, 30);
            button7.TabIndex = 23;
            button7.Text = "Информация о владельце";
            button7.UseVisualStyleBackColor = true;
            button7.Click += btnGetOwnerInfo_Click;
            // 
            // newYeartTech
            // 
            newYeartTech.Location = new Point(245, 273);
            newYeartTech.Name = "newYeartTech";
            newYeartTech.Size = new Size(146, 30);
            newYeartTech.TabIndex = 24;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(266, 251);
            label9.Name = "label9";
            label9.Size = new Size(111, 19);
            label9.TabIndex = 25;
            label9.Text = "Год тех.осмотра";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label9);
            Controls.Add(newYeartTech);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(label8);
            Controls.Add(amountIssuePay);
            Controls.Add(button5);
            Controls.Add(label7);
            Controls.Add(carNewOwner);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(label6);
            Controls.Add(carIssueFine);
            Controls.Add(button2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(carOwner);
            Controls.Add(carInspectionYear);
            Controls.Add(carYear);
            Controls.Add(carModel);
            Controls.Add(carBrand);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox carBrand;
        private TextBox carModel;
        private TextBox carYear;
        private TextBox carInspectionYear;
        private TextBox carOwner;
        private Button button1;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button2;
        private TextBox carIssueFine;
        private Label label6;
        private Button button3;
        private Button button4;
        private TextBox carNewOwner;
        private Label label7;
        private Button button5;
        private TextBox amountIssuePay;
        private Label label8;
        private Button button6;
        private Button button7;
        private TextBox newYeartTech;
        private Label label9;
    }
}

