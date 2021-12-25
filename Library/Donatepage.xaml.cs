using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Library
{
    /// <summary>
    /// Interaction logic for Donatepage.xaml
    /// </summary>
    public partial class Donatepage : Window
    {
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            Application.Current.Shutdown();
        }
        string uberr;
        string bner;
        string pder;
        string aner;
        public Donatepage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (ubna.Text == "")
            {
                bner = "Book name required!";
                bnaer.Content = bner;
            }
            else
            {
                bnaer.Content = "";
            }
            if (updt.Text == "")
            {
                pder = "Published date required!";
                pbter.Content = pder;
            }
            else
            {
                pbter.Content = "";
            }

            if (uaun.Text == "")
            {
                aner = "Author's name required!";
                auner.Content = aner;
            }
            else
            {
                auner.Content = "";
            }
            if (ue.Text == "")
            {
                uberr = "Author's name required!";
                uber.Content = uberr;
            }
            else
            {
                uber.Content = "";
            }
            if (ubna.Text != "" && updt.Text != "" && uaun.Text != "" && ue.Text != "")
            {
                SqlConnection sq = new SqlConnection(@"Data Source=DESKTOP-8A4LKRH\SQLEXPRESS;Initial Catalog=Library;Integrated Security=True");
                {

                    if (combobox2.SelectedItem == Horror)
                    {

                        try
                        {
                            sq.Open();
                            SqlCommand sqlcmp = new SqlCommand("Insert into [book] (Bname,bauthor,bpbdate,bprice,Cid) values ('" + ubna.Text + "', '" + uaun.Text + "','" + updt.Text + "', '" + ue.Text + "', '" + 1 + "') ", sq);
                            MessageBox.Show(sqlcmp.CommandText);
                            sqlcmp.ExecuteNonQuery();
                            MessageBox.Show("Saved");
                        }
                        catch (Exception we)
                        {
                            MessageBox.Show(we.Message);
                        }
                        finally
                        {
                            sq.Close();
                        }
                    }
                    else if (combobox2.SelectedItem == Biography)
                    {

                        try
                        {
                            sq.Open();
                            SqlCommand cvb = new SqlCommand("Insert into [book] (Bname,bauthor,bpbdate,bprice,Cid) values ('" + ubna.Text + "', '" + uaun.Text + "','" + updt.Text + "', '" + ue.Text + "', '" + 2 + "') ", sq);
                            MessageBox.Show(cvb.CommandText);
                            cvb.ExecuteNonQuery();
                            MessageBox.Show("Saved");
                        }
                        catch (Exception wm)
                        {
                            MessageBox.Show(wm.Message);
                        }
                        finally
                        {
                            sq.Close();
                        }

                    }
                    else if (combobox2.SelectedItem == Documentary)
                    {

                        try
                        {
                            sq.Open();
                            SqlCommand pp = new SqlCommand("Insert into [book] (Bname,bauthor,bpbdate,bprice,Cid) values ('" + ubna.Text + "', '" + uaun.Text + "','" + updt.Text + "', '" + ue.Text + "', '" + 3 + "') ", sq);
                            MessageBox.Show(pp.CommandText);
                            pp.ExecuteNonQuery();
                            MessageBox.Show("Saved");
                        }
                        catch (Exception wm)
                        {
                            MessageBox.Show(wm.Message);
                        }
                        finally
                        {
                            sq.Close();
                        }

                    }
                    else if (combobox2.SelectedItem == Thriller)
                    {
                        
                        try
                        {
                            sq.Open();
                            SqlCommand pk = new SqlCommand("Insert into [book] (Bname,bauthor,bpbdate,bprice,Cid) values ('" + ubna.Text + "', '" + uaun.Text + "','" + updt.Text + "', '" + ue.Text + "', '" + 4 + "') ", sq);
                            MessageBox.Show(pk.CommandText);
                            pk.ExecuteNonQuery();
                            MessageBox.Show("Saved");
                        }
                        catch (Exception wm)
                        {
                            MessageBox.Show(wm.Message);
                        }
                        finally
                        {
                            sq.Close();
                        }

                    }
                    else if (combobox2.SelectedItem == Comedy)
                    {
                        
                        try
                        {
                            sq.Open();
                            SqlCommand pj = new SqlCommand("Insert into [book] (Bname,bauthor,bpbdate,bprice,Cid) values ('" + ubna.Text + "', '" + uaun.Text + "','" + updt.Text + "', '" + ue.Text + "', '" + 5 + "') ", sq);
                            MessageBox.Show(pj.CommandText);
                            pj.ExecuteNonQuery();
                            MessageBox.Show("Saved");
                        }
                        catch (Exception wm)
                        {
                            MessageBox.Show(wm.Message);
                        }
                        finally
                        {
                            sq.Close();
                        }

                    }
                    else if (combobox2.SelectedItem == Poem)
                    {
                        
                        try
                        {
                            sq.Open();
                            SqlCommand ii = new SqlCommand("Insert into [book] (Bname,bauthor,bpbdate,bprice,Cid) values ('" + ubna.Text + "', '" + uaun.Text + "','" + updt.Text + "', '" + ue.Text + "', '" + 6 + "') ", sq);
                            MessageBox.Show(ii.CommandText);
                            ii.ExecuteNonQuery();
                            MessageBox.Show("Saved");
                        }
                        catch (Exception wm)
                        {
                            MessageBox.Show(wm.Message);
                        }
                        finally
                        {
                            sq.Close();
                        }

                    }
                    else if (combobox2.SelectedItem == SciFi)
                    {
                        
                        try
                        {
                            sq.Open();
                            SqlCommand vv = new SqlCommand("Insert into [book] (Bname,bauthor,bpbdate,bprice,Cid) values ('" + ubna.Text + "', '" + uaun.Text + "','" + updt.Text + "', '" + ue.Text + "', '" + 7 + "') ", sq);
                            MessageBox.Show(vv.CommandText);
                            vv.ExecuteNonQuery();
                            MessageBox.Show("Saved");
                        }
                        catch (Exception wm)
                        {
                            MessageBox.Show(wm.Message);
                        }
                        finally
                        {
                            sq.Close();
                        }

                    }
                    else if (combobox2.SelectedItem == Mystry)
                    {
                        
                        try
                        {
                            sq.Open();
                            SqlCommand sa = new SqlCommand("Insert into [book] (Bname,bauthor,bpbdate,bprice,Cid) values ('" + ubna.Text + "', '" + uaun.Text + "','" + updt.Text + "', '" + ue.Text + "', '" + 8 + "') ", sq);
                            MessageBox.Show(sa.CommandText);
                            sa.ExecuteNonQuery();
                            MessageBox.Show("Saved");
                        }
                        catch (Exception wm)
                        {
                            MessageBox.Show(wm.Message);
                        }
                        finally
                        {
                            sq.Close();
                        }

                    }

                }
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow Mn = new MainWindow();
            Mn.Show();
            this.Hide();
        }
    }
}
