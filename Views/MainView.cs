﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermarket_mvp.Views
{
    public partial class MainView : Form, IMainView
    {
        public MainView()
        {
            InitializeComponent();

            BtnPayMode.Click += delegate { ShowPayModeView?.Invoke(this, EventArgs.Empty); };
            BtnProducts.Click += delegate { ShowProductsView?.Invoke(this, EventArgs.Empty); };
            BtnCostumers.Click += delegate { ShowCostumersView?.Invoke(this, EventArgs.Empty); };
            BtnCategories.Click += delegate { ShowCategoriesView?.Invoke(this, EventArgs.Empty); };

            BtnExit.Click += delegate { this.Close(); };
        }

        public event EventHandler ShowPayModeView;
        public event EventHandler ShowProductsView;
        public event EventHandler ShowCostumersView;
        public event EventHandler ShowCategoriesView;

        private void BtnExit_Click(object sender, EventArgs e)
        {

        }

        private void BtnPayMode_Click(object sender, EventArgs e)
        {

        }
    }
}
