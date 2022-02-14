using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace SortingAlgorithmSimulation
{
    public partial class FormMain : Form
    {
        #region Properties
        List<Guna2Button> buttons; // Mảng nút sau khi random
        int[] arr; // Mảng giá trị sau khi random
        #endregion
        #region Form
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            btnMode_Click(null, null);
            buttons = new List<Guna2Button>();
        }

        private void btnAddNote_Click(object sender, EventArgs e)
        {
            int value = (int)nudNode.Value;

            Guna2Button btn = new Guna2Button()
            {
                FillColor = Content.fillColor,
                ForeColor = Content.foreColor,
                Font = new Font("Segoe UI", 11F),
                Size = new Size(Content.WIDTH_SIZE, Content.HEIGHT_SIZE),
                Text = value.ToString()
            };
            btn.Location = new Point(
                Content.DISTANCE + pnlSimulation.Controls.Count * (btn.Width + Content.DISTANCE),
                pnlSimulation.Height / 2 - btn.Height / 2);
            pnlSimulation.Controls.Add(btn);
            buttons.Add(btn);

            btnRun.Enabled = pnlSimulation.Controls.Count >= 2; // Khoá button run khi số lượng số nhỏ hơn 2

            // Chỉ cho phép tạo 12 node
            btnAddNote.Enabled = pnlSimulation.Controls.Count < 12;
            this.AcceptButton = pnlSimulation.Controls.Count < 12 ? btnAddNote : null;
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            arr = new int[buttons.Count];
            for (int i = 0; i < buttons.Count; i++)
                arr[i] = Convert.ToInt32(buttons[i].Text);

            if (cboAlgorithms.SelectedIndex == 0)
                bgwBubbleSort.RunWorkerAsync(); // Gọi hàm dowork
            else if (cboAlgorithms.SelectedIndex == 1)
                bgwInterchangeSort.RunWorkerAsync(); // Gọi hàm dowork
            else if (cboAlgorithms.SelectedIndex == 2)
                bgwSelectionSort.RunWorkerAsync(); // Gọi hàm dowork
            else if (cboAlgorithms.SelectedIndex == 3)
                bgwQuickSort.RunWorkerAsync(); // Gọi hàm dowork
            else if (cboAlgorithms.SelectedIndex == 4)
                bgwInsertionSort.RunWorkerAsync(); // Gọi hàm dowork
            btnAddNote.Enabled = false;
            rdbAscending.Enabled = rdbDecreasing.Enabled = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            buttons = new List<Guna2Button>();
            pnlSimulation.Controls.Clear();
            btnClear.Enabled = false;
            rdbAscending.Enabled = rdbDecreasing.Enabled = true;
        }

        private void btnMode_Click(object sender, EventArgs e)
        {
            if (btnMode.Tag.ToString() == "Night mode")
            {
                pnlCustomize.BackColor = Color.FromArgb(77, 170, 246);
                pnlSimulation.BackColor = Color.FromArgb(210, 234, 253);
                lblNode.ForeColor = lblAlgorithms.ForeColor = Color.Black;
                rdbAscending.ForeColor = rdbDecreasing.ForeColor = Color.Black;
                btnMode.Tag = "Day mode";
                btnMode.Image = SortingAlgorithmSimulation.Properties.Resources.Day_mode;
            }
            else
            {
                pnlCustomize.BackColor = pnlSimulation.BackColor = Color.Black;
                lblNode.ForeColor = lblAlgorithms.ForeColor = Color.White;
                rdbAscending.ForeColor = rdbDecreasing.ForeColor = Color.White;
                btnMode.Tag = "Night mode";
                btnMode.Image = SortingAlgorithmSimulation.Properties.Resources.Night_mode;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to quit?", "Quit", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
                this.Close();
        }
        #endregion
        #region Common functions
        private void Swap(ref int num1, ref int num2)
        {
            int temp = num1;
            num1 = num2;
            num2 = temp;
        }

        private void MoveButtons(BackgroundWorker bgw, int local1, int local2)
        {
            Status st = new Status();
            st.Local1 = local1;
            st.Local2 = local2;

            st.Type = MoveType.UP_DOWN;
            for (int i = 0; i < Content.HEIGHT; i++)
            {
                bgw.ReportProgress(0, st);
                Thread.Sleep(Content.threadTime);
            }

            st.Type = MoveType.RIGHT_LEFT;
            int WIDTH = Math.Abs(local1 - local2) * (Content.WIDTH_SIZE + Content.DISTANCE);
            for (int i = 0; i < WIDTH; i++)
            {
                bgw.ReportProgress(0, st);
                Thread.Sleep(Content.threadTime);
            }

            st.Type = MoveType.DOWN_UP;
            for (int i = 0; i < Content.HEIGHT; i++)
            {
                bgw.ReportProgress(0, st);
                Thread.Sleep(Content.threadTime);
            }

            st.Type = MoveType.STOP;
            bgw.ReportProgress(0, st);
        }

        private void ProgressButtons(Status st, string moveType)
        {
            if (st == null) return;
            if (st.Type == MoveType.STOP)
            {
                Guna2Button btn = buttons[st.Local2];
                buttons[st.Local2] = buttons[st.Local1];
                buttons[st.Local1] = btn;
                return;
            }

            Guna2Button btn1 = buttons[st.Local1];
            Guna2Button btn2 = buttons[st.Local2];
            if (st.Type == MoveType.UP_DOWN)
            {
                btn1.Top += 1;// Nút 1 đi lên
                btn2.Top -= 1;// Nút 2 đi xuống
            }
            else if (st.Type == MoveType.RIGHT_LEFT)
            {
                if (moveType == "RL")
                {
                    btn1.Left -= 1;// Nút 1 di chuyển qua phải
                    btn2.Left += 1;// Nút 1 di chuyển qua trái
                }
                else
                {
                    btn1.Left += 1;// Nút 1 di chuyển qua trái
                    btn2.Left -= 1;// Nút 1 di chuyển qua phải
                }
            }
            else if (st.Type == MoveType.DOWN_UP)
            {
                btn1.Top -= 1;// Nút 1 đi xuống
                btn2.Top += 1;// Nút 1 đi lên
            }
        }

        private void RunWorkerCompletedButtons()
        {
            foreach (Guna2Button btn in pnlSimulation.Controls)
            {
                btn.FillColor = Content.fillColorFinish;
                btn.ForeColor = Content.foreColorFinish;
            }
            btnAddNote.Enabled = true;
            btnRun.Enabled = false;
            btnClear.Enabled = true;
        }
        #endregion
        #region Bubble sort
        private void BubbleSort(int[] arr)
        {
            Status st = new Status();
            for (int i = 0; i < arr.Length; i++)
                for (int j = arr.Length - 1; j > i; j--)
                {
                    if (rdbAscending.Checked) // Tăng dần
                    {
                        if (arr[j] < arr[j - 1])
                        {
                            Swap(ref arr[j], ref arr[j - 1]);
                            Thread.Sleep(Content.threadTime); // Delay cho người dùng có thể xem khi di chuyển
                            MoveButtons(bgwBubbleSort, j, j - 1); // Gọi hàm di chuyển nút
                        }

                    }
                    else // Giảm dần
                    {
                        if (arr[j] > arr[j - 1])
                        {
                            Swap(ref arr[j], ref arr[j - 1]);
                            Thread.Sleep(Content.threadTime); // Delay cho người dùng có thể xem khi di chuyển
                            MoveButtons(bgwBubbleSort, j, j - 1); // Gọi hàm di chuyển nút
                        }
                    }
                }
        }

        private void bgwBubbleSort_DoWork(object sender, DoWorkEventArgs e)
        {
            // Hàm dowork sẽ xử lý thông tin nhưng không cập nhật giao diện
            BubbleSort(arr);
        }

        private void bgwBubbleSort_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            // Cập nhật giao diện và thực thi hàm dowork
            ProgressButtons(e.UserState as Status, "RL");
        }

        private void bgwBubbleSort_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // Kết thúc tiến trình
            RunWorkerCompletedButtons();
        }
        #endregion
        #region Interchange Sort
        private void InterchangeSort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
                for (int j = i + 1; j < arr.Length; j++)
                    if (rdbAscending.Checked) // Tăng dần
                    {
                        if (arr[j] < arr[i])
                        {
                            Swap(ref arr[j], ref arr[i]);
                            Thread.Sleep(Content.threadTime); // Delay cho người dùng có thể xem khi di chuyển
                            MoveButtons(bgwInterchangeSort, j, i); // Gọi hàm di chuyển nút
                        }

                    }
                    else // Giảm dần
                    {
                        if (arr[j] > arr[i])
                        {
                            Swap(ref arr[j], ref arr[i]);
                            Thread.Sleep(Content.threadTime); // Delay cho người dùng có thể xem khi di chuyển
                            MoveButtons(bgwInterchangeSort, j, i); // Gọi hàm di chuyển nút
                        }
                    }
        }

        private void bgwInterchangeSort_DoWork(object sender, DoWorkEventArgs e)
        {
            InterchangeSort(arr);
        }

        private void bgwInterchangeSort_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            ProgressButtons(e.UserState as Status, "RL");
        }

        private void bgwInterchangeSort_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            RunWorkerCompletedButtons();
        }
        #endregion
        #region Selection Sort
        private void SelectionSort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (rdbAscending.Checked) // Tăng dần
                    {
                        if (arr[j] < arr[min])
                            min = j;
                    }
                    else
                    {
                        if (arr[j] > arr[min]) // Giảm dần
                            min = j;
                    }
                }
                Swap(ref arr[min], ref arr[i]);
                Thread.Sleep(Content.threadTime); // Delay cho người dùng có thể xem khi di chuyển          
                MoveButtons(bgwSelectionSort, min, i); // Gọi hàm di chuyển nút
            }
        }

        private void bgwSelectionSort_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            SelectionSort(arr);
        }

        private void bgwSelectionSort_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            ProgressButtons(e.UserState as Status, "RL");
        }

        private void bgwSelectionSort_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            RunWorkerCompletedButtons();
        }

        #endregion
        #region Quick Sort
        private void QuickSort(int[] arr, int left, int right)
        {
            int i = left, j = right;
            int mid = arr[(i + j) / 2];
            do
            {
                if (rdbAscending.Checked) // Tăng dần
                {
                    while (arr[i] < mid) i++;
                    while (arr[j] > mid) j--;
                }
                else // Giảm dần
                {
                    while (arr[i] > mid) i++;
                    while (arr[j] < mid) j--;
                }
                if (i <= j)
                {
                    Swap(ref arr[i], ref arr[j]);
                    Thread.Sleep(Content.threadTime); // Delay cho người dùng có thể xem khi di chuyển          
                    MoveButtons(bgwQuickSort, i, j); // Gọi hàm di chuyển nút
                    i++; j--;
                }
            }
            while (i < j);
            if (left < j) QuickSort(arr, left, j);
            if (i < right) QuickSort(arr, i, right);
        }

        private void bgwQuickSort_DoWork(object sender, DoWorkEventArgs e)
        {
            QuickSort(arr, 0, arr.Length - 1);
        }

        private void bgwQuickSort_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            ProgressButtons(e.UserState as Status, "LR");
        }

        private void bgwQuickSort_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            RunWorkerCompletedButtons();
        }
        #endregion
        #region Insertion Sort
        private void InsertionSort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
                for (int j = i + 1; j > 0; j--)
                {
                    if (rdbAscending.Checked) // Tăng dần
                    {
                        if (arr[j - 1] > arr[j])
                        {
                            Swap(ref arr[j - 1], ref arr[j]);
                            Thread.Sleep(Content.threadTime); // Delay cho người dùng có thể xem khi di chuyển
                            MoveButtons(bgwInsertionSort, j - 1, j); // Gọi hàm di chuyển nút
                        }

                    }
                    else // Giảm dần
                    {
                        if (arr[j - 1] < arr[j])
                        {
                            Swap(ref arr[j - 1], ref arr[j]);
                            Thread.Sleep(Content.threadTime); // Delay cho người dùng có thể xem khi di chuyển
                            MoveButtons(bgwInsertionSort, j - 1, j); // Gọi hàm di chuyển nút
                        }
                    }
                }
        }

        private void bgwInsertionSort_DoWork(object sender, DoWorkEventArgs e)
        {
            InsertionSort(arr);
        }

        private void bgwInsertionSort_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            ProgressButtons(e.UserState as Status, "LR");
        }

        private void bgwInsertionSort_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            RunWorkerCompletedButtons();
        }

        #endregion
    }
}