using CyberHW1_5.Database.Entities;
using CyberHW1_5.Extensions;
using CyberHW1_5.MVP.Models;
using CyberHW1_5.MVP.Views;

namespace CyberHW1_5.MVP.Presenters
{
    public class PresenterUserHistory
    {
        ModelUser model = null;
        ViewUserHistory view = null;

        public PresenterUserHistory(ViewUserHistory form)
        {
            model = new ModelUser();
            view = form;
            view.FormLoad += new EventHandler(FormLoad);
            view.Back += new EventHandler(Back);

        }

        private void FormLoad(object? sender, EventArgs e)
        {
            Output();
        }
        private void LoadTableLayout()
        {
            this.view.TableLayoutPanel.Controls.Clear();
            List<(Guid id, string name, double price, DateTime? time)> currentProductHistoryTable = this.model.LoadCategoryInfoToTableLayoutPanel(view.currentUser);
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
        private void Output()
        {
            if (view.currentUser != null)
            {
                view.OutputId = view.currentUser.UserId.ToString();
                view.OutputName = view.currentUser.Name;
                view.OutputPhone = view.currentUser.Phone;
                view.OutputLogin = view.currentUser.Login;
                view.OutputPassword = view.currentUser.Password;
                view.OutputDate = view.currentUser.Date.ToString();
                LoadTableLayout();
            }
            else
            {
                EmptyDataOutput();
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
        private void Back(object? sender, EventArgs e)
        {
            this.view.Close();
        }

    }
}
