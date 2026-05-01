using OpenAI.Chat;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace drivora
{
    public partial class chatfrm : Form
    {
        private ChatClient chatClient;
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Mahmoud SY\Documents\datauser.mdf;Integrated Security=True;Connect Timeout=30");

        // API KEY 
        string key = "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";
        
        public chatfrm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usingInpu = cTextBox1.Text.Trim();
            if (string.IsNullOrEmpty(usingInpu)) return;

            cTextBox2.Text = "Wait for Answer...";

            //  إذا السؤال يخص قاعدة البيانات
            if (usingInpu.Contains("موجودة") || usingInpu.Contains("متوفرة") || usingInpu.Contains("متوفر") || usingInpu.Contains("المتاحة") || usingInpu.Contains("موديلات"))
            {
                cTextBox2.Text = GetAvailableCars();
            }
            else if (usingInpu.Contains("عملاء") || usingInpu.Contains("مستخدمين") || usingInpu.Contains("زبائن"))
            {
                cTextBox2.Text = GetCustomersCount();
            }
            else if (usingInpu.Contains("سعر") || usingInpu.Contains("اسعار") || usingInpu.Contains("لائحة الأسعار"))
            {
                cTextBox2.Text = GetPriceCars();
            }
            else if (usingInpu.Contains("لون") || usingInpu.Contains("الوان") || usingInpu.Contains("الالوان"))
            {
                cTextBox2.Text = GetColorCars();
            }
            else
            {
                // في حال السؤال لا يخص قاعدة البيانات
                chatClient = new ChatClient(model: "gpt-3.5-turbo", apiKey: key);
                ChatCompletion completion = chatClient.CompleteChat(usingInpu);
                cTextBox2.Text = $"[Chat Ai]: {completion.Content[0].Text}";
                cTextBox1.Clear();
            }
        }

        // اكواد جلب البيانات المطلوبه من قاعده البيانات حسب السؤال
        private string GetAvailableCars()
        {
            string result = "السيارات المتوفرة:\n";
            SqlCommand cmd = new SqlCommand("SELECT Car_Type,Car_Model FROM cars", conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                
                string carType = reader["Car_Type"].ToString();
                string Car_Model = reader["Car_Model"].ToString();

                result += $"- {carType} | Model: {Car_Model}\n";
            }
            conn.Close();
            return result;
        }
        private string GetPriceCars()
        {
            string result = "أسعار السيارات:\n";
            SqlCommand cmd = new SqlCommand("SELECT Car_Type,price FROM cars", conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {

                string carType = reader["Car_Type"].ToString();
                string price = reader["price"].ToString();

                result += $"- {carType} | price: {price} \n";
            }
            conn.Close();
            return result;
        }
        private string GetCustomersCount()
        {
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM users", conn);
            conn.Open();
            int count = (int)cmd.ExecuteScalar();
            conn.Close();
            return $"عدد العملاء المسجلين: {count}";
        }
        private string GetColorCars()
        {
            string result = "ألوان السيارات الموجودة:\n";
            SqlCommand cmd = new SqlCommand("SELECT Car_Type,Car_Color FROM cars", conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {

                string carType = reader["Car_Type"].ToString();
                string Car_Color = reader["Car_Color"].ToString();

                result += $"- {carType} | Color: {Car_Color} \n";
            }
            conn.Close();
            return result;
        }
    }
    
}
