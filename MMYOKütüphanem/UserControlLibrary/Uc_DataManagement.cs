using System;
using System.Linq;
using System.Windows.Forms;
using MMYOKutuphanem.Entites.Concrete;
using MMYOKutuphanem.Worker.DependencyResolvers.Ninject;
using MMYOKutuphanem.Worker.Abstract;
using MMYOKutuphanem.DataAccess.Concrete.EntityFramework.SQLite;
using MMYOKutuphanem.DataAccess.Concrete.EntityFramework.MySql.Context;

namespace MMYOKütüphanem
{
    public partial class uc_veriduzenleme : UserControl
    {
        private IUserService UserService = InstanceFactory.GetInstance<IUserService>();
        private IBookService BookService = InstanceFactory.GetInstance<IBookService>();
        private IBranchService BranchService = InstanceFactory.GetInstance<IBranchService>();
        private IAssignmentService AssignmentService = InstanceFactory.GetInstance<IAssignmentService>();
        MySqlContext context;

        public uc_veriduzenleme()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e) => switchTab(sender);
        private void lbl_verilenlog_teslim_Click(object sender, EventArgs e) => switchTab(sender);
        private void lbl_tab_kayitlar_Click(object sender, EventArgs e) => switchTab(sender);
        private void lbl_tab_branslar_Click(object sender, EventArgs e) => switchTab(sender);
        private void switchTab(object sender)
        {
            sep_verilenlog.Visible = false;
            sep_verilenlog.Left = ((Control)sender).Left;
            sep_verilenlog.Width = ((Control)sender).Width;
            bunifuTransition1.Show(sep_verilenlog, true, Bunifu.UI.WinForms.BunifuAnimatorNS.Animation.Leaf);
            p_panel.Tag = Convert.ToInt32(((Control)sender).Tag.ToString());
            AttachContext(Convert.ToInt32(((Control)sender).Tag.ToString()));
        }

        private void AttachContext(int ind)
        {
            switch (ind)
            {
                case 0:               
                    dgv_veriyonetimi.DataSource = UserService.GetDataManagementList();
                    break;
                case 1:
                    dgv_veriyonetimi.DataSource = BookService.GetDataManagementList();
                    break;
                case 2:
                    dgv_veriyonetimi.DataSource = AssignmentService.GetDataManagementList();
                    break;
                case 3:
                    dgv_veriyonetimi.DataSource = BranchService.GetDataManagementList();
                    break;
            }
        }

        private void Bttn_SaveChanges_Click(object sender, EventArgs e)
        {
            UserService.SaveChanges();
        }

        private void uc_veriduzenleme_VisibleChanged(object sender, EventArgs e)
        {
            AttachContext(Convert.ToInt32(p_panel.Tag.ToString()));
        }

        private void dgv_veriyonetimi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
