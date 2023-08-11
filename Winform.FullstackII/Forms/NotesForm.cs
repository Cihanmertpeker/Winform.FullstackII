using Microsoft.VisualBasic.ApplicationServices;
using System.Data;
using System.Data.SqlClient;
using Winform.FullstackII.Defaults;
using Winform.FullstackII.DTO;
using Winform.FullstackII.Entities;


namespace Winform.FullstackII
{
    public partial class NotesForm : Form
    {
        UserLoginResponseDTO responseDTO;
        Note selectedNote = null;

        public NotesForm(UserLoginResponseDTO responseDTO)
        {
            InitializeComponent();
            this.responseDTO = responseDTO;
            Reload();


        }

        private void Reload()
        {
            var notes = ListNote();
            listNote.DataSource = null;
            listNote.DataSource = notes;
            listNote.DisplayMember = "Description";
            listNote.ValueMember = "Id";

        }
        private void ClearText()
        {
            txtNote.Text = string.Empty;
        }

        private List<Note> ListNote()
        {
            UserLoginResponseDTO userLogin = new UserLoginResponseDTO();

            var notes = new List<Note>();

            SqlConnection connection = new SqlConnection("server =.\\SQLExpress; database = TutorialDb; integrated security= True;");
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.Connection = connection;
            command.CommandText = "select * from Notes where UserId = @UserId";
            var text = responseDTO.Id;
            var abc = "@UserId";
            command.Parameters.AddWithValue("@UserId", responseDTO.Id);

            connection.Open();



            var reader = command.ExecuteReader();

            while (reader.Read())
            {
                var note = new Note();
                note.Id = Convert.ToInt32(reader[0]);
                note.Description = Convert.ToString(reader[1]);
                note.UserId = Convert.ToInt32(reader[2]);

                notes.Add(note);

            }
            reader.Close();
            connection.Close();
            command.Parameters.Clear();
            return notes;
        }


        private void NotesForm_Load(object sender, EventArgs e)
        {
            lblUser.Text = responseDTO.Fullname;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNote.Text) && responseDTO != null)
            {
                SqlConnection connection = new SqlConnection("server =.\\SQLExpress; database = TutorialDb; integrated security= True;");
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.Connection = connection;
                command.CommandText = "insert into Notes values (@Description,@UserId)";
                command.Parameters.AddWithValue("@Description", txtNote.Text);
                command.Parameters.AddWithValue("@UserId", responseDTO.Id);

                connection.Open();
                var affectedRows = command.ExecuteNonQuery();
                command.Parameters.Clear();
                connection.Close();

                if (affectedRows > 0)
                {
                    MessageBox.Show("Successfully added.");
                    Reload();
                    ClearText();
                }
            }


        }

        private void NotesForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void listNote_SelectedIndexChanged(object sender, EventArgs e)
        {

            selectedNote = listNote.SelectedItem as Note;
            txtNote.Text = selectedNote.Description;


        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearText();
            selectedNote = null;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (selectedNote != null)
            {
                if (selectedNote != null && !string.IsNullOrEmpty(txtNote.Text))
                {
                    SqlConnection connection = new SqlConnection("server =.\\SQLExpress; database = TutorialDb; integrated security= True;");
                    SqlCommand command = new SqlCommand();
                    command.CommandType = CommandType.Text;
                    command.Connection = connection;
                    command.CommandText = "update Notes set Description=@Description where Id=@Id";

                    command.Parameters.AddWithValue("@Description", txtNote.Text);
                    command.Parameters.AddWithValue("@Id", selectedNote.Id);
                    connection.Open();
                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                    connection.Close();

                    Reload();
                    ClearText();
                }

            }
            else
            {
                MessageBox.Show(MessageDefaults.NoteNotSelected);
            }
        }

        private void listNote_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (listNote.SelectedItem != null)            
            {
                selectedNote = listNote.SelectedItem as Note;
                txtNote.Text = selectedNote.Description;             
                
            }

        }
    }
}


