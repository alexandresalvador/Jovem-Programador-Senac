using System;
using System.Windows.Forms;

namespace Views
{
    public class Exemplo : Form
    {
        private Form parent;
        private Label lblExemplo;
        private Button btnButton;
        private CheckBox cbxCheck;
        private TextBox inpInput;

        public Exemplo(Form parent)
        {
            this.parent = parent;
            lblExemplo = new Label();
            lblExemplo.Text = "Olá, mundo";
            lblExemplo.Location = new System.Drawing.Point(50, 50);

            btnButton = new Button();
            btnButton.Text = "Clique aqui";
            btnButton.Location = new System.Drawing.Point(150, 50);
            btnButton.Click += ClicarBotao;
            btnButton.Size = new System.Drawing.Size(100, 100);

            cbxCheck = new CheckBox();
            cbxCheck.Location = new System.Drawing.Point(50, 250);
            cbxCheck.Name = "cbxCheck";
            cbxCheck.Text = "CheckBox 1";
            // cbxCheck.Size = new System.Drawing.Size(230, 230);

            inpInput = new TextBox();
            inpInput.Location = new System.Drawing.Point(50, 300);
            inpInput.Name = "inpInput";
            inpInput.Size = new System.Drawing.Size(200, 200);

            this.Text = "Minha primeira janela";
            this.Size = new System.Drawing.Size(400, 400);
            // Adicionando em tela
            Controls.Add(lblExemplo);
            Controls.Add(btnButton);
            Controls.Add(cbxCheck);
            Controls.Add(inpInput);

            FormClosed += AoFechar;
        }

        private void ClicarBotao(object sender, EventArgs e)
        {
            if (inpInput.Text.Length < 1)
            {
                MessageBox.Show(
                    "O input está vazio, preenche ai",
                    "Erro",
                    MessageBoxButtons.OK
                );
            }
            else
            {
                lblExemplo.Text = inpInput.Text;
            }
        }

        private void AoFechar(object sender, FormClosedEventArgs e)
        {
            this.parent.Show();
        }
    }
}