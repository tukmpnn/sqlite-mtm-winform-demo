using Microsoft.EntityFrameworkCore;

namespace sqlite_mtm_winform_demo
{
    public partial class DemoForm : Form
    {
        private readonly MyContext _context = new MyContext();
        public DemoForm()
        {
            InitializeComponent();
            _context.Database.EnsureCreated();
            RefreshMerchants();
            RefreshWares();
            RefreshMerchantsHasWares();
        }

        /// <summary>
        /// Clear ChangeTracked and reload context
        /// </summary>
        private void RefreshContextAfterFail()
        {
            _context.ChangeTracker.Clear();
            _context.Merchants.Load();
            _context.MerchantHasWares.Load();
            _context.Wares.Load();
        }
        /// <summary>
        /// Reload context
        /// </summary>
        private void RefreshContext()
        {
            _context.Merchants.Load();
            _context.MerchantHasWares.Load();
            _context.Wares.Load();
        }
        public void RefreshMerchants()
        {
            _context.Merchants.Load();
            DGW_Merchant.DataSource = _context.Merchants.ToList();
            DGW_Merchant.Refresh();
        }

        public void RefreshWares()
        {
            _context.Wares.Load();
            DGW_Ware.DataSource = _context.Wares.ToList();
            DGW_Ware.Refresh();
        }

        public void RefreshMerchantsHasWares()
        {
            GenerateMerchatHasWaresTable();
        }

        private void DemoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _context.Dispose();
        }

        private void Btn_AddNewMerchant_Click(object sender, EventArgs e)
        {
            Merchant newMerchant = new Merchant();
            newMerchant.Name = Tb_NewMerchantName.Text;
            _context.Merchants.Add(newMerchant);
            _context.SaveChanges();
            Tb_NewMerchantName.Clear();
            RefreshMerchants();
        }

        private void Btn_AddNewWare_Click(object sender, EventArgs e)
        {
            Ware newWare = new Ware();
            newWare.Name = Tb_NewWareName.Text;
            _context.Wares.Add(newWare);
            _context.SaveChanges();
            Tb_NewWareName.Clear();
            RefreshWares();
        }

        private void Btn_AddSelectedWare_Click(object sender, EventArgs e)
        {        
            try
            {
                MerchantHasWares newMHW = new MerchantHasWares();
                newMHW.MerchantID = int.Parse(DGW_Merchant.CurrentRow.Cells[0].Value.ToString());
                newMHW.WareId = int.Parse(DGW_Ware.CurrentRow.Cells[0].Value.ToString());
                newMHW.Amount = (int)Nud_WareAmount.Value;
                _context.MerchantHasWares.Add(newMHW);
                _context.SaveChanges();
                RefreshMerchantsHasWares();
            }
            catch (InvalidOperationException)
            {
                RefreshContextAfterFail();
                MessageBox.Show(
                    "Error adding new ware to merchant. Duplicate entries not allowed",
                    "Error",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Error);
            }
            catch (NullReferenceException)
            {
                RefreshContextAfterFail();
                MessageBox.Show(
                    "Error adding new ware to merchant. Merchant and Ware have to be selected",
                    "Error",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Error);
            }
        }

        private void Btn_RemoveSelectedWare_Click(object sender, EventArgs e)
        {
            try
            {
                string merchantName = DGW_MerchantHasWares.CurrentRow.Cells[0].Value.ToString();
                string wareName = DGW_MerchantHasWares.CurrentRow.Cells[1].Value.ToString();
                int wareAmount = int.Parse(DGW_MerchantHasWares.CurrentRow.Cells[2].Value.ToString());

                MerchantHasWares victimMHW = _context.MerchantHasWares.First(x => x.Merchant.Name == merchantName && x.Ware.Name == wareName && x.Amount == wareAmount);
                _context.MerchantHasWares.Remove(victimMHW);
                _context.SaveChanges();
                RefreshMerchantsHasWares();
            }
            catch (NullReferenceException)
            {
                RefreshContextAfterFail();
                MessageBox.Show(
                    "Error removing wares from merchant. Cannot delete if nothing is selected",
                    "Error",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Error);
            }
        }

        private void GenerateMerchatHasWaresTable()
        {
            RefreshContext();

            //Generate Columns
            if (DGW_MerchantHasWares.Columns.Count != 3)
            {
                int columnWidth = DGW_MerchantHasWares.Width / 3;
                DGW_MerchantHasWares.Columns.Add("Merchant", "Merchant");
                DGW_MerchantHasWares.Columns[0].Width = columnWidth;
                DGW_MerchantHasWares.Columns.Add("Ware", "Ware");
                DGW_MerchantHasWares.Columns[1].Width = columnWidth;
                DGW_MerchantHasWares.Columns.Add("Amount", "Amount");
                //-3 to get rid of horizontal scroll bar
                DGW_MerchantHasWares.Columns[2].Width = columnWidth - 3;
            }

            //Clear previously generated rows
            DGW_MerchantHasWares.Rows.Clear();

            //Check if table has entries
            if (_context.MerchantHasWares.Any())
            {
                //Add each row
                foreach (var mhw in _context.MerchantHasWares)
                {
                    DGW_MerchantHasWares.Rows.Add(mhw.Merchant.Name, mhw.Ware.Name, mhw.Amount);
                }
            }
        }
    }
}