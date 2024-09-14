using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MonkeyTypeApp
{
    public partial class Form1 : Form
    {

        private Stopwatch stopwatch = new Stopwatch();
        private string texttotype;
        private int timeremaining = 15;  // Tiempo límite de 20 segundos
        private System.Windows.Forms.Timer countdowntimer = new System.Windows.Forms.Timer();  // Usa System.Windows.Forms.Timer
        private int score = 0;
        private bool gamestarted = false;

        public Form1()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;

            //Configuramos una cuenta regresiva
            countdowntimer.Interval = 1000;
            countdowntimer.Tick += timer1_Tick;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            try
            {
                string[] lines = File.ReadAllLines("D:/Proyectos/MonkeyTypeApp/ejemplosdetexto.txt");

                if (lines.Length == 0)
                {
                    MessageBox.Show("El archivo de texto esta vacio. ");
                    return;
                }

                //Seleccionar todas las palabras de todas las lineas
                string[] allwords = lines.SelectMany(line => line.Split(' ', StringSplitOptions.RemoveEmptyEntries)).ToArray();

                //Configuramos para seleccionar 15 palabras
                if (allwords.Length == 15)
                {
                    MessageBox.Show("No hay suficientes palabras en el archivo de texto. ");
                    return;
                }

                Random random = new Random();
                texttotype = string.Join(" ", allwords.OrderBy(x => random.Next()).Take(15)).Trim();

                texttotype = Regex.Replace(texttotype, @"\s+", " ");

                label3.Text = texttotype;

                score = 0;

                richTextBox1.Enabled = true;
                richTextBox1.Text = "";
                stopwatch.Restart();

                timeremaining = 15;
                updatetimelabel();

                iconButton1.Enabled = false;

                gamestarted = true;
            }

            catch (FileNotFoundException)
            {
                MessageBox.Show("Archivo no encontrado, asegure la ruta. ");
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrio un error: {ex.Message}");
            }
        }

        /*
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            if (gamestarted && !countdowntimer.Enabled)
            {
                countdowntimer.Start();
            }

            //Comprobar si el tiempo no ha llegado a cero
            if (timeremaining > 0)
            {

                //Comprobar palabras correctas
                calculatescore(textBox1.Text);

                if (textBox1.Text == texttotype)
                {
                    countdowntimer.Stop();
                    stopwatch.Stop();
                    MessageBox.Show($"Has terminado en {stopwatch.Elapsed.TotalSeconds} segundos.");
                    textBox1.Enabled = false;
                    iconButton1.Enabled = true;
                }
            }

        }
        */

        /*
        private void label4_Click(object sender, EventArgs e)
        {
        }
        */

        private void updatetimelabel()
        {
            label4.Text = $"Time left: {timeremaining}";
        }

        private void calculatescore(string userInput)
        {
            int correctLetters = 0;

            // Iterar sobre el texto ingresado por el usuario y el texto objetivo
            for (int i = 0; i < userInput.Length && i < texttotype.Length; i++)
            {
                if (userInput[i] == texttotype[i])
                {
                    correctLetters++;
                }
            }

            // Actualizar el puntaje (1 punto por cada letra correcta)
            score = correctLetters;
            label5.Text = $"Puntaje: {score}";

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeremaining--;
            updatetimelabel();

            //Si el tiempo llega a cero, detener el juego
            if (timeremaining <= 0)
            {
                countdowntimer.Stop();
                richTextBox1.Enabled = false;
                MessageBox.Show($"Tiempo agotado! Tu puntaje es: {score} de {texttotype.Length}");
                iconButton1.Enabled = true;
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (gamestarted && !countdowntimer.Enabled)
            {
                countdowntimer.Start();  // Iniciar el Timer
            }

            // Comprobar si el tiempo no ha llegado a 0
            if (timeremaining > 0)
            {
                // Marcar las letras correctas e incorrectas
                HighlightText(richTextBox1.Text);

                // Comprobar si el texto coincide completamente
                if (richTextBox1.Text == texttotype)
                {
                    countdowntimer.Stop();
                    stopwatch.Stop();
                    MessageBox.Show($"Has terminado en {stopwatch.Elapsed.TotalSeconds} segundos. ¡Puntaje final: {score}!");
                    richTextBox1.Enabled = false;
                    iconButton1.Enabled = true;
                }
            }
        }

        private void HighlightText(string userInput)
        {
            int correctletters = 0;

            //Desactivar temporalmente la actualizacion del control para mejorar el rendimiento
            richTextBox1.SuspendLayout();

            //Guardar la posicion actual del cursor
            int cursorposition = richTextBox1.SelectionStart;

            //Restablecer formato del texto
            richTextBox1.Select(0, richTextBox1.Text.Length);
            richTextBox1.SelectionColor = richTextBox1.ForeColor;

            //Iterar sobre el texto ingresado y el texto objetivo

            for (int i = 0; i < userInput.Length; i++)
            {
                richTextBox1.Select(i, 1); //Letra actual

                if (i < texttotype.Length && userInput[i] == texttotype[i])
                {
                    richTextBox1.SelectionColor = System.Drawing.Color.Blue; //Letra correcta
                    correctletters++;
                }
                else
                {
                    richTextBox1.SelectionColor = System.Drawing.Color.Red; //letra incorrecta
                }
            }

            score = correctletters;
            label5.Text = $"Puntaje: {score}";


            //restablecer posicion del cursor despues de colorear
            richTextBox1.SelectionStart = cursorposition;
            richTextBox1.SelectionLength = 0;

            richTextBox1.ResumeLayout();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
