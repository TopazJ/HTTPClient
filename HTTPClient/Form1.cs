﻿using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HTTPClient
{
    public partial class HTTPClient : Form
    {
        public HTTPClient()
        {
            InitializeComponent();
            RestClient.InitializeClient();
        }


        private async void Submit_Click(object sender, EventArgs e)
        {
            try
            {
                await SendData(URLTextbox.Text, assembleData());
            }
            catch (Exception except)
            {
                debugOutput(except.Message);
                debugOutput("As above, there was an error with information entered, try again.");
            }
        }

        private async void GetData_Click(object sender, EventArgs e)
        {
            try
            {
                await LoadData(textBox5.Text, Convert.ToInt32(textBox6.Text));
            }
            catch (Exception except)
            {
                debugOutput(except.Message);
                debugOutput("As above, there was an error with information entered, try again.");
            }
        }

        private async Task LoadData(string url, int id)
        {
            var data = await GetProcessor.loadData(id, url);
            debugOutput(data.args.toString());
        }

        private async Task SendData(string url, DataModel data)
        {
            var message = await PostProcessor.postData(url, data);
            //debugOutput(message);
            debugOutput(message.parseString().toString());
        }

        private DataModel assembleData()
        {
            int id = 1;
            return new DataModel(Convert.ToInt32(DataEntry1.Text), Convert.ToDouble(DataEntry2.Text),
                DataEntry3.Text, Convert.ToBoolean(DataEntry4.Text), Convert.ToInt32(DataEntry5.Text), id);

        }

        private void debugOutput(string strDebugText)
        {
            try
            {
                System.Diagnostics.Debug.Write(strDebugText + Environment.NewLine);
                Response.Text = Response.Text + strDebugText + Environment.NewLine;
                Response.SelectionStart = Response.TextLength;
                Response.ScrollToCaret();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Write(ex.Message, ToString() + Environment.NewLine);
            }
        }
    }
}
