    using MySql.Data.MySqlClient;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.IO;
    using System.Linq;
    using System.Security.AccessControl;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using TerraVerdeRealEstate.UC__Client_;

    namespace TerraVerdeRealEstate._4_Payment
    {
        public partial class UC_CardPayment : UserControl
        {
            private decimal compute_tax;
            private int id;
            private decimal totalAmountToBePaid, totalAmountPaid, tax, totalPrice, amountPaid, all;
            private int lease, clientId, userId;
            private string rentorsold, propertytranstype, propertyTransactionType;
            
            private void button1_Click(object sender, EventArgs e)
            {
                UC_C_Properties uc = new UC_C_Properties();
                uc.Dock = DockStyle.Fill;
                var panelcontainerParent = this.Parent as Panel;
                var formParent = panelcontainerParent.TopLevelControl as Form;
                ((Panel)formParent.Controls.Find("panelmain_seller", true)[0]).Controls.Clear();
                ((Panel)formParent.Controls.Find("panelmain_seller", true)[0]).Controls.Add(uc);
                uc.BringToFront();
                
            }


        private void UC_CardPayment_Load(object sender, EventArgs e)
        {

        }

        public UC_CardPayment(int prop_id, string status)
        {

                InitializeComponent();
                id = prop_id;
                clientId = Form_ClientSide.clientId;
                
                string connStr = "server=localhost;user=root;password='';database=terraverde_db";

                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    {
                        string query = @"SELECT 
                                p.PROPERTY_ADDRESS, 
                                p.PROPERTY_DESCRIPTION, 
                                p.PROPERTY_IMAGE, 
                                p.PROPERTY_TOTAL_PRICE, 
                                p.PROPERTY_NAME, 
                                t.AMOUNT_PAID,
                                t.TOTAL_AMOUNT_PAID,
                                t.TOTAL_AMOUNT_TO_BE_PAID,
                                t.TAX
                            FROM 
                                property p
                            LEFT JOIN 
                                transaction t ON p.PROPERTY_ID = t.PROPERTY_ID
                            WHERE 
                                p.PROPERTY_ID = @prop_id";

                        using (MySqlCommand command = new MySqlCommand(query, conn))
                        {
                            // Add parameter for prop_id
                            command.Parameters.AddWithValue("@prop_id", prop_id);

                            conn.Open();

                            using (MySqlDataReader reader = command.ExecuteReader())
                            {
                                if (reader.Read()) // Check if there is a row matching the prop_id
                                {
                                    string address = reader["PROPERTY_ADDRESS"].ToString();
                                    string description = reader["PROPERTY_DESCRIPTION"].ToString();
                                    string base64Image = reader["PROPERTY_IMAGE"].ToString();
                                    string property_name = reader["PROPERTY_NAME"].ToString();
                                    totalPrice = Convert.ToDecimal(reader["PROPERTY_TOTAL_PRICE"]);
                                    amountPaid = reader.IsDBNull(reader.GetOrdinal("AMOUNT_PAID")) ? 0m : Convert.ToDecimal(reader["AMOUNT_PAID"]);
                                    totalAmountPaid = reader.IsDBNull(reader.GetOrdinal("TOTAL_AMOUNT_PAID")) ? 0m : Convert.ToDecimal(reader["TOTAL_AMOUNT_PAID"]);
                                    totalAmountToBePaid = reader.IsDBNull(reader.GetOrdinal("TOTAL_AMOUNT_TO_BE_PAID")) ? 0m : Convert.ToDecimal(reader["TOTAL_AMOUNT_TO_BE_PAID"]);
                                    tax = reader.IsDBNull(reader.GetOrdinal("TAX")) ? 0m : Convert.ToDecimal(reader["TAX"]);
                                    label1.Text = "Online Card Payment for " + property_name;


                                    // Use the fetched values as needed
                                    // For example:
                                    // Display the information in your user interface
                                    amt_topropay.Text = "" + totalPrice;


                                    if (status == "Buying property")
                                    {
                                        compute_tax = 0.6m * totalPrice;
                                        rentorsold = "SOLD";
                                        propertytranstype = "SELL";
                                        lease = 0;
                                    }
                                    else
                                    {
                                        rentorsold = "RENTED";
                                        compute_tax = 0.4m * totalPrice;

                                        if (status == "3 Months") {lease = 3;}
                                        else if (status == "6 Months") { lease = 6;}
                                        else if (status == "12 Months") { lease = 12; }
                                        else if (status == "24 Months") { lease = 24; }
                                        propertytranstype = "RENT";
                                    }

                                    all = compute_tax + totalPrice;
                                    totaltopay.Text = "" + all;
                                    lbltax.Text = "" + compute_tax;
                                    lbl_address.Text = address;
                                    lbl_description.Text = description;
                                    byte[] imageBytes = Convert.FromBase64String(base64Image);

                                    // Convert byte array to Image
                                    Image image;
                                    using (MemoryStream ms = new MemoryStream(imageBytes))
                                    {
                                        image = Image.FromStream(ms);
                                    }
                                    pictureBox1.Image = image;

                                    // Set other labels/textboxes accordingly
                                }
                                else
                                {
                                    // Handle case where no row with matching prop_id is found
                                    MessageBox.Show("Property not found.");
                                }
                            }
                        }
                    }
                }
            }
            decimal total;
            decimal lasttotal;
           private void pay_Click(object sender, EventArgs e)
            {
                // Check if card pin or card number is empty
                if (string.IsNullOrEmpty(cardpin.Text) || string.IsNullOrEmpty(cordno.Text))
                {
                    MessageBox.Show("Enter Valid Card Pin or No.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Return from the method if any of the textboxes is empty
                }

                // Check if total amount is empty or not a valid decimal
                if (string.IsNullOrEmpty(mytotal.Text) || !decimal.TryParse(mytotal.Text, out total))
                {
                    MessageBox.Show("Enter a valid total amount.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Return from the method if total amount is not valid
                }

                // Proceed with the payment logic only if all checks pass
                if (total >= all)
                {
                    decimal minustax = total - compute_tax;

                    if (minustax > 0 & total >= totalPrice + compute_tax)
                    {
                        decimal totalamttobepaidd = total - (totalPrice + compute_tax);

                        lasttotal = 0;

                        string connStr = "server=localhost;user=root;password='';database=terraverde_db";
                        using (MySqlConnection conn = new MySqlConnection(connStr))
                        {
                            try
                            {
                                conn.Open();
                                if (totalamttobepaidd < 0) {
                                    totalamttobepaidd = 0;
                                }
                            UpdatePropertyStatus(conn, rentorsold, id, total, total, compute_tax, totalamttobepaidd, propertyTransactionType, clientId, userId, lease);
                            Console.WriteLine("working: ");
                                string propertyName = GetPropertyNameById(conn, id);

                                // Show success message after updating property status
                                MessageBox.Show($"{propertyName} bought successfully", "Purchase Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                UC_C_Properties uc = new UC_C_Properties();
                                uc.Dock = DockStyle.Fill;
                                var panelcontainerParent = this.Parent as Panel;
                                var formParent = panelcontainerParent.TopLevelControl as Form;
                                ((Panel)formParent.Controls.Find("panelmain_seller", true)[0]).Controls.Clear();
                                ((Panel)formParent.Controls.Find("panelmain_seller", true)[0]).Controls.Add(uc);
                                uc.BringToFront();


                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("Error: " + ex.Message);
                                MessageBox.Show("An error occurred during the transaction. Please try again.", "Transaction Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                /*
                   else if (minustax > 0 & total < totalPrice+ compute_tax)
                   {

                       decimal totalamttobepaidd = total - (totalPrice + compute_tax);
                       decimal tot = totalPrice;
                       lasttotal = tot - minustax;

                       string Buy = "SOLD";
                       string connStr = "server=localhost;user=root;password='';database=terraverde_db";
                       using (MySqlConnection conn = new MySqlConnection(connStr))
                       {
                           try
                           {
                               if (totalamttobepaidd < 0)
                               {
                                   totalamttobepaidd = 0;
                               }
                               conn.Open();
                               UpdatePropertyStatus(conn, Buy, id, total, total, compute_tax, totalamttobepaidd);
                               MessageBox.Show("Enter The Proper Amount.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                               Console.WriteLine("working: ");
                           }
                           catch (Exception ex)
                           {
                               Console.WriteLine("Error: " + ex.Message);
                               MessageBox.Show("An error occurred during the transaction. Please try again.", "Transaction Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                           }
                       }
                       */
            }
            else if (total < all) 
                {
                    MessageBox.Show("Enter The Proper Amount.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        static void UpdatePropertyStatus(MySqlConnection connection, string status, int prop_id, decimal totalAmountPaid, decimal amountPaid, decimal tax, decimal totalamountotbepaid, string propertyTransactionType, int clientId, int userId, int lease)
        {
            // Fetch seller ID from the property table
            int sellerId = GetSellerId(connection, prop_id);

            // Fetch property status from the property table
            string propertyStatus = GetPropertyStatus(connection, prop_id);

            propertyTransactionType = propertyStatus == "FOR SALE" ? "SELL" : "RENT";

            // Generate a unique reference number
            string referenceNumber = GenerateUniqueReferenceNumber();
            userId = UC__LogReg_.UC_LR_Login.userID; // Adjust this line as necessary

            // Determine lease term based on property transaction type
            int leaseTerm = lease; // Assuming 1 for RENT, adjust as needed

            string insertQuery = @"INSERT INTO transaction (PROPERTY_ID, TOTAL_AMOUNT_PAID, AMOUNT_PAID, TAX, TOTAL_AMOUNT_TO_BE_PAID, PROPERTY_TRANSACTION_TYPE, METHOD_OF_TRANSACTION, MODE_OF_PAYMENT, REFERENCE_NUMBER, LEASE_TERM, TRANSACTION_DATE, CLIENT_ID, SELLER_ID) 
                          VALUES (@prop_id, @totalAmountPaid, @amountPaid, @tax, @totamountPaid, @propertyTransactionType, 'ONLINE', 'CARD', @referenceNumber, @leaseTerm, @transactionDate, @clientId, @sellerId)";

            using (MySqlCommand insertCommand = new MySqlCommand(insertQuery, connection))
            {
                insertCommand.Parameters.AddWithValue("@prop_id", prop_id);
                insertCommand.Parameters.AddWithValue("@totalAmountPaid", totalAmountPaid);
                insertCommand.Parameters.AddWithValue("@amountPaid", amountPaid);
                insertCommand.Parameters.AddWithValue("@tax", tax);
                insertCommand.Parameters.AddWithValue("@totamountPaid", totalamountotbepaid);
                insertCommand.Parameters.AddWithValue("@propertyTransactionType", propertyTransactionType);
                insertCommand.Parameters.AddWithValue("@referenceNumber", referenceNumber);
                insertCommand.Parameters.AddWithValue("@leaseTerm", leaseTerm);
                insertCommand.Parameters.AddWithValue("@transactionDate", DateTime.Today); 
                insertCommand.Parameters.AddWithValue("@clientId", clientId);
                insertCommand.Parameters.AddWithValue("@sellerId", sellerId);

                insertCommand.ExecuteNonQuery();
            }

            // Update PROPERTY_STATUS in the property table
            string updatePropertyStatusQuery = "UPDATE property SET PROPERTY_STATUS = @status WHERE PROPERTY_ID = @prop_id";

            using (MySqlCommand updatePropertyStatusCommand = new MySqlCommand(updatePropertyStatusQuery, connection))
            {
                updatePropertyStatusCommand.Parameters.AddWithValue("@status", status);
                updatePropertyStatusCommand.Parameters.AddWithValue("@prop_id", prop_id);

                updatePropertyStatusCommand.ExecuteNonQuery();
            }
        }


        static int GetSellerId(MySqlConnection connection, int prop_id)
        {
            int sellerId = 0;
            string query = "SELECT SELLER_ID FROM property WHERE PROPERTY_ID = @prop_id";

            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@prop_id", prop_id);
                try
                {
                    sellerId = (int)command.ExecuteScalar();
                }
                catch (MySqlException ex)
                {
                    // Handle exception
                    Console.WriteLine(ex.Message);
                }
            }

            return sellerId;
        }

        static string GenerateUniqueReferenceNumber()
        {
            Random random = new Random();
            string letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string numbers = "1234567890";
            string referenceNumber = "";

            for (int i = 0; i < 3; i++)
            {
                referenceNumber += letters[random.Next(letters.Length)];
            }

            for (int i = 0; i < 3; i++)
            {
                referenceNumber += numbers[random.Next(numbers.Length)];
            }

            // Ensure uniqueness by checking against existing reference numbers in the database
            // This is a simplified example; you might need a more robust method to ensure uniqueness
            // For example, you could query the database to check if the generated reference number already exists
            // If it does, generate a new one and check again

            return referenceNumber;
        }

        private string GetPropertyNameById(MySqlConnection conn, int propertyId)
        {
            string propertyName = string.Empty;
            string query = "SELECT PROPERTY_NAME FROM Property WHERE PROPERTY_ID = @PropertyId";
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@PropertyId", propertyId);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        propertyName = reader["PROPERTY_NAME"].ToString();
                    }
                }
            }
            return propertyName;
        }

        static string GetPropertyStatus(MySqlConnection connection, int prop_id)
        {
            string propertyStatus = "";
            string query = "SELECT PROPERTY_STATUS FROM property WHERE PROPERTY_ID = @prop_id";

            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@prop_id", prop_id);
                try
                {
                    propertyStatus = (string)command.ExecuteScalar();
                }
                catch (MySqlException ex)
                {
                    // Handle exception
                    Console.WriteLine(ex.Message);
                }
            }

            return propertyStatus;
        }

        private string CheckVerificationStatus(int userId)
        {
            string verificationStatus = "Pending"; // Default status
            string connstr = "server=localhost;user=root;password='';database=terraverde_db";

            using (MySqlConnection connection = new MySqlConnection(connstr))
            {
                string query = "SELECT VERIFICATION_STATUS FROM verification WHERE USER_ID = @UserId";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserId", userId);

                    try
                    {
                        connection.Open();
                        object result = command.ExecuteScalar();

                        if (result != null && result != DBNull.Value)
                        {
                            verificationStatus = result.ToString();
                            Console.WriteLine("Error fetching verification status: " + userId);
                        }
                        connection.Close();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error fetching verification status: " + ex.Message);
                    }
                }
            }

            return verificationStatus;
        }


    }
}


