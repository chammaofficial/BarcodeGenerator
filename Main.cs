using BarcodeGenerator.LabelTypes;
using DevExpress.XtraReports.Parameters;
using DevExpress.XtraReports.UI;
using System;

namespace BarcodeGenerator
{
    public partial class Main : DevExpress.XtraEditors.XtraForm
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            TwoByOne one = new TwoByOne();

            one.Parameters["ShopName"].Value = txtShopName.Text;
            one.Parameters["ItemName"].Value = txtItemName.Text;
            one.Parameters["ItemPrice"].Value = txtItemPrice.Text;
            one.Parameters["BarcodeValue"].Value = txtBarcodeValue.Text;

            one.Parameters["ItemNameIsBold"].Value = chkItemNameBold.Checked;
            one.Parameters["ItemPriceIsBold"].Value = chkItemPriceBold.Checked;
            one.Parameters["ShopNameIsBold"].Value = chkShopNameBold.Checked;

            one.Parameters["ItemNameFontSize"].Value = numItemNameFont.Value;
            one.Parameters["ItemPriceFontSize"].Value = numItemPriceFont.Value;
            one.Parameters["ShopNameFontSize"].Value = numShopNameFont.Value;

            one.RequestParameters = false;
            one.ShowPreview();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void txtBarcodeValue_TextChanged(object sender, EventArgs e)
        {
            txtItemCode.Text = txtBarcodeValue.Text;
        }
    }
}
