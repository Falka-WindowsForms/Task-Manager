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
    public enum EnumStatuses
    {
        ToDo,
        InProgress,
        Done
    }
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
            UpdateAll();
        }
        private void UpdateAll()
        {
            Catalogs = new List<Catalog>();
            Statuses = new List<Status>();
            Tasks = new List<MyTask>();
            Category_comboBox.Items.Clear();
            task_viewer.Items.Clear();
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
            Catalog tmp = new Catalog() { Id = -1, Name = "All" };
            Catalogs.Add(tmp);
            Category_comboBox.Items.Add(tmp);
            Category_comboBox.SelectedIndex = 0;
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
                    Category_comboBox.Items.Add(catalog);
                    
                }
                Category_comboBox.DisplayMember = "Name";
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
        private void AddCatalog(string CatalogName)
        {
            try
            {
                string sqlQuery = $"insert into Catalogs (Name) values (@p1);";
                connection.Open();
                SqlCommand cmd = new SqlCommand(sqlQuery, connection);
                cmd.Parameters.Add("@p1", SqlDbType.NVarChar).Value = CatalogName;
                cmd.ExecuteNonQuery();
                MessageBox.Show($"Added");
                
                
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
                UpdateAll();
            }
        }
        private int FindCatalog(string Name)
        {
            int catalogId = -1;
            for (int i = 0; i < Catalogs.Count; i++)
            {
                if (Catalogs[i].Name.ToLower() == Name.ToLower())
                {
                    catalogId = Catalogs[i].Id;
                }
            }
            return catalogId;
        }
        private int FindLocalCatalogId(int Id)
        {
            for (int i = 0; i < Catalogs.Count; i++)
            {
                if (Catalogs[i].Id == Id)
                {
                    return i;
                }
            }
            return -1;
        }
        private EnumStatuses FindEnumStatus(int index)
        {
            int status = -1;
            for (int i = 0; i < Statuses.Count; i++)
            {
                if (Statuses[i].Id == index)
                {
                    status = i;
                    break;
                }
            }
            string es = Statuses[status].Name;
            if (es == "To do")
            {
                return EnumStatuses.ToDo;
            }
            else if (es == "In Progress")
            {
                return EnumStatuses.InProgress;
            }else if (es == "Done"){
                return EnumStatuses.Done;
            }
            return EnumStatuses.ToDo;
        }
        private int FindStatusIndex(EnumStatuses es)
        {
            string statusStr = "";
            if(es == EnumStatuses.ToDo)
            {
                statusStr = "To do";   
            }else if(es == EnumStatuses.InProgress)
            {
                statusStr = "In Progress";
            }
            else
            {
                statusStr = "Done";
            }
            for(int i = 0; i < Statuses.Count; i++)
            {
                if(Statuses[i].Name == statusStr)
                {
                    return Statuses[i].Id;
                }
            }
            return -1;
        }
        private void AddTask(string TaskName,string ShortDescr,string FullDescr,int statusId,int CatalogId)
        {
            try
            {
                string sqlQuery = $"insert into Tasks([TaskName],[TaskDescription],[TaskShortDescription],[CatalogId],[StatusId]) values (@p1,@p2,@p3,@p4,@p5);";
                connection.Open();
                SqlCommand cmd = new SqlCommand(sqlQuery, connection);
                cmd.Parameters.Add("@p1", SqlDbType.NVarChar).Value = TaskName;
                cmd.Parameters.Add("@p2", SqlDbType.NVarChar).Value = FullDescr;
                cmd.Parameters.Add("@p3", SqlDbType.NVarChar).Value = ShortDescr;
                cmd.Parameters.Add("@p4", SqlDbType.NVarChar).Value = CatalogId;
                cmd.Parameters.Add("@p5", SqlDbType.NVarChar).Value = statusId;
                cmd.ExecuteNonQuery();
                MessageBox.Show($"Added task","OK",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
                UpdateAll();
            }
        }
        private void AddTask_button_Click(object sender, EventArgs e)
        {
            AddTaskForm tdv = new AddTaskForm();
            tdv.ShowDialog();
            if (tdv.DialogResult != DialogResult.OK)
                return;
            string catalogName = tdv.Catalog;
            int catalogId = FindCatalog(catalogName);
            if (catalogId == -1)
            {
                AddCatalog(tdv.Catalog);
                catalogId = FindCatalog(catalogName);
            }
            string TaskName = tdv.TaskName;
            string status_str = "";
            int statusId = -1;
            if (tdv.StatusId == EnumStatuses.ToDo)
                status_str = "To do";
            else if (tdv.StatusId == EnumStatuses.InProgress)
                status_str = "In Progress";
            else
                status_str = "Done";

            for (int i = 0; i < Statuses.Count; i++)
                if (Statuses[i].Name == status_str)
                    statusId = Statuses[i].Id;

            if (statusId == -1) { 
                MessageBox.Show("Critical error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            AddTask(TaskName, tdv.ShortDescription, tdv.FullDescription, statusId, catalogId);

        }

        private void editTask_button_Click(object sender, EventArgs e)
        {

            if (task_viewer.SelectedItems.Count == 0)
                return;
            AddTaskForm adf = new AddTaskForm(1);
            var item = task_viewer.SelectedItems[0];
            var tmp = item.SubItems[0].Text;
            int Id = int.Parse(tmp);
            for (int i = 0; i < Tasks.Count; i++)
            {
                if (Tasks[i].Id == Id)
                {
                    adf.TaskName = Tasks[i].Name;
                    adf.ShortDescription = Tasks[i].ShortDescription;
                    adf.FullDescription = Tasks[i].FullDescription;
                    adf.Catalog = Catalogs[FindLocalCatalogId(Tasks[i].CatalogId)].Name;
                    adf.StatusId = FindEnumStatus(Tasks[i].StatusId);
                    break;
                }
            }
            adf.ShowDialog();
            if (adf.DialogResult != DialogResult.OK)
                return;
            int catalogId = FindCatalog(adf.Catalog);
            if (catalogId == -1)
            {
                AddCatalog(adf.Catalog);
                catalogId = FindCatalog(adf.Catalog);
            }
            try
            {
                string sqlQuery = $"UPDATE [Tasks] SET TaskName = @p1, TaskDescription = @p2, TaskShortDescription = @p3, CatalogId = @p4, StatusId = @p5 WHERE [Id] = @p6;";
                connection.Open();
                SqlCommand cmd = new SqlCommand(sqlQuery, connection);
                cmd.Parameters.Add("@p1", SqlDbType.NVarChar).Value = adf.TaskName;
                cmd.Parameters.Add("@p2", SqlDbType.NVarChar).Value = adf.FullDescription;
                cmd.Parameters.Add("@p3", SqlDbType.NVarChar).Value = adf.ShortDescription;
                cmd.Parameters.Add("@p4", SqlDbType.Int).Value = catalogId;
                cmd.Parameters.Add("@p5", SqlDbType.Int).Value = FindStatusIndex(adf.StatusId);
                cmd.Parameters.Add("@p6", SqlDbType.Int).Value = Id;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Updated!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
                UpdateAll();
            }
            

        }
    }
}
