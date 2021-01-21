using System;
using System.Windows.Forms;
using MMYOKutuphanem.Worker.Abstract;
using MMYOKutuphanem.Worker.DependencyResolvers.Ninject;
using MMYOKutuphanem.Entites.Concrete;

namespace MMYOKütüphanem
{
    public partial class Uc_kitapTeslimEt : UserControl
    {
        private readonly IAssignmentService AssignmentService = InstanceFactory.GetInstance<IAssignmentService>();
        private readonly IBookService BookService = InstanceFactory.GetInstance<IBookService>();
        private readonly IUserService UserService = InstanceFactory.GetInstance<IUserService>();
        private readonly IBranchService BranchService = InstanceFactory.GetInstance<IBranchService>();

        public Uc_kitapTeslimEt()
        {
            InitializeComponent();
        }


        private void LoadBooks()
        {
            cb_book_selectbook.Items.Clear();
            cb_user_selectbranch.Items.Clear();
            ClearFields();
            foreach (string name in BookService.GetNames(p => p.Statu == 0))
                if (cb_book_selectbook.FindStringExact(name) == -1) cb_book_selectbook.Items.Add(name);
            foreach (string name in BranchService.GetNames())
                cb_user_selectbranch.Items.Add(name);
            if (cb_book_selectbook.Items.Count == 0) cb_book_selectbook.Text = "<kayıt yok>";
        }

        private void ClearFields(){
            cb_book_selectbarcod.SelectedIndex = -1;cb_book_selectbook.SelectedIndex = -1;cb_user_selectuser.SelectedIndex = -1;cb_user_selectbranch.SelectedIndex = -1;
            tb_teslimalan_ekstranot.Clear();lbl_kitapsec_yazar.Text = "KİTAP YAZARI";lbl_kitapsec_okunmasayi.Text = "OKUNMA SAYISI";dtp_teslimalan.Value = DateTime.Now; 
            cb_book_selectbarcod.Text = "<kitap seçilmemiş>";cb_book_selectbarcod.Text = "<kitap seçilmemiş>";cb_user_selectbranch.Text = "<branş seçin>";cb_book_selectbook.Text = "<kitap seçin>";
        }

        private void bttn_teslimalan_teslimet_Click_1(object sender, EventArgs e)
        {
            if (cb_book_selectbook.SelectedIndex == -1) { _ = new uc_alertbox("İşlem yapılacak kitap seçilmemiş.", uc_alertbox.AlertType.Error, this); return; }
            if (cb_book_selectbarcod.Text == "<kitap seçilmemiş>" || cb_book_selectbarcod.Text == "<barkod seçin>") { _ = new uc_alertbox("Aynı ada sahip başka bir kitap mevcut. Barkot numarasını listeden seçin.", uc_alertbox.AlertType.Error, this); return; }
            if (cb_user_selectuser.Text == "<branş seçilmemiş>" || cb_user_selectuser.Text == "<kayıt yok>") { _ = new uc_alertbox("Kitabın kime teslim edileceği seçilmemiş.", uc_alertbox.AlertType.Error, this); return; }
            if (cb_user_selectbranch.SelectedIndex == -1) { _ = new uc_alertbox("Teslim alan kişinin branşı seçilmemiş.", uc_alertbox.AlertType.Error, this); return; }
            AssignmentService.Add(new Assignment()
            {
                UserId = UserService.Get(p => p.BranchId == BranchService.Get(f => f.Name == cb_user_selectbranch.SelectedItem.ToString()).Id && p.Name == cb_user_selectuser.SelectedItem.ToString()).Id,
                Barcod = Convert.ToInt64(cb_book_selectbarcod.SelectedItem),
                Notes = tb_teslimalan_ekstranot.Text,
                AssignDate = (int)(DateTime.Now.Subtract(new DateTime(1970, 1, 1))).TotalSeconds,
                DealedDate = (int)(dtp_teslimalan.Value.Subtract(new DateTime(1970, 1, 1))).TotalSeconds,
                Statu = 1
            });
            BookService.Modify(new Book()
            {
                Id = BookService.Get(p => p.Barcod == Convert.ToInt64(cb_book_selectbarcod.SelectedItem)).Id,
                RCount = BookService.Get(p => p.Barcod == Convert.ToInt64(cb_book_selectbarcod.SelectedItem)).RCount + 1,
                Name = BookService.Get(p => p.Barcod == Convert.ToInt64(cb_book_selectbarcod.SelectedItem)).Name,
                Author = BookService.Get(p => p.Barcod == Convert.ToInt64(cb_book_selectbarcod.SelectedItem)).Author,
                Barcod = BookService.Get(p => p.Barcod == Convert.ToInt64(cb_book_selectbarcod.SelectedItem)).Barcod,
                Statu = 1,
            });
            _ = new uc_alertbox("Kitap teslim kaydı açıldı!", uc_alertbox.AlertType.Success, this);
            LoadBooks();
        }

        private void cb_kitapsec_kitapisim_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_book_selectbarcod.Items.Clear();
            foreach (long _num in BookService.GetBarcodCodes(p => p.Name == cb_book_selectbook.SelectedItem.ToString()))
                cb_book_selectbarcod.Items.Add(_num.ToString());
            if (cb_book_selectbarcod.Items.Count > 1)
                cb_book_selectbarcod.Text = "<barkod seçiniz>";
            else
                cb_book_selectbarcod.SelectedIndex = 0;
        }

        private void uc_kitapTeslimEt_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible != true) return;
            LoadBooks();
        }

        private void dtp_teslimalan_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cb_teslimalan_brans_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_user_selectuser.Items.Clear();
            foreach (User _user in UserService.GetList(p => p.BranchId == BranchService.Get(f => f.Name == cb_user_selectbranch.SelectedItem.ToString()).Id))
                cb_user_selectuser.Items.Add(_user.Name);
            if (cb_user_selectuser.Items.Count > 0)
                cb_user_selectuser.SelectedIndex = 0;
            else cb_user_selectuser.Text = "<kayıt yok>";    
        }

        private void cb_kitapsec_barkotno_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_book_selectbarcod.SelectedIndex == -1) return;
            Book _book = new Book();
            _book = BookService.Get(p => p.Barcod == Convert.ToInt64(cb_book_selectbarcod.SelectedItem));
            lbl_kitapsec_yazar.Text = _book.Author;
            lbl_kitapsec_okunmasayi.Text = _book.RCount.ToString();
        }

        private void p_teslimalan_header_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
