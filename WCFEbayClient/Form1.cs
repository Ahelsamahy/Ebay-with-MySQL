using System;
using System.ServiceModel;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using WCFEbayClient.ServiceReference2;

namespace WCFEbayClient
{
    public partial class Form1 : Form
    {

        Service1Client client = new ServiceReference2.Service1Client();
        List<string> maxCarId = new List<string>();
        List<string> maxUserId = new List<string>();
        //find a way to get all the cars in a list here so you know the highest id and start from it 
        public Form1()
        {
            startCondition();
            MaxID();

            dgvForAll.AllowUserToAddRows = false;
        }

        public void MaxID()
        {
            //get all cars id
            // to use it for checking if the user will want to edit the user after he retrieve it by the id ex.
            // imagine that the user retrieved a user by id and wnated to change something in it, if the user
            // changed and added, i woud have duplication of carID in the database that would case problem
            // when trying to get user by id later as there are two with same id, this one will check first if the
            // id exists when adding a user if yes then will ask user if they want to change, if yes then will continue,
            // if not then will delete the data in the text boxes

            List<Car> CarResult; //can be made as global variable for adding and save memory
            CarResult = client.allCars().ToList<Car>();
            foreach (Car item in CarResult)
            {
                maxCarId.Add(item.CarID.ToString());
            };

            //same for users

            List<users> userResult;
            userResult = client.allUsers().ToList<users>();
            foreach (users item in userResult)
            {
                maxUserId.Add(item.UserID.ToString());
            };
        }
        public void startCondition()
        {
            InitializeComponent();
            tbCarID.Focus();
        }


        void intializeDgvForCars()
        {
            //Car's ID,Type , Brand, License Plate
            //change the selection row width and visibility
            dgvForAll.RowHeadersWidth = 24;
            dgvForAll.AutoGenerateColumns = false;

            dgvForAll.Columns.Add("Car's ID", "Car's ID");
            dgvForAll.Columns[0].Visible = false;
            dgvForAll.Columns.Add("Type", "Type");
            dgvForAll.Columns["Type"].Width = 100;
            dgvForAll.Columns.Add("Brand", "Brand");
            dgvForAll.Columns["Brand"].Width = 100;
            dgvForAll.Columns.Add("License Plate", "License Plate");
            dgvForAll.Columns["License Plate"].Width = 100;
            dgvForAll.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }
        void intializeDgvForUsers()
        {
            //User's ID, First name , Last name
            //change the selection row width and visibility
            //dgvCompany.RowHeadersVisible = false;
            dgvForAll.RowHeadersWidth = 24;
            dgvForAll.AutoGenerateColumns = false;

            dgvForAll.Columns.Add("User's ID", "User's ID");
            dgvForAll.Columns[0].Visible = false;
            dgvForAll.Columns["User's ID"].Width = 100;
            dgvForAll.Columns.Add("First name", "First name");
            dgvForAll.Columns["First name"].Width = 150;
            dgvForAll.Columns.Add("Last name", "Last name");
            dgvForAll.Columns["Last name"].Width = 150;
            dgvForAll.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }


