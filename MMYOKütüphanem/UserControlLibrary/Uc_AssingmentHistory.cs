using System;
using System.Drawing;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Bunifu.UI.WinForms;
using System.Data;
using MMYOKutuphanem.Entites.Concrete;
using MMYOKutuphanem.Worker.Abstract;
using MMYOKutuphanem.Worker.DependencyResolvers.Ninject;
using MMYOKütüphanem.Properties;

namespace MMYOKütüphanem
{
    public partial class uc_verilenlog : UserControl
    {
        private readonly IAssignmentService AssignmentService = InstanceFactory.GetInstance<IAssignmentService>();
        private readonly IBookService BookService = InstanceFactory.GetInstance<IBookService>();
        private readonly IUserService UserService = InstanceFactory.GetInstance<IUserService>();

        public uc_verilenlog()
        {
            InitializeComponent();
        }

        private void Uc_verilenlog_Load(object sender, EventArgs e)
        {
 
        }
        int subitem_count = 0;
        private void OgeOlustur(DateTime entryDate, string strMetin, int isOpen)
        {
            Panel subitem_item = new Panel();
            BunifuSeparator subitem_seperator = new BunifuSeparator();
            Label subitem_date = new Label();
            Panel subitem_panel_textframe = new Panel();
            Panel subpanel_item_panel_rightbutton = new Panel();
            Bunifu.Framework.UI.BunifuThinButton2 subitem_button_rightbutton = new Bunifu.Framework.UI.BunifuThinButton2();
            // 
            // subitem_item
            // 
            if (subitem_count % 2 == 0) subitem_item.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(215)))));
            else
                subitem_item.BackColor = Color.White;
            subitem_count++;

            subitem_item.Controls.Add(subitem_panel_textframe);
            subitem_item.Controls.Add(subpanel_item_panel_rightbutton);
            subitem_item.Controls.Add(subitem_seperator);
            subitem_item.Controls.Add(subitem_date);
            subitem_item.Margin = new System.Windows.Forms.Padding(0);
            subitem_item.Name = "subitem_item";
            subitem_item.Size = new System.Drawing.Size(805, 40);
            subitem_item.Tag = isOpen;
            // 
            // subitem_seperator
            // 
            subitem_seperator.BackColor = System.Drawing.Color.Transparent;
            subitem_seperator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            subitem_seperator.LineColor = System.Drawing.Color.Black;
            subitem_seperator.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.DoubleEdgeFaded;
            subitem_seperator.LineThickness = 1;
            subitem_seperator.Location = new System.Drawing.Point(148, 5);
            subitem_seperator.Name = "subitem_seperator";
            subitem_seperator.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Vertical;
            subitem_seperator.Size = new System.Drawing.Size(32, 1);
            subitem_seperator.TabIndex = 1;
            // 
            // subitem_date
            // 
            subitem_date.AutoSize = true;
            subitem_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            subitem_date.Location = new System.Drawing.Point(6, 11);
            subitem_date.Name = "subitem_date";
            subitem_date.Size = new System.Drawing.Size(112, 18);
            subitem_date.TabIndex = 0;
            subitem_date.Text = entryDate.ToString();
            // 
            // subpanel_item_panel_rightbutton
            // 
            subpanel_item_panel_rightbutton.Controls.Add(subitem_button_rightbutton);
            subpanel_item_panel_rightbutton.Dock = System.Windows.Forms.DockStyle.Right;
            subpanel_item_panel_rightbutton.Location = new System.Drawing.Point(673, 0);
            subpanel_item_panel_rightbutton.Name = "subpanel_item_panel_rightbutton";
            subpanel_item_panel_rightbutton.Padding = new System.Windows.Forms.Padding(1);
            subpanel_item_panel_rightbutton.Size = new System.Drawing.Size(60, 40);
            subpanel_item_panel_rightbutton.TabIndex = 3;
            subpanel_item_panel_rightbutton.BackColor = Color.Transparent;
            subpanel_item_panel_rightbutton.Visible = false;
            // 
            // subitem_button_rightbutton
            // 
            subitem_button_rightbutton.ActiveBorderThickness = 1;
            subitem_button_rightbutton.ActiveCornerRadius = 20;
            subitem_button_rightbutton.ActiveFillColor = System.Drawing.Color.SeaGreen;
            subitem_button_rightbutton.ActiveForecolor = System.Drawing.Color.White;
            subitem_button_rightbutton.ActiveLineColor = System.Drawing.Color.SeaGreen;
            subitem_button_rightbutton.BackColor = Color.Transparent;
            subitem_button_rightbutton.ButtonText = "İncele";
            subitem_button_rightbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            subitem_button_rightbutton.Dock = System.Windows.Forms.DockStyle.Fill;
            subitem_button_rightbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            subitem_button_rightbutton.ForeColor = System.Drawing.Color.SeaGreen;
            subitem_button_rightbutton.IdleBorderThickness = 1;
            subitem_button_rightbutton.IdleCornerRadius = 20;
            subitem_button_rightbutton.IdleFillColor = System.Drawing.Color.White;
            subitem_button_rightbutton.IdleForecolor = System.Drawing.Color.SeaGreen;
            subitem_button_rightbutton.IdleLineColor = System.Drawing.Color.SeaGreen;
            subitem_button_rightbutton.Location = new System.Drawing.Point(1, 1);
            subitem_button_rightbutton.Margin = new System.Windows.Forms.Padding(5);
            subitem_button_rightbutton.Name = "subitem_button_rightbutton";
            subitem_button_rightbutton.Size = new System.Drawing.Size(120, 38);
            subitem_button_rightbutton.TabIndex = 0;
            subitem_button_rightbutton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            subitem_button_rightbutton.Click += new EventHandler(Subitem_button_rightbutton_Click);
            subitem_button_rightbutton.Visible = false;
            // 
            // subitem_panel_textframe
            // 
            subitem_panel_textframe.Dock = System.Windows.Forms.DockStyle.Right;
            subitem_panel_textframe.Location = new System.Drawing.Point(20, 0);
            subitem_panel_textframe.Name = "subitem_panel_textframe";
            subitem_panel_textframe.Padding = new System.Windows.Forms.Padding(1);
            subitem_panel_textframe.Size = new System.Drawing.Size(650, 40);
            subitem_panel_textframe.TabIndex = 4;
            subitem_panel_textframe.Paint += new PaintEventHandler(AddPaintedText);
            text = strMetin;

            subitem_seperator.Orientation = BunifuSeparator.LineOrientation.Vertical;

            this.vscrollbar1.LargeChange = this.vscrollbar1.Maximum / 2;

            p_panel.Controls.Add(subitem_item);
            p_panel.Refresh();
        }

        public Panel CreateNoEntryInfo()
        {
            Panel p_noentry = new Panel();
            BunifuLabel lbl_h1inf = new BunifuLabel();
            PictureBox pb_ico = new PictureBox();

            p_noentry.Controls.Add(lbl_h1inf);
            p_noentry.Controls.Add(pb_ico);
            this.bunifuTransition1.SetDecoration(p_noentry, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            p_noentry.Location = new System.Drawing.Point(3, 3);
            p_noentry.Name = "p_noentry";
            p_noentry.Size = new System.Drawing.Size(805, 648);
            p_noentry.TabIndex = 0;
            p_noentry.Visible = true;

            lbl_h1inf.AllowParentOverrides = false;
            lbl_h1inf.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            lbl_h1inf.AutoEllipsis = false;
            lbl_h1inf.AutoSize = false;
            lbl_h1inf.CursorType = null; 
            this.bunifuTransition1.SetDecoration(lbl_h1inf, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            lbl_h1inf.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbl_h1inf.ForeColor = System.Drawing.Color.Black;
            lbl_h1inf.Location = new System.Drawing.Point(238, 241);
            lbl_h1inf.Name = "lbl_h1loading";
            lbl_h1inf.RightToLeft = System.Windows.Forms.RightToLeft.No;
            lbl_h1inf.Size = new System.Drawing.Size(484, 139);
            lbl_h1inf.TabIndex = 24;
            lbl_h1inf.Text = "<h2>kayıt bulunamadı !</h1>";
            lbl_h1inf.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            lbl_h1inf.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            lbl_h1inf.Visible = true;
            // 
            // pb_h1loading
            // 
            pb_ico.BackgroundImage = ((System.Drawing.Image)(Resources.empty_icon_0));
            pb_ico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuTransition1.SetDecoration(pb_ico, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            pb_ico.Location = new System.Drawing.Point(134, 265);
            pb_ico.Name = "pb_h1loading";
            pb_ico.Size = new System.Drawing.Size(98, 94);
            pb_ico.TabIndex = 23;
            pb_ico.TabStop = false;
            pb_ico.Visible = true;
            p_panel.Controls.Add(p_noentry);
            p_noentry.BringToFront();
            return p_noentry;
        }

        string text = "";
        private void AddPaintedText(object sender, PaintEventArgs e)
        {
            Control control = sender as Control;
            TextFormatFlags flags = TextFormatFlags.Left | TextFormatFlags.VerticalCenter |
                                    TextFormatFlags.NoPadding | TextFormatFlags.NoClipping;
            Font font = new Font("Times New Roman", 11, FontStyle.Regular, GraphicsUnit.Point);
            Rectangle WordBounds = Rectangle.Round(control.ClientRectangle);

            MatchCollection matches = Regex.Matches(text, "\\[color=([^\\]]+)\\]([^\\]]+)\\[\\/color\\]");
            foreach (Match match in matches)
            {
                Color _color;
                if (match.Groups[1].Value.StartsWith("#"))
                    _color = ColorTranslator.FromHtml(match.Groups[1].Value);
                else
                    _color = Color.FromName(match.Groups[1].Value);
                TextRenderer.DrawText(e.Graphics, match.Groups[2].Value, font, WordBounds, _color, flags);
                Size _textSize = TextRenderer.MeasureText(match.Groups[2].Value, font);
                WordBounds.X += _textSize.Width - 3;
            }
        }

        private void Subitem_button_rightbutton_Click(object sender, EventArgs e)
        {

        }

        private void ApplyFilter()
        {
            p_panel.Controls.Clear();
            foreach (Assignment _assignment in AssignmentService.GetList(p => p.Statu == curFilter))
            {
                Book _book = new Book(); _book = BookService.Get(p => p.Barcod == _assignment.Barcod);
                User _user = new User(); _user = UserService.Get(p => p.Id == _assignment.UserId);
                DateTime entryDate = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Local).AddSeconds(_assignment.AssignDate);
                TimeSpan keptDays = (new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Local).AddSeconds(_assignment.ReturnDate)) - entryDate;
                OgeOlustur(entryDate, string.Format("[color=seagreen]{0}[/color] [color=black]adlı kullanıcı[/color] [color=seagreen] {1}[/color][color=black] adlı kitabı[/color]",_user.Name,_book.Name)
                    + (curFilter == 1 ? string.Format("[color=orange] {0}[/color] [color=darkgray]okuyor[/color]", FarkHesapla(Convert.ToDouble(_assignment.AssignDate))).ToString() : string.Format("[color=blue]{0} sonra teslim etti.[/color]", keptDays.Days + " gün " + keptDays.Hours + " saat")), curFilter);
            }
            if (p_panel.Controls.Count == 0)
                bunifuTransition1.Show(CreateNoEntryInfo(), true, Bunifu.UI.WinForms.BunifuAnimatorNS.Animation.Transparent);
        }

        private void Lbl_verilenlog_teslim_Click(object sender, EventArgs e) => SwitchTab(sender);
        private void Lbl_verilen_gerialim_Click_1(object sender, EventArgs e) => SwitchTab(sender);
        private void Uc_verilenlog_VisibleChanged(object sender, EventArgs e) => ApplyFilter();

        private void Vscrollbar1_Scroll(object sender, BunifuVScrollBar.ScrollEventArgs e) => Refresh();

        int curFilter = 1;
        private void SwitchTab(object sender)
        {
            sep_verilenlog.Visible = false;
            sep_verilenlog.Left = ((Control)sender).Left;
            sep_verilenlog.Width = ((Control)sender).Width;
            bunifuTransition1.Show(sep_verilenlog, true, Bunifu.UI.WinForms.BunifuAnimatorNS.Animation.Leaf);
            curFilter = Convert.ToInt32(((Control)sender).Tag);
            ApplyFilter();
        }

        public static string FarkHesapla(double unixTimeStamp)
        {
            System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Local);
            TimeSpan _dt = DateTime.Now.Subtract(dtDateTime.AddSeconds(unixTimeStamp).ToLocalTime());
            return _dt.Days.ToString() + " gün " + _dt.Hours.ToString() + (_dt.TotalHours < 1 ? string.Format(" saat {0} dakikadır", _dt.Minutes.ToString()) : " saattir");
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            if (this.Visible != true) return;
            ApplyFilter();
        }

        private void p_header_Click(object sender, EventArgs e)
        {

        }

        private void sep_verilenlog_Load(object sender, EventArgs e)
        {

        }
    }
}
