using System;
using System.Collections.Generic;
using System.Data;
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
    /// Interaction logic for BorrowBooks.xaml
    /// </summary>
    public partial class BorrowBooks : Window
    {
        string booket;
        public BorrowBooks()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection sqod = new SqlConnection(@"Data Source=DESKTOP-8A4LKRH\SQLEXPRESS;Initial Catalog=Library;Integrated Security=True");
            {
                if (combo4.SelectedItem == Horror)
                {
                    try
                    {
                        sqod.Open();
                        SqlCommand sqlcmp = new SqlCommand(" Select * from [book] where cid=('" + 1 + "')  ", sqod);
                        MessageBox.Show(sqlcmp.CommandText);
                        sqlcmp.ExecuteNonQuery();
                        sqlcmp.CommandType = CommandType.Text;
                        DataTable dt = new DataTable();
                        SqlDataAdapter datadp = new SqlDataAdapter(sqlcmp);
                        datadp.Fill(dt);
                        dta.ItemsSource = dt.DefaultView;


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
                else if (combo4.SelectedItem == Biography)
                {

                    try
                    {
                        sqod.Open();
                        SqlCommand cvb = new SqlCommand("Select * from [book] where cid= ('" + 2 + "') ", sqod);
                        MessageBox.Show(cvb.CommandText);
                        cvb.ExecuteNonQuery();
                        cvb.CommandType = CommandType.Text;
                        DataTable dt = new DataTable();
                        SqlDataAdapter datadp = new SqlDataAdapter(cvb);
                        datadp.Fill(dt);
                        dta.ItemsSource = dt.DefaultView;

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
                else if (combo4.SelectedItem == Documentary)
                {

                    try
                    {
                        sqod.Open();
                        SqlCommand pp = new SqlCommand("Select * from [book] where cid= ( '" + 3 + "') ", sqod);
                        MessageBox.Show(pp.CommandText);
                        pp.ExecuteNonQuery();
                        pp.CommandType = CommandType.Text;
                        DataTable dt = new DataTable();
                        SqlDataAdapter datadp = new SqlDataAdapter(pp);
                        datadp.Fill(dt);
                        dta.ItemsSource = dt.DefaultView;

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
                else if (combo4.SelectedItem == Thriller)
                {

                    try
                    {
                        sqod.Open();
                        SqlCommand pk = new SqlCommand("Select * from [book] where cid= ( '" + 4 + "') ", sqod);
                        MessageBox.Show(pk.CommandText);
                        pk.ExecuteNonQuery();
                        pk.CommandType = CommandType.Text;
                        DataTable dt = new DataTable();
                        SqlDataAdapter datadp = new SqlDataAdapter(pk);
                        datadp.Fill(dt);
                        dta.ItemsSource = dt.DefaultView;

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
                else if (combo4.SelectedItem == Comedy)
                {

                    try
                    {
                        sqod.Open();
                        SqlCommand pj = new SqlCommand("Select * from [book] where cid= ( '" + 5 + "') ", sqod);
                        MessageBox.Show(pj.CommandText);
                        pj.ExecuteNonQuery();
                        pj.CommandType = CommandType.Text;
                        DataTable dt = new DataTable();
                        SqlDataAdapter datadp = new SqlDataAdapter(pj);
                        datadp.Fill(dt);
                        dta.ItemsSource = dt.DefaultView;
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
                else if (combo4.SelectedItem == Poem)
                {

                    try
                    {
                        sqod.Open();
                        SqlCommand ii = new SqlCommand("Select * from [book] where cid= (  '" + 6 + "') ", sqod);
                        MessageBox.Show(ii.CommandText);
                        ii.ExecuteNonQuery();
                        ii.CommandType = CommandType.Text;
                        DataTable dt = new DataTable();
                        SqlDataAdapter datadp = new SqlDataAdapter(ii);
                        datadp.Fill(dt);
                        dta.ItemsSource = dt.DefaultView;
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
                else if (combo4.SelectedItem == SciFi)
                {

                    try
                    {
                        sqod.Open();
                        SqlCommand vv = new SqlCommand("Select * from [book] where cid= ('" + 7 + "') ", sqod);
                        MessageBox.Show(vv.CommandText);
                        vv.ExecuteNonQuery();
                        vv.CommandType = CommandType.Text;
                        DataTable dt = new DataTable();
                        SqlDataAdapter datadp = new SqlDataAdapter(vv);
                        datadp.Fill(dt);
                        dta.ItemsSource = dt.DefaultView;

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
                else if (combo4.SelectedItem == Mystry)
                {

                    try
                    {
                        sqod.Open();
                        SqlCommand sa = new SqlCommand("Select * from [book] where cid= ( '" + 8 + "') ", sqod);
                        MessageBox.Show(sa.CommandText);
                        sa.ExecuteNonQuery();
                        sa.CommandType = CommandType.Text;
                        DataTable dt = new DataTable();
                        SqlDataAdapter datadp = new SqlDataAdapter(sa);
                        datadp.Fill(dt);
                        dta.ItemsSource = dt.DefaultView;
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

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (ubna.Text == "")
            {
                booket = "book name required";
                boerror.Content = booket;
            }
            else
            {
                boerror.Content = "";
            }
            if (ubna.Text != "")
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-8A4LKRH\SQLEXPRESS;Initial Catalog=Library;Integrated Security=True");
                try
                {
                    con.Open();
                    SqlCommand ql = new SqlCommand(@"DELETE FROM [book] where bname=('" + ubna.Text + "') ", con);
                    MessageBox.Show(ql.CommandText);
                    ql.ExecuteNonQuery();
                    MessageBox.Show("Book Purchased Successfully");
                }
                catch (Exception bl)
                {
                    MessageBox.Show(bl.Message);

                }
                finally
                {
                    con.Close();
                }
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MainWindow nop = new MainWindow();
            nop.Show();
            this.Hide();
        }
    }
}
