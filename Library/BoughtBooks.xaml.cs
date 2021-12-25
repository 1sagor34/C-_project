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
    /// Interaction logic for BoughtBooks.xaml
    /// </summary>
    public partial class BoughtBooks : Window
    {
        string booke;
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            Application.Current.Shutdown();
        }
        public BoughtBooks()
        {
            InitializeComponent();

        }
        

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection sqo = new SqlConnection(@"Data Source=DESKTOP-8A4LKRH\SQLEXPRESS;Initial Catalog=Library;Integrated Security=True");
            {
                if (combo3.SelectedItem == Horror)
                {
                    
                    try
                    {
                        sqo.Open();
                        SqlCommand sqlcmp = new SqlCommand(" Select * from [book] where cid=('" + 1 + "')  ", sqo);
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
                        sqo.Close();
                    }
                }
                else if (combo3.SelectedItem == Biography)
                {
                    
                    try
                    {
                        sqo.Open();
                        SqlCommand cvb = new SqlCommand("Select * from [book] where cid= ('" + 2 + "') ", sqo);
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
                        sqo.Close();
                    }

                }
                else if (combo3.SelectedItem == Documentary)
                {
                   
                    try
                    {
                        sqo.Open();
                        SqlCommand pp = new SqlCommand("Select * from [book] where cid= ( '" + 3 + "') ", sqo);
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
                        sqo.Close();
                    }

                }
                else if (combo3.SelectedItem == Thriller)
                {
                   
                    try
                    {
                        sqo.Open();
                        SqlCommand pk = new SqlCommand("Select * from [book] where cid= ( '" + 4 + "') ", sqo);
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
                        sqo.Close();
                    }

                }
                else if (combo3.SelectedItem == Comedy)
                {
                    
                    try
                    {
                        sqo.Open();
                        SqlCommand pj = new SqlCommand("Select * from [book] where cid= ( '" + 5 + "') ", sqo);
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
                        sqo.Close();
                    }

                }
                else if (combo3.SelectedItem == Poem)
                {
                    
                    try
                    {
                        sqo.Open();
                        SqlCommand ii = new SqlCommand("Select * from [book] where cid= (  '" + 6 + "') ", sqo);
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
                        sqo.Close();
                    }

                }
                else if (combo3.SelectedItem == SciFi)
                {
                    
                    try
                    {
                        sqo.Open();
                        SqlCommand vv = new SqlCommand("Select * from [book] where cid= ('" + 7 + "') ", sqo);
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
                        sqo.Close();
                    }

                }
                else if (combo3.SelectedItem == Mystry)
                {
                    
                    try
                    {
                        sqo.Open();
                        SqlCommand sa = new SqlCommand("Select * from [book] where cid= ( '" + 8 + "') ", sqo);
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
                        sqo.Close();
                    }

                }
            }

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
            {
                if (ubname.Text == "")
                {
                    booke = "book name required";
                    bookerror.Content = booke;
                }
                else
                {
                    bookerror.Content = "";
                }
                if (ubname.Text != "")
                {
                    SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-8A4LKRH\SQLEXPRESS;Initial Catalog=Library;Integrated Security=True");
                    try
                    {
                        con.Open();
                        SqlCommand ql = new SqlCommand(@"DELETE FROM [book] where bname=('" + ubname.Text + "') ", con);
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
            MainWindow mf = new MainWindow();
            mf.Show();
            this.Hide();
        }
    }
}
    

