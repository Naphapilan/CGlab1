using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CGlab01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            System.Drawing.Graphics myGraphic;
            myGraphic = this.CreateGraphics();

            Pen myPen1 = new Pen(System.Drawing.Color.Green, 5);
            Pen myPen2 = new Pen(System.Drawing.Color.Brown, 5);
            Pen myPen3 = new Pen(System.Drawing.Color.Black, 5);
            Pen myPen4 = new Pen(System.Drawing.Color.Red, 5);
            Pen myPen5 = new Pen(System.Drawing.Color.Yellow, 5);
            Pen myPen6 = new Pen(System.Drawing.Color.Magenta, 5);
            Pen myPen7 = new Pen(System.Drawing.Color.OrangeRed, 5);
            Pen myPen8 = new Pen(System.Drawing.Color.Gray, 5);
            Pen myPen9 = new Pen(System.Drawing.Color.Gold, 5);
            /*myGraphic.DrawLine(myPen1, 250, 350, 400, 50); //จุดเริ่ม จุดสิ้นสุด 
            myGraphic.DrawRectangle(myPen1, 215, 50, 370, 10); //จุดมุมบนซ้าย ความกว้าง ความสูงของสี่เหลี่ยม
            myGraphic.DrawEllipse(myPen2, 15, 35, 170, 140); //จุดมุมบนซ้าย ความกว้าง ความสูงของกรอบสี่เหลี่ยม
            myGraphic.DrawArc(myPen1, 100, 100, 450, 450, 0, 45); //จุดมุมบนซ้าย ความกว้าง ความสูง องศาเริ่ม องศาสิ้นสุด ตามเข็ม*/
            //christmas tree
            myGraphic.DrawRectangle(myPen2, 75, 400, 50, 50);
            myGraphic.DrawLine(myPen1, 50, 300, 100, 250);
            myGraphic.DrawLine(myPen1, 100, 250, 150, 300);
            myGraphic.DrawLine(myPen1, 50, 300, 75, 300);
            myGraphic.DrawLine(myPen1, 150, 300, 125, 300);
            myGraphic.DrawLine(myPen1, 75, 300, 35, 350);
            myGraphic.DrawLine(myPen1, 125, 300, 160, 350);
            myGraphic.DrawLine(myPen1, 35, 350, 55, 350);
            myGraphic.DrawLine(myPen1, 160, 350, 135, 350);
            myGraphic.DrawLine(myPen1, 55, 350, 25, 400);
            myGraphic.DrawLine(myPen1, 135, 350, 170, 400);
            myGraphic.DrawLine(myPen1, 25, 400, 170, 400);
            //gift box1
            myGraphic.DrawRectangle(myPen3, 550, 375, 75, 75);
            myGraphic.DrawRectangle(myPen3, 535, 355, 105, 20);
            myGraphic.DrawRectangle(myPen3, 575, 355, 25, 20);
            myGraphic.DrawRectangle(myPen3, 585, 375, 10, 75);
            //gift box2
            myGraphic.DrawRectangle(myPen3, 700, 375, 90, 75);
            myGraphic.DrawRectangle(myPen3, 740, 375, 10, 75);
            myGraphic.DrawLine(myPen3, 735, 365, 755, 365);
            myGraphic.DrawLine(myPen3, 735, 365, 735, 375);
            myGraphic.DrawLine(myPen3, 755, 365, 755, 375);
            myGraphic.DrawLine(myPen3, 735, 365, 720, 355);
            myGraphic.DrawLine(myPen3, 720, 355, 715, 375);
            myGraphic.DrawLine(myPen3, 755, 365, 770, 355);
            myGraphic.DrawLine(myPen3, 770, 355, 775, 375);
            //gift box3
            myGraphic.DrawLine(myPen3, 625, 425, 700, 425);
            myGraphic.DrawLine(myPen3, 605, 355, 605, 325);
            myGraphic.DrawLine(myPen3, 720, 355, 720, 325);
            myGraphic.DrawLine(myPen3, 605, 325, 720, 325);
            myGraphic.DrawRectangle(myPen3, 655, 325, 15, 100);
            myGraphic.DrawLine(myPen3, 650, 315, 675, 315);
            myGraphic.DrawLine(myPen3, 650, 315, 650, 325);
            myGraphic.DrawLine(myPen3, 675, 315, 675, 325);
            myGraphic.DrawLine(myPen3, 650, 315, 635, 300);
            myGraphic.DrawLine(myPen3, 635, 300, 630, 325);
            myGraphic.DrawLine(myPen3, 675, 315, 690, 300);
            myGraphic.DrawLine(myPen3, 690, 300, 695, 325);
            //balloon
            myGraphic.DrawEllipse(myPen9, 635, 150, 55, 75);
            myGraphic.DrawArc(myPen7, 540, 150, 55, 75, 225, 360);
            myGraphic.DrawArc(myPen8, 735, 150, 55, 75, 225, 360);
            myGraphic.DrawLine(myPen3, 662, 315, 662, 240);
            myGraphic.DrawLine(myPen9, 655, 240, 669, 240);
            myGraphic.DrawLine(myPen9, 655, 240, 660, 225);
            myGraphic.DrawLine(myPen9, 669, 240, 664, 225);
            myGraphic.DrawLine(myPen3, 630, 315, 580, 240);
            myGraphic.DrawLine(myPen7, 575, 245, 585, 235);
            myGraphic.DrawLine(myPen7, 575, 245, 575, 225);
            myGraphic.DrawLine(myPen7, 585, 235, 575, 225);
            myGraphic.DrawLine(myPen3, 695, 315, 745, 240);
            myGraphic.DrawLine(myPen8, 750, 245, 740, 235);
            myGraphic.DrawLine(myPen8, 750, 245, 755, 225);
            myGraphic.DrawLine(myPen8, 740, 235, 755, 225);
            //H
            myGraphic.DrawLine(myPen3, 125, 50, 125, 100);
            myGraphic.DrawLine(myPen3, 135, 50, 135, 70);
            myGraphic.DrawLine(myPen3, 135, 80, 135, 100);
            myGraphic.DrawLine(myPen3, 125, 50, 135, 50);
            myGraphic.DrawLine(myPen3, 125, 100, 135, 100);
            myGraphic.DrawLine(myPen3, 135, 70, 155, 70);
            myGraphic.DrawLine(myPen3, 135, 80, 155, 80);
            myGraphic.DrawLine(myPen3, 155, 50, 155, 70);
            myGraphic.DrawLine(myPen3, 155, 80, 155, 100);
            myGraphic.DrawLine(myPen3, 165, 50, 165, 100);
            myGraphic.DrawLine(myPen3, 155, 50, 165, 50);
            myGraphic.DrawLine(myPen3, 155, 100, 165, 100);
            //A
            myGraphic.DrawLine(myPen3, 175, 100, 185, 50);
            myGraphic.DrawLine(myPen3, 185, 50, 195, 50);
            myGraphic.DrawLine(myPen3, 195, 50, 205, 100);
            myGraphic.DrawLine(myPen3, 175, 100, 185, 100);
            myGraphic.DrawLine(myPen3, 195, 100, 205, 100);
            myGraphic.DrawLine(myPen3, 190, 80, 195, 100);
            myGraphic.DrawLine(myPen3, 190, 80, 185, 100);
            myGraphic.DrawLine(myPen3, 192, 65, 190, 70);
            //P
            myGraphic.DrawLine(myPen3, 215, 100, 215, 50);
            myGraphic.DrawLine(myPen3, 215, 50, 225, 50);
            myGraphic.DrawLine(myPen3, 215, 100, 225, 100);
            myGraphic.DrawLine(myPen3, 225, 100, 225, 80);
            myGraphic.DrawArc(myPen3, 225, 50, 20, 30, 270, 180);
            myGraphic.DrawLine(myPen3, 225, 50, 240, 50);
            myGraphic.DrawLine(myPen3, 225, 80, 240, 80);
            myGraphic.DrawLine(myPen3, 225, 60, 235, 65);
            myGraphic.DrawLine(myPen3, 225, 70, 235, 65);
            myGraphic.DrawLine(myPen3, 225, 60, 225, 70);
            //P
            myGraphic.DrawLine(myPen3, 255, 100, 255, 50);
            myGraphic.DrawLine(myPen3, 255, 50, 265, 50);
            myGraphic.DrawLine(myPen3, 255, 100, 265, 100);
            myGraphic.DrawLine(myPen3, 265, 100, 265, 80);
            myGraphic.DrawArc(myPen3, 265, 50, 20, 30, 270, 180);
            myGraphic.DrawLine(myPen3, 265, 50, 280, 50);
            myGraphic.DrawLine(myPen3, 265, 80, 280, 80);
            myGraphic.DrawLine(myPen3, 265, 60, 275, 65);
            myGraphic.DrawLine(myPen3, 265, 70, 275, 65);
            myGraphic.DrawLine(myPen3, 265, 60, 265, 70);
            //Y
            myGraphic.DrawLine(myPen3, 290, 50, 300, 50);
            myGraphic.DrawLine(myPen3, 290, 50, 300, 80);
            myGraphic.DrawLine(myPen3, 300, 80, 300, 100);
            myGraphic.DrawLine(myPen3, 310, 80, 310, 100);
            myGraphic.DrawLine(myPen3, 300, 100, 310, 100);
            myGraphic.DrawLine(myPen3, 300, 50, 305, 70);
            myGraphic.DrawLine(myPen3, 310, 50, 305, 70);
            myGraphic.DrawLine(myPen3, 310, 50, 320, 50);
            myGraphic.DrawLine(myPen3, 320, 50, 310, 80);
            //N
            myGraphic.DrawLine(myPen3, 135, 150, 135, 200);
            myGraphic.DrawLine(myPen3, 145, 170, 145, 200);
            myGraphic.DrawLine(myPen3, 135, 150, 145, 150);
            myGraphic.DrawLine(myPen3, 135, 200, 145, 200);
            myGraphic.DrawLine(myPen3, 145, 170, 155, 200);
            myGraphic.DrawLine(myPen3, 145, 150, 155, 170);
            myGraphic.DrawLine(myPen3, 155, 150, 155, 170);
            myGraphic.DrawLine(myPen3, 155, 150, 165, 150);
            myGraphic.DrawLine(myPen3, 155, 200, 165, 200);
            myGraphic.DrawLine(myPen3, 165, 150, 165, 200);
            //E
            myGraphic.DrawLine(myPen3, 175, 150, 175, 200);
            myGraphic.DrawLine(myPen3, 175, 150, 205, 150);
            myGraphic.DrawLine(myPen3, 175, 200, 205, 200);
            myGraphic.DrawLine(myPen3, 205, 150, 205, 160);
            myGraphic.DrawLine(myPen3, 205, 160, 185, 160);
            myGraphic.DrawLine(myPen3, 185, 160, 185, 170);
            myGraphic.DrawLine(myPen3, 205, 170, 185, 170);
            myGraphic.DrawLine(myPen3, 205, 170, 205, 180);
            myGraphic.DrawLine(myPen3, 205, 180, 185, 180);
            myGraphic.DrawLine(myPen3, 185, 180, 185, 190);
            myGraphic.DrawLine(myPen3, 185, 190, 205, 190);
            myGraphic.DrawLine(myPen3, 205, 190, 205, 200);
            //W
            myGraphic.DrawLine(myPen3, 215, 150, 225, 200);
            myGraphic.DrawLine(myPen3, 215, 150, 225, 150);
            myGraphic.DrawLine(myPen3, 225, 150, 230, 170);
            myGraphic.DrawLine(myPen3, 225, 200, 235, 200);
            myGraphic.DrawLine(myPen3, 235, 200, 240, 180);
            myGraphic.DrawLine(myPen3, 240, 180, 245, 200);
            myGraphic.DrawLine(myPen3, 245, 200, 255, 200);
            myGraphic.DrawLine(myPen3, 255, 200, 265, 150);
            myGraphic.DrawLine(myPen3, 265, 150, 255, 150);
            myGraphic.DrawLine(myPen3, 255, 150, 250, 170);
            myGraphic.DrawLine(myPen3, 240, 150, 250, 170);
            myGraphic.DrawLine(myPen3, 230, 170, 240, 150);

            //Y
            myGraphic.DrawLine(myPen3, 275, 150, 285, 150);
            myGraphic.DrawLine(myPen3, 275, 150, 285, 180);
            myGraphic.DrawLine(myPen3, 285, 180, 285, 200);
            myGraphic.DrawLine(myPen3, 295, 180, 295, 200);
            myGraphic.DrawLine(myPen3, 285, 200, 295, 200);
            myGraphic.DrawLine(myPen3, 285, 150, 290, 170);
            myGraphic.DrawLine(myPen3, 295, 150, 290, 170);
            myGraphic.DrawLine(myPen3, 295, 150, 305, 150);
            myGraphic.DrawLine(myPen3, 305, 150, 295, 180);
            //E
            myGraphic.DrawLine(myPen3, 315, 150, 315, 200);
            myGraphic.DrawLine(myPen3, 315, 150, 345, 150);
            myGraphic.DrawLine(myPen3, 315, 200, 345, 200);
            myGraphic.DrawLine(myPen3, 345, 150, 345, 160);
            myGraphic.DrawLine(myPen3, 345, 160, 325, 160);
            myGraphic.DrawLine(myPen3, 325, 160, 325, 170);
            myGraphic.DrawLine(myPen3, 345, 170, 325, 170);
            myGraphic.DrawLine(myPen3, 345, 170, 345, 180);
            myGraphic.DrawLine(myPen3, 345, 180, 325, 180);
            myGraphic.DrawLine(myPen3, 325, 180, 325, 190);
            myGraphic.DrawLine(myPen3, 325, 190, 345, 190);
            myGraphic.DrawLine(myPen3, 345, 190, 345, 200);
            //A
            myGraphic.DrawLine(myPen3, 355, 200, 365, 150);
            myGraphic.DrawLine(myPen3, 365, 150, 375, 150);
            myGraphic.DrawLine(myPen3, 375, 150, 385, 200);
            myGraphic.DrawLine(myPen3, 355, 200, 365, 200);
            myGraphic.DrawLine(myPen3, 375, 200, 385, 200);
            myGraphic.DrawLine(myPen3, 370, 180, 375, 200);
            myGraphic.DrawLine(myPen3, 370, 180, 365, 200);
            myGraphic.DrawLine(myPen3, 372, 165, 370, 170);
            //R
            myGraphic.DrawLine(myPen3, 395, 200, 395, 150);
            myGraphic.DrawLine(myPen3, 395, 150, 405, 150);
            myGraphic.DrawLine(myPen3, 395, 200, 405, 200);
            myGraphic.DrawLine(myPen3, 405, 200, 405, 180);
            myGraphic.DrawArc(myPen3, 405, 150, 20, 30, 270, 180);
            myGraphic.DrawLine(myPen3, 405, 150, 415, 150);
            //myGraphic.DrawLine(myPen3, 305, 180, 315, 180);
            myGraphic.DrawLine(myPen3, 405, 180, 415, 200);
            myGraphic.DrawLine(myPen3, 415, 200, 425, 200);
            myGraphic.DrawLine(myPen3, 415, 180, 425, 200);
            myGraphic.DrawLine(myPen3, 405, 160, 415, 165);
            myGraphic.DrawLine(myPen3, 405, 170, 415, 165);
            myGraphic.DrawLine(myPen3, 405, 160, 405, 170);
            //fire
            myGraphic.DrawArc(myPen3, 0, 0, 200, 30, 0, 180);
            myGraphic.DrawArc(myPen3, 200, 0, 200, 30, 0, 180);
            myGraphic.DrawArc(myPen3, 400, 0, 200, 30, 0, 180);
            myGraphic.DrawArc(myPen3, 600, 0, 200, 30, 0, 180);
            myGraphic.DrawEllipse(myPen4, 15, 29, 5, 5);
            myGraphic.DrawEllipse(myPen1, 45, 32, 5, 5);
            myGraphic.DrawEllipse(myPen5, 75, 33, 5, 5);
            myGraphic.DrawEllipse(myPen6, 105, 33, 5, 5);
            myGraphic.DrawEllipse(myPen4, 135, 32, 5, 5);
            myGraphic.DrawEllipse(myPen1, 175, 29, 5, 5);
            myGraphic.DrawEllipse(myPen5, 205, 26, 5, 5);
            myGraphic.DrawEllipse(myPen6, 235, 32, 5, 5);
            myGraphic.DrawEllipse(myPen4, 265, 33, 5, 5);
            myGraphic.DrawEllipse(myPen1, 295, 33, 5, 5);
            myGraphic.DrawEllipse(myPen5, 325, 32, 5, 5);
            myGraphic.DrawEllipse(myPen6, 355, 32, 5, 5);
            myGraphic.DrawEllipse(myPen4, 385, 28, 5, 5);
            myGraphic.DrawEllipse(myPen1, 415, 29, 5, 5);
            myGraphic.DrawEllipse(myPen5, 445, 32, 5, 5);
            myGraphic.DrawEllipse(myPen6, 475, 33, 5, 5);
            myGraphic.DrawEllipse(myPen4, 505, 33, 5, 5);
            myGraphic.DrawEllipse(myPen1, 535, 32, 5, 5);
            myGraphic.DrawEllipse(myPen5, 575, 29, 5, 5);
            myGraphic.DrawEllipse(myPen6, 605, 26, 5, 5);
            myGraphic.DrawEllipse(myPen4, 635, 32, 5, 5);
            myGraphic.DrawEllipse(myPen1, 665, 33, 5, 5);
            myGraphic.DrawEllipse(myPen5, 695, 33, 5, 5);
            myGraphic.DrawEllipse(myPen6, 725, 32, 5, 5);
            myGraphic.DrawEllipse(myPen4, 755, 32, 5, 5);
            myGraphic.DrawEllipse(myPen5, 785, 28, 5, 5);
        }
    }
}
