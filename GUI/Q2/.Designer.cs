namespace Q2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.content = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnmenu = new System.Windows.Forms.Button();
            this.btnabtus = new System.Windows.Forms.Button();
            this.btneatingin = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.picvegie = new System.Windows.Forms.PictureBox();
            this.piccheesemix = new System.Windows.Forms.PictureBox();
            this.piconions = new System.Windows.Forms.PictureBox();
            this.btnvegie = new System.Windows.Forms.Button();
            this.btncheesemix = new System.Windows.Forms.Button();
            this.btnonimato = new System.Windows.Forms.Button();
            this.lbl_abtus = new System.Windows.Forms.Label();
            this.btn_cart = new System.Windows.Forms.Button();
            this.grppizzaBox = new System.Windows.Forms.GroupBox();
            this.TimeLbl = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.RichPizza = new System.Windows.Forms.RichTextBox();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.btn_Buy = new System.Windows.Forms.Button();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picvegie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.piccheesemix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.piconions)).BeginInit();
            this.grppizzaBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // content
            // 
            this.content.AutoSize = true;
            this.content.BackColor = System.Drawing.Color.AntiqueWhite;
            this.content.Font = new System.Drawing.Font("Snap ITC", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.content.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.content.Location = new System.Drawing.Point(155, 23);
            this.content.Name = "content";
            this.content.Size = new System.Drawing.Size(483, 39);
            this.content.TabIndex = 0;
            this.content.Text = "Welcome to AxM Pizzaria\r\n";
            this.content.Click += new System.EventHandler(this.label1_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // btnmenu
            // 
            this.btnmenu.BackColor = System.Drawing.Color.DarkGray;
            this.btnmenu.ForeColor = System.Drawing.Color.Black;
            this.btnmenu.Location = new System.Drawing.Point(149, 78);
            this.btnmenu.Name = "btnmenu";
            this.btnmenu.Size = new System.Drawing.Size(187, 94);
            this.btnmenu.TabIndex = 2;
            this.btnmenu.Text = "To the Menu";
            this.btnmenu.UseVisualStyleBackColor = false;
            this.btnmenu.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnabtus
            // 
            this.btnabtus.Location = new System.Drawing.Point(429, 78);
            this.btnabtus.Name = "btnabtus";
            this.btnabtus.Size = new System.Drawing.Size(167, 94);
            this.btnabtus.TabIndex = 4;
            this.btnabtus.Text = "About us";
            this.btnabtus.UseVisualStyleBackColor = true;
            this.btnabtus.Click += new System.EventHandler(this.btnabtus_Click);
            // 
            // btneatingin
            // 
            this.btneatingin.Location = new System.Drawing.Point(266, 78);
            this.btneatingin.Name = "btneatingin";
            this.btneatingin.Size = new System.Drawing.Size(187, 94);
            this.btneatingin.TabIndex = 7;
            this.btneatingin.Text = "Eating in";
            this.btneatingin.UseVisualStyleBackColor = true;
            this.btneatingin.Visible = false;
            this.btneatingin.Click += new System.EventHandler(this.btneatingin_Click);
            // 
            // btnback
            // 
            this.btnback.Location = new System.Drawing.Point(33, 23);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(73, 21);
            this.btnback.TabIndex = 8;
            this.btnback.Text = "back";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Visible = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // picvegie
            // 
            this.picvegie.Image = ((System.Drawing.Image)(resources.GetObject("picvegie.Image")));
            this.picvegie.Location = new System.Drawing.Point(531, 22);
            this.picvegie.Name = "picvegie";
            this.picvegie.Size = new System.Drawing.Size(178, 138);
            this.picvegie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picvegie.TabIndex = 9;
            this.picvegie.TabStop = false;
            // 
            // piccheesemix
            // 
            this.piccheesemix.Image = ((System.Drawing.Image)(resources.GetObject("piccheesemix.Image")));
            this.piccheesemix.Location = new System.Drawing.Point(279, 22);
            this.piccheesemix.Name = "piccheesemix";
            this.piccheesemix.Size = new System.Drawing.Size(184, 138);
            this.piccheesemix.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.piccheesemix.TabIndex = 10;
            this.piccheesemix.TabStop = false;
            this.piccheesemix.Click += new System.EventHandler(this.piconionstomato_Click);
            // 
            // piconions
            // 
            this.piconions.Image = ((System.Drawing.Image)(resources.GetObject("piconions.Image")));
            this.piconions.Location = new System.Drawing.Point(38, 21);
            this.piconions.Name = "piconions";
            this.piconions.Size = new System.Drawing.Size(184, 138);
            this.piconions.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.piconions.TabIndex = 11;
            this.piconions.TabStop = false;
            // 
            // btnvegie
            // 
            this.btnvegie.BackColor = System.Drawing.Color.Wheat;
            this.btnvegie.Location = new System.Drawing.Point(562, 165);
            this.btnvegie.Name = "btnvegie";
            this.btnvegie.Size = new System.Drawing.Size(127, 87);
            this.btnvegie.TabIndex = 12;
            this.btnvegie.Text = "Vegie Pizza \r\nfor these who want to do diet\r\n65 shekels\r\n\r\n";
            this.btnvegie.UseVisualStyleBackColor = false;
            this.btnvegie.Click += new System.EventHandler(this.btnvegie_Click);
            // 
            // btncheesemix
            // 
            this.btncheesemix.BackColor = System.Drawing.Color.Wheat;
            this.btncheesemix.Location = new System.Drawing.Point(313, 165);
            this.btncheesemix.Name = "btncheesemix";
            this.btncheesemix.Size = new System.Drawing.Size(128, 117);
            this.btncheesemix.TabIndex = 13;
            this.btncheesemix.Text = "Chesse mix \r\nmore cheese and different types of the best chesse around the world " +
    "\r\n75 shekels\r\n";
            this.btncheesemix.UseVisualStyleBackColor = false;
            this.btncheesemix.Click += new System.EventHandler(this.btncheesemix_Click);
            // 
            // btnonimato
            // 
            this.btnonimato.BackColor = System.Drawing.Color.Wheat;
            this.btnonimato.Location = new System.Drawing.Point(38, 176);
            this.btnonimato.Name = "btnonimato";
            this.btnonimato.Size = new System.Drawing.Size(167, 100);
            this.btnonimato.TabIndex = 14;
            this.btnonimato.Text = "OniMato\r\ntomato slices with onions is the\r\n perfect combo\r\n70 shekels\r\n";
            this.btnonimato.UseVisualStyleBackColor = false;
            this.btnonimato.Click += new System.EventHandler(this.btnonimato_Click);
            // 
            // lbl_abtus
            // 
            this.lbl_abtus.AutoSize = true;
            this.lbl_abtus.BackColor = System.Drawing.Color.Wheat;
            this.lbl_abtus.Font = new System.Drawing.Font("Rockwell", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_abtus.Location = new System.Drawing.Point(63, 60);
            this.lbl_abtus.Name = "lbl_abtus";
            this.lbl_abtus.Size = new System.Drawing.Size(638, 76);
            this.lbl_abtus.TabIndex = 16;
            this.lbl_abtus.Text = resources.GetString("lbl_abtus.Text");
            this.lbl_abtus.Visible = false;
            this.lbl_abtus.Click += new System.EventHandler(this.lbl_abtus_Click);
            // 
            // btn_cart
            // 
            this.btn_cart.BackColor = System.Drawing.Color.Wheat;
            this.btn_cart.Location = new System.Drawing.Point(21, 376);
            this.btn_cart.Name = "btn_cart";
            this.btn_cart.Size = new System.Drawing.Size(115, 72);
            this.btn_cart.TabIndex = 17;
            this.btn_cart.Text = "Cart$$";
            this.btn_cart.UseVisualStyleBackColor = false;
            this.btn_cart.Click += new System.EventHandler(this.btn_cart_Click);
            // 
            // grppizzaBox
            // 
            this.grppizzaBox.BackColor = System.Drawing.Color.Transparent;
            this.grppizzaBox.Controls.Add(this.TimeLbl);
            this.grppizzaBox.Controls.Add(this.btn_cart);
            this.grppizzaBox.Controls.Add(this.piconions);
            this.grppizzaBox.Controls.Add(this.btncheesemix);
            this.grppizzaBox.Controls.Add(this.piccheesemix);
            this.grppizzaBox.Controls.Add(this.btnvegie);
            this.grppizzaBox.Controls.Add(this.picvegie);
            this.grppizzaBox.Controls.Add(this.btnonimato);
            this.grppizzaBox.Location = new System.Drawing.Point(12, -1);
            this.grppizzaBox.Name = "grppizzaBox";
            this.grppizzaBox.Size = new System.Drawing.Size(725, 553);
            this.grppizzaBox.TabIndex = 18;
            this.grppizzaBox.TabStop = false;
            this.grppizzaBox.Text = "groupBox1";
            this.grppizzaBox.Visible = false;
            this.grppizzaBox.Enter += new System.EventHandler(this.grppizzaBox_Enter);
            // 
            // TimeLbl
            // 
            this.TimeLbl.AutoSize = true;
            this.TimeLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.TimeLbl.Location = new System.Drawing.Point(362, 59);
            this.TimeLbl.Name = "TimeLbl";
            this.TimeLbl.Size = new System.Drawing.Size(0, 18);
            this.TimeLbl.TabIndex = 23;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Wheat;
            this.btnDelete.Location = new System.Drawing.Point(50, 485);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // RichPizza
            // 
            this.RichPizza.BackColor = System.Drawing.Color.Wheat;
            this.RichPizza.Location = new System.Drawing.Point(166, 204);
            this.RichPizza.Name = "RichPizza";
            this.RichPizza.Size = new System.Drawing.Size(447, 310);
            this.RichPizza.TabIndex = 20;
            this.RichPizza.Text = "";
            this.RichPizza.Visible = false;
            this.RichPizza.TextChanged += new System.EventHandler(this.RichPizza_TextChanged);
            // 
            // ClearBtn
            // 
            this.ClearBtn.BackColor = System.Drawing.Color.Wheat;
            this.ClearBtn.Location = new System.Drawing.Point(50, 456);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(75, 23);
            this.ClearBtn.TabIndex = 21;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.UseVisualStyleBackColor = false;
            this.ClearBtn.Visible = false;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // btn_Buy
            // 
            this.btn_Buy.BackColor = System.Drawing.Color.Wheat;
            this.btn_Buy.Location = new System.Drawing.Point(50, 363);
            this.btn_Buy.Name = "btn_Buy";
            this.btn_Buy.Size = new System.Drawing.Size(75, 23);
            this.btn_Buy.TabIndex = 22;
            this.btn_Buy.Text = "Buy";
            this.btn_Buy.UseVisualStyleBackColor = false;
            this.btn_Buy.Visible = false;
            this.btn_Buy.Click += new System.EventHandler(this.btn_Buy_Click);
            // 
            // Timer
            // 
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(734, 553);
            this.Controls.Add(this.btn_Buy);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.RichPizza);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.grppizzaBox);
            this.Controls.Add(this.lbl_abtus);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btneatingin);
            this.Controls.Add(this.btnabtus);
            this.Controls.Add(this.btnmenu);
            this.Controls.Add(this.content);
            this.Font = new System.Drawing.Font("Rockwell", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "AM Pizzaria";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picvegie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.piccheesemix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.piconions)).EndInit();
            this.grppizzaBox.ResumeLayout(false);
            this.grppizzaBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label content;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnmenu;
        private System.Windows.Forms.Button btnabtus;
        private System.Windows.Forms.Button btneatingin;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.PictureBox picvegie;
        private System.Windows.Forms.PictureBox piccheesemix;
        private System.Windows.Forms.PictureBox piconions;
        private System.Windows.Forms.Button btnvegie;
        private System.Windows.Forms.Button btncheesemix;
        private System.Windows.Forms.Button btnonimato;
        private System.Windows.Forms.Label lbl_abtus;
        private System.Windows.Forms.Button btn_cart;
        private System.Windows.Forms.GroupBox grppizzaBox;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.RichTextBox RichPizza;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Button btn_Buy;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Label TimeLbl;
    }
}

