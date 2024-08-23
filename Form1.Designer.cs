namespace dz
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.title = new System.Windows.Forms.Label();
            this.buyer = new System.Windows.Forms.Button();
            this.seller = new System.Windows.Forms.Button();
            this.all = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.title_form = new System.Windows.Forms.Label();
            this.main_window = new System.Windows.Forms.GroupBox();
            this.buyer_window = new System.Windows.Forms.GroupBox();
            this.buyer_title = new System.Windows.Forms.Label();
            this.rooms = new System.Windows.Forms.TextBox();
            this.rooms_lbl = new System.Windows.Forms.Label();
            this.area_lbl = new System.Windows.Forms.Label();
            this.area = new System.Windows.Forms.TextBox();
            this.phone_lbl = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.TextBox();
            this.floor_lbl = new System.Windows.Forms.Label();
            this.floor = new System.Windows.Forms.TextBox();
            this.address_lbl = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.TextBox();
            this.search = new System.Windows.Forms.Button();
            this.seller_window = new System.Windows.Forms.GroupBox();
            this.sell = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.addresss = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.floors = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.phones = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.areas = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.roomss = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.backs = new System.Windows.Forms.Button();
            this.all_window = new System.Windows.Forms.GroupBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.all_back = new System.Windows.Forms.Button();
            this.main_window.SuspendLayout();
            this.buyer_window.SuspendLayout();
            this.seller_window.SuspendLayout();
            this.all_window.SuspendLayout();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.title.Location = new System.Drawing.Point(360, 60);
            this.title.Margin = new System.Windows.Forms.Padding(0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(181, 37);
            this.title.TabIndex = 0;
            this.title.Text = "КУПИДОМ.РУ";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buyer
            // 
            this.buyer.BackColor = System.Drawing.Color.DarkGray;
            this.buyer.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buyer.Location = new System.Drawing.Point(310, 210);
            this.buyer.Name = "buyer";
            this.buyer.Size = new System.Drawing.Size(280, 45);
            this.buyer.TabIndex = 1;
            this.buyer.Text = "Я покупатель";
            this.buyer.UseVisualStyleBackColor = false;
            this.buyer.Click += new System.EventHandler(this.buyer_Click);
            // 
            // seller
            // 
            this.seller.BackColor = System.Drawing.Color.DarkGray;
            this.seller.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.seller.Location = new System.Drawing.Point(310, 280);
            this.seller.Name = "seller";
            this.seller.Size = new System.Drawing.Size(280, 45);
            this.seller.TabIndex = 2;
            this.seller.Text = "Я продавец";
            this.seller.UseVisualStyleBackColor = false;
            this.seller.Click += new System.EventHandler(this.seller_Click);
            // 
            // all
            // 
            this.all.BackColor = System.Drawing.Color.DarkGray;
            this.all.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.all.Location = new System.Drawing.Point(310, 365);
            this.all.Name = "all";
            this.all.Size = new System.Drawing.Size(280, 45);
            this.all.TabIndex = 3;
            this.all.Text = "Все квартиры";
            this.all.UseVisualStyleBackColor = false;
            this.all.Click += new System.EventHandler(this.all_Click);
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.DarkGray;
            this.back.Font = new System.Drawing.Font("Impact", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.back.Location = new System.Drawing.Point(17, 34);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(133, 34);
            this.back.TabIndex = 5;
            this.back.Text = "На главную";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // title_form
            // 
            this.title_form.AutoSize = true;
            this.title_form.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.title_form.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.title_form.Location = new System.Drawing.Point(678, 27);
            this.title_form.Margin = new System.Windows.Forms.Padding(0);
            this.title_form.Name = "title_form";
            this.title_form.Size = new System.Drawing.Size(181, 37);
            this.title_form.TabIndex = 4;
            this.title_form.Text = "КУПИДОМ.РУ";
            this.title_form.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // main_window
            // 
            this.main_window.Controls.Add(this.all);
            this.main_window.Controls.Add(this.seller);
            this.main_window.Controls.Add(this.buyer);
            this.main_window.Controls.Add(this.title);
            this.main_window.Location = new System.Drawing.Point(-5, -8);
            this.main_window.Name = "main_window";
            this.main_window.Size = new System.Drawing.Size(868, 563);
            this.main_window.TabIndex = 6;
            this.main_window.TabStop = false;
            this.main_window.Text = "z";
            // 
            // buyer_window
            // 
            this.buyer_window.Controls.Add(this.search);
            this.buyer_window.Controls.Add(this.address_lbl);
            this.buyer_window.Controls.Add(this.address);
            this.buyer_window.Controls.Add(this.floor_lbl);
            this.buyer_window.Controls.Add(this.floor);
            this.buyer_window.Controls.Add(this.phone_lbl);
            this.buyer_window.Controls.Add(this.phone);
            this.buyer_window.Controls.Add(this.area_lbl);
            this.buyer_window.Controls.Add(this.area);
            this.buyer_window.Controls.Add(this.rooms_lbl);
            this.buyer_window.Controls.Add(this.rooms);
            this.buyer_window.Controls.Add(this.buyer_title);
            this.buyer_window.Controls.Add(this.title_form);
            this.buyer_window.Controls.Add(this.back);
            this.buyer_window.Location = new System.Drawing.Point(-5, -17);
            this.buyer_window.Name = "buyer_window";
            this.buyer_window.Size = new System.Drawing.Size(862, 572);
            this.buyer_window.TabIndex = 4;
            this.buyer_window.TabStop = false;
            this.buyer_window.Text = "groupBox1";
            this.buyer_window.Visible = false;
            // 
            // buyer_title
            // 
            this.buyer_title.AutoSize = true;
            this.buyer_title.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buyer_title.ForeColor = System.Drawing.Color.Silver;
            this.buyer_title.Location = new System.Drawing.Point(350, 102);
            this.buyer_title.Margin = new System.Windows.Forms.Padding(0);
            this.buyer_title.Name = "buyer_title";
            this.buyer_title.Size = new System.Drawing.Size(227, 37);
            this.buyer_title.TabIndex = 10;
            this.buyer_title.Text = "Подбор квартир";
            this.buyer_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rooms
            // 
            this.rooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rooms.Location = new System.Drawing.Point(303, 170);
            this.rooms.Name = "rooms";
            this.rooms.Size = new System.Drawing.Size(300, 34);
            this.rooms.TabIndex = 11;
            // 
            // rooms_lbl
            // 
            this.rooms_lbl.AutoSize = true;
            this.rooms_lbl.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rooms_lbl.ForeColor = System.Drawing.Color.Silver;
            this.rooms_lbl.Location = new System.Drawing.Point(151, 175);
            this.rooms_lbl.Margin = new System.Windows.Forms.Padding(0);
            this.rooms_lbl.Name = "rooms_lbl";
            this.rooms_lbl.Size = new System.Drawing.Size(142, 25);
            this.rooms_lbl.TabIndex = 12;
            this.rooms_lbl.Text = "Кол-во комнат:";
            this.rooms_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rooms_lbl.Click += new System.EventHandler(this.rooms_lbl_Click);
            // 
            // area_lbl
            // 
            this.area_lbl.AutoSize = true;
            this.area_lbl.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.area_lbl.ForeColor = System.Drawing.Color.Silver;
            this.area_lbl.Location = new System.Drawing.Point(136, 245);
            this.area_lbl.Margin = new System.Windows.Forms.Padding(0);
            this.area_lbl.Name = "area_lbl";
            this.area_lbl.Size = new System.Drawing.Size(157, 25);
            this.area_lbl.TabIndex = 14;
            this.area_lbl.Text = "Общая площадь:";
            this.area_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // area
            // 
            this.area.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.area.Location = new System.Drawing.Point(303, 240);
            this.area.Name = "area";
            this.area.Size = new System.Drawing.Size(300, 34);
            this.area.TabIndex = 13;
            // 
            // phone_lbl
            // 
            this.phone_lbl.AutoSize = true;
            this.phone_lbl.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phone_lbl.ForeColor = System.Drawing.Color.Silver;
            this.phone_lbl.Location = new System.Drawing.Point(132, 455);
            this.phone_lbl.Margin = new System.Windows.Forms.Padding(0);
            this.phone_lbl.Name = "phone_lbl";
            this.phone_lbl.Size = new System.Drawing.Size(161, 25);
            this.phone_lbl.TabIndex = 16;
            this.phone_lbl.Text = "Номер телефона:";
            this.phone_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.phone_lbl.Click += new System.EventHandler(this.phone_lbl_Click);
            // 
            // phone
            // 
            this.phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phone.Location = new System.Drawing.Point(303, 450);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(300, 34);
            this.phone.TabIndex = 15;
            // 
            // floor_lbl
            // 
            this.floor_lbl.AutoSize = true;
            this.floor_lbl.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.floor_lbl.ForeColor = System.Drawing.Color.Silver;
            this.floor_lbl.Location = new System.Drawing.Point(239, 309);
            this.floor_lbl.Margin = new System.Windows.Forms.Padding(0);
            this.floor_lbl.Name = "floor_lbl";
            this.floor_lbl.Size = new System.Drawing.Size(61, 25);
            this.floor_lbl.TabIndex = 18;
            this.floor_lbl.Text = "Этаж:";
            this.floor_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // floor
            // 
            this.floor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.floor.Location = new System.Drawing.Point(303, 307);
            this.floor.Name = "floor";
            this.floor.Size = new System.Drawing.Size(300, 34);
            this.floor.TabIndex = 17;
            // 
            // address_lbl
            // 
            this.address_lbl.AutoSize = true;
            this.address_lbl.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.address_lbl.ForeColor = System.Drawing.Color.Silver;
            this.address_lbl.Location = new System.Drawing.Point(232, 381);
            this.address_lbl.Margin = new System.Windows.Forms.Padding(0);
            this.address_lbl.Name = "address_lbl";
            this.address_lbl.Size = new System.Drawing.Size(68, 25);
            this.address_lbl.TabIndex = 20;
            this.address_lbl.Text = "Адрес:";
            this.address_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // address
            // 
            this.address.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.address.Location = new System.Drawing.Point(303, 376);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(300, 34);
            this.address.TabIndex = 19;
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.Color.DarkGray;
            this.search.Font = new System.Drawing.Font("Impact", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.search.Location = new System.Drawing.Point(388, 502);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(150, 45);
            this.search.TabIndex = 21;
            this.search.Text = "Поиск";
            this.search.UseVisualStyleBackColor = false;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // seller_window
            // 
            this.seller_window.Controls.Add(this.sell);
            this.seller_window.Controls.Add(this.label1);
            this.seller_window.Controls.Add(this.addresss);
            this.seller_window.Controls.Add(this.label2);
            this.seller_window.Controls.Add(this.floors);
            this.seller_window.Controls.Add(this.label3);
            this.seller_window.Controls.Add(this.phones);
            this.seller_window.Controls.Add(this.label4);
            this.seller_window.Controls.Add(this.areas);
            this.seller_window.Controls.Add(this.label5);
            this.seller_window.Controls.Add(this.roomss);
            this.seller_window.Controls.Add(this.label6);
            this.seller_window.Controls.Add(this.label7);
            this.seller_window.Controls.Add(this.backs);
            this.seller_window.Location = new System.Drawing.Point(-5, -17);
            this.seller_window.Name = "seller_window";
            this.seller_window.Size = new System.Drawing.Size(867, 589);
            this.seller_window.TabIndex = 22;
            this.seller_window.TabStop = false;
            this.seller_window.Text = "groupBox1";
            this.seller_window.Visible = false;
            // 
            // sell
            // 
            this.sell.BackColor = System.Drawing.Color.DarkGray;
            this.sell.Font = new System.Drawing.Font("Impact", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sell.Location = new System.Drawing.Point(388, 502);
            this.sell.Name = "sell";
            this.sell.Size = new System.Drawing.Size(150, 45);
            this.sell.TabIndex = 21;
            this.sell.Text = "Продать";
            this.sell.UseVisualStyleBackColor = false;
            this.sell.Click += new System.EventHandler(this.sell_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(232, 381);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 20;
            this.label1.Text = "Адрес:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addresss
            // 
            this.addresss.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addresss.Location = new System.Drawing.Point(303, 376);
            this.addresss.Name = "addresss";
            this.addresss.Size = new System.Drawing.Size(300, 34);
            this.addresss.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(239, 309);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 25);
            this.label2.TabIndex = 18;
            this.label2.Text = "Этаж:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // floors
            // 
            this.floors.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.floors.Location = new System.Drawing.Point(303, 307);
            this.floors.Name = "floors";
            this.floors.Size = new System.Drawing.Size(300, 34);
            this.floors.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(132, 455);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "Номер телефона:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // phones
            // 
            this.phones.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phones.Location = new System.Drawing.Point(303, 450);
            this.phones.Name = "phones";
            this.phones.Size = new System.Drawing.Size(300, 34);
            this.phones.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(136, 245);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "Общая площадь:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // areas
            // 
            this.areas.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.areas.Location = new System.Drawing.Point(303, 240);
            this.areas.Name = "areas";
            this.areas.Size = new System.Drawing.Size(300, 34);
            this.areas.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Silver;
            this.label5.Location = new System.Drawing.Point(151, 175);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "Кол-во комнат:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // roomss
            // 
            this.roomss.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.roomss.Location = new System.Drawing.Point(303, 170);
            this.roomss.Name = "roomss";
            this.roomss.Size = new System.Drawing.Size(300, 34);
            this.roomss.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.Silver;
            this.label6.Location = new System.Drawing.Point(318, 102);
            this.label6.Margin = new System.Windows.Forms.Padding(0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(272, 37);
            this.label6.TabIndex = 10;
            this.label6.Text = "Продажа квартиры";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(678, 27);
            this.label7.Margin = new System.Windows.Forms.Padding(0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(181, 37);
            this.label7.TabIndex = 4;
            this.label7.Text = "КУПИДОМ.РУ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // backs
            // 
            this.backs.BackColor = System.Drawing.Color.DarkGray;
            this.backs.Font = new System.Drawing.Font("Impact", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backs.Location = new System.Drawing.Point(17, 34);
            this.backs.Name = "backs";
            this.backs.Size = new System.Drawing.Size(133, 34);
            this.backs.TabIndex = 5;
            this.backs.Text = "На главную";
            this.backs.UseVisualStyleBackColor = false;
            this.backs.Click += new System.EventHandler(this.backs_Click_1);
            // 
            // all_window
            // 
            this.all_window.Controls.Add(this.all_back);
            this.all_window.Controls.Add(this.webBrowser1);
            this.all_window.Location = new System.Drawing.Point(-15, -17);
            this.all_window.Name = "all_window";
            this.all_window.Size = new System.Drawing.Size(889, 639);
            this.all_window.TabIndex = 7;
            this.all_window.TabStop = false;
            this.all_window.Text = "z";
            this.all_window.Visible = false;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(3, 18);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(887, 559);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.Url = new System.Uri("http://localhost/dz.php?&all=Продать", System.UriKind.Absolute);
            // 
            // all_back
            // 
            this.all_back.BackColor = System.Drawing.Color.DarkGray;
            this.all_back.Font = new System.Drawing.Font("Impact", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.all_back.Location = new System.Drawing.Point(27, 27);
            this.all_back.Name = "all_back";
            this.all_back.Size = new System.Drawing.Size(133, 34);
            this.all_back.TabIndex = 6;
            this.all_back.Text = "На главную";
            this.all_back.UseVisualStyleBackColor = false;
            this.all_back.Click += new System.EventHandler(this.all_back_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(855, 553);
            this.Controls.Add(this.all_window);
            this.Controls.Add(this.main_window);
            this.Controls.Add(this.seller_window);
            this.Controls.Add(this.buyer_window);
            this.Name = "Main";
            this.Text = "Form1";
            this.main_window.ResumeLayout(false);
            this.main_window.PerformLayout();
            this.buyer_window.ResumeLayout(false);
            this.buyer_window.PerformLayout();
            this.seller_window.ResumeLayout(false);
            this.seller_window.PerformLayout();
            this.all_window.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button buyer;
        private System.Windows.Forms.Button seller;
        private System.Windows.Forms.Button all;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Label title_form;
        private System.Windows.Forms.GroupBox main_window;
        private System.Windows.Forms.GroupBox buyer_window;
        private System.Windows.Forms.Label buyer_title;
        private System.Windows.Forms.Label rooms_lbl;
        private System.Windows.Forms.TextBox rooms;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Label address_lbl;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.Label floor_lbl;
        private System.Windows.Forms.TextBox floor;
        private System.Windows.Forms.Label phone_lbl;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.Label area_lbl;
        private System.Windows.Forms.TextBox area;
        private System.Windows.Forms.GroupBox seller_window;
        private System.Windows.Forms.Button sell;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox addresss;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox floors;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox phones;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox areas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox roomss;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button backs;
        private System.Windows.Forms.GroupBox all_window;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button all_back;
    }
}

