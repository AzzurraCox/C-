using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace finalproject
{
    public partial class Form3 : Form
    {
        Clues clue_window = new Clues();//提示的畫面
        List<id_cells> idc = new List<id_cells>();
        public String puzzle_file = Application.StartupPath + "\\Puzzles\\puzzle_1.pzl";//導入詞庫
        

        public Form3()
        {
            BuildWordList();
            InitializeComponent();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BuildWordList()//導入詞庫
        {
            String line = "";
            using (StreamReader s = new StreamReader(puzzle_file))
            {
                line = s.ReadLine();
                while((line = s.ReadLine()) != null)
                    {
                    String [] l = line.Split('|');
                    idc.Add(new id_cells(Int32.Parse(l[0]), Int32.Parse(l[1]), l[2], l[3], l[4], l[5]));
                    clue_window.clue_table.Rows.Add(new String[] { l[3], l[2], l[5] });
                }
            }
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Help About", "By 405530028");
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            InitializeBoard();
            clue_window.SetDesktopLocation(this.Location.X + this.Width + 1, this.Location.Y);
            clue_window.StartPosition = FormStartPosition.Manual;

            clue_window.Show();
            clue_window.clue_table.AutoResizeColumns();
        }
        private void InitializeBoard()//根據詞庫設定格子
        {
            board.BackgroundColor = Color.Black;
            board.DefaultCellStyle.BackColor = Color.Black;
            for (int i = 0; i < 21; i++)
                board.Rows.Add();

            foreach (DataGridViewColumn c in board.Columns)
                c.Width = board.Width / board.Columns.Count;

            foreach (DataGridViewRow r in board.Rows)
                r.Height = board.Height / board.Rows.Count;

            for (int row = 0; row < board.Rows.Count; row++)
            {
                for (int col = 0; col < board.Columns.Count; col++)
                    board[col, row].ReadOnly = true;
            }

            foreach (id_cells i in idc)//把詞接起來
            {
                int start_col = i.X;
                int start_row = i.Y;
                char[] word = i.word.ToArray();

                for (int j = 0; j < word.Length; j++)
                {
                    if (i.direction.ToUpper() == "ACROSS")
                        FormatCell(start_row, start_col + j, word[j].ToString());
                    if (i.direction.ToUpper() == "DOWN")
                        FormatCell(start_row + j, start_col, word[j].ToString());
                }
            }
        }

        private void FormatCell(int row, int col, String letter)//設定可以填詞的空格
        {
            DataGridViewCell c = board[col, row];
            c.Style.BackColor = Color.White;
            c.ReadOnly = false;
            c.Style.SelectionBackColor = Color.Cyan;
            c.Tag = letter;
        }

        private void Form3_LocationChanged(object sender, EventArgs e)//提示窗粘著游戲窗
        {
            clue_window.SetDesktopLocation(this.Location.X + this.Width + 1, this.Location.Y);
        }

        private void Board_CellValueChanged(object sender, DataGridViewCellEventArgs e)//判斷填的詞對錯，填錯會轉成紅色，對的會是青色
        {
            try
            {
                board[e.ColumnIndex, e.RowIndex].Value = board[e.ColumnIndex, e.RowIndex].Value.ToString().ToUpper();
            }
            catch { }

            try
            {
               if(board[e.ColumnIndex, e.RowIndex].Value.ToString().Length > 1)
                    board[e.ColumnIndex, e.RowIndex].Value = board[e.ColumnIndex, e.RowIndex].Value.ToString().Substring(0,1);
            }
            catch { }

            try
            {
                if (board[e.ColumnIndex, e.RowIndex].Value.ToString().ToUpper().Equals(board[e.ColumnIndex, e.RowIndex].Tag.ToString().ToUpper()))
                    board[e.ColumnIndex, e.RowIndex].Style.ForeColor = Color.DarkGreen;
                else
                    board[e.ColumnIndex, e.RowIndex].Style.ForeColor = Color.Red; 
            }
            catch { }
        }

        private void OpenPuzzleToolStripMenuItem_Click(object sender, EventArgs e)//導入詞庫的文件
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Puzzle Files|*.pzl";
            if(ofd.ShowDialog().Equals(DialogResult.OK))
            {
                puzzle_file = ofd.FileName;

                board.Rows.Clear();
                clue_window.clue_table.Rows.Clear();
                idc.Clear();

                BuildWordList();
                InitializeBoard();
            }
        }

        private void Board_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)//格子字的設定
        {
            String number = "";

            if (idc.Any(c => (number = c.number) != "" && c.X == e.ColumnIndex && c.Y ==e.RowIndex))
            {
                Rectangle r = new Rectangle(e.CellBounds.X, e.CellBounds.Y, e.CellBounds.Width, e.CellBounds.Height);
                e.Graphics.FillRectangle(Brushes.White, r);
                Font f = new Font(e.CellStyle.Font.FontFamily, 7);
                e.Graphics.DrawString(number, f, Brushes.Black, r);
                e.PaintContent(e.ClipBounds);
                e.Handled = true;
            }
        }
    }

    public class id_cells//設定坐標和宣告
    {
        public int X;
        public int Y;
        public String direction;
        public String number;
        public String word;
        public String clue;

        public id_cells(int x, int y, String d, String n, String w, String c)
        {
            this.X = x;
            this.Y = y;
            this.direction = d;
            this.number = n;
            this.word = w;
            this.clue = c;
        }
    }
}
