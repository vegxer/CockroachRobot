using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Робот_Таракан
{
    enum Direction : byte { Up, Right, Down, Left };

    public partial class MainForm : Form
    {
        Bitmap shell;
        int AlgStep = 0;
        List<Cockroach> workCockroaches; //рабочий Таракан - активный Таракан, который будет выполнять алгоритм
        List<PictureBox> workpb; //рабочее поле PictureBox - поле на котрой будет рабочий Таракан
        List<Cockroach> LC; //Список для хранения созданных Тараканов
        List<PictureBox> PB; //Список для хранения созданных объектов PictureBox


        public MainForm()
        {
            InitializeComponent();
            LC = new List<Cockroach>();
            PB = new List<PictureBox>();
            workCockroaches = new List<Cockroach>();
            workpb = new List<PictureBox>();
            shell = new Bitmap(Properties.Resources.cockroach);
            openFileDialog.Filter = "Файлы изображений (*.jpg, *.png)|*.jpg;*.png";
        }

        private void NewHeroBtn_Click(object sender, EventArgs e)
        {
            Cockroach cockroach = new Cockroach(new Bitmap(shell), Size);
            PictureBox p = new PictureBox();
            p.BackColor = Color.Transparent;
            p.MouseMove += new MouseEventHandler(IMouseMove);
            p.MouseDown += new MouseEventHandler(IMouseDown);
            PB.Add(p);
            LC.Add(cockroach);
            workCockroaches.Clear();
            workpb.Clear();
            workCockroaches.Add(cockroach);
            workpb.Add(p);
            Show(p, Field);
        }

        public void Repaint(PictureBox p, int cockroachIndex)
        {
            p.Bounds = new Rectangle(workCockroaches[cockroachIndex].X, workCockroaches[cockroachIndex].Y, workCockroaches[cockroachIndex].Image.Width, workCockroaches[cockroachIndex].Image.Height); //создание новых границ изображения для PictureBox
            p.Image = workCockroaches[cockroachIndex].Image;
        }

        public void Show(PictureBox p, Panel owner)
        {
            workCockroaches[0].X = (owner.Width - workCockroaches[0].Image.Width) / 2;
            workCockroaches[0].Y = (owner.Height - workCockroaches[0].Image.Height) / 2;
            Repaint(p, 0);
            owner.Controls.Add(p); // добавляем PictureBox к элементу Panel
        }

        private void IMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                PictureBox currPB = sender as PictureBox;
                int k = PB.IndexOf(currPB); //запоминаем номер нажатого компонента PictureBox
                if (ModifierKeys == Keys.Control && !workCockroaches.Contains(LC[k]))
                {
                    workpb.Add(currPB); //объявляем его рабочим
                    workCockroaches.Add(LC[k]);
                }
                else if (!(ModifierKeys == Keys.Control))
                {
                    workpb.Clear();
                    workCockroaches.Clear();
                    workpb.Add(currPB); //объявляем его рабочим
                    workCockroaches.Add(LC[k]);
                }   
            }
        }

        private void IMouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                PictureBox picture = sender as PictureBox;
                picture.Tag = new Point(e.X, e.Y); //запоминаем координаты мыши на момент начала перетаскивания
                picture.DoDragDrop(sender, DragDropEffects.Move); //начинаем перетаскивание ЧЕГО и с КАКИМ ЭФФЕКТОМ
            }
        }

        private void Field_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(PictureBox)))
            {
                e.Effect = DragDropEffects.Move;
            }
        }

        private void Field_DragDrop(object sender, DragEventArgs e)
        {
            //извлекаем PictureBox
            PictureBox picture = (PictureBox)e.Data.GetData(typeof(PictureBox));
            Panel panel = sender as Panel;
            //получаем клиентские координаты в момент отпускания кнопки
            Point pointDrop = panel.PointToClient(new Point(e.X - workCockroaches[0].Image.Width / 2, e.Y - workCockroaches[0].Image.Height / 2));
            //извлекаем клиентские координаты мыши в момент начала перетскивания
            Point pointDrag = (Point)picture.Tag;
            //вычисляем и устанавливаем Location для PictureBox в Panel

            picture.Location = pointDrop;
            //устанавливаем координаты X и Y для рабочего таракана
            workCockroaches[0].X = picture.Location.X;
            workCockroaches[0].Y = picture.Location.Y;
            picture.Parent = panel;
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Algorithm.Items.Add((sender as Button).Text);
        }

        private void RunBtn_Click(object sender, EventArgs e)
        {
            timerAlgorithm.Start();
        }

        private void timerAlgorithm_Tick(object sender, EventArgs e)
        {
            if (AlgStep == Algorithm.Items.Count) //конец алгоритма
            {
                timerAlgorithm.Stop();
            }
            else//выполнение команды из списка
            {
                string step = (string)Algorithm.Items[AlgStep];
                Algorithm.SetSelected(AlgStep, true);
                if (step == "Step")
                {
                    for (int i = 0; i < workCockroaches.Count; ++i)
                    {
                        workCockroaches[i].Step();
                        Repaint(workpb[i], i);
                    }
                }
                else
                {
                    for (int i = 0; i < workCockroaches.Count; ++i)
                    {
                        workCockroaches[i].ChangeTrend(step);
                        Repaint(workpb[i], i);
                    }    
                }      
                ++AlgStep;
            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            AlgStep = 0;
            Algorithm.Items.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < workCockroaches.Count; ++i)
            {
                Field.Controls.Remove(workpb[i]);
                LC.Remove(workCockroaches[i]);
                PB.Remove(workpb[i]);
            }
            workCockroaches.Clear();
            workpb.Clear();    
        }

        private void btnChangeImage_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                shell = new Bitmap(@openFileDialog.FileName);
                for (int i = 0; i < workCockroaches.Count; ++i)
                {
                    workpb[i].Image = new Bitmap(shell);
                    workCockroaches[i].Image = new Bitmap(shell);
                }
            }
        }

        private void Algorithm_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sender is ListBox && !timerAlgorithm.Enabled)
                AlgStep = (sender as ListBox).SelectedIndex;
        }
    }
}
