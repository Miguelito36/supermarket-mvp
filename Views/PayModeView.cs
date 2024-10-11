using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermarket_mvp.Views
{
    public partial class PayModeView : Form, IPayModeView
    {
        private bool isEdit;
        private bool isSuccessful;
        private string message;
        public PayModeView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();

            tabControl1.TabPages.Remove(tabPagePayModeDetail);
        }

        public string PayModeId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string PayModeName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string PayModeObservation { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string SearchValue { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string IsEdit { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string IsSuccessful { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string Message { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }



        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;
        public event EventHandler Searchevent;

        public string PayModeId
        {
            get { return TxtPayModeId.Text; }
            set { TxtPayModeId.Text = value; }
        }
        public string PayModeName
        {
            get { return TxtPayModeName.Text; }
            set { TxtPayModeName.Text = value; }

        }
        public string PayModeObservation
        {
            get { return TxtPayModeObservation.Text; }
            set { TxtPayModeObservation.Text = value; }
        }
        public string SearchValue
        {
            get { return Txtsearch.Text; }
            set { Txtsearch.Text = value; }
        }
        public bool IsEdit
        {
            get { return isEdit; }
            set { IsEdit = value; }
        }
        public bool IsSuccessful
        {
            get { return isSuccessful; }
            set { IsSuccessful = value; }
        }
        public string Message
        {
            get { return Message; }
            set { message = value; }
        }
        public void SetPayModeListBildingSource(BindingSource payModeList)
        {
            DgPayMode.DataSource = payModeList;
        }
        private void AssociateAndRaiseViewEvents()
        {
            BtnSearch.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            Txtsearch.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    SearchEvent?.Invoke(this, EventArgs.Empty);
                }
            };
        }

        public string SearchValues { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool IsSuccessfull { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}

