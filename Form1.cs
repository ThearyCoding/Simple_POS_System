using BETA_POS.pages;
using Simple_POS_system.controller;
using Simple_POS_system.pages;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Simple_POS_system
{
    public partial class Form1 : Form
    {

        private RouteConfig routeConfig;
        private ButtonHiglighter buttonHiglighter;
        private Color defaultBtnColor = Color.AliceBlue;
        public Form1()
        {
            InitializeComponent();
            callAllRoutes();
            setHighlightBtnColor();
        }
        
       


        // dependency injection for the routeConfig instance
        private void callAllRoutes()
        {
            List<UserControl> routes = new List<UserControl>() {
                new HomePage(),
                new SalesPage(),
                new ProductPage(),
                new CategoryPage(),
                new UserPage(),
                new SupplierPage(),
                new CustomerPage(),
                new AboutUsPage()
            };
            routeConfig = new RouteConfig(routes, controlPanel);
            routeConfig.displayRoute(0);
        }

        private void setHighlightBtnColor()
        {
            List<Button> buttons = new List<Button>()
            {
                homeBtn,
                salesBtn,
                productBtn,
                categoryBtn,
                userBtn,
                supplierBtn,
                customerBtn,
                aboutUsBtn,
                logoutBtn
            };
            buttonHiglighter = new ButtonHiglighter(buttons,defaultBtnColor);
            
            buttonHiglighter.highlightBtn(homeBtn,Color.Aqua);

        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            routeConfig.displayRoute(0);
            buttonHiglighter.highlightBtn(homeBtn,Color.Aqua);
        }
        private void salesBtn_Click(object sender, EventArgs e)
        {
            routeConfig.displayRoute(1);
            buttonHiglighter.highlightBtn(salesBtn, Color.Violet);
        }
        private void productBtn_Click(object sender, EventArgs e)
        {
            routeConfig.displayRoute(2);
            buttonHiglighter.highlightBtn(productBtn, Color.DarkKhaki);
        }

        private void categoryBtn_Click(object sender, EventArgs e)
        {
            routeConfig.displayRoute(3);
            buttonHiglighter.highlightBtn(categoryBtn, Color.Aquamarine);
        }

        private void adminBtn_Click(object sender, EventArgs e)
        {
            routeConfig.displayRoute(4);
            buttonHiglighter.highlightBtn(userBtn, Color.Crimson);
        }

        private void supplierBtn_Click(object sender, EventArgs e)
        {
            routeConfig.displayRoute(5);
            buttonHiglighter.highlightBtn(supplierBtn, Color.DeepSkyBlue);
        }

        private void customerBtn_Click(object sender, EventArgs e)
        {
            routeConfig.displayRoute(6);
            buttonHiglighter.highlightBtn(customerBtn, Color.DarkTurquoise);
        }

        private void aboutUsBtn_Click(object sender, EventArgs e)
        {
            routeConfig.displayRoute(7);
            buttonHiglighter.highlightBtn(aboutUsBtn, Color.LimeGreen);
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void controlPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        
    }
}
