namespace ejercicio_formulario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            //Declaracion de variables
            int valor1, valor2, Resta, Multiplicacion, División;
            //Entrada de datos
            valor1 = int.Parse(txt_Valor1.Text);
            valor2 = int.Parse(txt_Valor2.Text);
            Resta = int.Parse(txt_Resta.Text);
            Multiplicacion = int.Parse(txt_multiplicación.Text);
            División = int.Parse(txt_División.Text);


            //Proceso
            int resultado = valor1 + valor2;
            //Salida de datos
            txt_Resultado.Text = resultado.ToString();
        }
        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Listar_Click(object sender, EventArgs e)
        {

            txt_Valor1.Clear();
            txt_Valor2.Clear();
            txt_Resultado.Clear();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }


}