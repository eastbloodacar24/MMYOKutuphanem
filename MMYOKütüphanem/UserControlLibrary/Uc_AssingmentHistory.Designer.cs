namespace MMYOKütüphanem
{
    partial class uc_verilenlog
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
            Bunifu.UI.WinForms.BunifuAnimatorNS.Animation animation1 = new Bunifu.UI.WinForms.BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_verilenlog));
            this.sep_verilenlog = new Bunifu.Framework.UI.BunifuSeparator();
            this.lbl_verilen_gerialim = new System.Windows.Forms.Label();
            this.lbl_verilenlog_teslim = new System.Windows.Forms.Label();
            this.p_header = new Bunifu.UI.WinForms.BunifuGradientPanel();
            this.bunifuTransition1 = new Bunifu.UI.WinForms.BunifuTransition(this.components);
            this.sep_log = new Bunifu.UI.WinForms.BunifuSeparator();
            this.vscrollbar1 = new Bunifu.UI.WinForms.BunifuVScrollBar();
            this.p_panel = new System.Windows.Forms.FlowLayoutPanel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // sep_verilenlog
            // 
            this.sep_verilenlog.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.sep_verilenlog, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.sep_verilenlog.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(58)))), ((int)(((byte)(108)))));
            this.sep_verilenlog.LineThickness = 4;
            this.sep_verilenlog.Location = new System.Drawing.Point(256, 27);
            this.sep_verilenlog.Name = "sep_verilenlog";
            this.sep_verilenlog.Size = new System.Drawing.Size(143, 10);
            this.sep_verilenlog.TabIndex = 16;
            this.sep_verilenlog.Transparency = 255;
            this.sep_verilenlog.Vertical = false;
            this.sep_verilenlog.Load += new System.EventHandler(this.sep_verilenlog_Load);
            // 
            // lbl_verilen_gerialim
            // 
            this.lbl_verilen_gerialim.AutoSize = true;
            this.lbl_verilen_gerialim.BackColor = System.Drawing.Color.White;
            this.lbl_verilen_gerialim.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.lbl_verilen_gerialim, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.lbl_verilen_gerialim.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lbl_verilen_gerialim.ForeColor = System.Drawing.Color.Black;
            this.lbl_verilen_gerialim.Location = new System.Drawing.Point(420, 10);
            this.lbl_verilen_gerialim.Name = "lbl_verilen_gerialim";
            this.lbl_verilen_gerialim.Size = new System.Drawing.Size(107, 20);
            this.lbl_verilen_gerialim.TabIndex = 15;
            this.lbl_verilen_gerialim.Tag = "0";
            this.lbl_verilen_gerialim.Text = "ESKİ KAYITLAR";
            this.lbl_verilen_gerialim.Click += new System.EventHandler(this.Lbl_verilen_gerialim_Click_1);
            // 
            // lbl_verilenlog_teslim
            // 
            this.lbl_verilenlog_teslim.AutoSize = true;
            this.lbl_verilenlog_teslim.BackColor = System.Drawing.Color.White;
            this.lbl_verilenlog_teslim.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.lbl_verilenlog_teslim, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.lbl_verilenlog_teslim.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lbl_verilenlog_teslim.ForeColor = System.Drawing.Color.Black;
            this.lbl_verilenlog_teslim.Location = new System.Drawing.Point(254, 10);
            this.lbl_verilenlog_teslim.Name = "lbl_verilenlog_teslim";
            this.lbl_verilenlog_teslim.Size = new System.Drawing.Size(148, 20);
            this.lbl_verilenlog_teslim.TabIndex = 14;
            this.lbl_verilenlog_teslim.Tag = "1";
            this.lbl_verilenlog_teslim.Text = "REZERVE EDİLENLER";
            this.lbl_verilenlog_teslim.Click += new System.EventHandler(this.Lbl_verilenlog_teslim_Click);
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
            this.p_header.TabIndex = 12;
            this.p_header.Click += new System.EventHandler(this.p_header_Click);
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
            // sep_log
            // 
            this.sep_log.BackColor = System.Drawing.Color.Transparent;
            this.sep_log.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sep_log.BackgroundImage")));
            this.sep_log.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuTransition1.SetDecoration(this.sep_log, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.sep_log.LineColor = System.Drawing.Color.Black;
            this.sep_log.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid;
            this.sep_log.LineThickness = 1;
            this.sep_log.Location = new System.Drawing.Point(0, 43);
            this.sep_log.Name = "sep_log";
            this.sep_log.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.sep_log.Size = new System.Drawing.Size(825, 1);
            this.sep_log.TabIndex = 17;
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
            this.vscrollbar1.BindingContainer = null;
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
            this.vscrollbar1.TabIndex = 18;
            this.vscrollbar1.ThumbColor = System.Drawing.Color.Teal;
            this.vscrollbar1.ThumbLength = 642;
            this.vscrollbar1.ThumbMargin = 1;
            this.vscrollbar1.ThumbStyle = Bunifu.UI.WinForms.BunifuVScrollBar.ThumbStyles.Inset;
            this.vscrollbar1.Value = 0;
            // 
            // p_panel
            // 
            this.bunifuTransition1.SetDecoration(this.p_panel, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.p_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.p_panel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.p_panel.Location = new System.Drawing.Point(0, 43);
            this.p_panel.Margin = new System.Windows.Forms.Padding(0);
            this.p_panel.Name = "p_panel";
            this.p_panel.Size = new System.Drawing.Size(808, 651);
            this.p_panel.TabIndex = 20;
            this.p_panel.WrapContents = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // uc_verilenlog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.p_panel);
            this.Controls.Add(this.vscrollbar1);
            this.Controls.Add(this.sep_log);
            this.Controls.Add(this.sep_verilenlog);
            this.Controls.Add(this.lbl_verilen_gerialim);
            this.Controls.Add(this.lbl_verilenlog_teslim);
            this.Controls.Add(this.p_header);
            this.bunifuTransition1.SetDecoration(this, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.Name = "uc_verilenlog";
            this.Size = new System.Drawing.Size(825, 694);
            this.Load += new System.EventHandler(this.Uc_verilenlog_Load);
            this.VisibleChanged += new System.EventHandler(this.Uc_verilenlog_VisibleChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.UI.WinForms.BunifuTransition bunifuTransition1;
        private Bunifu.Framework.UI.BunifuSeparator sep_verilenlog;
        private System.Windows.Forms.Label lbl_verilen_gerialim;
        private System.Windows.Forms.Label lbl_verilenlog_teslim;
        private Bunifu.UI.WinForms.BunifuGradientPanel p_header;
        private Bunifu.UI.WinForms.BunifuSeparator sep_log;
        private System.Windows.Forms.Timer timer1;
        private Bunifu.UI.WinForms.BunifuVScrollBar vscrollbar1;
        private System.Windows.Forms.FlowLayoutPanel p_panel;
    }
}
