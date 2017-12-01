using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Drawing;

namespace scoringProject.Logic
{
    public static class DataGridViewer
    {
        public static void FillDataGrid(ClientPage form)
        {
            //инициилизация датагрида
            DataGridView dtv = new DataGridView();

            //установка свойств дата грида
            dtv.RowHeadersVisible = false;
            dtv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtv.Size = new Size(340, 139);
            dtv.Location = new Point(332, 172);
            dtv.AllowUserToAddRows = false;
            dtv.AllowUserToDeleteRows = false;
            dtv.ReadOnly = true;

            DataSet ds = InteractionDB.FillDataGrid(Client.getInstance().ID);
            DataTable dt = ds.Tables[0];
            dt.Columns[0].ColumnName = "Тип кредита";
            dt.Columns[1].ColumnName = "Полученный балл";
            dt.Columns[2].ColumnName = "Результат";
            dtv.DataSource = dt;
            dtv.CellFormatting += Dtv_CellFormatting;

       /*     for (int i = 0; i < dtv.Rows.Count; i++)
            {
                if (dtv.Rows[i].Cells[2].Value.ToString() == "Yes")
                    dtv.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                else dtv.Rows[i].DefaultCellStyle.BackColor = Color.Red;
            } */


            form.Controls.Add(dtv);
          //  dtv.Rows.RemoveAt(dtv.Rows.Count - 2);

        }

        private static void Dtv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridView dtv = (DataGridView)sender;
                if (dtv.Rows[e.RowIndex].Cells[2].Value.ToString() == "Одобрено")
                    e.CellStyle.BackColor = Color.Green;
                else e.CellStyle.BackColor = Color.Red;
        }
    }
}
