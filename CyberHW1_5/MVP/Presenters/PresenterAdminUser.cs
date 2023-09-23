using ShopMVP.Database.Entities;
using ShopMVP.Extensions;
using ShopMVP.MVP.Models;
using ShopMVP.MVP.Views;

namespace ShopMVP.MVP.Presenters
{
    public class PresenterAdminUser
    {
        ModelUser model = null;
        ViewAdminUser view = null;
        User currentUser;

        public PresenterAdminUser(ViewAdminUser form)
        {
            model = new ModelUser();
            view = form;
            view.FormLoad += new EventHandler(FormLoad);

            view.SwapRight += new EventHandler(SwapRight);
            view.SwapLeft += new EventHandler(SwapLeft);

            view.AddUser += new EventHandler(Add);
            view.UpdateUser += new EventHandler(Update);
            view.DeleteUser += new EventHandler(Delete);
            view.Back += new EventHandler(Back);

        }

        private void Back(object? sender, EventArgs e)
        {
            ViewAdminMenu back = new ViewAdminMenu();
            back.Show();
            this.view.Hide();
        }

        private void Output()
        {
            if (currentUser != null)
            {
                view.OutputId = currentUser.UserId.ToString();
                view.OutputName = currentUser.Name;
                view.OutputPhone = currentUser.Phone;
                view.OutputLogin = currentUser.Login;
                view.OutputPassword = currentUser.Password;
                view.OutputDate = currentUser.Date.ToString();
                LoadTableLayout(); 
            }
            else
            {
                EmptyDataOutput();
            }
        }

        private void LoadTableLayout()
        {
            this.view.TableLayoutPanel.Controls.Clear();
            List<(Guid id, string name, double price, DateTime? time)> currentProductHistoryTable = this.model.LoadCategoryInfoToTableLayoutPanel(currentUser);
            Label labelNumber = new Label();
            labelNumber.Text = "N";
            this.view.TableLayoutPanel.Controls.Add(labelNumber, 0, 0);

            Label labelId = new Label();
            labelId.Text = "id";
            this.view.TableLayoutPanel.Controls.Add(labelId, 1, 0);

            Label labelName = new Label();
            labelName.Text = "Name";
            this.view.TableLayoutPanel.Controls.Add(labelName, 2, 0);

            Label labelProductId = new Label();
            labelProductId.Text = "Price";
            this.view.TableLayoutPanel.Controls.Add(labelProductId, 3, 0);


            Label labelCartDateTime = new Label();
            labelCartDateTime.Text = "Time";
            this.view.TableLayoutPanel.Controls.Add(labelCartDateTime, 4, 0);

            for (int i = 0; i < currentProductHistoryTable.Count; i++)
            {
                int rowIndex = this.view.TableLayoutPanel.RowCount++;
                Label labelNumberValue = new Label();
                labelNumberValue.Text = (i + 1).ToString();
                this.view.TableLayoutPanel.Controls.Add(labelNumberValue, 0, i + 1);

                Label labelIdValue = new Label();
                labelIdValue.Text = currentProductHistoryTable[i].id.ToString();
                this.view.TableLayoutPanel.Controls.Add(labelIdValue, 1, i + 1);

                Label labelNameValue = new Label();
                labelNameValue.Text = currentProductHistoryTable[i].name;
                this.view.TableLayoutPanel.Controls.Add(labelNameValue, 2, i + 1);

                Label labelProductIdValue = new Label();
                labelProductIdValue.Text = currentProductHistoryTable[i].price.ToString();
                this.view.TableLayoutPanel.Controls.Add(labelProductIdValue, 3, i + 1);

                Label labelCartDateTimeValue = new Label();
                labelCartDateTimeValue.Text = currentProductHistoryTable[i].time.ToString();
                this.view.TableLayoutPanel.Controls.Add(labelCartDateTimeValue, 4, i + 1);
            }
        }

        private void EmptyDataOutput()
        {
            view.OutputId = "No Data";
            view.OutputName = "No Data";
            view.OutputLogin = "No Data";
            view.OutputPassword = "No Data";
            view.OutputPhone = "No Data";
            view.OutputDate = "No Data";
        }
        private void UpdateNumberLabel()
        {
            if (!model.IsUserDataEmpty() && currentUser != null)
            {
                view.LabelNumber.LabelNumberUpdate(currentUser.Number + 1, model.GetLastUserNumber());
            }
            else
            {
                view.LabelNumber.LabelNumberUpdate(0, model.GetLastUserNumber());
            }
        }

        private void Add(object? sender, EventArgs e)
        {
            ViewAdminUserAdd addUser = new ViewAdminUserAdd();
            addUser.ShowDialog();
            currentUser = model.LoadLastUser();
            UpdateNumberLabel();
            Output();

        }
        private void Delete(object? sender, EventArgs e)
        {
            if (!model.IsUserDataEmpty())
            {
                long currentNumber = currentUser.Number;
                model.DeleteUser(currentUser);

                if (!model.IsUserDataEmpty())
                {
                    currentUser = model.LoadUser(currentNumber);
                    Output();
                }
                else
                {
                    EmptyDataOutput();
                }

                UpdateNumberLabel();
            }
            else
            {
                MessageBox.Show("Firstly add at least 1 user");
            }
        }
        private void Update(object? sender, EventArgs e)
        {
            if (!model.IsUserDataEmpty())
            {
                ViewAdminUserUpdate updateUser = new ViewAdminUserUpdate(currentUser);
                updateUser.ShowDialog();
                currentUser = model.LoadUser(currentUser.Number);
                Output();
            }
            else
            {
                MessageBox.Show("Firstly add at least 1 User");
            }
        }

        private void SwapLeft(object? sender, EventArgs e)
        {
            if (!model.IsUserDataEmpty())
            {
                if (currentUser.Number == 0)
                {
                    currentUser = model.LoadLastUser();
                }
                else currentUser = model.LoadUser(currentUser.Number - 1);

                Output();
                UpdateNumberLabel();
            }
            else
            {
                MessageBox.Show("Firstly add at least 1 user");
            }
        }
        private void SwapRight(object? sender, EventArgs e)
        {
            if (!model.IsUserDataEmpty())
            {
                currentUser = model.LoadUser(currentUser.Number + 1);

                Output();
                UpdateNumberLabel();
            }
            else
            {
                MessageBox.Show("Firstly add at least 1 user");
            }
        }

        private void FormLoad(object? sender, EventArgs e)
        {
            if (!model.IsUserDataEmpty())
            {
                currentUser = model.LoadUser(0);

                UpdateNumberLabel();
                Output();
            }
            else
            {
                EmptyDataOutput();
            }
        }
    }
}
