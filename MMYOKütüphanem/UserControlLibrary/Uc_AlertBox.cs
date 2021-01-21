using System;
using System.Drawing;
using System.Windows.Forms;
namespace MMYOKütüphanem
{
    public partial class uc_alertbox : UserControl{
        public uc_alertbox(string mesaj, AlertType mesajtip, Control control, int interval = 4000)
        {
            InitializeComponent();
            autoclose.Interval = interval;
            switch (mesajtip)
            {
                case AlertType.Error:
                    this.BackColor = Color.Crimson;
                    pictureBox1.Image = imageList1.Images[1];
                    break;
                case AlertType.Success:
                    this.BackColor = Color.FromArgb(35, 168, 109);
                    pictureBox1.Image = imageList1.Images[0];
                    break;
                case AlertType.Warning:
                    this.BackColor = Color.Gray;
                    pictureBox1.Image = imageList1.Images[2];
                    break;
            }
            lbl_text.Text = mesaj;
            control.Controls.Add(this);
            this.Location = new Point((control.Width / 2) - (this.Width / 2), control.Height);
            this.BringToFront();
            ShoworHide(true);
         }

        private void ShoworHide(bool showorhide)
        {
            for (int i = 0; i < (int)((this.Height + 5) / 3); i++){
                if (showorhide) { this.Location = new Point(this.Location.X, this.Location.Y - 3); Refresh(); }
                else { this.Location = new Point(this.Location.X, this.Location.Y + 6); this.Parent.Refresh(); };
            }
            if (!showorhide) this.Dispose();
        }

        private void Uc_alertbox_Load(object sender, EventArgs e){}
        public enum AlertType{Success, Error, Warning}

        private void Bttn_close_Click(object sender, EventArgs e) => ShoworHide(false);

        private void autoclose_Tick(object sender, EventArgs e) => ShoworHide(false);
    }
}
