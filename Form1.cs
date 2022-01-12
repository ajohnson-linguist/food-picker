using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodPicker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            noCookText.Text = NOCOOK;
            liteCookText.Text = LITECOOK;
        }

        private static readonly string NOCOOK = "Crackers & Cheese (& Meat)\r\nCrackers & Tuna\r\nCanned Beans & Spices\r\n"+
            "Canned Corn\r\nCanned Chickpeas & Salt, Garlic, Lemon, Olive Oil\r\nCereal & Milk\r\nGranola & Milk\r\nOatmeal\r\n" +
            "Apples & PB\r\nFrozen Fruit & Spoonful of PB/Cashews\r\nChips & Salsa",
            LITECOOK = "Tots & Jar Sauce\r\nPasta & Frozen Sauce\r\nGrilled Cheese\r\nQuinoa & Balls\r\nTots, Beans, Cheese Bake\r\n" +
            "Tots & Fish Filet (defrost and season)\r\nPasta Salad (pasta, beans, salad dressing)\r\nTaco (Bean, beef, taco seasoning, salsa, tortilla)";

        private void noCookRandomize_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            string[] noCook = noCookText.Text.Split('\n');
            MessageBox.Show(noCook[rand.Next(0, noCook.Length)]);
        }

        private void liteCookRandomize_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            string[] liteCook = liteCookText.Text.Split('\n');
            MessageBox.Show(liteCook[rand.Next(0, liteCook.Length)]);
        }
    }

}
