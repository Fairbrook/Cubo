using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpMatrices;
using OpMatrices.Types;
using OpMatrices.Proceso;

namespace Cubo
{
    public partial class Form1 : Form
    {
        private Matriz<double>[] puntos;
        private Matriz<double> zoom;
        private Matriz<double> PP;
        private Matriz<double> x;
        private Matriz<double> y;
        private Matriz<double> z;

        int usrZoom;
        double usrX;
        double usrY;
        double usrZ;
        int usrPosY;
        int usrPosX;
        int usrPosZ;
        private double[,] aux;
        public Form1()
        {
            usrZoom = 10;
            usrPosY = 250;
            usrPosX = 260;
            usrPosZ = 0;
            usrX = 100;
            usrY = 30;
            usrZ = 0;
            puntos = new Matriz<double>[16];
            zoom = new Matriz<double>();
            x = new Matriz<double>();
            y = new Matriz<double>();
            z = new Matriz<double>();
            PP = new Matriz<double>();

            aux = new double[4, 4];
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (i == j) aux[i, j] = 1;
                    else aux[i, j] = 0;
                }
            }

            aux[0, 3] = 10;
            aux[1, 3] = 0;
            aux[2, 3] = 0;
            puntos[0] = new Matriz<double>();
            puntos[0].setMatriz(4, 4, aux);

            aux[0, 3] = 0;
            aux[1, 3] = 10;
            aux[2, 3] = 0;
            puntos[1] = new Matriz<double>();
            puntos[1].setMatriz(4, 4, aux);

            aux[0, 3] = -10;
            aux[1, 3] = 0;
            aux[2, 3] = 0;
            puntos[2] = new Matriz<double>();
            puntos[2].setMatriz(4, 4, aux);

            aux[0, 3] = 0;
            aux[1, 3] = 0;
            aux[2, 3] = 10;
            puntos[3] = new Matriz<double>();
            puntos[3].setMatriz(4, 4, aux);

            aux[0, 3] = 0;
            aux[1, 3] = -10;
            aux[2, 3] = 0;
            puntos[4] = new Matriz<double>();
            puntos[4].setMatriz(4, 4, aux);

            aux[0, 3] = 10;
            aux[1, 3] = 0;
            aux[2, 3] = 0;
            puntos[5] = new Matriz<double>();
            puntos[5].setMatriz(4, 4, aux);

            aux[0, 3] = 0;
            aux[1, 3] = 0;
            aux[2, 3] = -10;
            puntos[6] = new Matriz<double>();
            puntos[6].setMatriz(4, 4, aux);

            aux[0, 3] = 0;
            aux[1, 3] = 10;
            aux[2, 3] = 0;
            puntos[7] = new Matriz<double>();
            puntos[7].setMatriz(4, 4, aux);

            aux[0, 3] = 0;
            aux[1, 3] = 0;
            aux[2, 3] = 10;
            puntos[8] = new Matriz<double>();
            puntos[8].setMatriz(4, 4, aux);

            aux[0, 3] = -10;
            aux[1, 3] = 0;
            aux[2, 3] = 0;
            puntos[9] = new Matriz<double>();
            puntos[9].setMatriz(4, 4, aux);

            aux[0, 3] = 0;
            aux[1, 3] = -10;
            aux[2, 3] = 0;
            puntos[10] = new Matriz<double>();
            puntos[10].setMatriz(4, 4, aux);

            aux[0, 3] = 0;
            aux[1, 3] = 0;
            aux[2, 3] = -10;
            puntos[11] = new Matriz<double>();
            puntos[11].setMatriz(4, 4, aux);

            aux[0, 3] = 0;
            aux[1, 3] = 10;
            aux[2, 3] = 0;
            puntos[12] = new Matriz<double>();
            puntos[12].setMatriz(4, 4, aux);

            aux[0, 3] = 0;
            aux[1, 3] = 0;
            aux[2, 3] = 10;
            puntos[13] = new Matriz<double>();
            puntos[13].setMatriz(4, 4, aux);

            aux[0, 3] = 10;
            aux[1, 3] = 0;
            aux[2, 3] = 0;
            puntos[14] = new Matriz<double>();
            puntos[14].setMatriz(4, 4, aux);

            aux[0, 3] = 0;
            aux[1, 3] = -10;
            aux[2, 3] = 0;
            puntos[15] = new Matriz<double>();
            puntos[15].setMatriz(4, 4, aux);

