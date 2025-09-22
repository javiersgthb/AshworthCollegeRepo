using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;

namespace RestaurantBillCalculator
{
    public partial class BillForm : Form
    {
        // ===== Configuration =====
        private const decimal TaxRate = 0.0825m; // 8.25% – Tax Rate for Texas

        // ===== Menu data (swap to match Deitel Fig. 15.52 if required) =====
        private readonly Dictionary<string, decimal> _beverages = new()
        {
            { "(none)", 0.00m },
            { "Soda", 1.95m },
            { "Tea", 1.50m },
            { "Coffee", 1.25m },
            { "Mineral Water", 2.95m },
            { "Juice", 2.50m },
            { "Milk", 1.50m }
        };

        private readonly Dictionary<string, decimal> _appetizers = new()
        {
            { "(none)", 0.00m },
            { "Buffalo Wings", 5.95m },
            { "Buffalo Fingers", 6.95m },
            { "Potato Skins", 8.95m },
            { "Nachos", 8.95m },
            { "Mushroom Caps", 10.95m },
            { "Shrimp Cocktail", 12.95m },
            { "Chips and Salsa", 6.95m }
        };

        private readonly Dictionary<string, decimal> _mains = new()
        {
            { "(none)", 0.00m },
            { "Seafood Alfredo", 15.95m },
            { "Chicken Alfredo", 13.95m },
            { "Chicken Picatta", 13.95m },
            { "Turkey Club", 11.95m },
            { "Lobster Pie", 19.95m },
            { "Prime Rib", 20.95m },
            { "Shrimp Scampi", 18.95m },
            { "Turkey Dinner", 13.95m },
            { "Stuffed Chicken", 14.95m }
        };

        private readonly Dictionary<string, decimal> _desserts = new()
        {
            { "(none)", 0.00m },
            { "Apple Pie", 5.95m },
            { "Sundae", 3.95m },
            { "Carrot Cake", 5.95m },
            { "Mud Pie", 4.95m },
            { "Apple Crisp", 5.95m }
        };

        public BillForm()
        {
            InitializeComponent();
            // Bind menu options to ComboBoxes
            BindCombo(cboBeverage, _beverages);
            BindCombo(cboAppetizer, _appetizers);
            BindCombo(cboMainCourse, _mains);
            BindCombo(cboDessert, _desserts);

            // Initial totals
            UpdateTotals();
        }

        private void BindCombo(ComboBox combo, Dictionary<string, decimal> source)
        {
            combo.Items.Clear();
            foreach (var kv in source)
            {
                combo.Items.Add($"{kv.Key} ({kv.Value.ToString("C", CultureInfo.CurrentCulture)})");
            }
            combo.SelectedIndex = 0; // "(none)"
        }

        private decimal GetSelectedPrice(ComboBox combo, Dictionary<string, decimal> source)
        {
            if (combo.SelectedIndex < 0) return 0m;
            var display = combo.SelectedItem?.ToString() ?? string.Empty;
            var cut = display.LastIndexOf(" (", StringComparison.Ordinal);
            var name = (cut > 0) ? display.Substring(0, cut) : display;
            return source.TryGetValue(name, out var price) ? price : 0m;
        }

        private void UpdateTotals()
        {
            decimal subtotal = 0m;
            subtotal += GetSelectedPrice(cboBeverage, _beverages);
            subtotal += GetSelectedPrice(cboAppetizer, _appetizers);
            subtotal += GetSelectedPrice(cboMainCourse, _mains);
            subtotal += GetSelectedPrice(cboDessert, _desserts);

            var tax = Math.Round(subtotal * TaxRate, 2);
            var total = subtotal + tax;

            lblSubtotalValue.Text = subtotal.ToString("C");
            lblTaxValue.Text = tax.ToString("C");
            lblTotalValue.Text = total.ToString("C");
        }

        // ===== Event handlers wired in Designer =====
        private void cboBeverage_SelectedIndexChanged(object sender, EventArgs e) => UpdateTotals();
        private void cboAppetizer_SelectedIndexChanged(object sender, EventArgs e) => UpdateTotals();
        private void cboMainCourse_SelectedIndexChanged(object sender, EventArgs e) => UpdateTotals();
        private void cboDessert_SelectedIndexChanged(object sender, EventArgs e) => UpdateTotals();

        private void btnClearBill_Click(object sender, EventArgs e)
        {
            cboBeverage.SelectedIndex = 0;
            cboAppetizer.SelectedIndex = 0;
            cboMainCourse.SelectedIndex = 0;
            cboDessert.SelectedIndex = 0;
            UpdateTotals();
        }
    }
}
