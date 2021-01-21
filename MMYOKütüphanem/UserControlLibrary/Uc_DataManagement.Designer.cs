namespace MMYOKütüphanem
{
    partial class uc_veriduzenleme
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_veriduzenleme));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            Bunifu.UI.WinForms.BunifuAnimatorNS.Animation animation1 = new Bunifu.UI.WinForms.BunifuAnimatorNS.Animation();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.vscrollbar1 = new Bunifu.UI.WinForms.BunifuVScrollBar();
            this.dgv_veriyonetimi = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.sep_verilenlog = new Bunifu.Framework.UI.BunifuSeparator();
            this.lbl_tab_kayitlar = new System.Windows.Forms.Label();
            this.lbl_tab_kitaplar = new System.Windows.Forms.Label();
            this.p_header = new Bunifu.UI.WinForms.BunifuGradientPanel();
            this.bunifuTransition1 = new Bunifu.UI.WinForms.BunifuTransition(this.components);
            this.lbl_tab_kullancilar = new System.Windows.Forms.Label();
            this.lbl_tab_branslar = new System.Windows.Forms.Label();
            this.p_panel = new System.Windows.Forms.Panel();
            this.Bttn_SaveChanges = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_veriyonetimi)).BeginInit();
            this.p_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // vscrollbar1
            // 
            this.vscrollbar1.AllowCursorChanges = true;
            this.vscrollbar1.AllowHomeEndKeysDetection = false;
            this.vscrollbar1.AllowIncrementalClickMoves = true;
            this.vscrollbar1.AllowMouseDownEffects = true;
            this.vscrollbar1.AllowMouseHoverEffects = true;
            this.vscrollbar1.AllowScrollingAnimations = true;
            this.vscrollbar1.AllowScrollKeysDetection = true;
            this.vscrollbar1.AllowScrollOptionsMenu = true;
            this.vscrollbar1.AllowShrinkingOnFocusLost = true;
            this.vscrollbar1.BackgroundColor = System.Drawing.Color.Silver;
            this.vscrollbar1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("vscrollbar1.BackgroundImage")));
            this.vscrollbar1.BindingContainer = this.dgv_veriyonetimi;
            this.vscrollbar1.BorderColor = System.Drawing.Color.Silver;
            this.vscrollbar1.BorderRadius = 14;
            this.vscrollbar1.BorderThickness = 1;
            this.bunifuTransition1.SetDecoration(this.vscrollbar1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.vscrollbar1.Dock = System.Windows.Forms.DockStyle.Right;
            this.vscrollbar1.DurationBeforeShrink = 2000;
            this.vscrollbar1.LargeChange = 100;
            this.vscrollbar1.Location = new System.Drawing.Point(808, 43);
            this.vscrollbar1.Maximum = 100;
            this.vscrollbar1.Minimum = 0;
            this.vscrollbar1.MinimumThumbLength = 18;
            this.vscrollbar1.Name = "vscrollbar1";
            this.vscrollbar1.OnDisable.ScrollBarBorderColor = System.Drawing.Color.Silver;
            this.vscrollbar1.OnDisable.ScrollBarColor = System.Drawing.Color.Transparent;
            this.vscrollbar1.OnDisable.ThumbColor = System.Drawing.Color.Silver;
            this.vscrollbar1.ScrollBarBorderColor = System.Drawing.Color.Silver;
            this.vscrollbar1.ScrollBarColor = System.Drawing.Color.Silver;
            this.vscrollbar1.ShrinkSizeLimit = 3;
            this.vscrollbar1.Size = new System.Drawing.Size(17, 651);
            this.vscrollbar1.SmallChange = 50;
            this.vscrollbar1.TabIndex = 17;
            this.vscrollbar1.ThumbColor = System.Drawing.Color.Teal;
            this.vscrollbar1.ThumbLength = 642;
            this.vscrollbar1.ThumbMargin = 1;
            this.vscrollbar1.ThumbStyle = Bunifu.UI.WinForms.BunifuVScrollBar.ThumbStyles.Inset;
            this.vscrollbar1.Value = 0;
            // 
            // dgv_veriyonetimi
            // 
            this.dgv_veriyonetimi.AllowCustomTheming = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgv_veriyonetimi.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_veriyonetimi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_veriyonetimi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_veriyonetimi.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_veriyonetimi.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_veriyonetimi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_veriyonetimi.ColumnHeadersHeight = 40;
            this.dgv_veriyonetimi.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dgv_veriyonetimi.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgv_veriyonetimi.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgv_veriyonetimi.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgv_veriyonetimi.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgv_veriyonetimi.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dgv_veriyonetimi.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgv_veriyonetimi.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dgv_veriyonetimi.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dgv_veriyonetimi.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_veriyonetimi.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.dgv_veriyonetimi.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_veriyonetimi.CurrentTheme.Name = null;
            this.dgv_veriyonetimi.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_veriyonetimi.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgv_veriyonetimi.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgv_veriyonetimi.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgv_veriyonetimi.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.bunifuTransition1.SetDecoration(this.dgv_veriyonetimi, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_veriyonetimi.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_veriyonetimi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_veriyonetimi.EnableHeadersVisualStyles = false;
            this.dgv_veriyonetimi.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgv_veriyonetimi.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dgv_veriyonetimi.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgv_veriyonetimi.HeaderForeColor = System.Drawing.Color.White;
            this.dgv_veriyonetimi.Location = new System.Drawing.Point(3, 3);
            this.dgv_veriyonetimi.Name = "dgv_veriyonetimi";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_veriyonetimi.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_veriyonetimi.RowHeadersVisible = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgv_veriyonetimi.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_veriyonetimi.RowTemplate.Height = 40;
            this.dgv_veriyonetimi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_veriyonetimi.Size = new System.Drawing.Size(802, 645);
            this.dgv_veriyonetimi.TabIndex = 0;
            this.dgv_veriyonetimi.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.dgv_veriyonetimi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_veriyonetimi_CellContentClick);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            // 
            // sep_verilenlog
            // 
            this.sep_verilenlog.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.sep_verilenlog, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.sep_verilenlog.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(58)))), ((int)(((byte)(108)))));
            this.sep_verilenlog.LineThickness = 4;
            this.sep_verilenlog.Location = new System.Drawing.Point(214, 29);
            this.sep_verilenlog.Name = "sep_verilenlog";
            this.sep_verilenlog.Size = new System.Drawing.Size(104, 10);
            this.sep_verilenlog.TabIndex = 22;
            this.sep_verilenlog.Transparency = 255;
            this.sep_verilenlog.Vertical = false;
            // 
            // lbl_tab_kayitlar
            // 
            this.lbl_tab_kayitlar.AutoSize = true;
            this.lbl_tab_kayitlar.BackColor = System.Drawing.Color.White;
            this.lbl_tab_kayitlar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.lbl_tab_kayitlar, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.lbl_tab_kayitlar.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lbl_tab_kayitlar.ForeColor = System.Drawing.Color.Black;
            this.lbl_tab_kayitlar.Location = new System.Drawing.Point(424, 12);
            this.lbl_tab_kayitlar.Name = "lbl_tab_kayitlar";
            this.lbl_tab_kayitlar.Size = new System.Drawing.Size(74, 20);
            this.lbl_tab_kayitlar.TabIndex = 21;
            this.lbl_tab_kayitlar.Tag = "2";
            this.lbl_tab_kayitlar.Text = "KAYITLAR";
            this.lbl_tab_kayitlar.Click += new System.EventHandler(this.lbl_tab_kayitlar_Click);
            // 
            // lbl_tab_kitaplar
            // 
            this.lbl_tab_kitaplar.AutoSize = true;
            this.lbl_tab_kitaplar.BackColor = System.Drawing.Color.White;
            this.lbl_tab_kitaplar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.lbl_tab_kitaplar, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.lbl_tab_kitaplar.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lbl_tab_kitaplar.ForeColor = System.Drawing.Color.Black;
            this.lbl_tab_kitaplar.Location = new System.Drawing.Point(333, 12);
            this.lbl_tab_kitaplar.Name = "lbl_tab_kitaplar";
            this.lbl_tab_kitaplar.Size = new System.Drawing.Size(74, 20);
            this.lbl_tab_kitaplar.TabIndex = 20;
            this.lbl_tab_kitaplar.Tag = "1";
            this.lbl_tab_kitaplar.Text = "KİTAPLAR";
            this.lbl_tab_kitaplar.Click += new System.EventHandler(this.lbl_verilenlog_teslim_Click);
            // 
            // p_header
            // 
            this.p_header.BackColor = System.Drawing.SystemColors.Control;
            this.p_header.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p_header.BackgroundImage")));
            this.p_header.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.p_header.BorderRadius = 1;
            this.bunifuTransition1.SetDecoration(this.p_header, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.p_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.p_header.GradientBottomLeft = System.Drawing.Color.White;
            this.p_header.GradientBottomRight = System.Drawing.Color.White;
            this.p_header.GradientTopLeft = System.Drawing.Color.White;
            this.p_header.GradientTopRight = System.Drawing.Color.White;
            this.p_header.Location = new System.Drawing.Point(0, 0);
            this.p_header.Name = "p_header";
            this.p_header.Quality = 10;
            this.p_header.Size = new System.Drawing.Size(825, 43);
            this.p_header.TabIndex = 18;
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = Bunifu.UI.WinForms.BunifuAnimatorNS.AnimationType.VertSlide;
            this.bunifuTransition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.bunifuTransition1.DefaultAnimation = animation1;
            // 
            // lbl_tab_kullancilar
            // 
            this.lbl_tab_kullancilar.AutoSize = true;
            this.lbl_tab_kullancilar.BackColor = System.Drawing.Color.White;
            this.lbl_tab_kullancilar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.lbl_tab_kullancilar, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.lbl_tab_kullancilar.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lbl_tab_kullancilar.ForeColor = System.Drawing.Color.Black;
            this.lbl_tab_kullancilar.Location = new System.Drawing.Point(214, 12);
            this.lbl_tab_kullancilar.Name = "lbl_tab_kullancilar";
            this.lbl_tab_kullancilar.Size = new System.Drawing.Size(108, 20);
            this.lbl_tab_kullancilar.TabIndex = 23;
            this.lbl_tab_kullancilar.Tag = "0";
            this.lbl_tab_kullancilar.Text = "KULLANICILAR";
            this.lbl_tab_kullancilar.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_tab_branslar
            // 
            this.lbl_tab_branslar.AutoSize = true;
            this.lbl_tab_branslar.BackColor = System.Drawing.Color.White;
            this.lbl_tab_branslar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.lbl_tab_branslar, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.lbl_tab_branslar.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lbl_tab_branslar.ForeColor = System.Drawing.Color.Black;
            this.lbl_tab_branslar.Location = new System.Drawing.Point(509, 12);
            this.lbl_tab_branslar.Name = "lbl_tab_branslar";
            this.lbl_tab_branslar.Size = new System.Drawing.Size(83, 20);
            this.lbl_tab_branslar.TabIndex = 21;
            this.lbl_tab_branslar.Tag = "3";
            this.lbl_tab_branslar.Text = "BRANŞLAR";
            this.lbl_tab_branslar.Click += new System.EventHandler(this.lbl_tab_branslar_Click);
            // 
            // p_panel
            // 
            this.p_panel.Controls.Add(this.Bttn_SaveChanges);
            this.p_panel.Controls.Add(this.dgv_veriyonetimi);
            this.bunifuTransition1.SetDecoration(this.p_panel, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.p_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.p_panel.Location = new System.Drawing.Point(0, 43);
            this.p_panel.Name = "p_panel";
            this.p_panel.Padding = new System.Windows.Forms.Padding(3);
            this.p_panel.Size = new System.Drawing.Size(808, 651);
            this.p_panel.TabIndex = 24;
            this.p_panel.Tag = "0";
            // 
            // Bttn_SaveChanges
            // 
            this.Bttn_SaveChanges.AllowToggling = false;
            this.Bttn_SaveChanges.AnimationSpeed = 150;
            this.Bttn_SaveChanges.AutoGenerateColors = false;
            this.Bttn_SaveChanges.AutoSizeLeftIcon = true;
            this.Bttn_SaveChanges.AutoSizeRightIcon = true;
            this.Bttn_SaveChanges.BackColor = System.Drawing.Color.Transparent;
            this.Bttn_SaveChanges.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.Bttn_SaveChanges.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Bttn_SaveChanges.BackgroundImage")));
            this.Bttn_SaveChanges.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Bttn_SaveChanges.ButtonText = "           kaydet";
            this.Bttn_SaveChanges.ButtonTextMarginLeft = 0;
            this.Bttn_SaveChanges.ColorContrastOnClick = 45;
            this.Bttn_SaveChanges.ColorContrastOnHover = 45;
            this.Bttn_SaveChanges.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.Bttn_SaveChanges.CustomizableEdges = borderEdges1;
            this.bunifuTransition1.SetDecoration(this.Bttn_SaveChanges, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.Bttn_SaveChanges.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Bttn_SaveChanges.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.Bttn_SaveChanges.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Bttn_SaveChanges.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.Bttn_SaveChanges.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.Bttn_SaveChanges.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.45F);
            this.Bttn_SaveChanges.ForeColor = System.Drawing.Color.White;
            this.Bttn_SaveChanges.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Bttn_SaveChanges.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.Bttn_SaveChanges.IconLeftPadding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.Bttn_SaveChanges.IconMarginLeft = 11;
            this.Bttn_SaveChanges.IconPadding = 10;
            this.Bttn_SaveChanges.IconRightAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Bttn_SaveChanges.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.Bttn_SaveChanges.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.Bttn_SaveChanges.IconSize = 27;
            this.Bttn_SaveChanges.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.Bttn_SaveChanges.IdleBorderRadius = 1;
            this.Bttn_SaveChanges.IdleBorderThickness = 1;
            this.Bttn_SaveChanges.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.Bttn_SaveChanges.IdleIconLeftImage = ((System.Drawing.Image)(resources.GetObject("Bttn_SaveChanges.IdleIconLeftImage")));
            this.Bttn_SaveChanges.IdleIconRightImage = null;
            this.Bttn_SaveChanges.IndicateFocus = false;
            this.Bttn_SaveChanges.Location = new System.Drawing.Point(676, 601);
            this.Bttn_SaveChanges.Name = "Bttn_SaveChanges";
            this.Bttn_SaveChanges.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.Bttn_SaveChanges.OnDisabledState.BorderRadius = 1;
            this.Bttn_SaveChanges.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Bttn_SaveChanges.OnDisabledState.BorderThickness = 1;
            this.Bttn_SaveChanges.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Bttn_SaveChanges.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.Bttn_SaveChanges.OnDisabledState.IconLeftImage = null;
            this.Bttn_SaveChanges.OnDisabledState.IconRightImage = null;
            this.Bttn_SaveChanges.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(60)))), ((int)(((byte)(78)))));
            this.Bttn_SaveChanges.onHoverState.BorderRadius = 1;
            this.Bttn_SaveChanges.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Bttn_SaveChanges.onHoverState.BorderThickness = 1;
            this.Bttn_SaveChanges.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(60)))), ((int)(((byte)(78)))));
            this.Bttn_SaveChanges.onHoverState.ForeColor = System.Drawing.Color.White;
            this.Bttn_SaveChanges.onHoverState.IconLeftImage = null;
            this.Bttn_SaveChanges.onHoverState.IconRightImage = null;
            this.Bttn_SaveChanges.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.Bttn_SaveChanges.OnIdleState.BorderRadius = 1;
            this.Bttn_SaveChanges.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Bttn_SaveChanges.OnIdleState.BorderThickness = 1;
            this.Bttn_SaveChanges.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.Bttn_SaveChanges.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.Bttn_SaveChanges.OnIdleState.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("Bttn_SaveChanges.OnIdleState.IconLeftImage")));
            this.Bttn_SaveChanges.OnIdleState.IconRightImage = null;
            this.Bttn_SaveChanges.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(15)))), ((int)(((byte)(25)))));
            this.Bttn_SaveChanges.OnPressedState.BorderRadius = 1;
            this.Bttn_SaveChanges.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Bttn_SaveChanges.OnPressedState.BorderThickness = 1;
            this.Bttn_SaveChanges.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(15)))), ((int)(((byte)(25)))));
            this.Bttn_SaveChanges.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.Bttn_SaveChanges.OnPressedState.IconLeftImage = null;
            this.Bttn_SaveChanges.OnPressedState.IconRightImage = null;
            this.Bttn_SaveChanges.Size = new System.Drawing.Size(126, 44);
            this.Bttn_SaveChanges.TabIndex = 28;
            this.Bttn_SaveChanges.Tag = "veri yönetimi";
            this.Bttn_SaveChanges.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Bttn_SaveChanges.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.Bttn_SaveChanges.TextMarginLeft = 0;
            this.Bttn_SaveChanges.TextPadding = new System.Windows.Forms.Padding(0);
            this.Bttn_SaveChanges.UseDefaultRadiusAndThickness = true;
            this.Bttn_SaveChanges.Click += new System.EventHandler(this.Bttn_SaveChanges_Click);
            // 
            // uc_veriduzenleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.p_panel);
            this.Controls.Add(this.lbl_tab_branslar);
            this.Controls.Add(this.lbl_tab_kullancilar);
            this.Controls.Add(this.vscrollbar1);
            this.Controls.Add(this.sep_verilenlog);
            this.Controls.Add(this.lbl_tab_kayitlar);
            this.Controls.Add(this.lbl_tab_kitaplar);
            this.Controls.Add(this.p_header);
            this.bunifuTransition1.SetDecoration(this, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.Name = "uc_veriduzenleme";
            this.Size = new System.Drawing.Size(825, 694);
            this.VisibleChanged += new System.EventHandler(this.uc_veriduzenleme_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_veriyonetimi)).EndInit();
            this.p_panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.UI.WinForms.BunifuTransition bunifuTransition1;
        private Bunifu.UI.WinForms.BunifuVScrollBar vscrollbar1;
        private System.Windows.Forms.Timer timer1;
        private Bunifu.Framework.UI.BunifuSeparator sep_verilenlog;
        private System.Windows.Forms.Label lbl_tab_kayitlar;
        private System.Windows.Forms.Label lbl_tab_kitaplar;
        private Bunifu.UI.WinForms.BunifuGradientPanel p_header;
        private System.Windows.Forms.Label lbl_tab_kullancilar;
        private System.Windows.Forms.Label lbl_tab_branslar;
        private System.Windows.Forms.Panel p_panel;
        private Bunifu.UI.WinForms.BunifuDataGridView dgv_veriyonetimi;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton Bttn_SaveChanges;
    }
}