            InitializeComponent();
        }

        private void pivote()
        {
            aux = new double[4, 4];
            lblRotateX.Text = usrX.ToString();
            lblRotateY.Text = usrY.ToString();
            lblRotateZ.Text = usrZ.ToString();
            lblZoom.Text = usrZoom.ToString();
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (i == j) aux[i, j] = 1;
                    else aux[i, j] = 0;
                }
            }

            aux[0, 3] = usrPosX;
            aux[1, 3] = usrPosY;
            aux[2, 3] = usrPosZ;
            PP.setMatriz(4, 4, aux);

            aux[0, 3] = 0;
            aux[1, 3] = 0;
            aux[2, 3] = 0;
            aux[0, 0] = usrZoom;
            aux[1, 1] = usrZoom;
            aux[2, 2] = usrZoom;
            zoom.setMatriz(4, 4, aux);

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    aux[i, j] = 0;
                }
            }
            aux[0, 0] = 1;
            aux[3, 3] = 1;
            aux[1, 1] = Math.Cos(usrX * (Math.PI / 180));
            aux[1, 2] = (Math.Sin(usrX * (Math.PI / 180)) * -1);
            aux[2, 1] = Math.Sin(usrX * (Math.PI / 180));
            aux[2, 2] = Math.Cos(usrX * (Math.PI / 180));
            x.setMatriz(4, 4, aux);

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    aux[i, j] = 0;
                }
            }
            aux[1, 1] = 1;
            aux[3, 3] = 1;
            aux[0, 0] = Math.Cos(usrY * (Math.PI / 180));
            aux[0, 2] = Math.Sin(usrY * (Math.PI / 180));
            aux[2, 0] = (Math.Sin(usrY * (Math.PI / 180)) * -1);
            aux[2, 2] = Math.Cos(usrY * (Math.PI / 180));
            y.setMatriz(4, 4, aux);

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    aux[i, j] = 0;
                }
            }
            aux[2, 2] = 1;
            aux[3, 3] = 1;
            aux[0, 0] = Math.Cos(usrZ * (Math.PI / 180));
            aux[0, 1] = (Math.Sin(usrZ * (Math.PI / 180)) * -1);
            aux[1, 0] = Math.Sin(usrZ * (Math.PI / 180));
            aux[1, 1] = Math.Cos(usrZ * (Math.PI / 180));
            z.setMatriz(4, 4, aux);
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            double x1, y1, x2, y2;
            Matriz<double> pos;
            pivote();
            pos = Operaciones.mult(PP, z);
            pos = Operaciones.mult(pos, y);
            pos = Operaciones.mult(pos, x);
            pos = Operaciones.mult(pos, zoom);
            x1 = pos.getItem(0, 3) - (Math.Cos(30) * pos.getItem(2, 3));
            y1 = pos.getItem(1, 3) - (Math.Sin(30) * pos.getItem(2, 3));
            pos = Operaciones.mult(pos, puntos[0]);
            for (int i = 1; i < 16; i++)
            {
                x2 = pos.getItem(0, 3) - (Math.Cos(30) * pos.getItem(2, 3));
                y2 = pos.getItem(1, 3) - (Math.Sin(30) * pos.getItem(2, 3));
                e.Graphics.DrawLine(Pens.IndianRed, Convert.ToInt32(x1), Convert.ToInt32(y1), Convert.ToInt32(x2), Convert.ToInt32(y2));
                pos = Operaciones.mult(pos, puntos[i]);
                x1 = x2;
                y1 = y2;
            }
            x2 = pos.getItem(0, 3) - (Math.Cos(30) * pos.getItem(2, 3));
            y2 = pos.getItem(1, 3) - (Math.Sin(30) * pos.getItem(2, 3));
            e.Graphics.DrawLine(Pens.IndianRed, Convert.ToInt32(x1), Convert.ToInt32(y1), Convert.ToInt32(x2), Convert.ToInt32(y2));
        }

        private void acercar_Click(object sender, EventArgs e)
        {
            usrZoom += 1;
            this.Refresh();
        }

        private void alejar_Click(object sender, EventArgs e)
        {
            if (usrZoom > 1) usrZoom -= 1;
            this.Refresh();
        }

        private void btnRotateX_Click(object sender, EventArgs e)
        {
            if (usrX < 360) usrX += 10;
            else usrX = 0;
            this.Refresh();
        }

        private void btnRotateY_Click(object sender, EventArgs e)
        {
            if (usrY < 360) usrY += 10;
            else usrY = 0;
            this.Refresh();
        }

        private void btnRotateZ_Click(object sender, EventArgs e)
        {
            if (usrZ < 360) usrZ += 10;
            else usrZ = 0;
            this.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (usrPosY > 50) usrPosY -= 50;
            this.Refresh();
        }

        private void btnAbajo_Click(object sender, EventArgs e)
        {
            usrPosY += 50;
            this.Refresh();
        }

        private void btnIzq_Click(object sender, EventArgs e)
        {
            if (usrPosX > 50) usrPosX -= 50;
            this.Refresh();
        }

        private void btnDer_Click(object sender, EventArgs e)
        {
            usrPosX += 50;
            this.Refresh();
        }

        private void btnFrente_Click(object sender, EventArgs e)
        {
            usrPosZ+=50;
            this.Refresh();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            if (usrPosZ > 1) usrPosZ-=50;
            this.Refresh();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            usrZoom = 10;
            usrPosY = 250;
            usrPosX = 260;
            usrPosZ = 0;
            usrX = 100;
            usrY = 30;
            usrZ = 0;
            this.Refresh();
        }


    }
}
