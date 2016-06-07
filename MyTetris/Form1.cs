using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyTetris
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
      
        public int[, , ,] brick = {{
                                      {
                                          {1,0,0,0},
                                          {1,0,0,0},
                                          {1,0,0,0},
                                          {1,0,0,0}
                                      },
                                      {
                                          {1,1,1,1},
                                          {0,0,0,0},
                                          {0,0,0,0},
                                          {0,0,0,0}
                                      },
                                      {
                                          {1,0,0,0},
                                          {1,0,0,0},
                                          {1,0,0,0},
                                          {1,0,0,0}
                                      },
                                      {
                                          {1,1,1,1},
                                          {0,0,0,0},
                                          {0,0,0,0},
                                          {0,0,0,0}
                                      }
                                  },
                                  {
                                       {
                                           {1,1,0,0},
                                           {1,1,0,0},
                                           {0,0,0,0},
                                           {0,0,0,0}
                                       },
                                       {
                                           {1,1,0,0},
                                           {1,1,0,0},
                                           {0,0,0,0},
                                           {0,0,0,0}
                                       },
                                       {
                                           {1,1,0,0},
                                           {1,1,0,0},
                                           {0,0,0,0},
                                           {0,0,0,0}
                                       },
                                       {
                                           {1,1,0,0},
                                           {1,1,0,0},
                                           {0,0,0,0},
                                           {0,0,0,0}
                                       }
                                   },
                                   {
                                       {
                                           {1,0,0,0},
                                           {1,1,0,0},
                                           {0,1,0,0},
                                           {0,0,0,0}
                                       },
                                       {
                                           {0,1,1,0},
                                           {1,1,0,0},
                                           {0,0,0,0},
                                           {0,0,0,0}
                                       },
                                       {
                                           {1,0,0,0},
                                           {1,1,0,0},
                                           {0,1,0,0},
                                           {0,0,0,0}
                                       },
                                       {
                                           {0,1,1,0},
                                           {1,1,0,0},
                                           {0,0,0,0},
                                           {0,0,0,0}
                                       }
                                   },
                                   {
                                       {
                                           {1,1,0,0},
                                           {0,1,0,0},
                                           {0,1,0,0},
                                           {0,0,0,0}
                                       },
                                       {
                                           {0,0,1,0},
                                           {1,1,1,0},
                                           {0,0,0,0},
                                           {0,0,0,0}
                                       },
                                       {
                                           {1,0,0,0},
                                           {1,0,0,0},
                                           {1,1,0,0},
                                           {0,0,0,0}
                                       },
                                       {
                                           {1,1,1,0},
                                           {1,0,0,0},
                                           {0,0,0,0},
                                           {0,0,0,0}
                                       }
                                   }};

        private int[,] backGround ={
                                     {0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                                     {0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                                     {0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                                     {0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                                     {0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                                     {0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                                     {0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                                     {0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                                     {0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                                     {0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                                     {0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                                     {0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                                     {0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                                     {0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                                     {0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                                     {0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                                     {0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                                     {0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                                     {0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                                     {0,0,0,0,0,0,0,0,0,0,0,0,0,0}
                                 };

        private int[,] currentBrick = new int[4, 4];

        public int[,] CurrentBrick
        {
            get { return currentBrick; }
            set { currentBrick = value; }
        }
        private int currentType;

        public int CurrentType
        {
            get { return currentType; }
            set { currentType = value; }
        }
        private int currentState;

        public int CurrentState
        {
            get { return currentState; }
            set { currentState = value; }
        }
        private int currentX, currentY, score;

        public int CurrentY
        {
            get { return currentY; }
            set { currentY = value; }
        }

        public int CurrentX
        {
            get { return currentX; }
            set { currentX = value; }
        }
        private Image image;
        private BrickFactory brickFactory;
       

        private void Form1_Load(object sender, EventArgs e)
        {
            image = new Bitmap(panel1.Width, panel1.Height);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Draw();
            base.OnPaint(e);
        }
        /// <summary>
        /// 开始游戏
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            for (int y = 0; y < 20; y++)
            {
                for (int x = 0; x < 14; x++)
                {
                   backGround[y, x] = 0;
                }
            }
            timer1.Interval = 1000;
            score = 0;

            brickFactory = new BrickFactory();
            brickFactory.CreateBrick(this);
            comboBox1.Enabled=false;
            timer1.Start(); 
            this.Focus();
        }
        /// <summary>
        /// 暂停游戏
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == "暂停游戏")
            {
                button2.Text = "继续游戏";
                timer1.Stop();
            }
            else
            {
                button2.Text = "暂停游戏";
                timer1.Start();
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Down();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                TransformBrick();
                Draw();
            }
            else if (e.KeyCode == Keys.A)
            {
                if (CheckIsLeft())
                {
                    currentX--;
                }
                Draw();
            }
            else if (e.KeyCode == Keys.D)
            {
                if (CheckIsRight())
                {
                    currentX++;
                }
                Draw();
            }
            else if (e.KeyCode == Keys.S)
            {
                timer1.Stop();
                timer1.Interval = 10;
                timer1.Start();
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.S)
            {
                timer1.Stop();
                timer1.Interval = 1000;
                timer1.Start();
            }
        }
        public void Down()
        {
            if (CheckIsDown())
            {
                currentY++;
            }
            else
            {
                if (currentY == 0)
                {
                    timer1.Stop();
                    MessageBox.Show("Game over!!  再来一局叭，婧婧在胜利的彼岸等着你喔~");
                    score = 0;
                    label1_Score.Text = (score / 10).ToString();
                    comboBox1.Enabled = true;
                    return;
                }

                for (int y = 0; y < 4; y++)
                {
                    for (int x = 0; x < 4; x++)
                    {
                        if (currentBrick[y, x] == 1)
                        {
                            backGround[currentY + y, currentX + x] = currentBrick[y, x];
                        }
                    }
                }
                CheckSore();
                brickFactory.CreateBrick(this);
                timer1.Start(); 
            }
            Draw();
        }

        /// <summary>
        /// 检测是否到底底部
        /// </summary>
        /// <returns></returns>
        private bool CheckIsDown()
        {
            for (int y = 0; y < 4; y++)
            {
                for (int x = 0; x < 4; x++)
                {
                    if (currentBrick[y, x] == 1)
                    {
                        if (y + currentY + 1 >= 20)
                        {
                            return false;
                        }
                        if (x + currentX >= 14)
                        {
                            currentX = 13 - x;
                        }
                        if (backGround[y + currentY + 1, x + currentX] == 1)
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }
        /// <summary>
        /// 检测是否到达左端
        /// </summary>
        /// <returns></returns>
        private bool CheckIsLeft()
        {
            for (int y = 0; y < 4; y++)
            {
                for (int x = 0; x < 4; x++)
                {
                    if (currentBrick[y, x] == 1)
                    {
                        if (x + currentX - 1 < 0)
                        {
                            return false;
                        }
                        if (backGround[y + currentY, x + currentX - 1] == 1)
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }
        /// <summary>
        /// 检测是否可以右移
        /// </summary>
        /// <returns></returns>
        private bool CheckIsRight()
        {
            for (int y = 0; y < 4; y++)
            {
                for (int x = 0; x < 4; x++)
                {
                    if (currentBrick[y, x] == 1)
                    {
                        if (x + currentX + 1 >= 14)
                        {
                            return false;
                        }
                        if (backGround[y + currentY, x + currentX + 1] == 1)
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }

        private void CheckSore()
        {
            for (int y = 19; y > -1; y--)
            {
                bool isFull = true;
                for (int x = 13; x > -1; x--)
                {
                    if (backGround[y, x] == 0)
                    {
                        isFull = false;
                        break;
                    }
                }
                if (isFull)
                {
                    score = score + 100;
                    this.label1_Score.Text = (score/10).ToString();
                    for (int yy = y; yy > 0; yy--)
                    {
                        for (int xx = 0; xx < 14; xx++)
                        {
                            int temp = backGround[yy - 1, xx];
                            backGround[yy, xx] = temp;
                        }
                    }
                    y++;
                    if (comboBox1.SelectedIndex == 0)
                    {
                        if (score > 400)
                        {
                            timer1.Stop();
                            timer1.Interval = 1000;
                            
                            MessageBox.Show("你胜利了!!");
                            for (int x = 0; x < 14; x++)
                            {
                                for (int k = 0; k < 20; k++)
                                    backGround[k, x] = 0;
                            }
                            score = 0;
                            this.label1_Score.Text = (score / 10).ToString();
                            return;
                        }
                    }
                    else if (comboBox1.SelectedIndex == 1)
                    {
                        if (score > 900)
                        {
                            timer1.Stop();
                            timer1.Interval = 1000;
                            
                            MessageBox.Show("你胜利了!!");
                            for (int x = 0; x < 14; x++)
                            {
                                for (int k = 0; k < 20; k++)
                                    backGround[k, x] = 0;
                            }
                            score = 0;
                            this.label1_Score.Text = (score / 10).ToString();
                            return;
                        }
                    }
                    else if (comboBox1.SelectedIndex == 2)
                    {
                        if (score > 4900)
                        {
                            timer1.Stop();
                            timer1.Interval = 1000;
                            
                            MessageBox.Show("你胜利了!!");
                            for (int x = 0; x < 14; x++)
                            {
                                for (int k = 0; k < 20; k++)
                                    backGround[k, x] = 0;
                            }
                            score = 0;
                            this.label1_Score.Text = (score / 10).ToString();
                            return;
                        }
                    }
                    else
                    {
                        if (score > 900)
                        {
                            timer1.Stop();
                            timer1.Interval = 1000;
                            
                            MessageBox.Show("你胜利了!!");
                            for (int x = 0; x < 14; x++)
                            {
                                for (int k = 0; k < 20; k++)
                                    backGround[k, x] = 0;
                            }
                            score = 0;
                            this.label1_Score.Text = (score / 10).ToString();
                            return;
                        }
                    }
                }

            }
        }

        /// <summary>
        /// 变换砖块形状
        /// </summary>
        public void TransformBrick()
        {
            if (currentState < 3)
                currentState++;
            else
                currentState = 0;
            for (int y = 0; y < 4; y++)
            {
                for (int x = 0; x < 4; x++)
                {
                    currentBrick[y, x] = brick[currentType, currentState, y, x];
                }
            }
        }

        private void Draw()
        {
            Graphics g = Graphics.FromImage(image);
            g.Clear(this.BackColor);
            for (int bgy = 0; bgy < 20; bgy++)
            {
                for (int bgx = 0; bgx < 14; bgx++)
                {
                    if (backGround[bgy, bgx] == 1)
                    {

                        g.FillRectangle(new SolidBrush(Color.Blue), bgx * 20, bgy * 20, 20, 20);
                    }
                }
            }

            for (int y = 0; y < 4; y++)
            {
                for (int x = 0; x < 4; x++)
                {
                    if (currentBrick[y, x] == 1)
                    {
                        g.FillRectangle(new SolidBrush(Color.Blue), (x + currentX) * 20, (y + currentY) * 20, 20, 20);
                    }
                }
            }

            Graphics graphics = panel1.CreateGraphics();

            graphics.DrawImage(image, 0, 0);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


    }
}
