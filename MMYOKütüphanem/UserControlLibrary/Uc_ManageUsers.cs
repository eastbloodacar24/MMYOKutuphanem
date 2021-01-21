using MMYOKutuphanem.Worker.Abstract;
using MMYOKutuphanem.Worker.DependencyResolvers.Ninject;
using System;
using MMYOKutuphanem.Entites.Concrete;
using System.Windows.Forms;

namespace MMYOKütüphanem
{
    public partial class uc_kullanicilariYonet : UserControl
    {
        private IUserService UserService = InstanceFactory.GetInstance<IUserService>();
        private IBranchService BranchService = InstanceFactory.GetInstance<IBranchService>();

        public uc_kullanicilariYonet()
        {
            InitializeComponent();
        }
        private void Uc_kullanicilariYonet_Load(object sender, EventArgs e)
        {

        }

        private void LoadItems()
        {
            cb_branch_select.Items.Clear(); cb_user_select_branch.Items.Clear();cb_user_select_user.Text = "<kullanıcı seç>"; cb_user_select_branch.Text = "<branş / kullanıcı türü seç>";cb_branch_select.Text = "<branş / kullanıcı türü seç>";
            cb_branch_select.Items.AddRange(BranchService.GetNames());cb_user_select_branch.Items.AddRange(BranchService.GetNames());
            
        }

        private void bttn_brans_ekle_Click(object sender, EventArgs e)
        {
            if (tb_branch_name.Text == "" || tb_branch_name.Text.Length < 3) { _ = new uc_alertbox("Branşın ismi boş olamaz ve üç karakterden kısa olamaz.", uc_alertbox.AlertType.Error, this); return; }
            if (cb_branch_select.FindStringExact(tb_branch_name.Text) == 0) { _ = new uc_alertbox("Aynı ada sahip bir branş bulundu.", uc_alertbox.AlertType.Warning, this); return; }
            BranchService.Add(new Branch() { Name = tb_branch_name.Text });
            _ = new uc_alertbox(string.Format("{0} adlı yeni branş başarıyla eklendi!", tb_branch_name.Text), uc_alertbox.AlertType.Success, this);
            LoadItems();
        }

        private void Bttn_brans_degistir_Click(object sender, EventArgs e)
        {
            if (cb_branch_select.SelectedText == "branş / kullanıcı türü seç"){_ = new uc_alertbox("Branş adı değiştirmek için bir branş seçmelisin!", uc_alertbox.AlertType.Error, this);return;}
            if (tb_branch_name.Text == "" || tb_branch_name.Text.Length < 3) { _ = new uc_alertbox("Branşın ismi boş olamaz ve üç karakterden kısa olamaz.", uc_alertbox.AlertType.Error, this); return; }
            if (cb_branch_select.FindStringExact(tb_branch_name.Text) == 0) { _ = new uc_alertbox("Aynı ada sahip bir branş bulundu.", uc_alertbox.AlertType.Warning, this); return; }
            BranchService.Modify(new Branch() { Id = BranchService.Get(p => p.Name == cb_branch_select.SelectedItem.ToString()).Id, Name = tb_branch_name.Text });
            _ = new uc_alertbox(string.Format("{0} adlı branşın adı {1} olarak değiştirildi!", cb_branch_select.SelectedItem.ToString(), tb_branch_name.Text), uc_alertbox.AlertType.Success, this);
            LoadItems();
        }

