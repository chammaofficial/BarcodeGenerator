namespace BarcodeGenerator.LabelTypes
{
    partial class TwoByOne
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraPrinting.BarCode.Code11Generator code11Generator1 = new DevExpress.XtraPrinting.BarCode.Code11Generator();
            DevExpress.XtraPrinting.BarCode.Code11Generator code11Generator2 = new DevExpress.XtraPrinting.BarCode.Code11Generator();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.xrBarCode1 = new DevExpress.XtraReports.UI.XRBarCode();
            this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrBarCode2 = new DevExpress.XtraReports.UI.XRBarCode();
            this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.ShopName = new DevExpress.XtraReports.Parameters.Parameter();
            this.ItemName = new DevExpress.XtraReports.Parameters.Parameter();
            this.ItemPrice = new DevExpress.XtraReports.Parameters.Parameter();
            this.BarcodeValue = new DevExpress.XtraReports.Parameters.Parameter();
            this.ShopNameIsBold = new DevExpress.XtraReports.Parameters.Parameter();
            this.ItemNameIsBold = new DevExpress.XtraReports.Parameters.Parameter();
            this.ItemPriceIsBold = new DevExpress.XtraReports.Parameters.Parameter();
            this.ShopNameFontSize = new DevExpress.XtraReports.Parameters.Parameter();
            this.ItemNameFontSize = new DevExpress.XtraReports.Parameters.Parameter();
            this.ItemPriceFontSize = new DevExpress.XtraReports.Parameters.Parameter();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // TopMargin
            // 
            this.TopMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrBarCode1,
            this.xrLabel7,
            this.xrBarCode2,
            this.xrLabel5,
            this.xrLabel4,
            this.xrLabel3,
            this.xrLabel2,
            this.xrLabel1});
            this.TopMargin.HeightF = 103.3333F;
            this.TopMargin.Name = "TopMargin";
            // 
            // xrBarCode1
            // 
            this.xrBarCode1.Alignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrBarCode1.AnchorHorizontal = ((DevExpress.XtraReports.UI.HorizontalAnchorStyles)((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left | DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)));
            this.xrBarCode1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "?BarcodeValue")});
            this.xrBarCode1.LocationFloat = new DevExpress.Utils.PointFloat(6.357829E-06F, 54.00002F);
            this.xrBarCode1.Name = "xrBarCode1";
            this.xrBarCode1.Padding = new DevExpress.XtraPrinting.PaddingInfo(10, 10, 0, 0, 100F);
            this.xrBarCode1.SizeF = new System.Drawing.SizeF(187.5F, 31.66663F);
            this.xrBarCode1.StylePriority.UseTextAlignment = false;
            this.xrBarCode1.Symbology = code11Generator1;
            this.xrBarCode1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel7
            // 
            this.xrLabel7.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "?ItemPrice")});
            this.xrLabel7.LocationFloat = new DevExpress.Utils.PointFloat(212.5F, 36.00001F);
            this.xrLabel7.Multiline = true;
            this.xrLabel7.Name = "xrLabel7";
            this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel7.SizeF = new System.Drawing.SizeF(187.5F, 18F);
            this.xrLabel7.StylePriority.UseTextAlignment = false;
            this.xrLabel7.Text = "xrLabel5";
            this.xrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrBarCode2
            // 
            this.xrBarCode2.Alignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrBarCode2.AnchorHorizontal = ((DevExpress.XtraReports.UI.HorizontalAnchorStyles)((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left | DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)));
            this.xrBarCode2.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "?BarcodeValue")});
            this.xrBarCode2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrBarCode2.LocationFloat = new DevExpress.Utils.PointFloat(213.5F, 54.00002F);
            this.xrBarCode2.Name = "xrBarCode2";
            this.xrBarCode2.Padding = new DevExpress.XtraPrinting.PaddingInfo(10, 10, 0, 0, 100F);
            this.xrBarCode2.SizeF = new System.Drawing.SizeF(187.5F, 31.66663F);
            this.xrBarCode2.StylePriority.UseFont = false;
            this.xrBarCode2.StylePriority.UseTextAlignment = false;
            this.xrBarCode2.Symbology = code11Generator2;
            this.xrBarCode2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel5
            // 
            this.xrLabel5.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "?ItemPrice")});
            this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(0F, 36.00001F);
            this.xrLabel5.Multiline = true;
            this.xrLabel5.Name = "xrLabel5";
            this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel5.SizeF = new System.Drawing.SizeF(187.5F, 18F);
            this.xrLabel5.StylePriority.UseTextAlignment = false;
            this.xrLabel5.Text = "xrLabel5";
            this.xrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel4
            // 
            this.xrLabel4.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "?ItemName")});
            this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(212.5F, 17.16667F);
            this.xrLabel4.Multiline = true;
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel4.SizeF = new System.Drawing.SizeF(187.5F, 18.83333F);
            this.xrLabel4.StylePriority.UseTextAlignment = false;
            this.xrLabel4.Text = "xrLabel3";
            this.xrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel3
            // 
            this.xrLabel3.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "?ItemName")});
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(0F, 17.16667F);
            this.xrLabel3.Multiline = true;
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(187.5F, 18.83333F);
            this.xrLabel3.StylePriority.UseTextAlignment = false;
            this.xrLabel3.Text = "xrLabel3";
            this.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel2
            // 
            this.xrLabel2.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "?ShopName")});
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(212.5F, 0F);
            this.xrLabel2.Multiline = true;
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(187.5F, 17.16667F);
            this.xrLabel2.StylePriority.UseTextAlignment = false;
            this.xrLabel2.Text = "xrLabel1";
            this.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel1
            // 
            this.xrLabel1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "?ShopName")});
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel1.Multiline = true;
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(187.5F, 17.16667F);
            this.xrLabel1.StylePriority.UseTextAlignment = false;
            this.xrLabel1.Text = "xrLabel1";
            this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 0F;
            this.BottomMargin.Name = "BottomMargin";
            // 
            // Detail
            // 
            this.Detail.HeightF = 0F;
            this.Detail.Name = "Detail";
            // 
            // ShopName
            // 
            this.ShopName.AllowNull = true;
            this.ShopName.Description = "Shop Name";
            this.ShopName.Name = "ShopName";
            // 
            // ItemName
            // 
            this.ItemName.AllowNull = true;
            this.ItemName.Description = "Item Name";
            this.ItemName.Name = "ItemName";
            // 
            // ItemPrice
            // 
            this.ItemPrice.AllowNull = true;
            this.ItemPrice.Description = "Price";
            this.ItemPrice.Name = "ItemPrice";
            // 
            // BarcodeValue
            // 
            this.BarcodeValue.AllowNull = true;
            this.BarcodeValue.Description = "Barcode Value";
            this.BarcodeValue.Name = "BarcodeValue";
            // 
            // ShopNameIsBold
            // 
            this.ShopNameIsBold.Description = "Is Shop Name Bold";
            this.ShopNameIsBold.Name = "ShopNameIsBold";
            this.ShopNameIsBold.Type = typeof(bool);
            this.ShopNameIsBold.ValueInfo = "False";
            // 
            // ItemNameIsBold
            // 
            this.ItemNameIsBold.Description = "Is Item Name Bold";
            this.ItemNameIsBold.Name = "ItemNameIsBold";
            this.ItemNameIsBold.Type = typeof(bool);
            this.ItemNameIsBold.ValueInfo = "False";
            // 
            // ItemPriceIsBold
            // 
            this.ItemPriceIsBold.Description = "Is Item Price Bold";
            this.ItemPriceIsBold.Name = "ItemPriceIsBold";
            this.ItemPriceIsBold.Type = typeof(bool);
            this.ItemPriceIsBold.ValueInfo = "False";
            // 
            // ShopNameFontSize
            // 
            this.ShopNameFontSize.Description = "Shop Name Font Size";
            this.ShopNameFontSize.Name = "ShopNameFontSize";
            this.ShopNameFontSize.Type = typeof(decimal);
            this.ShopNameFontSize.ValueInfo = "10";
            // 
            // ItemNameFontSize
            // 
            this.ItemNameFontSize.Description = "Item Name Font Size";
            this.ItemNameFontSize.Name = "ItemNameFontSize";
            this.ItemNameFontSize.Type = typeof(decimal);
            this.ItemNameFontSize.ValueInfo = "10";
            // 
            // ItemPriceFontSize
            // 
            this.ItemPriceFontSize.Description = "Item Price Font Size";
            this.ItemPriceFontSize.Name = "ItemPriceFontSize";
            this.ItemPriceFontSize.Type = typeof(decimal);
            this.ItemPriceFontSize.ValueInfo = "10";
            // 
            // TwoByOne
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.Detail});
            this.Font = new System.Drawing.Font("Arial", 9.75F);
            this.Margins = new System.Drawing.Printing.Margins(0, 2, 103, 0);
            this.PageHeight = 888;
            this.PageWidth = 403;
            this.PaperKind = System.Drawing.Printing.PaperKind.Custom;
            this.ParameterPanelLayoutItems.AddRange(new DevExpress.XtraReports.Parameters.ParameterPanelLayoutItem[] {
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.ShopName, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.ItemName, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.ItemPrice, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.BarcodeValue, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.ShopNameIsBold, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.ItemNameIsBold, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.ItemPriceIsBold, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.ShopNameFontSize, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.ItemNameFontSize, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.ItemPriceFontSize, DevExpress.XtraReports.Parameters.Orientation.Horizontal)});
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.ShopName,
            this.ItemName,
            this.ItemPrice,
            this.BarcodeValue,
            this.ShopNameIsBold,
            this.ItemNameIsBold,
            this.ItemPriceIsBold,
            this.ShopNameFontSize,
            this.ItemNameFontSize,
            this.ItemPriceFontSize});
            this.Scripts.OnAfterPrint = "TwoByOne_AfterPrint";
            this.Scripts.OnBeforePrint = "TwoByOne_BeforePrint";
            this.Version = "22.1";
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.Parameters.Parameter ShopName;
        private DevExpress.XtraReports.UI.XRLabel xrLabel7;
        private DevExpress.XtraReports.UI.XRBarCode xrBarCode2;
        private DevExpress.XtraReports.UI.XRLabel xrLabel5;
        private DevExpress.XtraReports.UI.XRLabel xrLabel4;
        private DevExpress.XtraReports.UI.XRLabel xrLabel3;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        private DevExpress.XtraReports.Parameters.Parameter ItemName;
        private DevExpress.XtraReports.Parameters.Parameter ItemPrice;
        private DevExpress.XtraReports.Parameters.Parameter BarcodeValue;
        private DevExpress.XtraReports.UI.XRBarCode xrBarCode1;
        private DevExpress.XtraReports.Parameters.Parameter ShopNameIsBold;
        private DevExpress.XtraReports.Parameters.Parameter ItemNameIsBold;
        private DevExpress.XtraReports.Parameters.Parameter ItemPriceIsBold;
        private DevExpress.XtraReports.Parameters.Parameter ShopNameFontSize;
        private DevExpress.XtraReports.Parameters.Parameter ItemNameFontSize;
        private DevExpress.XtraReports.Parameters.Parameter ItemPriceFontSize;
    }
}
