namespace ejercicio_formulario
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
            txt_Valor1 = new Label();
            text_Resta = new Label();
            text_Multiplicación = new Label();
            text_División = new Label();
            txt_Valor2 = new Label();
            txt_Resultado = new Label();
            label7 = new Label();
            Txt_Resta = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            Txt_Multiplicación = new TextBox();
            Txt_División = new TextBox();
            btn_Calcular = new Button();
            btn_Listar = new Button();
            btn_Salir = new Button();
            textBox6 = new TextBox();
            SuspendLayout();
            // 
            // txt_Valor1
            // 
            txt_Valor1.AutoSize = true;
            txt_Valor1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Valor1.Location = new Point(44, 147);
            txt_Valor1.Name = "txt_Valor1";
            txt_Valor1.Size = new Size(58, 23);
            txt_Valor1.TabIndex = 0;
            txt_Valor1.Text = "Valor1";
            // 
            // text_Resta
            // 
            text_Resta.AutoSize = true;
            text_Resta.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            text_Resta.Location = new Point(44, 217);
            text_Resta.Name = "text_Resta";
            text_Resta.Size = new Size(51, 23);
            text_Resta.TabIndex = 1;
            text_Resta.Text = "Resta";
            // 
            // text_Multiplicación
            // 
            text_Multiplicación.AutoSize = true;
            text_Multiplicación.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            text_Multiplicación.Location = new Point(12, 277);
            text_Multiplicación.Name = "text_Multiplicación";
            text_Multiplicación.Size = new Size(116, 23);
            text_Multiplicación.TabIndex = 2;
            text_Multiplicación.Text = "Multiplicacion";
            // 
            // text_División
            // 
            text_División.AutoSize = true;
            text_División.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            text_División.Location = new Point(33, 347);
            text_División.Name = "text_División";
            text_División.Size = new Size(69, 23);
            text_División.TabIndex = 3;
            text_División.Text = "División";
            // 
            // txt_Valor2
            // 
            txt_Valor2.AutoSize = true;
            txt_Valor2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Valor2.Location = new Point(314, 140);
            txt_Valor2.Name = "txt_Valor2";
            txt_Valor2.Size = new Size(58, 23);
            txt_Valor2.TabIndex = 4;
            txt_Valor2.Text = "Valor2";
            // 
            // txt_Resultado
            // 
            txt_Resultado.AutoSize = true;
            txt_Resultado.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Resultado.Location = new Point(300, 383);
            txt_Resultado.Name = "txt_Resultado";
            txt_Resultado.Size = new Size(85, 23);
            txt_Resultado.TabIndex = 5;
            txt_Resultado.Text = "Resultado";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Edwardian Script ITC", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(248, 9);
            label7.Name = "label7";
            label7.Size = new Size(273, 71);
            label7.TabIndex = 6;
            label7.Text = " Calculadora";
            // 
            // Txt_Resta
            // 
            Txt_Resta.Location = new Point(125, 214);
            Txt_Resta.Name = "Txt_Resta";
            Txt_Resta.Size = new Size(125, 27);
            Txt_Resta.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(125, 140);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(396, 381);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(141, 27);
            textBox3.TabIndex = 9;
            // 
            // Txt_Multiplicación
            // 
            Txt_Multiplicación.Location = new Point(134, 273);
            Txt_Multiplicación.Name = "Txt_Multiplicación";
            Txt_Multiplicación.Size = new Size(125, 27);
            Txt_Multiplicación.TabIndex = 10;
            Txt_Multiplicación.TextChanged += textBox4_TextChanged;
            // 
            // Txt_División
            // 
            Txt_División.Location = new Point(125, 340);
            Txt_División.Name = "Txt_División";
            Txt_División.Size = new Size(125, 27);
            Txt_División.TabIndex = 11;
            // 
            // btn_Calcular
            // 
            btn_Calcular.BackColor = Color.AntiqueWhite;
            btn_Calcular.Location = new Point(610, 143);
            btn_Calcular.Name = "btn_Calcular";
            btn_Calcular.Size = new Size(107, 39);
            btn_Calcular.TabIndex = 12;
            btn_Calcular.Text = "Calcular";
            btn_Calcular.UseVisualStyleBackColor = false;
            btn_Calcular.Click += btn_Calcular_Click;
            // 
            // btn_Listar
            // 
            btn_Listar.BackColor = Color.AntiqueWhite;
            btn_Listar.Location = new Point(610, 230);
            btn_Listar.Name = "btn_Listar";
            btn_Listar.Size = new Size(107, 38);
            btn_Listar.TabIndex = 13;
            btn_Listar.Text = "Listar";
            btn_Listar.UseVisualStyleBackColor = false;
            btn_Listar.Click += btn_Listar_Click;
            // 
            // btn_Salir
            // 
            btn_Salir.BackColor = Color.AntiqueWhite;
            btn_Salir.Location = new Point(610, 308);
            btn_Salir.Name = "btn_Salir";
            btn_Salir.Size = new Size(107, 41);
            btn_Salir.TabIndex = 14;
            btn_Salir.Text = "Salir";
            btn_Salir.UseVisualStyleBackColor = false;
            btn_Salir.Click += btn_Salir_Click;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(382, 137);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(125, 27);
            textBox6.TabIndex = 15;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox6);
            Controls.Add(btn_Salir);
            Controls.Add(btn_Listar);
            Controls.Add(btn_Calcular);
            Controls.Add(Txt_División);
            Controls.Add(Txt_Multiplicación);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(Txt_Resta);
            Controls.Add(label7);
            Controls.Add(txt_Resultado);
            Controls.Add(txt_Valor2);
            Controls.Add(text_División);
            Controls.Add(text_Multiplicación);
            Controls.Add(text_Resta);
            Controls.Add(txt_Valor1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txt_Valor1;
        private Label text_Resta;
        private Label text_Multiplicación;
        private Label text_División;
        private Label txt_Valor2;
        private Label txt_Resultado;
        private Label label7;
        private TextBox Txt_Resta;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox Txt_Multiplicación;
        private TextBox Txt_División;
        private Button btn_Calcular;
        private Button btn_Listar;
        private Button btn_Salir;
        private TextBox textBox6;
    }
}