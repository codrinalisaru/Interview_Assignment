using ClosedXML.Excel;
using iTextSharp.text;
using iTextSharp.text.pdf;
using MySql.Data.MySqlClient;
using System.Data;

namespace Ex2App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ExportToPdf(DataGridView dgv, string fileName)
        {
            Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 20f, 20f);
            PdfWriter.GetInstance(pdfDoc, new FileStream(fileName, FileMode.Create));
            pdfDoc.Open();

            PdfPTable pdfTable = new PdfPTable(dgv.ColumnCount);

            foreach (DataGridViewColumn column in dgv.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                cell.BackgroundColor = BaseColor.LIGHT_GRAY;
                pdfTable.AddCell(cell);
            }
            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (row.IsNewRow) continue;

                foreach (DataGridViewCell cell in row.Cells)
                {
                    pdfTable.AddCell(cell.Value?.ToString() ?? "");
                }
            }

            pdfDoc.Add(pdfTable);
            pdfDoc.Close();

        }

        private void ExportToExcel(DataGridView dgv, string filename)
        {
            DataTable dt = new DataTable();

            foreach (DataGridViewColumn column in dgv.Columns)
            {
                dt.Columns.Add(column.HeaderText, typeof(string));
            }

            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (row.IsNewRow) continue;
                DataRow dr = dt.NewRow();
                for (int i = 0; i < dgv.ColumnCount; i++)
                {
                    dr[i] = row.Cells[i].Value?.ToString() ?? "";
                }
                dt.Rows.Add(dr);
            }

            using (XLWorkbook wb = new XLWorkbook())
            {
                wb.Worksheets.Add(dt, "TabelDate");
                wb.SaveAs(filename);
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            try
            {
                string connstring = "server = localhost; uid = root; pwd = password; database = import_excel";
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = connstring;
                con.Open();
                string sql = "select * from import_excel.sales";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                MessageBox.Show("Connected successfully");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }


        private void button6_Click(object sender, EventArgs e)
        {
            string connstring = "server = localhost; uid = root; pwd = password; database = import_excel";
            using (MySqlConnection conn = new MySqlConnection(connstring))
            {
                try
                {
                    conn.Open();
                    string query = "DELETE FROM import_excel.sales WHERE id = @id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@id", textBox7.Text);

                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Data removed successfully");
                        textBox7.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("An error has occurred");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            string connstring = "server = localhost; uid = root; pwd = password; database = import_excel";
            using (MySqlConnection conn = new MySqlConnection(connstring))
            {
                conn.Open();
                string query = "SELECT * FROM import_excel.sales";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            string connstring = "server = localhost; uid = root; pwd = password; database = import_excel";
            using (MySqlConnection conn = new MySqlConnection(connstring))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO import_excel.sales (Code, Month, Sales) VALUES (@Code, @Month, @Sales)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@Code", textBox1.Text);
                    cmd.Parameters.AddWithValue("@Month", textBox8.Text);
                    cmd.Parameters.AddWithValue("@Sales", textBox12.Text);

                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Data insert successfully");
                        textBox1.Text = "";
                        textBox8.Text = "";
                        textBox12.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("An error has occurred");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string connstring = "server = localhost; uid = root; pwd = password; database = import_excel";
            using (MySqlConnection conn = new MySqlConnection(connstring))
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE import_excel.sales SET Code = @Code, Month = @Month, Sales = @Sales WHERE id = @id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@id", textBox2.Text);
                    cmd.Parameters.AddWithValue("@Code", textBox3.Text);
                    cmd.Parameters.AddWithValue("@Month", textBox6.Text);
                    cmd.Parameters.AddWithValue("@Sales", textBox10.Text);

                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Data updated successfully");
                        textBox2.Text = "";
                        textBox3.Text = "";
                        textBox6.Text = "";
                        textBox10.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("An error has occurred");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
            saveFileDialog.FileName = "RaportDate.pdf";
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                ExportToPdf(dataGridView1, saveFileDialog.FileName);
                MessageBox.Show("Successfully saved as PDF");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx";
            saveFileDialog.FileName = "RaportDate.xlsx";
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                ExportToExcel(dataGridView1, saveFileDialog.FileName);
                MessageBox.Show("Successfully saved as Excel");
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
