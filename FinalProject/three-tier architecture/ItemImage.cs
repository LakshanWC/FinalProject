using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.three_tier_architecture
{
    public class ItemImage
    {
        //foods
        private Image frideRice = Image.FromFile("D:\\Nibm\\C# projects\\FinalProject\\icons & images\\Ui-icons\\Food Items\\fried_rice.jpg");
        private Image GSSandwich = Image.FromFile("D:\\Nibm\\C# projects\\FinalProject\\icons & images\\Ui-icons\\Food Items\\grilled_cheese_sandwich.jpg");
        private Image Ffries = Image.FromFile("D:\\Nibm\\C# projects\\FinalProject\\icons & images\\Ui-icons\\Food Items\\french_friesjpg.jpg");
        private Image Seafood = Image.FromFile("D:\\Nibm\\C# projects\\FinalProject\\icons & images\\Ui-icons\\Food Items\\seafood_ricejpg.jpg");
        private Image Noodles = Image.FromFile("D:\\Nibm\\C# projects\\FinalProject\\icons & images\\Ui-icons\\Food Items\\noodles.jpg");
        private Image Burger = Image.FromFile("D:\\Nibm\\C# projects\\FinalProject\\icons & images\\Ui-icons\\Food Items\\burger.jpg");
        private Image Sushi = Image.FromFile("D:\\Nibm\\C# projects\\FinalProject\\icons & images\\Ui-icons\\Food Items\\sushi.jpg");

        //drinks
        private Image Latte = Image.FromFile("D:\\Nibm\\C# projects\\FinalProject\\icons & images\\Ui-icons\\Food Items\\Lattejpg.jpg");
        private Image IcedCoffee = Image.FromFile("D:\\Nibm\\C# projects\\FinalProject\\icons & images\\Ui-icons\\Food Items\\Iced_coffee.jpg");
        private Image Smoothie = Image.FromFile("D:\\Nibm\\C# projects\\FinalProject\\icons & images\\Ui-icons\\Food Items\\Smoothie.jpg");

        public Image getItemImage(int count) 
        {
            switch(count)
            {
                case 1:
                    return GSSandwich;
                    break;
                case 2:
                    return Ffries;
                    break;
                case 3:
                    return Seafood;
                    break;
                case 4:
                    return Noodles;
                    break;
                case 5:
                    return Burger;
                    break;
                case 6:
                    return Sushi;
                case 7:
                    return Latte;
                    break;
                case 8:
                    return IcedCoffee;
                    break;
                case 9:
                    return Smoothie;
                    break;
                default:
                    return frideRice;
                    break;
            }   
        
        }
    }
}
