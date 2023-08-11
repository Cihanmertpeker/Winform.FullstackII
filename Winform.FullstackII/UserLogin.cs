using Microsoft.VisualBasic.ApplicationServices;
using System.Data;
using System.Data.SqlClient;
using Winform.FullstackII.DTO;
using Winform.FullstackII.Forms;

namespace Winform.FullstackII
{
    public partial class UserLogin : Form
    {

        public UserLogin()
        {
            InitializeComponent();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {


           
            if (!string.IsNullOrEmpty(txtUserName.Text) && !string.IsNullOrEmpty(txtPassword.Text))
            {
                var response = GetUser(txtUserName.Text, txtPassword.Text);


                if (response != null)
                {
                    NavigationForm form = new NavigationForm(response);
                  
                    form.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre hatalı");
                }

            }
            else
            {
                MessageBox.Show("Alanları doldurunuz.");
            }

            
        }

        /// <summary>
        /// Paramatre olarak girilen username ve passworde karşılık user fullname'ini döner.
        /// </summary>

        private UserLoginResponseDTO GetUser(string username, string password)
        {
            SqlConnection connection = new SqlConnection("server=.\\SQLExpress; database=TutorialDb; integrated security = True;");

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.Connection = connection;
            command.CommandText = "select * from Users where username=@username and password=@password";

            command.Parameters.AddWithValue("username", username);
            command.Parameters.AddWithValue("password", password);


            connection.Open();
            var reader = command.ExecuteReader();
            command.Parameters.Clear();
            var id = 0;
            UserLoginResponseDTO responseDTO = null;

            string fullname = "";

            while (reader.Read())
            {
                responseDTO = new UserLoginResponseDTO();
                responseDTO.Id = Convert.ToInt32(reader[0]);
               responseDTO.Fullname = Convert.ToString(reader[3]);
            }



            connection.Close();

            return responseDTO;
        }

    }
}
