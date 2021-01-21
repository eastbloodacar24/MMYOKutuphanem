using MMYOKutuphanem.Entites.Concrete;
using MMYOKutuphanem.Worker.Abstract;
using MMYOKutuphanem.Worker.DependencyResolvers.Ninject;
using System;
using System.Data;
using System.Windows.Forms;
namespace MMYOKütüphanem
{
    public partial class uc_kitaplariyonet : UserControl
    {
        public uc_kitaplariyonet()
        {
            InitializeComponent();
        }
        private readonly IBookService BookService = InstanceFactory.GetInstance<IBookService>();

        private void Uc_kitaplariyonet_Load(object sender, EventArgs e)
        {
 
        }

        private void LoadBooks()
        {
            cb_book_selectbook.Items.Clear();
            foreach (string name in BookService.GetNames())
                if (cb_book_selectbook.FindStringExact(name) == -1) cb_book_selectbook.Items.Add(name);
        }

        private void SwitchTab(object sender)
        {
            sep_verilenlog.Visible = false;
            sep_verilenlog.Left = ((Control)sender).Left;
            sep_verilenlog.Width = ((Control)sender).Width;
            bunifuTransition1.Show(sep_verilenlog, true, Bunifu.UI.WinForms.BunifuAnimatorNS.Animation.Leaf);
            pages_islem.SelectedIndex = Convert.ToInt32(((Control)sender).Tag.ToString());
        }

        private void Bttn_kitap_ekle_Click(object sender, EventArgs e)
        {
            if (tb_kitap_isim.Text == "" || tb_kitap_isim.Text.Length < 3) { _ = new uc_alertbox("Girilen kitap adı geçersiz. En az üç karakterden oluşan bir kitap ismi girilmeli.", uc_alertbox.AlertType.Error, this); return; }
            if (tb_kitap_barkot.Text == "") { _ = new uc_alertbox("Girilen kitap adı geçersiz. En az üç karakterden oluşan bir kitap ismi girilmeli.", uc_alertbox.AlertType.Error, this); return; }
            if (BookService.Get(p => p.Barcod == Convert.ToInt64(tb_kitap_barkot.Text)) != null) { _ = new uc_alertbox("Aynı barkod numarası üzerine başka bir kitap bulundu. Farklı bir barkod girilmesi gerekmekte.", uc_alertbox.AlertType.Error, this); return; }
            BookService.Add(new Book() { Barcod = Convert.ToInt64(tb_kitap_barkot.Text), Name = tb_kitap_isim.Text, Author = tb_kitap_yazar.Text });
            _ = new uc_alertbox(string.Format("{0} adlı kitap başarıyla eklendi!", tb_kitap_isim.Text), uc_alertbox.AlertType.Success, this);
            tb_kitap_isim.Text = "";tb_kitap_yazar.Text = "";tb_kitap_barkot.Text = "";
            LoadBooks();
        }

        private void Bttn_kitap_degistir_Click(object sender, EventArgs e)
        {
            if (cb_book_selectbook.SelectedItem.ToString() == "kitap seç"){_ = new uc_alertbox("Düzenlenecek kitabı seçin.", uc_alertbox.AlertType.Error, this); return;}
            if (cb_book_selectbarcod.Text == "<kitap seçilmemiş>" || cb_book_selectbarcod.Text == "<barkot numarası seçin>") { _ = new uc_alertbox("Aynı ada sahip başka bir kitap mevcut. Barkot numarasını listeden seçin.", uc_alertbox.AlertType.Error, this); return; }
            if (tb_kitap_duzenle_ad.Text == ""){_ = new uc_alertbox("Kitap adı alanı boş olamaz.", uc_alertbox.AlertType.Error, this); return;}
            if (tb_kitap_duzenle_yazar.Text == "") { _ = new uc_alertbox("Yazar adı alanı boş olamaz.", uc_alertbox.AlertType.Error, this); return; }
            BookService.Modify(new Book() { Id = BookService.Get(p => p.Barcod == Convert.ToInt64(cb_book_selectbarcod.SelectedItem)).Id, Author = tb_kitap_duzenle_yazar.Text, Name = tb_kitap_duzenle_ad.Text, Barcod = BookService.Get(p => p.Barcod == Convert.ToInt64(cb_book_selectbarcod.SelectedItem)).Barcod, Statu = BookService.Get(p => p.Barcod == Convert.ToInt64(cb_book_selectbarcod.SelectedItem)).Statu });
            _ = new uc_alertbox("Kitap bilgileri güncellendi!", uc_alertbox.AlertType.Success, this);
            tb_kitap_duzenle_ad.Text = "";tb_kitap_duzenle_yazar.Text = "";
            LoadBooks();
        }
        private void Lbl_islem_ekle_Click(object sender, EventArgs e) => SwitchTab(sender);
        private void Lbl_islem_duzenle_Click(object sender, EventArgs e) => SwitchTab(sender);

        private void Uc_kitaplariyonet_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible == true) cb_book_selectbook.Items.Clear(); cb_book_selectbook.Items.AddRange(BookService.GetNames()); ;
        }

        private void Cb_kitap_sec_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_book_selectbarcod.Items.Clear();
            foreach (long _num in BookService.GetBarcodCodes(p => p.Name == cb_book_selectbook.SelectedItem.ToString()))
                cb_book_selectbarcod.Items.Add(_num.ToString());
            cb_book_selectbarcod.SelectedIndex = 0;
        }

        private void cb_book_selectbarcod_SelectedIndexChanged(object sender, EventArgs e)
        {
            Book _book = new Book(); ;
            _book = BookService.Get(p => p.Barcod == Convert.ToInt64(cb_book_selectbarcod.SelectedItem));

            tb_kitap_duzenle_ad.Text = _book.Name;
            tb_kitap_duzenle_yazar.Text = _book.Author;
        }
    }
}
