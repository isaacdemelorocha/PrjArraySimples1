namespace PrjArraySimples1
{
    public partial class Form1 : MetroFramework.Forms.MetroForm

    {
        //Lembre-se: Todo array (primitivo) devemos informar a quantidade de posi��es
        // M�todo especial � um evento

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
            //se n�o acertar, mostre -1
            //se acertar,mostrar em qual posi��o est� no array

            int num = int.Parse(txtBox.Text);

            for (int x = 0; x < MAX; x++) ;

            if (num == x[0]){
                MessageBox.Show("Posi��o 0");
                txtBox.Text = "";

            } else if(num == x[1])
            {
                MessageBox.Show("Posi��o 1");
                txtBox.Text = "";
            }

            else if (num == x[2])
            {
                MessageBox.Show("Posi��o 2");
                txtBox.Text = "";
            }
            
            else { MessageBox.Show("Error 404: N�o cont�m no Array");
                   txtBox.Text = "";
                }       

            }
        }
    }

