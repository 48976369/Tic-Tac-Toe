using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Media;

namespace 棋牌類遊戲
{
    public partial class Form1 : Form
    {
        bool isTurnO = true; // 紀錄輪到誰 (O先手)
        int turnCount = 0;   // 紀錄下了幾步
        SoundPlayer playerClick = new SoundPlayer("click.wav");
        SoundPlayer playerWin = new SoundPlayer("win.wav");

        public Form1()
        {
            InitializeComponent();
        }

        // 表單載入時，綁定九宮格的點擊事件
        private void Form1_Load(object sender, EventArgs e)
        {
            lblStatus.Text = "目前輪到：O";
            Button[] btns = { btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9 };
            foreach (Button b in btns)
            {
                b.Click += new EventHandler(Button_Click);
            }
        }

        // 共用的按鈕點擊事件
        private void Button_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackgroundImage != null) return; // 如果這格已經有圖片(已經下過)，就不動作

            // 播放下棋語音 (加上 try-catch 避免找不到檔案時當機)
            try { playerClick.Play(); } catch { }

            if (isTurnO)
            {
                btn.BackgroundImage = Image.FromFile("O.png");
                btn.Tag = "O"; // 用 Tag 紀錄這格是誰下的
                lblStatus.Text = "目前輪到：X";
            }
            else
            {
                btn.BackgroundImage = Image.FromFile("X.png");
                btn.Tag = "X";
                lblStatus.Text = "目前輪到：O";
            }

            isTurnO = !isTurnO;
            turnCount++;
            CheckWinner();
        }

        // 判斷輸贏的邏輯
        private void CheckWinner()
        {
            bool isWinner = false;
            string winner = "";

            // 取得 9 個格子的狀態
            string[,] b = {
        { GetTag(btn1), GetTag(btn2), GetTag(btn3) },
        { GetTag(btn4), GetTag(btn5), GetTag(btn6) },
        { GetTag(btn7), GetTag(btn8), GetTag(btn9) }
    };

            // 檢查橫向與直向
            for (int i = 0; i < 3; i++)
            {
                if (b[i, 0] != "" && b[i, 0] == b[i, 1] && b[i, 1] == b[i, 2]) { isWinner = true; winner = b[i, 0]; }
                if (b[0, i] != "" && b[0, i] == b[1, i] && b[1, i] == b[2, i]) { isWinner = true; winner = b[0, i]; }
            }
            // 檢查兩條對角線斜向
            if (b[0, 0] != "" && b[0, 0] == b[1, 1] && b[1, 1] == b[2, 2]) { isWinner = true; winner = b[0, 0]; }
            if (b[0, 2] != "" && b[0, 2] == b[1, 1] && b[1, 1] == b[2, 0]) { isWinner = true; winner = b[0, 2]; }

            if (isWinner)
            {
                try { playerWin.Play(); } catch { }
                MessageBox.Show(winner + " 贏得了遊戲！", "遊戲結束");
                ResetGame();
            }
            else if (turnCount == 9)
            {
                MessageBox.Show("雙方平手！", "遊戲結束");
                ResetGame();
            }
        }

        // 輔助函式：安全取得按鈕的 Tag
        private string GetTag(Button btn)
        {
            return btn.Tag == null ? "" : btn.Tag.ToString();
        }

        // 重新開始按鈕
        private void btnRestart_Click(object sender, EventArgs e)
        {
            ResetGame();
        }

        // 重設遊戲版面
        private void ResetGame()
        {
            Button[] btns = { btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9 };
            foreach (Button b in btns)
            {
                b.BackgroundImage = null;
                b.Tag = null;
            }
            isTurnO = true;
            turnCount = 0;
            lblStatus.Text = "目前輪到：O";
        }
    }
}
