// CIS 199
// Program 3
// Due : 04/01/2021
// By: R2696
// This program calculates total price of orders from 4 different farms
// each farm has their own shipping rate
// each item has different price rate
// different discount rates apply to different quantity in orders

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog3
{
    public partial class uPickItGroceryCostForm : Form
    {
        public uPickItGroceryCostForm()
        {
            InitializeComponent();
        }

        // total price calculation starts here
        private void btnCal_Click(object sender, EventArgs e)
        {
            //parallel array for farms and their shipment fees
            String[] farms = { "NE", "NW", "SE", "SW" }; //Farms to select
            double[] shipmentRates = { 0.06, 0.0717, 0.07, 0.0874 };//shipment fee of farms

            //parallel array for items and their prices
            int[] itemNums = { 10001, 10002, 10003, 10004, 10005, 10006, 10007 };// item number
            double[] itemCostRates = { 7.87, 9.51, 10.73, 9.99, 11.99, 5.00, 4.58 };// item price

            //parallel array for quantities and their diccounts
            int[] quantityRanges = { 0, 6, 11, 21 };// quantity ranges from the lower limits
            double[] discounts = { 0, 0.05, 0.1, 0.15 }; // different discounts of different range

            bool foundItem = false; //  remains false until item is found to countinue the search
            bool foundDiscount = false; // remains false until quantity is found in the range to countinue the search
            double initialCost = 0; // cost before discount and shipment
            double discountedCost=0; // discount cost
            double shipmentCost=0; // shipment cost
            double totalPrice; //Price after discount and shipment
            double shippingRate=0; // shipping rate of the selected farm
            int selectedItem; // the item iput 
            int quantity; // the quantity input    
            double discount=0; // discount for input quantity
            double itemRate=0; // selected item price
            string selectedFarm;// farm that selected by users


            // select farms and decide the shipment fee
            if (selectFarm.SelectedIndex >= 0) // users have to select one farm, selectedIndex starts from 0
            {
                selectedFarm = farms[selectFarm.SelectedIndex];
                shippingRate = shipmentRates[selectFarm.SelectedIndex];               
            }

            else
                MessageBox.Show("Please select a farm."); // when users fail to select a farm

            //decide the discount range and calculate the discounted cost
            if (int.TryParse(iptQuantity.Text, out quantity) && quantity > 0)
            {
                for (int i = 0; i < quantityRanges.Length; i++)
                {
                    if (i != quantityRanges.Length && quantity >= quantityRanges[i] ) //when the quanlity is greater or equal to the lower end of the range
                    {
                        foundDiscount = true;
                        discount = discounts[i];
                    }
                }
            }


            //search for the item and find the price, calculate the initial cost
            if (int.TryParse(iptItem.Text, out selectedItem))
            {
                for (int i = 0; i < itemNums.Length; i++)
                {
                    if (selectedItem == itemNums[i]) // match the input with the item number
                    {
                        foundItem = true;
                        itemRate = itemCostRates[i]; // find the item price that match the input
                    }
                }
            }

            // calacute the total price after discount and shipment fee      
            if (foundItem)
                initialCost = quantity * itemRate;

            else
                MessageBox.Show("Item not found!"); // when users fail to enter an existed item

            if (foundDiscount)
                discountedCost = initialCost- discount * initialCost;
            else
                MessageBox.Show("Invalid quantity!"); // when users enter an invalied quantity

            shipmentCost = discountedCost * shippingRate;
            totalPrice = discountedCost + shipmentCost;

            // display the output for initial cost, 
            optInitialCost.Text = $"{initialCost:C}";
            optShipmentCost.Text = $"{shipmentCost:C}";
            optDiscountedCost.Text = $"{discountedCost:C}";
            optTotalPrice.Text = $"{totalPrice:C}";
        }
    }
}
