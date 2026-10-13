namespace VERIFICA_DI_RIPASSO_C_
{
    public partial class Form1 : Form
    {
        string[] alfabeto = {"A","B","C","D","E","F","G","H","I","J","K","L","M","N","O","P","Q","R","S","T","U","V","W","X","Y","Z"};
        string[] parola = new string[15];
        string par;
        string lettera;
        string nuovaParola = "";
        int count=0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (StreamReader sr = new StreamReader("frasi.txt"))
            {
                string riga = sr.ReadLine();
                for(int i = 0; i<parola.Length; i++)
                {
                    riga = sr.ReadLine();
                    parola[i] = riga;
                }
            }
            for(int i = 0; i<parola.Length; i++)
            {
                par = parola[i];
                for(int j = 0; j < par.Length; j++)
                {
                    lettera = Convert.ToString(par[j]);
                    for(int a = 0 ; a < alfabeto.Length; a++)
                    {
                        if (alfabeto[a] == lettera)
                        {
                            count = a;
                        }
                    }  
                    if (count-3 >= 0)
                    {
                        nuovaParola = nuovaParola + alfabeto[count-3];
                    }
                    else
                    {
                        nuovaParola = nuovaParola + alfabeto[count-3 + alfabeto.Length];
                    }
                }
            }
        }

        private void listBoxfrasi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
