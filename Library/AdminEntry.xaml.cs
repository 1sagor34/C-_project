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
    /// Interaction logic for AdminEntry.xaml
    /// </summary>
    public partial class AdminEntry : Window
    {
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            Application.Current.Shutdown();
        }
        string bnerr;
        string pderr;
        string anerr;
        string ubper;
        public AdminEntry()
        {
            InitializeComponent();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (Bn.Text == "")
            {
                bnerr = "Book name required!";
                Bnerr.Content = bnerr;
            }
            else
            {
                Bnerr.Content = "";
            }

            if (Pd.Text == "")
            {
                pderr = "Published date required!";
                Pderr.Content = pderr;
            }
            else
            {
                Pderr.Content = "";
            }

            if (An.Text == "")
            {
                anerr = "Author's name required!";
                Anerr.Content = anerr;
            }
            else
            {
                Anerr.Content = "";
            }
            if (ubp.Text == "")
            {
                ubper = "Book's price required!";
                ubperr.Content = ubper;
            }
            else
            {
                ubperr.Content = "";
            }


            if (Bn.Text != "" && Pd.Text != "" && An.Text != "" && ubp.Text != "")
            {
                SqlConnection sqod = new SqlConnection(@"Data Source=DESKTOP-8A4LKRH\SQLEXPRESS;Initial Catalog=Library;Integrated Security=True");
                {
                    if (combobox1.SelectedItem == Horror)
                    {

                        try
                        {
                            sqod.Open();
                            SqlCommand sqlcmp = new SqlCommand("Insert into [book] (Bname,bauthor,bpbdate,bprice,Cid) values ('" + Bn.Text + "', '" + An.Text + "','" + Pd.Text + "', '" + ubp.Text + "', '" + 1 + "') ", sqod);
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
                            sqod.Close();
                        }
                    }
                    else if (combobox1.SelectedItem == Biography)
                    {
                        
                        try
                        {
                            sqod.Open();
                            SqlCommand cvb = new SqlCommand("Insert into [book] (Bname,bauthor,bpbdate,bprice,Cid) values ('" + Bn.Text + "', '" + An.Text + "','" + Pd.Text + "', '" + ubp.Text + "', '" + 2 + "') ", sqod);
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
                            sqod.Close();
                        }

                    }
                    else if (combobox1.SelectedItem == Documentary)
                    {
                        
                        try
                        {
                            sqod.Open();
                            SqlCommand pp = new SqlCommand("Insert into [book] (Bname,bauthor,bpbdate,bprice,Cid) values ('" + Bn.Text + "', '" + An.Text + "','" + Pd.Text + "', '" + ubp.Text + "', '" + 3 + "') ", sqod);
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
                            sqod.Close();
                        }

                    }
                    else if (combobox1.SelectedItem == Thriller)
                    {
                        
                        try
                        {
                            sqod.Open();
                            SqlCommand pk = new SqlCommand("Insert into [book] (Bname,bauthor,bpbdate,bprice,Cid) values ('" + Bn.Text + "', '" + An.Text + "','" + Pd.Text + "', '" + ubp.Text + "', '" + 4 + "') ", sqod);
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
                            sqod.Close();
                        }

                    }
                    else if (combobox1.SelectedItem == Comedy)
                    {
                        
                        try
                        {
                            sqod.Open();
                            SqlCommand pj = new SqlCommand("Insert into [book] (Bname,bauthor,bpbdate,bprice,Cid) values ('" + Bn.Text + "', '" + An.Text + "','" + Pd.Text + "', '" + ubp.Text + "', '" + 5 + "') ", sqod);
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
                            sqod.Close();
                        }

                    }
                    else if (combobox1.SelectedItem == Poem)
                    {
                        
                        try
                        {
                            sqod.Open();
                            SqlCommand ii = new SqlCommand("Insert into [book] (Bname,bauthor,bpbdate,bprice,Cid) values ('" + Bn.Text + "', '" + An.Text + "','" + Pd.Text + "', '" + ubp.Text + "', '" + 6 + "') ", sqod);
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
                            sqod.Close();
                        }

                    }
                    else if (combobox1.SelectedItem == SciFi)
                    {
                        
                        try
                        {
                            sqod.Open();
                            SqlCommand vv = new SqlCommand("Insert into [book] (Bname,bauthor,bpbdate,bprice,Cid) values ('" + Bn.Text + "', '" + An.Text + "','" + Pd.Text + "', '" + ubp.Text + "', '" + 7 + "') ", sqod);
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
                            sqod.Close();
                        }

                    }
                    else if (combobox1.SelectedItem == Mystry)
                    {
                        
                        try
                        {
                            sqod.Open();
                            SqlCommand sa = new SqlCommand("Insert into [book] (Bname,bauthor,bpbdate,bprice,Cid) values ('" + Bn.Text + "', '" + An.Text + "','" + Pd.Text + "', '" + ubp.Text + "', '" + 8 + "') ", sqod);
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
                            sqod.Close();
                        }

                    }
                }

            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Adminchoice ddd = new Adminchoice();
            ddd.Show();
            this.Hide();
        }
    }
}
           
            

            

        

