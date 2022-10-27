using System.Diagnostics;

namespace metodosOrdenacao {
    public partial class Frame : Form {
        //instâncias 
        Ordenacao ordenacao = new Ordenacao();
        Util util = new Util();
        Infos infos = new Infos();
        int metodo;

        public Frame() {
            InitializeComponent();
        }

        private void btInfos_Click(object sender, EventArgs e) {
            metodo = Int32.Parse(Aba_metodos.GetItemText(Aba_metodos.SelectedIndex)); //Int32 é um tipo de valor imutável que representa inteiros com sinal com valores que variam
            tela_info.Text = infos.Get_informacoes(metodo);
        }
        
        private void btLimpar_Click(object sender, EventArgs e) {
            tela_info.Clear();
            tela_numeros.Clear();
            Tabela_Numeros.Clear();
            temp_Exe.Clear();
        }

        private void Ordenar_Click(object sender, EventArgs e) {
            int qtdNum = Int32.Parse(Tabela_Numeros.Text);
            //Int32 é um tipo de valor imutável que representa inteiros com sinal com valores que variam de 2.147.483.648 negativos 
            
            List<int> listaNum = util.popularLista(qtdNum);

            Stopwatch sw = new Stopwatch(); // medir tempo decorrido de um intervalo
            if (metodo == 0)
            { // se o metodo 0 for selecionado, ordena em bolha
                sw.Start();
                metodo = Int32.Parse(Aba_metodos.GetItemText(Aba_metodos.SelectedIndex)); 
                tela_numeros.Text = infos.Get_informacoes(metodo);
                sw.Stop();
            }
            else if (metodo == 1) { // se o metodo 0 for selecionado, ordena em bolha
                sw.Start();
                tela_numeros.Text = String.Join(Environment.NewLine, ordenacao.bolha(listaNum));
                sw.Stop();
                temp_Exe.Text = sw.ElapsedMilliseconds.ToString();
                sw.Reset();
            } else if (metodo == 2) { // se o metodo 1 for selecionado, ordena em selecao
                sw.Start();
                tela_numeros.Text = String.Join(Environment.NewLine, ordenacao.selecao(listaNum));
                sw.Stop();
                temp_Exe.Text = sw.ElapsedMilliseconds.ToString();
                sw.Reset();
            } else if (metodo == 3) { // se o metodo 2 for selecionado, ordena em insercao
                sw.Start();
                tela_numeros.Text = String.Join(Environment.NewLine, ordenacao.insercao(listaNum));
                sw.Stop();
                temp_Exe.Text = sw.ElapsedMilliseconds.ToString();
                sw.Reset();
            } else if (metodo == 4) {// se o metodo 3 for selecionado, ordena em agitacao
                sw.Start();
                tela_numeros.Text = String.Join(Environment.NewLine, ordenacao.agitacao(listaNum));
                sw.Stop();
                temp_Exe.Text = sw.ElapsedMilliseconds.ToString();
                sw.Reset();
            } else if (metodo == 5) {// se o metodo 4 for selecionado, ordena em pente
                sw.Start();
                tela_numeros.Text = String.Join(Environment.NewLine, ordenacao.pente(listaNum));
                sw.Stop();
                temp_Exe.Text = sw.ElapsedMilliseconds.ToString();
                sw.Reset();
            } else if (metodo == 6) {// se o metodo 5 for selecionado, ordena em shell
                sw.Start();
                tela_numeros.Text = String.Join(Environment.NewLine, ordenacao.shell(listaNum));
                sw.Stop();
                temp_Exe.Text = sw.ElapsedMilliseconds.ToString();
                sw.Reset();
            } else if (metodo == 7) {// se o metodo 6 for selecionado, ordena em quick
                sw.Start();
                tela_numeros.Text = String.Join(Environment.NewLine, ordenacao.quick(listaNum, 0, listaNum.Count - 1));
                sw.Stop();
                temp_Exe.Text = sw.ElapsedMilliseconds.ToString();
                sw.Reset();
            } else if (metodo == 8) {// se o metodo 7 for selecionado, ordena em heap
                sw.Start();
                tela_numeros.Text = String.Join(Environment.NewLine, ordenacao.heap(listaNum));
                sw.Stop();
                temp_Exe.Text = sw.ElapsedMilliseconds.ToString();
                sw.Reset();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("tempo foi de :" + temp_Exe.Text + "ms");

        }

        private void cbMetodos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tela_info_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbTempoExec_TextChanged(object sender, EventArgs e)
        {

        }

        private void Tabela_Numeros_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("escolha qual metodo de ordenação deseja, a seguir digite uma quantidade de numeros para serem ordenados, caso deseje saber um pouco " +
                "mais sobre os metodos clique em exebir info.");
        }
    }
}