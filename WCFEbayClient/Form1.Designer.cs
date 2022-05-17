
namespace WCFEbayClient
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
            this.btCarAdd = new System.Windows.Forms.Button();
            this.tbUserAdd = new System.Windows.Forms.Button();
            this.tbBrand = new System.Windows.Forms.TextBox();
            this.tbLicensePlate = new System.Windows.Forms.TextBox();
            this.tbUserId = new System.Windows.Forms.TextBox();
            this.tbUserFirstName = new System.Windows.Forms.TextBox();
            this.lbType = new System.Windows.Forms.Label();
            this.lbBrand = new System.Windows.Forms.Label();
            this.lbLicensePlate = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbUserFirstName = new System.Windows.Forms.Label();
            this.lbCarID = new System.Windows.Forms.Label();
            this.tbCarID = new System.Windows.Forms.TextBox();
            this.btGetCarByID = new System.Windows.Forms.Button();
            this.btDelCarByID = new System.Windows.Forms.Button();
            this.rbCarPetrol = new System.Windows.Forms.RadioButton();
            this.rbCarElectric = new System.Windows.Forms.RadioButton();
            this.lbUserLastName = new System.Windows.Forms.Label();
            this.tbUserLastName = new System.Windows.Forms.TextBox();
            this.btGetUserbyID = new System.Windows.Forms.Button();
            this.btUserDelete = new System.Windows.Forms.Button();
            this.tbShowCarsAll = new System.Windows.Forms.Button();
            this.tbShowAllUsers = new System.Windows.Forms.Button();
            this.dgvForAll = new System.Windows.Forms.DataGridView();
            this.carBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Highest = new System.Windows.Forms.Button();
            this.lbStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvForAll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btCarAdd
            // 
            this.btCarAdd.Location = new System.Drawing.Point(672, 130);
            this.btCarAdd.Name = "btCarAdd";
            this.btCarAdd.Size = new System.Drawing.Size(102, 28);
            this.btCarAdd.TabIndex = 1;
            this.btCarAdd.Text = "Add Car";
            this.btCarAdd.UseVisualStyleBackColor = true;
            this.btCarAdd.Click += new System.EventHandler(this.btCarAdd_Click);
            // 
            // tbUserAdd
            // 
            this.tbUserAdd.Location = new System.Drawing.Point(672, 272);
            this.tbUserAdd.Name = "tbUserAdd";
            this.tbUserAdd.Size = new System.Drawing.Size(102, 26);
            this.tbUserAdd.TabIndex = 2;
            this.tbUserAdd.Text = "Add user";
            this.tbUserAdd.UseVisualStyleBackColor = true;
            this.tbUserAdd.Click += new System.EventHandler(this.tbUserAdd_Click);
            // 
            // tbBrand
            // 
            this.tbBrand.Location = new System.Drawing.Point(556, 92);
            this.tbBrand.Name = "tbBrand";
            this.tbBrand.Size = new System.Drawing.Size(100, 22);
            this.tbBrand.TabIndex = 6;
            // 
            // tbLicensePlate
            // 
            this.tbLicensePlate.Location = new System.Drawing.Point(556, 120);
            this.tbLicensePlate.Name = "tbLicensePlate";
            this.tbLicensePlate.Size = new System.Drawing.Size(100, 22);
            this.tbLicensePlate.TabIndex = 7;
            // 
            // tbUserId
            // 
            this.tbUserId.Location = new System.Drawing.Point(556, 207);
            this.tbUserId.Name = "tbUserId";
            this.tbUserId.Size = new System.Drawing.Size(100, 22);
            this.tbUserId.TabIndex = 8;
            // 
            // tbUserFirstName
            // 
            this.tbUserFirstName.Location = new System.Drawing.Point(556, 235);
            this.tbUserFirstName.Name = "tbUserFirstName";
            this.tbUserFirstName.Size = new System.Drawing.Size(100, 22);
            this.tbUserFirstName.TabIndex = 9;
            // 
            // lbType
            // 
            this.lbType.AutoSize = true;
            this.lbType.Location = new System.Drawing.Point(505, 45);
            this.lbType.Name = "lbType";
            this.lbType.Size = new System.Drawing.Size(40, 17);
            this.lbType.TabIndex = 11;
            this.lbType.Text = "Type";
            // 
            // lbBrand
            // 
            this.lbBrand.AutoSize = true;
            this.lbBrand.Location = new System.Drawing.Point(504, 95);
            this.lbBrand.Name = "lbBrand";
            this.lbBrand.Size = new System.Drawing.Size(46, 17);
            this.lbBrand.TabIndex = 12;
            this.lbBrand.Text = "Brand";
            // 
            // lbLicensePlate
            // 
            this.lbLicensePlate.AutoSize = true;
            this.lbLicensePlate.Location = new System.Drawing.Point(457, 123);
            this.lbLicensePlate.Name = "lbLicensePlate";
            this.lbLicensePlate.Size = new System.Drawing.Size(93, 17);
            this.lbLicensePlate.TabIndex = 13;
            this.lbLicensePlate.Text = "License Plate";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(485, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "User\'s ID";
            // 
            // lbUserFirstName
            // 
            this.lbUserFirstName.AutoSize = true;
            this.lbUserFirstName.Location = new System.Drawing.Point(476, 238);
            this.lbUserFirstName.Name = "lbUserFirstName";
            this.lbUserFirstName.Size = new System.Drawing.Size(74, 17);
            this.lbUserFirstName.TabIndex = 15;
            this.lbUserFirstName.Text = "First name";
            // 
            // lbCarID
            // 
            this.lbCarID.AutoSize = true;
            this.lbCarID.Location = new System.Drawing.Point(493, 17);
            this.lbCarID.Name = "lbCarID";
            this.lbCarID.Size = new System.Drawing.Size(57, 17);
            this.lbCarID.TabIndex = 17;
            this.lbCarID.Text = "Car\'s ID";
            // 
            // tbCarID
            // 
            this.tbCarID.Location = new System.Drawing.Point(556, 14);
            this.tbCarID.Name = "tbCarID";
            this.tbCarID.Size = new System.Drawing.Size(100, 22);
            this.tbCarID.TabIndex = 16;
            this.tbCarID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCarID_KeyPress);
            // 
            // btGetCarByID
            // 
            this.btGetCarByID.Location = new System.Drawing.Point(672, 10);
            this.btGetCarByID.Name = "btGetCarByID";
            this.btGetCarByID.Size = new System.Drawing.Size(102, 30);
            this.btGetCarByID.TabIndex = 18;
            this.btGetCarByID.Text = "Get by ID";
            this.btGetCarByID.UseVisualStyleBackColor = true;
            this.btGetCarByID.Click += new System.EventHandler(this.btGetCarByID_Click);
            // 
            // btDelCarByID
            // 
            this.btDelCarByID.Location = new System.Drawing.Point(672, 79);
            this.btDelCarByID.Name = "btDelCarByID";
            this.btDelCarByID.Size = new System.Drawing.Size(102, 32);
            this.btDelCarByID.TabIndex = 19;
            this.btDelCarByID.Text = "Delete by ID";
            this.btDelCarByID.UseVisualStyleBackColor = true;
            this.btDelCarByID.Click += new System.EventHandler(this.btDelCarByID_Click);
            // 
            // rbCarPetrol
            // 
            this.rbCarPetrol.AutoSize = true;
            this.rbCarPetrol.Location = new System.Drawing.Point(556, 43);
            this.rbCarPetrol.Name = "rbCarPetrol";
            this.rbCarPetrol.Size = new System.Drawing.Size(66, 21);
            this.rbCarPetrol.TabIndex = 20;
            this.rbCarPetrol.TabStop = true;
            this.rbCarPetrol.Text = "Petrol";
            this.rbCarPetrol.UseVisualStyleBackColor = true;
            // 
            // rbCarElectric
            // 
            this.rbCarElectric.AutoSize = true;
            this.rbCarElectric.Location = new System.Drawing.Point(556, 65);
            this.rbCarElectric.Name = "rbCarElectric";
            this.rbCarElectric.Size = new System.Drawing.Size(75, 21);
            this.rbCarElectric.TabIndex = 21;
            this.rbCarElectric.TabStop = true;
            this.rbCarElectric.Text = "Electric";
            this.rbCarElectric.UseVisualStyleBackColor = true;
            // 
            // lbUserLastName
            // 
            this.lbUserLastName.AutoSize = true;
            this.lbUserLastName.Location = new System.Drawing.Point(472, 264);
            this.lbUserLastName.Name = "lbUserLastName";
            this.lbUserLastName.Size = new System.Drawing.Size(74, 17);
            this.lbUserLastName.TabIndex = 22;
            this.lbUserLastName.Text = "Last name";
            // 
            // tbUserLastName
            // 
            this.tbUserLastName.Location = new System.Drawing.Point(556, 264);
            this.tbUserLastName.Name = "tbUserLastName";
            this.tbUserLastName.Size = new System.Drawing.Size(100, 22);
            this.tbUserLastName.TabIndex = 23;
            // 
            // btGetUserbyID
            // 
            this.btGetUserbyID.Location = new System.Drawing.Point(672, 200);
            this.btGetUserbyID.Name = "btGetUserbyID";
            this.btGetUserbyID.Size = new System.Drawing.Size(102, 29);
            this.btGetUserbyID.TabIndex = 24;
            this.btGetUserbyID.Text = "Get by ID";
            this.btGetUserbyID.UseVisualStyleBackColor = true;
            this.btGetUserbyID.Click += new System.EventHandler(this.btGetUserbyID_Click);
            // 
            // btUserDelete
            // 
            this.btUserDelete.Location = new System.Drawing.Point(672, 235);
            this.btUserDelete.Name = "btUserDelete";
            this.btUserDelete.Size = new System.Drawing.Size(102, 31);
            this.btUserDelete.TabIndex = 25;
            this.btUserDelete.Text = "Delete by ID";
            this.btUserDelete.UseVisualStyleBackColor = true;
            this.btUserDelete.Click += new System.EventHandler(this.btUserDelete_Click);
            // 
            // tbShowCarsAll
            // 
            this.tbShowCarsAll.Location = new System.Drawing.Point(475, 362);
            this.tbShowCarsAll.Name = "tbShowCarsAll";
            this.tbShowCarsAll.Size = new System.Drawing.Size(110, 26);
            this.tbShowCarsAll.TabIndex = 27;
            this.tbShowCarsAll.Text = "Show all cars";
            this.tbShowCarsAll.UseVisualStyleBackColor = true;
            this.tbShowCarsAll.Click += new System.EventHandler(this.tbShowCarsAll_Click);
            // 
            // tbShowAllUsers
            // 
            this.tbShowAllUsers.Location = new System.Drawing.Point(662, 362);
            this.tbShowAllUsers.Name = "tbShowAllUsers";
            this.tbShowAllUsers.Size = new System.Drawing.Size(112, 26);
            this.tbShowAllUsers.TabIndex = 28;
            this.tbShowAllUsers.Text = "Show all users";
            this.tbShowAllUsers.UseVisualStyleBackColor = true;
            this.tbShowAllUsers.Click += new System.EventHandler(this.tbShowAllUsers_Click);
            // 
            // dgvForAll
            // 
            this.dgvForAll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvForAll.Location = new System.Drawing.Point(13, 12);
            this.dgvForAll.Name = "dgvForAll";
            this.dgvForAll.RowHeadersWidth = 51;
            this.dgvForAll.RowTemplate.Height = 24;
            this.dgvForAll.Size = new System.Drawing.Size(438, 376);
            this.dgvForAll.TabIndex = 29;
            this.dgvForAll.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvForAll_CellClick);
            // 
            // carBindingSource
            // 
            this.carBindingSource.DataSource = typeof(WCFEbayClient.ServiceReference2.Car);
            // 
            // Highest
            // 
            this.Highest.Location = new System.Drawing.Point(594, 365);
            this.Highest.Name = "Highest";
            this.Highest.Size = new System.Drawing.Size(58, 39);
            this.Highest.TabIndex = 30;
            this.Highest.Text = "High";
            this.Highest.UseVisualStyleBackColor = true;
            this.Highest.Click += new System.EventHandler(this.Highest_Click);
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatus.Location = new System.Drawing.Point(586, 315);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(0, 29);
            this.lbStatus.TabIndex = 31;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 420);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.Highest);
            this.Controls.Add(this.dgvForAll);
            this.Controls.Add(this.tbShowAllUsers);
            this.Controls.Add(this.tbShowCarsAll);
            this.Controls.Add(this.btUserDelete);
            this.Controls.Add(this.btGetUserbyID);
            this.Controls.Add(this.tbUserLastName);
            this.Controls.Add(this.lbUserLastName);
            this.Controls.Add(this.rbCarElectric);
            this.Controls.Add(this.rbCarPetrol);
            this.Controls.Add(this.btDelCarByID);
            this.Controls.Add(this.btGetCarByID);
            this.Controls.Add(this.lbCarID);
            this.Controls.Add(this.tbCarID);
            this.Controls.Add(this.lbUserFirstName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbLicensePlate);
            this.Controls.Add(this.lbBrand);
            this.Controls.Add(this.lbType);
            this.Controls.Add(this.tbUserFirstName);
            this.Controls.Add(this.tbUserId);
            this.Controls.Add(this.tbLicensePlate);
            this.Controls.Add(this.tbBrand);
            this.Controls.Add(this.tbUserAdd);
            this.Controls.Add(this.btCarAdd);
            this.Name = "Form1";
            this.Text = "Home";
            ((System.ComponentModel.ISupportInitialize)(this.dgvForAll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

      }

      #endregion
      private System.Windows.Forms.Button btCarAdd;
      private System.Windows.Forms.Button tbUserAdd;
      private System.Windows.Forms.TextBox tbBrand;
      private System.Windows.Forms.TextBox tbLicensePlate;
      private System.Windows.Forms.TextBox tbUserId;
      private System.Windows.Forms.TextBox tbUserFirstName;
      private System.Windows.Forms.Label lbType;
      private System.Windows.Forms.Label lbBrand;
      private System.Windows.Forms.Label lbLicensePlate;
      private System.Windows.Forms.Label label5;
      private System.Windows.Forms.Label lbUserFirstName;
      private System.Windows.Forms.Label lbCarID;
      private System.Windows.Forms.TextBox tbCarID;
      private System.Windows.Forms.Button btGetCarByID;
      private System.Windows.Forms.Button btDelCarByID;
      private System.Windows.Forms.RadioButton rbCarPetrol;
      private System.Windows.Forms.RadioButton rbCarElectric;
      private System.Windows.Forms.Label lbUserLastName;
      private System.Windows.Forms.TextBox tbUserLastName;
      private System.Windows.Forms.Button btGetUserbyID;
      private System.Windows.Forms.Button btUserDelete;
      private System.Windows.Forms.Button tbShowCarsAll;
      private System.Windows.Forms.BindingSource carBindingSource;
      private System.Windows.Forms.Button tbShowAllUsers;
      private System.Windows.Forms.DataGridView dgvForAll;
      private System.Windows.Forms.Button Highest;
        private System.Windows.Forms.Label lbStatus;
    }
}

