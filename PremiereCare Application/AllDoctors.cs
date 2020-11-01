using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PremiereCare_Application
{
   
    public partial class AllDoctors : Form
    {
        User.Doctor doctor = new User.Doctor();
        public AllDoctors()
        {
            InitializeComponent();
        }


        public class CustomHeaderCell : DataGridViewRowHeaderCell
        {
            protected override Size GetPreferredSize(Graphics graphics, DataGridViewCellStyle cellStyle, int rowIndex, Size constraintSize)
            {
                var size1 = base.GetPreferredSize(graphics, cellStyle, rowIndex, constraintSize);
                var value = string.Format("{0}", this.DataGridView.Rows[rowIndex].HeaderCell.FormattedValue);
                var size2 = TextRenderer.MeasureText(value, cellStyle.Font);
                var padding = cellStyle.Padding;
                return new Size(size2.Width + padding.Left + padding.Right, size1.Height);
            }
            protected override void Paint(Graphics graphics, Rectangle clipBounds, Rectangle cellBounds, int rowIndex, DataGridViewElementStates cellState, object value, object formattedValue, string errorText, DataGridViewCellStyle cellStyle, DataGridViewAdvancedBorderStyle advancedBorderStyle, DataGridViewPaintParts paintParts)
            {
                base.Paint(graphics, clipBounds, cellBounds, rowIndex, cellState, value, formattedValue, errorText, cellStyle, advancedBorderStyle, DataGridViewPaintParts.Background);
                base.PaintBorder(graphics, clipBounds, cellBounds, cellStyle, advancedBorderStyle);
                TextRenderer.DrawText(graphics, string.Format("{0}", formattedValue), cellStyle.Font, cellBounds, cellStyle.ForeColor);
            }
        }

        private void PopulateDataGridView()
        {
            DataTable dt = doctor.GetAllDoctors();
            dgvAllDoctors.DataSource = dt;
        }

        private void StyleDataGridView()
        {
            //dgvAllDoctors.RowTemplate.DefaultHeaderCellType = typeof(CustomHeaderCell);
            //dgvAllDoctors.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            //dgvAllDoctors.RowHeadersDefaultCellStyle.Padding = new Padding(2);
            dgvAllDoctors.BorderStyle = BorderStyle.None;
            dgvAllDoctors.RowsDefaultCellStyle.BackColor = Color.FromArgb(227, 224, 217);
            dgvAllDoctors.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            //dgvAllDoctors.DefaultCellStyle.SelectionBackColor = Color.FromArgb(53, 64, 82);
            //dgvAllDoctors.DefaultCellStyle.SelectionForeColor = Color.FromArgb(227, 224, 217);
            dgvAllDoctors.BackgroundColor = Color.FromArgb(227, 224, 217);
            dgvAllDoctors.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvAllDoctors.EnableHeadersVisualStyles = false;
            dgvAllDoctors.ColumnHeadersDefaultCellStyle.Font = new Font("Calib", 10);
            dgvAllDoctors.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(227, 224, 217);
            dgvAllDoctors.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(53, 64, 82);
        }

        private void AllDoctors_Load(object sender, EventArgs e)
        {
            StyleDataGridView();
            PopulateDataGridView();
        }
            


    }
}
