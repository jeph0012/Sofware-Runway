using System;
using System.Windows.Forms;

namespace TuProyecto
{
    public partial class Form1 : Form
    {
        // Declarar variables para cada dato
        private int dato1, dato2, dato3, dato4, dato5, dato6, dato7, dato8, dato9, dato10;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            // Leer cada dato desde los cuadros de texto
            dato1 = Convert.ToInt32(txtDato1.Text);
            dato2 = Convert.ToInt32(txtDato2.Text);
            dato3 = Convert.ToInt32(txtDato3.Text);
            dato4 = Convert.ToInt32(txtDato4.Text);
            dato5 = Convert.ToInt32(txtDato5.Text);
            dato6 = Convert.ToInt32(txtDato6.Text);
            dato7 = Convert.ToInt32(txtDato7.Text);
            dato8 = Convert.ToInt32(txtDato8.Text);
            dato9 = Convert.ToInt32(txtDato9.Text);
            dato10 = Convert.ToInt32(txtDato10.Text);

            // Mostrar los datos ingresados
            MessageBox.Show($"Datos ingresados:\n\n" +
                            $"Dato 1: {dato1}\n" +
                            $"Dato 2: {dato2}\n" +
                            $"Dato 3: {dato3}\n" +
                            $"Dato 4: {dato4}\n" +
                            $"Dato 5: {dato5}\n" +
                            $"Dato 6: {dato6}\n" +
                            $"Dato 7: {dato7}\n" +
                            $"Dato 8: {dato8}\n" +
                            $"Dato 9: {dato9}\n" +
                            $"Dato 10: {dato10}");
        }
    }
}
