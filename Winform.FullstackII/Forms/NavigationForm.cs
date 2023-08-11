using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Winform.FullstackII.DTO;

namespace Winform.FullstackII.Forms
{
    public partial class NavigationForm : Form
    {
        UserLoginResponseDTO ResponseDTO;

        public UserLoginResponseDTO responseDTO;

        public NavigationForm(UserLoginResponseDTO responseDTO)        {
            
            InitializeComponent();
            this.ResponseDTO = responseDTO;
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            ProductsForm form = new ProductsForm(ResponseDTO.Fullname);
            form.Show();
            this.Hide();
        }

        private void btnNote_Click(object sender, EventArgs e)
        {
            NotesForm form = new NotesForm(this.ResponseDTO);
            form.Show();
            this.Hide();
        }
    }
}
 