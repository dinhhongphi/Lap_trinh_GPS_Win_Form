using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GPS_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            try
            {
                if (rdbAddress.Checked)
                {
                    if (String.IsNullOrEmpty(txtAddress.Text))
                    {
                        MessageBox.Show("Lat and Long have to value", "Error", MessageBoxButtons.OK);
                        return;
                    }
                    wbrMap.Url = Map.SearchByAddress(txtAddress.Text);
                }
                else //rdbCoordinate checked
                {
                    if (String.IsNullOrEmpty(txtLat.Text) || String.IsNullOrEmpty(txtLong.Text))
                    {
                        MessageBox.Show("Lat and Long have to value", "Error", MessageBoxButtons.OK);
                        return;
                    }
                    wbrMap.Url = Map.SearchByCoordinate(txtLat.Text, txtLong.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while get information", "Error", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            if (rdbAddCoo.Checked)
            {
                if (String.IsNullOrEmpty(txtAddress.Text))
                {
                    MessageBox.Show("Lat and Long have to value", "Error", MessageBoxButtons.OK);
                    return;
                }
                try
                {
                    //get vị trí từ địa chỉ
                    var location = Map.GetCoordinateFromAddress(txtAddress.Text);
                    txtLat.Text = location.lat;
                    txtLong.Text = location.lng;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error while get information", "Error", MessageBoxButtons.OK);
                    return;
                }
            }
            else if (rdbCooAdd.Checked)
            {
                if (String.IsNullOrEmpty(txtLat.Text) || String.IsNullOrEmpty(txtLong.Text))
                {
                    MessageBox.Show("Lat and Long have to value", "Error", MessageBoxButtons.OK);
                    return;
                }
                var location = new Location { lat = txtLat.Text, lng = txtLong.Text };
                try
                {
                    var address = Map.GetAddressFromCoordinate(location);
                    txtAddress.Text = address;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error while get information", "Error", MessageBoxButtons.OK);
                    return;
                }
            }
            else
            {
                try
                {
                    MapInfo_Ip info = Map.GetMapInfoByIP(lblIP.Text);
                    var result = Map.SearchByCoordinate(info.latitude, info.longitude);
                    txtLat.Text = info.latitude;
                    txtLong.Text = info.longitude;
                    wbrMap.Url = result;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error while get information", "Error", MessageBoxButtons.OK);
                    return;
                }
            }
        }

        private void rdbCoordinate_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbAddress.Checked)
            {
                gbxCoor.Enabled = false;
                txtAddress.Enabled = true;
            }
            else if (rdbCoordinate.Checked)
            {
                gbxCoor.Enabled = true;
                txtAddress.Enabled = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblIP.Text = MyIP.Get();
        }
    }
}


