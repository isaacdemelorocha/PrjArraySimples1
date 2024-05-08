namespace PrjArraySimples1
{
    public partial class Form1 : MetroFramework.Forms.MetroForm

    {
        //Lembre-se: Todo array (primitivo) devemos informar a quantidade de posições
        // Método especial é um evento

        const int MAX = 3;
        int[] x = new int[MAX];

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            x[0] = 99;
            x[1] = 73;
            x[2] = 27;
        }

        private void btn_Click(object sender, EventArgs e)
        {
            //se não acertar, mostre -1
            //se acertar,mostrar em qual posição está no array

            int num = int.Parse(txtBox.Text);

            for (int x = 0; x < MAX; x++) ;

            if (num == x[0]){
                MessageBox.Show("Posição 0");
                txtBox.Text = "";

            } else if(num == x[1])
            {
                MessageBox.Show("Posição 1");
                txtBox.Text = "";
            }

            else if (num == x[2])
            {
                MessageBox.Show("Posição 2");
                txtBox.Text = "";
            }
            
            else { MessageBox.Show("Error 404: Não contém no Array");
                   txtBox.Text = "";
                }       

            }
        }
    }

