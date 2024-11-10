using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgroByte_Desktop
{
    public partial class RelatorioCadastros : UserControl
    {
        public RelatorioCadastros()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection(@"Data Source=ALBANY;Initial Catalog=Agrobyte;Integrated Security=SSPI");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dt;


        private void ExportarParaExcel(DataGridView dgv)
        {
            using (var workbook = new ClosedXML.Excel.XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Relatório");

                // Cabeçalho das colunas
                for (int i = 0; i < dgv.Columns.Count; i++)
                {
                    worksheet.Cell(1, i + 1).Value = dgv.Columns[i].HeaderText;
                }

                // Dados das linhas
                for (int i = 0; i < dgv.Rows.Count; i++)
                {
                    for (int j = 0; j < dgv.Columns.Count; j++)
                    {
                        // Garantir que o valor da célula seja tratado como string
                        var cellValue = dgv.Rows[i].Cells[j].Value;

                        // Preenchendo a célula da planilha com o valor correto
                        worksheet.Cell(i + 2, j + 1).Value = cellValue != null ? cellValue.ToString() : string.Empty;
                    }
                }

                // Salvar o arquivo
                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "Excel Files|*.xlsx",
                    FileName = "Relatorio.xlsx"
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    workbook.SaveAs(saveFileDialog.FileName);
                    MessageBox.Show("Relatório exportado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        //
        private void ExportarParaPDF(DataGridView dgv)
        {
            // Criar o documento PDF
            Document documento = new Document();
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Arquivos PDF (*.pdf)|*.pdf";
            saveFileDialog.FileName = "Relatorio_Cadastros.pdf";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                PdfWriter.GetInstance(documento, new System.IO.FileStream(saveFileDialog.FileName, System.IO.FileMode.Create));

                // Abrir o documento
                documento.Open();

                // Criar a tabela no PDF com o número de colunas igual ao do DataGridView
                PdfPTable tabela = new PdfPTable(dgv.Columns.Count);

                // Adicionar os cabeçalhos da tabela (nomes das colunas)
                foreach (DataGridViewColumn coluna in dgv.Columns)
                {
                    tabela.AddCell(new Phrase(coluna.HeaderText)); // Adiciona o texto do cabeçalho
                }

                // Adicionar os dados das linhas do DataGridView à tabela no PDF
                foreach (DataGridViewRow linha in dgv.Rows)
                {
                    if (linha.IsNewRow) continue;  // Ignora a última linha vazia do DataGridView

                    foreach (DataGridViewCell celula in linha.Cells)
                    {
                        // Converte o valor da célula para string antes de passar para o PDF
                        tabela.AddCell(new Phrase(celula.Value != null ? celula.Value.ToString() : ""));
                    }
                }

                // Adiciona a tabela ao documento
                documento.Add(tabela);

                // Fecha o documento PDF
                documento.Close();

                // Informa ao usuário que o relatório foi gerado com sucesso
                MessageBox.Show("Relatório gerado com sucesso!", "Relatório", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }



        //
        private void button1_Click(object sender, EventArgs e)
        {


            try
            {
                cn.Open();
                cm.CommandText = "select * from VWCadastro2 ";
                cm.Connection = cn;



                SqlDataAdapter da = new SqlDataAdapter(); // recebe os dados de uma tabela após a execução de um select

                DataTable dt = new DataTable(); // representa uma ou mais tabela de dados que ficam na memoria para serem manipuladas

                da.SelectCommand = cm; // pega o resultado do select e inclui no da
                da.Fill(dt);// preencher a tabela 
                dataGridViewRel.DataSource = dt; // envia para o dataGridFunc a tabela
                cn.Close(); // fecha a conexão com o banco de dados


            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);

            }


        }



        private void buttonExpRel_Click(object sender, EventArgs e)
        {
            ExportarParaExcel(dataGridViewRel);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ExportarParaPDF(dataGridViewRel);
        }
    }
}


