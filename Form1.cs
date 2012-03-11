using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ondas
{

    public partial class Form1 : Form
    {
        
        Single dx, dy; //Desplazamiento del origen
        int amplitud; //Alto y ancho del rectangulo que encierra al circulo
        int altura; //Mitad del alto total
        int numCurvas;

        int xSegmento, ySegmento;
        double radianes; //Radianes que el segmento ha girado
        Pen lapiz;
        Pen lapizSegmento;
        Pen lapizAltura;
        Rectangle rectangulo; //Encierra al circulo
        Modulacion.CreadorCurvas creador = new Modulacion.CreadorCurvas();
        const int ANCHO_LAPIZ = 2;
        public Form1()
        {
            
            InitializeComponent();
        
            dx = 150;
            dy = 150;
            
            lapiz = new Pen(Color.Blue, ANCHO_LAPIZ);
            lapizSegmento = new Pen(Color.Red, ANCHO_LAPIZ);
            lapizAltura = new Pen(Brushes.Black);
            redibujar();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        //Dibuja el semento que gira alrededor del centro
        void dibujarSegmento(Graphics g)
        {
            int grados = Convert.ToInt32(360-numGrados.Value);
            radianes = grados * 2 * Math.PI / 360;
            double radsTransformados = (2 * Math.PI) - radianes;
            xSegmento= Convert.ToInt32(  (altura* Math.Cos(radianes)));
            ySegmento =Convert.ToInt32(  (altura * Math.Sin(radianes)));
            g.DrawLine(lapizSegmento, 0, 0, xSegmento, ySegmento);

            g.DrawLine(lapizAltura, xSegmento, ySegmento, 0, ySegmento);
            txtRadianes.Text = radsTransformados.ToString();
            txtX.Text = xSegmento.ToString();
            txtY.Text = ySegmento.ToString();

            g.DrawEllipse(lapiz, xSegmento - 5, ySegmento - 5, 5, 5);
            g.DrawEllipse(lapiz, -5, ySegmento - 5, 5, 5);

            
        }
        
        void dibujarCurva(Graphics g)
        {
            int ultimoX;
            float rads = (float)radianes;
            PointF[] puntos;
            float radsIniciales = (float)(((Math.PI) * 2) - rads);
            puntos=creador.crearCurva(altura,radsIniciales, 1, 0, 100, out ultimoX);
            //puntos = creador.simetriaAltura(-altura, puntos);
            ultimoX--;
            g.DrawCurve(lapizSegmento, puntos);
            for (int i = 2; i <= numCurvas; i++)
            {
                puntos = creador.crearCurva(altura, radsIniciales, 1, ultimoX, 100, out ultimoX);
                ultimoX--;
                g.DrawCurve(lapizSegmento, puntos);
            }
        }

        void dibujarCruz(Graphics g)
        {
            g.DrawLine(lapiz, 0, -altura, 0, altura);
            g.DrawLine(lapiz, - altura, 0,  altura,0);
        }
        private void redibujar()
        {
            amplitud = Convert.ToInt32(numAmplitud.Value);
            altura = amplitud / 2;
            


            rectangulo = new Rectangle(-(amplitud/2), -(amplitud/2), amplitud, amplitud);
            
            /*
             * Añadido para gestionar el doble buffer
             * 
             * 
             */
            

            Bitmap buffer = new Bitmap(panelDibujo.Width, panelDibujo.Height);
            Graphics g = Graphics.FromImage(buffer);

            g.Clear(Color.White) ;
            g.TranslateTransform(dx, dy);
            g.DrawEllipse(lapiz, rectangulo);
            dibujarCruz(g);
            dibujarSegmento(g);
            dibujarCurva(g);

            //Una vez hechos los dibujos se vuelva la imagen
            //en el panel de dibujo y asi se evita el parpadeo.
            panelDibujo.CreateGraphics().DrawImageUnscaled(buffer, 0, 0);
        }
        private void panelDibujo_Paint(object sender, PaintEventArgs e)
        {
            redibujar();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            redibujar();
        }

        private void numGrados_ValueChanged(object sender, EventArgs e)
        {
            if (numGrados.Value == numGrados.Maximum) numGrados.Value = numGrados.Minimum+1;
            if (numGrados.Value == numGrados.Minimum) numGrados.Value = numGrados.Maximum - 1;
            redibujar();
        }

        private void panelDibujo_MouseDown(object sender, MouseEventArgs e)
        {
           
        }

        private void numericUpDown1_ValueChanged_1(object sender, EventArgs e)
        {
            numCurvas = Convert.ToInt32(numNumCurvas.Value);
            redibujar();
        }
    }
}
