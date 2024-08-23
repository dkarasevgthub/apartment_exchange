using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dz
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        bool IsPhoneNumber(string input)
        {
            if (input.Length > 12 || input.Length < 11) return false;

            for (int i = 1; i < input.Length; ++i)
            {
                if (!Char.IsDigit(input, i))
                {
                    return false;
                }
            }
            return true;
        }

        private void buyer_Click(object sender, EventArgs e)
        {
            main_window.Visible = false;
            seller_window.Visible = false;
            buyer_window.Visible = true;
            all_window.Visible = false;
        }

        private void back_Click(object sender, EventArgs e)
        {
            buyer_window.Visible = false;
            seller_window.Visible = false;
            main_window.Visible = true;
            all_window.Visible = false;
            rooms.Clear();
            area.Clear();
            floor.Clear();
            address.Clear();
            phone.Clear();
            roomss.Clear();
            areas.Clear();
            floors.Clear();
            addresss.Clear();
            phones.Clear();
        }

        private void backs_Click_1(object sender, EventArgs e)
        {
            buyer_window.Visible = false;
            seller_window.Visible = false;
            main_window.Visible = true;
            all_window.Visible = false;
        }

        private void all_back_Click(object sender, EventArgs e)
        {
            buyer_window.Visible = false;
            seller_window.Visible = false;
            main_window.Visible = true;
            all_window.Visible = false;
        }

        private void seller_Click(object sender, EventArgs e)
        {
            main_window.Visible = false;
            seller_window.Visible = true;
            buyer_window.Visible = false;
            all_window.Visible = false;
        }

        private void all_Click(object sender, EventArgs e)
        {
            main_window.Visible = false;
            seller_window.Visible = false;
            buyer_window.Visible = false;
            all_window.Visible = true;
            WebRequest request = WebRequest.Create($"http://localhost/dz.php?&all=All+Flats");
            WebResponse response = request.GetResponse();
            Stream stream = response.GetResponseStream();
            StreamReader reader = new StreamReader(stream);
            string line = "";
            String result = "";
            while ((line = reader.ReadLine()) != null)
            {
                result += line;
            }
            response.Close();
            stream.Close();
            reader.Close();
            webBrowser1.DocumentText = result;
            webBrowser1.Refresh();
        }

        private void search_Click(object sender, EventArgs e)
        {
            int rooms_inp;
            int area_inp;
            int floor_inp;
            String address_inp;
            String phone_inp;
            try
            {
                rooms_inp = Convert.ToInt32(rooms.Text);
                area_inp = Convert.ToInt32(area.Text);
                floor_inp = Convert.ToInt32(floor.Text);
                if (String.IsNullOrEmpty(address.Text))
                {
                    MessageBox.Show("Неверный формат ввода");
                    return;
                }
                else
                {
                    address_inp = address.Text;
                }
                if (String.IsNullOrEmpty(phone.Text) || !IsPhoneNumber(phone.Text) || !IsPhoneNumber(phone.Text))
                {
                    MessageBox.Show("Неверный формат ввода номера телефона");
                    return;
                }
                else
                {
                    phone_inp = phone.Text;
                }
            }
            catch 
            {
                MessageBox.Show("Неверный формат ввода");
                return;
            }
            
            WebRequest request = WebRequest.Create($"http://localhost/dz.php?rooms={rooms_inp}&area={area_inp}&floor={floor_inp}&address={address_inp}&tel={phone_inp}&find=%D0%9F%D0%BE%D0%B8%D1%81%D0%BA");
            WebResponse response = request.GetResponse();
            Stream stream = response.GetResponseStream();
            StreamReader reader = new StreamReader(stream);
            string line = "";
            String result = "";
            String title = "";
            while ((line = reader.ReadLine()) != null)
            {
                if (String.IsNullOrEmpty(result))
                {
                    title += line;
                }
                result += line;
                result += "\n";
            }
            MessageBox.Show(result, title);
            response.Close();
            stream.Close();
            reader.Close();
        }

        private void sell_Click(object sender, EventArgs e)
        {
            int rooms_inp;
            int area_inp;
            int floor_inp;
            String address_inp;
            String phone_inp;
            try
            {
                rooms_inp = Convert.ToInt32(roomss.Text);
                area_inp = Convert.ToInt32(areas.Text);
                floor_inp = Convert.ToInt32(floors.Text);
                if (String.IsNullOrEmpty(addresss.Text))
                {
                    MessageBox.Show("Неверный формат ввода");
                    return;
                }
                else
                {
                    address_inp = addresss.Text;
                }
                if (String.IsNullOrEmpty(phones.Text) || !IsPhoneNumber(phones.Text) || !IsPhoneNumber(phones.Text))
                {
                    MessageBox.Show("Неверный формат ввода номера телефона");
                    return;
                }
                else
                {
                    phone_inp = phones.Text;
                }
            }
            catch
            {
                MessageBox.Show("Неверный формат ввода");
                return;
            }

            WebRequest request = WebRequest.Create($"http://localhost/dz.php?rooms={rooms_inp}&area={area_inp}&floor={floor_inp}&address={address_inp}&tel={phone_inp}&sell=%D0%9F%D0%BE%D0%B8%D1%81%D0%BA");
            WebResponse response = request.GetResponse();
            Stream stream = response.GetResponseStream();
            StreamReader reader = new StreamReader(stream);
            string line = "";
            String result = "";
            String title = "";
            while ((line = reader.ReadLine()) != null)
            {
                if (String.IsNullOrEmpty(result))
                {
                    title += line;
                }
                result += line;
                result += "\n";
            }
            MessageBox.Show(result, title);
            response.Close();
            stream.Close();
            reader.Close();
        }

        private void rooms_lbl_Click(object sender, EventArgs e)
        {

        }

        private void phone_lbl_Click(object sender, EventArgs e)
        {

        }
    }
}