        private void tbUserAdd_Click(object sender, EventArgs e)
        {
            try
            {
                //for first name
                if (tbUserFirstName.TextLength < 3)
                {
                    MessageBox.Show("First name can't be less than 3 character");
                    tbUserFirstName.Text = "";
                }
                else if (string.IsNullOrEmpty(tbUserFirstName.Text))
                {
                    MessageBox.Show("First name can't be empty");
                    tbUserFirstName.Text = "";
                }
                //for second name
                else if (tbUserLastName.TextLength < 3)
                {
                    MessageBox.Show("Second name can't be less than 3 character");
                    tbUserLastName.Text = "";
                }
                else if (string.IsNullOrEmpty(tbUserLastName.Text))
                {
                    MessageBox.Show("Second name can't be empty");
                    tbUserLastName.Text = "";
                }
                //for id
                else if (int.Parse(tbUserId.Text) < 0)
                {
                    MessageBox.Show("User's ID can't be negative number");
                    tbUserId.Text = "";
                }


                //this if to make sure that the user will be added only if all the info is there


                if (maxUserId.Contains(tbUserId.Text))
                {
                    DialogResult dialogResult = MessageBox.Show("there is already a user with this Id.\n> if you press YES then it will modify the one that already exists. \n> if you press NO then it will remove the data from input element.", "Data duplication", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        //first will have to delete the user
                        client.DeleteUsers(int.Parse(tbUserId.Text));
                        //then it will add later in the normal code
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        tbUserId.Text = "";
                        tbUserFirstName.Text = "";
                        tbUserLastName.Text = "";

                    }
                }
                else if (tbUserFirstName.Text == "" || tbUserLastName.Text == "")
                {
                    MessageBox.Show("please fill all the info again with right value this time");
                }

                int MaxNum = int.Parse(maxUserId.Last());
                MaxNum++;
                if (int.Parse(tbUserId.Text) != MaxNum)
                {
                    MessageBox.Show(string.Format("The number you have entered is {0} that isn't the next user ID, so it will be replaced with {1} that is next ID", tbUserId.Text, MaxNum));
                    tbUserId.Text = MaxNum.ToString();
                }
                users normaluser = new users();

                normaluser.FirstName = tbUserFirstName.Text;
                normaluser.SecondName = tbUserLastName.Text;
                normaluser.UserID = int.Parse(tbUserId.Text);

                client.SaveUsers(normaluser);


                //to make sure there won't be duplication of ID problem if the user added the same client, so it will incrememnt the ID for them
                int tempNum = int.Parse(tbUserId.Text);
                tempNum++;
                tbUserId.Text = tempNum.ToString();


                lbStatus.Text = "Added user";
                tbShowAllUsers_Click(this, null);
            }
            catch (FaultException<ServiceData> Fex)
            {
                MessageBox.Show("ErrorDetails::" + Environment.NewLine + Fex.Detail.ErrorDetails, "input Error");
            }
            catch (EndpointNotFoundException)
            {
                MessageBox.Show("Problem with the server!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "System Error");
            }
        }

        private void btCarAdd_Click(object sender, EventArgs e)
        {
            MaxID();//to refresh the maximum number 
            try
            {
                //for code
                if (tbBrand.TextLength < 3)
                {
                    MessageBox.Show("Brand can't be less than 3 character");
                    tbBrand.Text = "";
                }
                else if (string.IsNullOrEmpty(tbBrand.Text))
                {
                    MessageBox.Show("Brand can't be empty");
                    tbBrand.Text = "";
                }
                //for price
                else if (int.Parse(tbLicensePlate.Text) < 0)
                {
                    MessageBox.Show("License Plate can't be negative number");
                    tbLicensePlate.Text = "";
                }


                Car normalCar = new Car();
                //cheap way to make sure that the user will enter all data for car

                if (maxCarId.Contains(tbCarID.Text))
                {
                    DialogResult dialogResult = MessageBox.Show("there is already a car with this Id.\n> if you press YES then it will modify the one that already exists. \n> if you press NO then it will remove the data from input element.", "Data duplication", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        //first will have to delete the car
                        client.DeleteCars(int.Parse(tbCarID.Text));
                        //then it will add later in the normal code
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        tbBrand.Text = "";
                        tbLicensePlate.Text = "";
                        if (rbCarElectric.Checked)
                        {
                            rbCarElectric.Checked = false;
                        }
                        else
                        {
                            rbCarPetrol.Checked = false;
                        }
                        tbCarID.Text = "";

                    }
                }
                else if (tbBrand.Text == "" || tbLicensePlate.Text == "")
                {
                    MessageBox.Show("please fill all the info again with right value this time");
                }

                //make sure the user will enter car id incremented to one in the DB, so the car's id won't have gap in numbers 
                int MaxNum = int.Parse(maxCarId.Last());
                MaxNum++;
                if (int.Parse(tbCarID.Text) != MaxNum)
                {
                    MessageBox.Show(string.Format("The number you have entered is {0} that isn't the next car ID, so it will be replaced with {1} that is next ID", tbCarID.Text, MaxNum));
                    tbCarID.Text = MaxNum.ToString();
                }


                normalCar.Brand = tbBrand.Text;
                normalCar.License_plate = tbLicensePlate.Text;
                normalCar.Type = rbCarElectric.Checked == true ? "Electric" : "Petrol";
                normalCar.CarID = int.Parse(tbCarID.Text);

                client.SaveCars(normalCar);

                //to make sure there won't be duplication of ID problem if the user added the same client, so it will incrememnt the ID for them
                int tempNum = int.Parse(tbCarID.Text);
                tempNum++;
                tbCarID.Text = tempNum.ToString();

                lbStatus.Text = "Added car";
                tbShowCarsAll_Click(this, null);

            }
            catch (FaultException<ServiceData> Fex)
            {
                MessageBox.Show("ErrorMessage::" + Fex.Detail.ErrorMessage + Environment.NewLine);
                MessageBox.Show("ErrorDetails::" + Environment.NewLine + Fex.Detail.ErrorDetails, "input Error");
            }
            catch (EndpointNotFoundException)
            {
                MessageBox.Show("Problem with the server!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "System Error");
            }

        }

        private void btGetCarByID_Click(object sender, EventArgs e)
        {
            try
            {
                Car normalCar = client.GetCars(int.Parse(tbCarID.Text));
                //cheap way to check if there is a car or not
                if (normalCar.Brand == null)
                {
                    MessageBox.Show("there isn't car with this id, please try with another one", "input Error");
                    tbCarID.Text = "";
                }
                else
                {
                    tbBrand.Text = normalCar.Brand;
                    tbLicensePlate.Text = normalCar.License_plate;
                    if (normalCar.Type == "Electric")
                    {
                        rbCarElectric.Checked = true;
                    }
                    else
                    {
                        rbCarPetrol.Checked = true;
                    }
                }
            }
            #region normal Exceptions
            catch (FaultException<ServiceData> Fex)
            {
                MessageBox.Show("ErrorMessage::" + Fex.Detail.ErrorMessage + Environment.NewLine, "input Error");
                MessageBox.Show("ErrorDetails::" + Environment.NewLine + Fex.Detail.ErrorDetails, "input Error");
            }
            catch (EndpointNotFoundException)
            {
                MessageBox.Show("Problem with the server!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "System Error");
            }
            #endregion
        }

        private void btDelCarByID_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(tbCarID.Text) < 0)
                {
                    MessageBox.Show("the ID can't be less than zero, try again with differnet number");

                }
                else
                {
                    if (maxCarId.Contains(tbCarID.Text))
                    {
                        client.DeleteCars(int.Parse(tbCarID.Text));
                        MessageBox.Show("Car is removed");
                    }
                    else
                    {
                        MessageBox.Show(string.Format("there isn't car with this ID because the highest one is {0}, will change the one you entered with it.", maxCarId.Last()), "Highest ID");
                        tbCarID.Text = maxCarId.Last();
                    }
                }

            }
            #region normal Exceptions
            catch (FaultException<ServiceData> Fex)
            {
                MessageBox.Show("ErrorMessage::" + Fex.Detail.ErrorMessage + Environment.NewLine, "input Error");
                MessageBox.Show("ErrorDetails::" + Environment.NewLine + Fex.Detail.ErrorDetails, "input Error");
            }
            catch (EndpointNotFoundException)
            {
                MessageBox.Show("Problem with the server!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "System Error");
            }
            #endregion
        }

        private void btGetUserbyID_Click(object sender, EventArgs e)
        {
            try
            {
                users normalUser = client.GetUsers(int.Parse(tbUserId.Text));
                //cheap way to check if there is a user or not
                if (normalUser.FirstName == null)
                {
                    MessageBox.Show("there isn't user with this id, please try with another one", "input Error");
                    tbUserId.Text = "";
                }
                else
                {
                    tbUserFirstName.Text = normalUser.FirstName;
                    tbUserLastName.Text = normalUser.SecondName;
                }
            }
            #region normal Exceptions
            catch (FaultException<ServiceData> Fex)
            {
                MessageBox.Show("ErrorMessage::" + Fex.Detail.ErrorMessage + Environment.NewLine, "input Error");
                MessageBox.Show("ErrorDetails::" + Environment.NewLine + Fex.Detail.ErrorDetails, "input Error");
            }
            catch (EndpointNotFoundException)
            {
                MessageBox.Show("Problem with the server!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "System Error");
            }
            #endregion
        }

        private void btUserDelete_Click(object sender, EventArgs e)
        {
            try
            {

                if (int.Parse(tbUserId.Text) < 0)
                {
                    MessageBox.Show("the ID can't be less than zero, try again with differnet number");

                }
                client.DeleteUsers(int.Parse(tbUserId.Text));
                MessageBox.Show("User is removed");

                //for developing only
                int tempNum = int.Parse(tbUserId.Text);
                tempNum--;
                tbUserId.Text = tempNum.ToString();
            }
            #region normal Exceptions
            catch (FaultException<ServiceData> Fex)
            {
                MessageBox.Show("ErrorMessage::" + Fex.Detail.ErrorMessage + Environment.NewLine, "input Error");
                MessageBox.Show("ErrorDetails::" + Environment.NewLine + Fex.Detail.ErrorDetails, "input Error");
            }
            catch (EndpointNotFoundException)
            {
                MessageBox.Show("Problem with the server!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "System Error");
            }
            #endregion
        }

        //make sure input will be digits only
        private void tbCarID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void tbShowCarsAll_Click(object sender, EventArgs e)
        {
            // the order: id, type, brand, license plate
            dgvForAll.Columns.Clear();
            intializeDgvForCars();
            List<Car> result;
            result = client.allCars().ToList<Car>();
            dgvForAll.Rows.Clear();
            foreach (Car item in result)
            {
                string[] row = new string[]
                {
               item.CarID.ToString(),
               item.Type,
               item.Brand,
               item.License_plate,

             };
                dgvForAll.Rows.Add(row);
            }

        }

        //to show the cars and users in their tb
        private void dgvForAll_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //to make sure that the dgv is showing data for car then it show it in the tb of cars
            if (dgvForAll.Columns[0].Name == "Car's ID")
            {
                int selectedrowindex = dgvForAll.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvForAll.Rows[selectedrowindex];
                tbCarID.Text = Convert.ToString(selectedRow.Cells["Car's ID"].Value);
                //tbCarID.Enabled = false;
                if (Convert.ToString(selectedRow.Cells["Type"].Value) == "Electric")
                { rbCarElectric.Checked = true; }
                else
                { rbCarPetrol.Checked = true; }
                tbBrand.Text = Convert.ToString(selectedRow.Cells["Brand"].Value);
                tbLicensePlate.Text = Convert.ToString(selectedRow.Cells["License Plate"].Value);
            }


            //for user's side

            else if (dgvForAll.Columns[0].Name == "User's ID")
            {
                int selectedrowindex = dgvForAll.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvForAll.Rows[selectedrowindex];
                tbUserId.Text = Convert.ToString(selectedRow.Cells["User's ID"].Value);
                //tbUserId.Enabled = false;

                tbUserFirstName.Text = Convert.ToString(selectedRow.Cells["First name"].Value);
                tbUserLastName.Text = Convert.ToString(selectedRow.Cells["Last name"].Value);
            }
        }

        private void tbShowAllUsers_Click(object sender, EventArgs e)
        {
            // the order: id, type, brand, license plate
            dgvForAll.Columns.Clear();
            intializeDgvForUsers();
            List<users> result;
            result = client.allUsers().ToList<users>();
            dgvForAll.Rows.Clear();
            foreach (users item in result)
            {
                string[] row = new string[]
                {
               item.UserID.ToString(),
               item.FirstName,
               item.SecondName,

             };
                dgvForAll.Rows.Add(row);
            }
        }

        private void Highest_Click(object sender, EventArgs e)
        {

            List<Car> result;
            result = client.allCars().ToList<Car>();
            foreach (Car item in result)
            {
                maxCarId.Add(item.CarID.ToString());
            };
            MessageBox.Show(string.Format("{0} is the last ID in the Users\n", maxUserId.Last())
                          + string.Format("{0} is the last ID in the Cars", maxCarId.Last()), "Highest ID");

        }

    }
}
