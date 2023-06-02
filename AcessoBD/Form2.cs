using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AcessoBD
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #region Método modifica (para DELETE , UPDATE e INSERT)

        private void modifica(String sql)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = sql;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = Conexao.abreConexao();
            try
            {
                if (MessageBox.Show("Deseja executar esse ação?", "Atenção",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        lblResul.Visible = true;

                        timer1.Start();
                        lblResul.Visible = false;

                    }
                    else
                    {
                        lblResul2.Visible = true;

                        timer1.Start();
                        lblResul2.Visible = false;
                    }
                    cmd.Dispose();
                }

            }
            catch (MySqlException ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conexao.fechaConexao();
            }
        }

        #endregion

       

      
 #region botão de Pesquisa
        private void pesquisar(String sql)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = sql;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = Conexao.abreConexao();
            MySqlDataReader dr;
            try
            {
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtCodigo.Text = dr["codigo"].ToString();
                    txtNome.Text = dr["nome"].ToString();
                    String sexo = dr["sexo"].ToString();
                    if (sexo == "F")
                    {
                        rdbF.Checked = true;
                    }
                    else if (sexo == "M")
                    {
                        rdbM.Checked = true;
                    }
                    
                }

                else 
                {

                    txtNome.Text = " ";
                    rdbM.Checked = false;
                    rdbF.Checked = false;
                }
                dr.Close();
                cmd.Dispose();
            }
            catch (MySqlException ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conexao.fechaConexao();
            }
        }
        #endregion

        private void btnApagar_Click(object sender, EventArgs e)
        {
            String apaga = String.Format(
                "DELETE FROM clientes WHERE codigo = {0}", txtCodigo.Text);
            modifica(apaga);
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {

            String sexo;
            if (rdbF.Checked) { 
            String vsf = "INSERT INTO clientes VALUES('" + txtCodigo.Text + "','" + txtNome.Text + "'," + rdbF.Text + "')";
        
            String novo = String.Format(" INSERT INTO clientes VALUES('{0}','{1}','{2}')", txtCodigo.Text, txtNome.Text, rdbF.Text);
            modifica(novo);
            }
            else
            {
                String vsf = "INSERT INTO clientes VALUES('" + txtCodigo.Text + "','" + txtNome.Text + "'," + rdbM.Text + "')";

                String novo = String.Format(" INSERT INTO clientes VALUES('{0}','{1}','{2}')", txtCodigo.Text, txtNome.Text, rdbM.Text);
                modifica(novo);

            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (rdbF.Checked) {
                String atualiza = String.Format("UPDATE clientes SET nome='{0}', sexo='{1}' WHERE codigo= '{2}'",
                txtNome.Text, rdbF.Text, txtCodigo.Text);
            modifica(atualiza);
            }
            else { 
            String atualiza = String.Format("UPDATE clientes SET nome='{0}', sexo='{1}' WHERE codigo= '{2}'",
            txtNome.Text, rdbM.Text, txtCodigo.Text);
            modifica(atualiza);
            }
        }

        private void btnPrimeiro_Click(object sender, EventArgs e)
        {
            String primeiro = "SELECT * FROM clientes LIMIT 1";
            pesquisar(primeiro);
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            String anterior = String.Format("Select * FROM clientes WHERE codigo < {0} ORDER BY codigo DESC LIMIT 1", txtCodigo.Text);
            pesquisar(anterior);
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            String proximo = String.Format("SELECT * FROM clientes WHERE codigo > {0} LIMIT 1 ", txtCodigo.Text);
            pesquisar(proximo);
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            String ultimo = "SELECT * FROM clientes ORDER BY codigo DESC LIMIT 1 ";
            pesquisar(ultimo);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }
    }
}