        private void Bttn_kullanici_ekle_Click(object sender, EventArgs e)
        {
            if (tb_kullanici_isim.Text == "" || tb_kullanici_isim.Text.Length < 3) { _ = new uc_alertbox("Kullanıcı adı boş olamaz ve üç karakterden kısa olamaz.", uc_alertbox.AlertType.Error, this); return; }
            if (cb_user_select_branch.Text == "<branş / kullanıcı türü seç>" || cb_user_select_branch.SelectedItem.ToString() == "<kayıt yok>" || cb_user_select_branch.SelectedIndex == -1){_ = new uc_alertbox("Branş seçimi yapmalısın.", uc_alertbox.AlertType.Error, this);return;}
            if (UserService.Get(f => f.BranchId == BranchService.Get(p => p.Name == cb_user_select_branch.SelectedItem.ToString()).Id && f.Name == tb_kullanici_isim.Text) != null) { _ = new uc_alertbox("Aynı ada ve branşa kayıtlı  bir kullanıcı bulundu.", uc_alertbox.AlertType.Warning, this); return; }
            UserService.Add(new User() { Name = tb_kullanici_isim.Text, BranchId = BranchService.Get(p => p.Name == cb_user_select_branch.SelectedItem.ToString()).Id });
            _ = new uc_alertbox(string.Format("{0} adlı yeni kullanıcı {1} branşı ile başarıyla eklendi!", tb_kullanici_isim.Text, cb_user_select_branch.SelectedItem.ToString()), uc_alertbox.AlertType.Success, this);
            LoadItems();
        }

        private void Bttn_kullanici_bilgidegistir_Click(object sender, EventArgs e)
        {
            if (cb_user_select_branch.Text == "<branş / kullanıcı türü seç>" || cb_user_select_branch.SelectedIndex == -1) {_ = new uc_alertbox("Branş seçimi yapmalısın.", uc_alertbox.AlertType.Error, this);return;}
            if (cb_user_select_user.Text == "<kullanıcı seç>" || cb_user_select_user.Text == "<kayıt yok>" && cb_user_select_user.SelectedIndex == -1) { _ = new uc_alertbox("Düzenlenecek kullanıyı seçmelisin!", uc_alertbox.AlertType.Error, this); return; }
            if (tb_kullanici_isim.Text == "" || tb_kullanici_isim.Text.Length < 3) { _ = new uc_alertbox("Kullanıcı adı boş olamaz veya üç karakterden kısa olamaz.", uc_alertbox.AlertType.Error, this); return; }
            if (UserService.Get(f => f.BranchId == BranchService.Get(p => p.Name == cb_user_select_branch.SelectedItem.ToString()).Id && f.Name == tb_kullanici_isim.Text) != null) { _ = new uc_alertbox("Aynı ada ve branşa kayıtlı  bir kullanıcı bulundu.", uc_alertbox.AlertType.Warning, this); return; }
            UserService.Modify(new User()
            {
                Id = UserService.Get(p => p.BranchId == BranchService.Get(s => s.Name == cb_user_select_branch.SelectedItem.ToString()).Id && p.Name == cb_user_select_user.SelectedItem.ToString()).Id,
                Name = tb_kullanici_isim.Text,
                BranchId = BranchService.Get(p => p.Name == cb_user_select_branch.SelectedItem.ToString()).Id,
                ReadBooks = UserService.Get(p => p.BranchId == BranchService.Get(s => s.Name == cb_user_select_branch.SelectedItem.ToString()).Id && p.Name == cb_user_select_user.SelectedItem.ToString()).ReadBooks
            });
            _ = new uc_alertbox(String.Format("{0} adlı kullanıcının adı {1} olarak değiştirildi!", cb_user_select_user.Text, tb_kullanici_isim.Text), uc_alertbox.AlertType.Success, this);
            LoadItems();
        }

        private void Uc_kullanicilariYonet_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible != true) return;
            LoadItems();
        }

        private void Cb_user_select_branch_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_user_select_user.Items.Clear();
            foreach (User user in UserService.GetList(p => p.BranchId == BranchService.Get(f => f.Name == cb_user_select_branch.SelectedItem.ToString()).Id))  
                cb_user_select_user.Items.Add(user.Name);
            if (cb_user_select_user.Items.Count == 0)
                cb_user_select_user.Text = "<kayıt yok>";
            else
                cb_user_select_user.SelectedIndex = 0;
        }
    }
}
