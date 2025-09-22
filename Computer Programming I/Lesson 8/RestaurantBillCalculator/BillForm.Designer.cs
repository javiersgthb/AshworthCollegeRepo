using System.Drawing;
using System.Windows.Forms;

namespace RestaurantBillCalculator
{
    partial class BillForm
    {
        private System.ComponentModel.IContainer components = null;

        private TableLayoutPanel table;
        private Label lblBeverage;
        private Label lblAppetizer;
        private Label lblMain;
        private Label lblDessert;
        private ComboBox cboBeverage;
        private ComboBox cboAppetizer;
        private ComboBox cboMainCourse;
        private ComboBox cboDessert;

        private Label lblSubtotal;
        private Label lblTax;
        private Label lblTotal;
        private Label lblSubtotalValue;
        private Label lblTaxValue;
        private Label lblTotalValue;

        private Button btnClearBill;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();

            // Form
            this.Text = "Restaurant Bill Calculator";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MinimumSize = new Size(640, 420);
            this.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);

            // TableLayoutPanel
            table = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 2,
                RowCount = 8,
                Padding = new Padding(16)
            };
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65F));
            for (int i = 0; i < 8; i++)
                table.RowStyles.Add(new RowStyle(SizeType.AutoSize));

            // Labels
            lblBeverage = new Label { Text = "Beverage:", AutoSize = true, Anchor = AnchorStyles.Left };
            lblAppetizer = new Label { Text = "Appetizer:", AutoSize = true, Anchor = AnchorStyles.Left };
            lblMain = new Label { Text = "Main Course:", AutoSize = true, Anchor = AnchorStyles.Left };
            lblDessert = new Label { Text = "Dessert:", AutoSize = true, Anchor = AnchorStyles.Left };

            // ComboBoxes
            cboBeverage = new ComboBox { DropDownStyle = ComboBoxStyle.DropDownList, Anchor = AnchorStyles.Left | AnchorStyles.Right };
            cboAppetizer = new ComboBox { DropDownStyle = ComboBoxStyle.DropDownList, Anchor = AnchorStyles.Left | AnchorStyles.Right };
            cboMainCourse = new ComboBox { DropDownStyle = ComboBoxStyle.DropDownList, Anchor = AnchorStyles.Left | AnchorStyles.Right };
            cboDessert = new ComboBox { DropDownStyle = ComboBoxStyle.DropDownList, Anchor = AnchorStyles.Left | AnchorStyles.Right };

            // Totals labels
            lblSubtotal = new Label { Text = "Subtotal:", AutoSize = true, Anchor = AnchorStyles.Left };
            lblTax = new Label { Text = "Tax:", AutoSize = true, Anchor = AnchorStyles.Left };
            lblTotal = new Label { Text = "Total:", AutoSize = true, Anchor = AnchorStyles.Left, Font = new Font(this.Font, FontStyle.Bold) };

            lblSubtotalValue = new Label { Text = "$0.00", AutoSize = true, Anchor = AnchorStyles.Left };
            lblTaxValue = new Label { Text = "$0.00", AutoSize = true, Anchor = AnchorStyles.Left };
            lblTotalValue = new Label { Text = "$0.00", AutoSize = true, Anchor = AnchorStyles.Left, Font = new Font(this.Font, FontStyle.Bold) };

            // Clear button
            btnClearBill = new Button { Text = "Clear Bill", AutoSize = true, Anchor = AnchorStyles.Left };
            btnClearBill.Click += btnClearBill_Click;

            // Wire selection events
            cboBeverage.SelectedIndexChanged += cboBeverage_SelectedIndexChanged;
            cboAppetizer.SelectedIndexChanged += cboAppetizer_SelectedIndexChanged;
            cboMainCourse.SelectedIndexChanged += cboMainCourse_SelectedIndexChanged;
            cboDessert.SelectedIndexChanged += cboDessert_SelectedIndexChanged;

            // Add controls to table
            table.Controls.Add(lblBeverage, 0, 0);
            table.Controls.Add(cboBeverage, 1, 0);

            table.Controls.Add(lblAppetizer, 0, 1);
            table.Controls.Add(cboAppetizer, 1, 1);

            table.Controls.Add(lblMain, 0, 2);
            table.Controls.Add(cboMainCourse, 1, 2);

            table.Controls.Add(lblDessert, 0, 3);
            table.Controls.Add(cboDessert, 1, 3);

            table.Controls.Add(lblSubtotal, 0, 4);
            table.Controls.Add(lblSubtotalValue, 1, 4);

            table.Controls.Add(lblTax, 0, 5);
            table.Controls.Add(lblTaxValue, 1, 5);

            table.Controls.Add(lblTotal, 0, 6);
            table.Controls.Add(lblTotalValue, 1, 6);

            table.Controls.Add(btnClearBill, 0, 7);

            // Add table to form
            this.Controls.Add(table);
        }
    }
}
