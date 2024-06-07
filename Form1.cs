using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace WindowsForm_move
{

    public partial class Form1 : Form
    {
        private int position_x = 0;
        private int position_y = 0;
        private int I_Would_Win = 0;

        private bool check_coll_left = false;
        private bool check_coll_right = false;
        private bool check_coll_top = false;
        private bool check_coll_bottom = false;

        private SerialPort serialPort;
        public Form1()
        {
            InitializeComponent();
            InitializeSerialPort();
        }
        private void InitializeSerialPort()
        {
            serialPort = new SerialPort("COM9", 9600); // 포트와 속도는 사용 중인 시리얼 장치에 맞게 수정해야 합니다.
            serialPort.DataReceived += SerialPort_DataReceived;
            try
            {
                serialPort.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("시리얼 포트를 열 수 없습니다: " + ex.Message);
            }
        }

        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            try
            {
                string data = sp.ReadLine();
                string[] values = data.Split(',');
                if (values.Length == 2)
                {
                    char x = values[0][0];  //serial x값
                    char y = values[1][0];  //serial y값


                    //move
                    if(x == '+')
                    {
                        position_x = position_x + 1;
                    }
                    else if(x == '*')
                    {
                        position_x = position_x + 2;
                    }
                    else if (x == '-')
                    {
                        position_x = position_x - 1;
                    }
                    else if (x == '/')
                    {
                        position_x = position_x - 2;
                    }

                    if (y == '+')
                    {
                        position_y = position_y + 1;
                    }
                    else if (y == '*')
                    {
                        position_y = position_y + 2;
                    }
                    else if (y == '-')
                    {
                        position_y = position_y - 1;
                    }
                    else if (y == '/')
                    {
                        position_y = position_y - 2;
                    }

                    //limit screen move
                    if (position_x < 0)
                    {
                        position_x = 0;
                    }
                    if (position_y < 0)
                    {
                        position_y = 0;
                    }
                    if (position_x > 800)
                    {
                        position_x = 800;
                    }
                    if (position_y > 470)
                    {
                        position_y = 470;
                    }

                    //limit obstacel move
                    if (pictureBox1.Bounds.IntersectsWith(pictureObstacle1.Bounds))
                    {
                        Rectangle intersect = Rectangle.Intersect(pictureBox1.Bounds, pictureObstacle1.Bounds);

                        // 충돌 영역의 크기와 위치
                        int intersectWidth = intersect.Width;
                        int intersectHeight = intersect.Height;
                        int intersectX = intersect.X - pictureBox1.Left;
                        int intersectY = intersect.Y - pictureBox1.Top;

                        // 충돌한 면 결정
                        if (intersectWidth > intersectHeight)
                        {
                            if (intersectY > (pictureBox1.Height - intersectY))
                            {
                                // 위쪽 충돌
                                Console.WriteLine("Top collision");
                                position_y -= 2;
                            }
                            else
                            {
                                // 아래쪽 충돌
                                Console.WriteLine("Bottom collision");
                                position_y += 2;
                            }
                        }
                        else
                        {
                            if (intersectX > (pictureBox1.Width - intersectX))
                            {
                                // 왼쪽 충돌
                                Console.WriteLine("Left collision");
                                position_x -= 2;
                            }
                            else
                            {
                                // 오른쪽 충돌
                                Console.WriteLine("Right collision");
                                position_x += 2;
                            }
                        }

                    }

                    //처음으로 가는 함정
                    if(pictureBox1.Bounds.IntersectsWith(pictureTrap1.Bounds))
                    {
                        position_x = 0;
                        position_y = 0;
                    }

                        MoveRectangle(position_x, position_y);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("데이터를 읽을 수 없습니다: " + ex.Message);
            }
        }

        private void MoveRectangle(int x, int y)
        {
            if (pictureBox1.InvokeRequired)
            {
                pictureBox1.Invoke(new MethodInvoker(delegate { MoveRectangle(x, y); }));
            }
            else
            {
                pictureBox1.Location = new System.Drawing.Point(x, y);
            }

            

            //win
            if (pictureBox1.Bounds.IntersectsWith(pictureFlag.Bounds))
            {
                I_Would_Win++;
            }
            if(I_Would_Win  == 1)
            {
                I_Would_Win++;
                MessageBox.Show("Win!");
            }

            /*
            Console.Write(pictureFlag.Location.X);
            Console.Write(",");
            Console.Write(pictureFlag.Location.Y);
            Console.Write("/");
            Console.Write(pictureFlag.Size.Height);
            Console.Write(",");
            Console.WriteLine(pictureFlag.Size.Width);
            */
        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort != null && serialPort.IsOpen)
            {
                serialPort.Close();
            }
        }
    }
}
