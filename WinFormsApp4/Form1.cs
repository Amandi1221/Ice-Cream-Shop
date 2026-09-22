namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Price = 0;
            if (typeIcecream.SelectedItem.ToString() == "VANILA")
            {
                Price = 200 * Convert.ToInt16(textBox1.Text);
            }
            if (typeIcecream.SelectedItem.ToString() == "CHOCOLATE")
            {
                Price = 250 * Convert.ToInt16(textBox1.Text);
            }
            if (typeIcecream.SelectedItem.ToString() == "FRUIT & NUT")
            {
                Price = 300 * Convert.ToInt16(textBox1.Text);
            }
            if (typeIcecream.SelectedItem.ToString() == "STAWBERRY")
            {
                Price = 280 * Convert.ToInt16(textBox1.Text);
            }
            if (typeIcecream.SelectedItem.ToString() == "MANGO")
            {
                Price = 260 * Convert.ToInt16(textBox1.Text);
            }
            if (typeIcecream.SelectedItem.ToString() == "WOOD APPLE")
            {
                Price = 230 * Convert.ToInt16(textBox1.Text);
            }




            if (typeCake.SelectedItem.ToString() == "BUTTER")
            {
                Price = Price + (250 * Convert.ToInt16(textBox1.Text));
            }
            if (typeCake.SelectedItem.ToString() == "CHOCOLATE")
            {
                Price = Price + (270 * Convert.ToInt16(textBox1.Text));
            }
            if (typeCake.SelectedItem.ToString() == "RIBBON")
            {
                Price = Price + (290 * Convert.ToInt16(textBox1.Text));
            }
            if (typeCake.SelectedItem.ToString() == "BANANA CAKE")
            {
                Price = Price + (260 * Convert.ToInt16(textBox1.Text));
            }
            if (typeCake.SelectedItem.ToString() == "CUPCAKES")
            {
                Price = Price + (200 * Convert.ToInt16(textBox1.Text));
            }


            if (chkDrinks.GetItemChecked(0))
            {
                Price = Price + (150 * Convert.ToInt16(textBox1.Text));
            }
            if (chkDrinks.GetItemChecked(1))
            {
                Price = Price + (170 * Convert.ToInt16(textBox1.Text)); 
            }
            if (chkDrinks.GetItemChecked(2))
            { 
                Price = Price + (200 * Convert.ToInt16(textBox1.Text));
            }
            if (chkDrinks.GetItemChecked(3))
            { 
                Price = Price + (200 * Convert.ToInt16(textBox1.Text)); 
            }
            if (chkDrinks.GetItemChecked(4))
            { 
                Price = Price + (180 * Convert.ToInt16(textBox1.Text));
            }
            if (chkDrinks.GetItemChecked(5))
            {
                Price = Price + (250 * Convert.ToInt16(textBox1.Text));
            }



            if (rdoMS.Checked)
            {
                Price = Price + (180 * Convert.ToInt16(textBox1.Text));
            }
            if (rdoMS2.Checked)
            {
                Price = Price + (200 * Convert.ToInt16(textBox1.Text));
            }
            if (rdoMS3.Checked)
            {
                Price = Price + (160 * Convert.ToInt16(textBox1.Text));
            }
            if (rdoMS4.Checked)
            { 
                Price = Price + (190 * Convert.ToInt16(textBox1.Text));
            }
            if (rdoMS5.Checked)
            {
                Price = Price + (250 * Convert.ToInt16(textBox1.Text));
            }
            if (rdoMS6.Checked)
            {
                Price = Price + (150 * Convert.ToInt16(textBox1.Text));
            }

            txtValue.Text = Convert.ToString(Price);
        }

        private void chkDrinks_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
