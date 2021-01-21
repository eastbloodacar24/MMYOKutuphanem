using System;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;
using MMYOKutuphanem.Worker.DependencyResolvers.Ninject;
using MMYOKutuphanem.Worker.Abstract;

namespace MMYOKütüphanem
{
    public partial class Form_main : Form
    {
        public Form initiliazer;

        private readonly IUserService UserService = InstanceFactory.GetInstance<IUserService>();
        private readonly IBookService BookService = InstanceFactory.GetInstance<IBookService>();

        public Form_main()
        {
            InitializeComponent();
            InitializeApplication();
        }

        #region "Formlar hazırlanıyor"
        Uc_kitapTeslimEt var_form_kitapTeslimEt = new Uc_kitapTeslimEt();
        uc_kitapTeslimAl var_form_kitapTeslimAl = new uc_kitapTeslimAl();
        uc_verilenlog var_form_kitapteslimliste = new uc_verilenlog();
        uc_kitaplariyonet var_form_kitaplariyonet = new uc_kitaplariyonet();
        uc_kullanicilariYonet var_form_kullanicilariYonet = new uc_kullanicilariYonet();
        uc_veriduzenleme var_form_veriduzenleme = new uc_veriduzenleme();
        private void InitializeApplication()
        {
            BindUserControl(var_form_kitapTeslimEt); BindUserControl(var_form_kitapTeslimAl); BindUserControl(var_form_kitapteslimliste); BindUserControl(var_form_kitaplariyonet);
            BindUserControl(var_form_kullanicilariYonet); BindUserControl(var_form_veriduzenleme);
            lbl_facts.Text = string.Format(lbl_facts.Text, BookService.RecordCount().ToString(), BookService.GetList(p => p.Statu == 1).Count().ToString(), UserService.RecordCount().ToString());
            lbl_facts.BringToFront();

            Activated += new EventHandler(Form_main_Activated);
            bttn_form_header_mini.Click += new EventHandler(bttn_form_header_mini_Click);
        }
        private void BindUserControl(UserControl childForm){
            p_main_container.Controls.Add(childForm);childForm.Show();
            childForm.Visible = true; childForm.Visible = false;}
        #endregion
        #region "Tasarım olayları"
        #region "form geçişleri"
        private UserControl activeForm = new UserControl(); 
        private void ShowChildUserControl(UserControl childForm){
            if (activeForm != null) activeForm.Hide();
            p_welcome.Dispose();
            activeForm.Visible = false;childForm.Visible = true;
            childForm.BringToFront();
            //bunifuTransition2.Show(childForm, true, Bunifu.UI.WinForms.BunifuAnimatorNS.Animation.Transparent);
            activeForm = childForm;
        }
        private void bttn_main_menu_islemler_ver_Click(object sender, EventArgs e) => ShowChildUserControl(var_form_kitapTeslimEt);
        private void bttn_main_menu_islemler_al_Click(object sender, EventArgs e) =>ShowChildUserControl(var_form_kitapTeslimAl);
        private void button1_Click(object sender, EventArgs e) =>ShowChildUserControl(var_form_kitapteslimliste);
        private void bttn_main_menu_yonetim_kitapekle_Click_1(object sender, EventArgs e) => ShowChildUserControl(var_form_kitaplariyonet);
        private void bttn_main_menu_arsiv_goruntule_Click(object sender, EventArgs e) => ShowChildUserControl(var_form_kitapteslimliste);
        private void bttn_yonetim_kullancilar_Click_1(object sender, EventArgs e) => ShowChildUserControl(var_form_kullanicilariYonet);
        private void button1_Click_1(object sender, EventArgs e) => ShowChildUserControl(var_form_veriduzenleme);
        #endregion

        private void SyncTime()
        {
            do
            {
                lblinf.Text = DateTime.Now.ToString();
                System.Threading.Thread.Sleep(1000);
            }
            while (true);
        }
        #endregion

        private void Form_main_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;

            lbl_menu_bottom_buildinf.Text = String.Format(lbl_menu_bottom_buildinf.Text, Assembly.GetExecutingAssembly().GetName().Version.Revision.ToString());
            Task.Factory.StartNew(() =>
            {
                SyncTime();
            });
        }

        private void bttn_form_header_mini_Click(object sender, EventArgs e) => this.Opacity = 0;
        private void Form_main_Activated(object sender, EventArgs e) => this.Opacity = 100;
    }
}
