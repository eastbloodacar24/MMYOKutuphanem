using MMYOKutuphanem.Worker.Abstract;
using MMYOKutuphanem.Worker.DependencyResolvers.Ninject;
using System;
using System.Windows.Forms;
using MMYOKutuphanem.Entites.Concrete;
using System.Linq;

namespace MMYOKütüphanem
{
    public partial class uc_kitapTeslimAl : UserControl
    {
        private readonly IAssignmentService AssignmentService = InstanceFactory.GetInstance<IAssignmentService>();
        private readonly IBookService BookService = InstanceFactory.GetInstance<IBookService>();
        private readonly IUserService UserService = InstanceFactory.GetInstance<IUserService>();

        public uc_kitapTeslimAl()
        {
            InitializeComponent();
        }

        private void Uc_kitapTeslimAl_Load(object sender, EventArgs e)
        {

        }

        private void LoadBooks()
        {
            cb_book_selectbook.Items.Clear();
            ClearFields();
            foreach (string name in BookService.GetNames(p => p.Statu == 1))
                if (cb_book_selectbook.FindStringExact(name) == -1) cb_book_selectbook.Items.Add(name);
            if (cb_book_selectbook.Items.Count == 0) cb_book_selectbook.Text = "<kayıt yok>";
        }
        private void ClearFields()
        {
            cb_book_selectbarcod.SelectedIndex = -1; cb_book_selectbook.SelectedIndex = -1; lbl_telsimeden_isim.Text = ""; lbl_teslimeden_fark.Text = "";
            tb_teslimeden_ekstranot.Clear(); lbl_kitapsec_yazar.Text = "KİTAP YAZARI"; lbl_kitapsec_okunmasayi.Text = "OKUNMA SAYISI"; dtp_teslimalan.Value = DateTime.Now; cb_book_selectbarcod.Text = "< kitap seçilmemiş >";
            cb_book_selectbook.Text = "";
        }

        private void bttn_teslimalan_teslimet_Click(object sender, EventArgs e)
        {
            if (cb_book_selectbook.SelectedIndex == -1) { _ = new uc_alertbox("İşlem yapılacak kitap seçilmemiş.", uc_alertbox.AlertType.Error, this); return; }
            if (cb_book_selectbarcod.Text == "<kitap seçilmemiş>" || cb_book_selectbarcod.Text == "<barkot numarası seçin>") { _ = new uc_alertbox("Aynı ada sahip başka bir kitap mevcut. Barkot numarasını listeden seçin.", uc_alertbox.AlertType.Error, this); return; }
            AssignmentService.Modify(new Assignment()
            {
                Id = AssignmentService.GetMAX(f => f.Barcod == Convert.ToInt64(cb_book_selectbarcod.SelectedItem)).Id,
                UserId = AssignmentService.GetMAX(f => f.Barcod == Convert.ToInt64(cb_book_selectbarcod.SelectedItem)).UserId,
                Barcod = Convert.ToInt64(cb_book_selectbarcod.SelectedItem),
                ReturnDate = (int)(DateTime.Now.Subtract(new DateTime(1970, 1, 1))).TotalSeconds,
                DealedDate = AssignmentService.GetMAX(f => f.Barcod == Convert.ToInt64(cb_book_selectbarcod.SelectedItem)).DealedDate,
                AssignDate = AssignmentService.GetMAX(f => f.Barcod == Convert.ToInt64(cb_book_selectbarcod.SelectedItem)).AssignDate,
                Notes = tb_teslimeden_ekstranot.Text,
                Statu = 0
            });
            BookService.Modify(new Book()
            {
                Id = BookService.Get(p => p.Barcod == Convert.ToInt64(cb_book_selectbarcod.SelectedItem)).Id,
                RCount = BookService.Get(p => p.Barcod == Convert.ToInt64(cb_book_selectbarcod.SelectedItem)).RCount + 1,
                Name = BookService.Get(p => p.Barcod == Convert.ToInt64(cb_book_selectbarcod.SelectedItem)).Name,
                Author = BookService.Get(p => p.Barcod == Convert.ToInt64(cb_book_selectbarcod.SelectedItem)).Author,
                Barcod = BookService.Get(p => p.Barcod == Convert.ToInt64(cb_book_selectbarcod.SelectedItem)).Barcod,
                Statu = 0,
            });
            _ = new uc_alertbox("Kitap teslim alındı!", uc_alertbox.AlertType.Success, this);
            LoadBooks();
        }

        private void cb_kitapsec_kitapisim_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_book_selectbarcod.Items.Clear();
            foreach (long _num in BookService.GetBarcodCodes(p => p.Name == cb_book_selectbook.SelectedItem.ToString()))
                cb_book_selectbarcod.Items.Add(_num.ToString());
            cb_book_selectbarcod.SelectedIndex = 0;
        }
        private void Uc_kitapTeslimAl_VisibleChanged(object sender, EventArgs e) { if (Visible == true) LoadBooks(); }

        private void cb_kitapsec_barkotno_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_book_selectbarcod.SelectedIndex == -1) return;
            Book _book = new Book();
            Assignment _assignment = new Assignment();
            MessageBox.Show(Convert.ToInt64(cb_book_selectbarcod.SelectedItem).ToString() + " " + Convert.ToInt64(cb_book_selectbarcod.SelectedItem).ToString() + " " + AssignmentService.GetMAX(f => f.Barcod == Convert.ToInt64(cb_book_selectbarcod.SelectedItem)).Id.ToString());
            _assignment = AssignmentService.Get(P => P.Barcod == Convert.ToInt64(cb_book_selectbarcod.SelectedItem) && P.Id == AssignmentService.GetMAX(f => f.Barcod == Convert.ToInt64(cb_book_selectbarcod.SelectedItem)).Id);
            _book = BookService.Get(p => p.Barcod == Convert.ToInt64(cb_book_selectbarcod.SelectedItem));
            lbl_teslimeden_fark.Text = string.Format("bu kitap {0} bu kişide.", FarkHesapla(_assignment.AssignDate));
            tb_teslimeden_ekstranot.Text = _assignment.Notes;
            lbl_kitapsec_okunmasayi.Text = _book.RCount.ToString();
            lbl_kitapsec_yazar.Text = _book.Author;
            lbl_telsimeden_isim.Text = UserService.Get(p => p.Id == _assignment.UserId).Name;
        }

        public static string FarkHesapla(double unixTimeStamp)
        {
            DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Local);
            TimeSpan _dt = DateTime.Now.Subtract(dtDateTime.AddSeconds(unixTimeStamp).ToLocalTime());
            return _dt.Days.ToString() +" gün "+ _dt.Hours.ToString() + (_dt.TotalHours < 1 ? string.Format(" saat {0} dakikadır", _dt.Minutes.ToString()) : " saattir");
        }
    }
}
