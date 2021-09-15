using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskManager.Models;
namespace TaskManager
{
    public partial class Form1 : Form
    {
        string connectionString;
        SqlConnection connection;
        List<MyTask> Tasks;
        List<Catalog> Catalogs;
        List<Status> Statuses;
        public Form1()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            Console.WriteLine(connectionString);
            connection = new SqlConnection(connectionString);
            Tasks = new List<MyTask>();
            Catalogs = new List<Catalog>();
            Statuses = new List<Status>();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadCatalogs();
            LoadStatus();
            LoadTasks();
        }
        private void LoadStatus()
        {
            try
            {
                string sqlQuery = $"select * from Statuses";
                connection.Open();
                SqlCommand cmd = new SqlCommand(sqlQuery, connection);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Status status = new Status();
                    status.Id = (int)reader["Id"];
                    status.Name = reader["Name"].ToString();
                    Statuses.Add(status);
                }

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }
        private void LoadCatalogs() {
            try
            {
                string sqlQuery = $"select * from Catalogs";
                connection.Open();
                SqlCommand cmd = new SqlCommand(sqlQuery, connection);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Catalog catalog = new Catalog();
                    catalog.Id = (int)reader["Id"];
                    catalog.Name = reader["Name"].ToString();
                    Catalogs.Add(catalog);
                }

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }
        private void LoadTasks()
        {
            try
            {
                string sqlQuery = $"select * from Tasks";
                connection.Open();
                SqlCommand cmd = new SqlCommand(sqlQuery, connection);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    MyTask task = new MyTask();
                    task.Id = (int)reader["Id"];
                    task.Name = reader["TaskName"].ToString();
                    task.ShortDescription = reader["TaskShortDescription"].ToString();
                    task.FullDescription = reader["TaskDescription"].ToString();
                    task.CatalogId = (int)reader["CatalogId"];
                    task.StatusId = (int)reader["StatusId"];
                    var item = task_viewer.Items.Add(task.Id.ToString());
                    string CatalogName = "Error";
                    if(Catalogs.Count>0 && Catalogs[0].Id == task.CatalogId)
                    {
                        CatalogName = Catalogs[0].Name;
                    }
                    else
                    {
                        for(int i = 0; i < Catalogs.Count; i++)
                            if (Catalogs[i].Id == task.CatalogId)
                                CatalogName = Catalogs[i].Name;
                    }
                    item.SubItems.Add(CatalogName);

                    item.SubItems.Add(task.Name);
                    item.SubItems.Add(task.ShortDescription);

                    string StatusName = "Error";
                    if (Statuses.Count > 0 && Statuses[0].Id == task.StatusId)
                    {
                        StatusName = Statuses[0].Name;
                    }
                    else
                    {
                        for (int i = 0; i < Statuses.Count; i++)
                            if (Statuses[i].Id == task.StatusId)
                                StatusName = Statuses[i].Name;
                    }
                    item.SubItems.Add(StatusName);

                    Tasks.Add(task);
                }

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }
        
        private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            int currentSort = e.Column;
            resetColumnsName();
            switch (currentSort)
            {
                case 0:
                    task_viewer.Columns[0].Text = "Num↓";
                    break;
                case 1:
                    task_viewer.Columns[1].Text = "Category↓";
                    break;
                case 2:
                    task_viewer.Columns[2].Text = "Task↓";
                    break;
                case 3:
                    task_viewer.Columns[3].Text = "Short description↓";
                    break;
                case 4:
                    task_viewer.Columns[4].Text = "Status↓";
                    break;
            }
        }
        private void resetColumnsName()
        {
            task_viewer.Columns[0].Text = "Num";
            task_viewer.Columns[1].Text = "Category";
            task_viewer.Columns[2].Text = "Task";
            task_viewer.Columns[3].Text = "Short description";
            task_viewer.Columns[4].Text = "Status";
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void task_viewer_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            TaskDetailView tdv= new TaskDetailView();
            string tmp = "";
            if (task_viewer.SelectedItems.Count > 0)
            {
                var item = task_viewer.SelectedItems[0];
                tmp = item.SubItems[0].Text;
            }
            int Id = int.Parse(tmp);
            for(int i = 0; i < Tasks.Count; i++)
            {
                if (Tasks[i].Id == Id)
                {
                    tdv.TaskName = Tasks[i].Name;
                    tdv.ShortDescription = Tasks[i].ShortDescription;
                    tdv.FullDescription = Tasks[i].FullDescription;
                    tdv.CatalogId = Tasks[i].CatalogId;
                    tdv.StatusId = Tasks[i].StatusId;
                    tdv.Catalogs = Catalogs;
                    break;
                }
            }
            //MessageBox.Show(tmp);
            tdv.ShowDialog();
        }
    }
}
