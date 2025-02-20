namespace _Xadrez_no_WinForms;

public partial class Form1 : Form
    {
        private Button[,] buttons = new Button[8, 8];
        private Button selectedButton = null;

        public Form1()
        {
            InitializeComponent();
            CreateBoard();
        }

        private void CreateBoard()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    buttons[i, j] = new Button();
                    buttons[i, j].Size = new Size(60, 60);
                    buttons[i, j].Location = new Point(j * 60, i * 60);
                    buttons[i, j].Tag = $"{i},{j}"; // Armazena a posição no botão
                    buttons[i, j].Click += Button_Click;

                    // Exibe uma peça inicial (por exemplo, "P" para uma peça)
                    if ((i + j) % 2 == 0) // Alterna as peças para visualização
                        buttons[i, j].Text = "P";

                    this.Controls.Add(buttons[i, j]);
                }
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;

            if (selectedButton == null)
            {
                // Seleciona a peça
                selectedButton = clickedButton;
                clickedButton.BackColor = Color.Yellow; // Destaca o botão selecionado
            }
            else
            {
                // Move a peça para outra posição
                clickedButton.Text = selectedButton.Text; // Move o texto da peça
                selectedButton.Text = ""; // Limpa a posição anterior
                selectedButton.BackColor = DefaultBackColor; // Reseta a cor do botão anterior
                selectedButton = null; // Reseta a seleção
            }
        }
    }

