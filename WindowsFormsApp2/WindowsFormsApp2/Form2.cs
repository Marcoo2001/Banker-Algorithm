using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
        public int[] total_ressources_arr;
        public int[] available_ressources_arr;
        public int[,] current_allocated_arr;
        public int[,] max_need_arr;
        public int[,] remain_need_arr;

        public int available, asked, count = 0, enter;
        public string available_s, s;
        public bool ispressed, x;
        public  List<string> mylist = new List<string>();
        public  static List<string> steps_list = new List<string>();


        public Form2()
        {
            InitializeComponent();

            Total_ressources();
            Available_Ressources();
            current_allocated();
            max_need();
            combobox_list();

        }
        public void Total_ressources()
        {
            for (int i = 0; i < Form1.nb_of_ressources; i++)
            {
                string columnName = ((char)('A' + i)).ToString();
                total_ressources_table.Columns.Add(columnName, columnName);
            }

            for (int i=0; i< 1; i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(total_ressources_table);
                total_ressources_table.Rows.Add(row);
            }
        }

        public void Available_Ressources()
        {
            for (int i = 0; i < Form1.nb_of_ressources; i++)
            {
                string columnName = ((char)('A' + i)).ToString();
                available_ressources_table.Columns.Add(columnName, columnName);
            }

            for (int i = 0; i < 1; i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(available_ressources_table);
                available_ressources_table.Rows.Add(row);
            }
        }

        public void current_allocated()
        {
            for (int i = 0; i < Form1.nb_of_ressources; i++)
            {
                string columnName = ((char)('A' + i)).ToString();
                current_allocated_table.Columns.Add(columnName, columnName);
            }

            for (int i = 0; i < Form1.nb_of_processes; i++)
            {
                string rowName = "P" + (i + 1).ToString();
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(current_allocated_table);
                for (int j = 0; j < Form1.nb_of_ressources; j++)
                {
                    row.Cells[j].Value = "";
                }
                row.HeaderCell.Value = rowName;
                current_allocated_table.Rows.Add(row);
            }
        }

        public void max_need ()
        {
            for (int i = 0; i < Form1.nb_of_ressources; i++)
            {
                string columnName = ((char)('A' + i)).ToString();
                maximum_need_table.Columns.Add(columnName, columnName);
            }

            for (int i = 0; i < Form1.nb_of_processes; i++)
            {
                string rowName = "P" + (i + 1).ToString();
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(maximum_need_table);
                for (int j = 0; j < Form1.nb_of_ressources; j++)
                {
                    row.Cells[j].Value = "";
                }
                row.HeaderCell.Value = rowName;
                maximum_need_table.Rows.Add(row);
            }
        }

        public void remain_need()
        {
            remain_need_label.Visible = true;
            remain_need_table.Visible = true;
       
            for (int i = 0; i < Form1.nb_of_ressources; i++)
            {
                string columnName = ((char)('A' + i)).ToString();
                remain_need_table.Columns.Add(columnName, columnName);
            }

            for (int i = 0; i < Form1.nb_of_processes; i++)
            {
                string rowName = "P" + (i + 1).ToString();
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(remain_need_table);
                for (int j = 0; j < Form1.nb_of_ressources; j++)
                {
                    row.Cells[j].Value = "";
                }
                row.HeaderCell.Value = rowName;
                remain_need_table.Rows.Add(row);
            }

            remain_need_arr = new int[remain_need_table.Rows.Count, remain_need_table.Columns.Count];

            for (int i=0 ;i< remain_need_table.Rows.Count; i++)
            {
                for (int j=0; j< remain_need_table.Columns.Count;j++)
                {
                    remain_need_arr[i, j] = max_need_arr[i, j] - current_allocated_arr[i, j];
                    remain_need_table.Rows[i].Cells[j].Value = remain_need_arr[i, j];
                }
            }
        }

        public void combobox_list ()
        {
            for (int i = 0; i < Form1.nb_of_processes; i++)
            {
                List<string> processes = new List<string>();
                processes.Add("P" + (i + 1).ToString());
                processes_combobox.Items.AddRange(processes.ToArray());
            }
            for (int i = 0; i < Form1.nb_of_ressources; i++)
            {
                List<string> ressources = new List<string>();
                ressources.Add(((char)('A' + i)).ToString());
                ressources_combobox.Items.AddRange(ressources.ToArray());
            }
        }

        public bool common()
        {
            total_ressources_arr = new int[total_ressources_table.Columns.Count];
            available_ressources_arr = new int[available_ressources_table.Columns.Count];
            current_allocated_arr = new int[current_allocated_table.Rows.Count, current_allocated_table.Columns.Count];
            max_need_arr = new int[maximum_need_table.Rows.Count, maximum_need_table.Columns.Count];

            int x = 0;
            int y = 1;


            if ((Total_Ressources_Constraints() == true) && (available_ressources_Constraints() == true) && (current_allocated_Constraints() == true) && (Max_need_constraints() == true))
            {
                
                for (int i = 0; i < total_ressources_table.Columns.Count; i++)
                {
                    total_ressources_arr[i] = int.Parse(total_ressources_table.Rows[0].Cells[i].Value.ToString());
                }

                for (int i = 0; i < available_ressources_table.Columns.Count; i++)
                {
                    available_ressources_arr[i] = int.Parse(available_ressources_table.Rows[0].Cells[i].Value.ToString());
                }

                for (int i = 0; i < current_allocated_table.Rows.Count; i++)
                {
                    for (int j = 0; j < current_allocated_table.Columns.Count; j++)
                    {
                        current_allocated_arr[i, j] = int.Parse(current_allocated_table.Rows[i].Cells[j].Value.ToString());
                    }
                }

                for (int i = 0; i < maximum_need_table.Rows.Count; i++)
                {
                    for (int j = 0; j < maximum_need_table.Columns.Count; j++)
                    {
                        max_need_arr[i, j] = int.Parse(maximum_need_table.Rows[i].Cells[j].Value.ToString());
                    }
                }

                x = 1;
            }
            
            else
            {
                x = 2;
            }

            for (int i=0;i< current_allocated_table.Rows.Count;i++)
            {
                for (int j=0;j< current_allocated_table.Columns.Count;j++ )
                {
                    if (max_need_arr[i,j] <  current_allocated_arr[i,j])
                    {
                        y = 2; 
                        MessageBox.Show(" Maximum need must be greater than or equal current allocated");
                        break;
                    }
                }
                if (y==2 )
                {
                    break;
                }
            }

            if (x==1 && y==1 )
            {
                return true ;
            }
            else
            {
                return false;
            }


        }

        private void enter_button_Click(object sender, EventArgs e)
        {
            if (common() == true)
            {
                total_ressources_table.ReadOnly = true;
                available_ressources_table.ReadOnly = true;
                current_allocated_table.ReadOnly = true;
                maximum_need_table.ReadOnly = true;
                if (processes_combobox.SelectedItem == null)
                {
                    MessageBox.Show("Please select the process");
                }
                else if (string.IsNullOrWhiteSpace(request_ressources_txt.Text))
                {
                    MessageBox.Show("Please enter the number of ressources");
                }
                else if (ressources_combobox.SelectedItem == null)
                {
                    MessageBox.Show("Please select the ressource");
                }

                else
                {
                    asked = int.Parse(request_ressources_txt.Text);
                    string x = ressources_combobox.SelectedItem.ToString();

                    for (int i = 0; i < available_ressources_arr.Length; i++)
                    {
                        if (available_ressources_table.Columns[i].HeaderText == x)
                        {
                            available = int.Parse(available_ressources_table.Rows[0].Cells[i].Value.ToString());
                        }
                    }

                    if (asked > available)
                    {
                        MessageBox.Show("Unsafe , There is only " + available + " ressources available of type " + x);
                    }

                    else
                    {
                        for (int i = 0; i < available_ressources_arr.Length; i++)
                        {
                            if (available_ressources_table.Columns[i].HeaderText == x)
                            {
                                available_ressources_arr[i] -= asked;
                                available_ressources_table.Rows[0].Cells[i].Value = available_ressources_arr[i];
                            }
                        }

                        string y = processes_combobox.SelectedItem.ToString();

                        for (int i = 0; i < current_allocated_table.Rows.Count; i++)
                        {
                            for (int j = 0; j < current_allocated_table.Columns.Count; j++)
                            {
                                if ((y == current_allocated_table.Rows[i].HeaderCell.Value.ToString()) && (x == current_allocated_table.Columns[j].HeaderText))
                                {
                                    current_allocated_arr[i, j] += asked;
                                    current_allocated_table.Rows[i].Cells[j].Value = current_allocated_arr[i, j];
                                }
                            }
                        }
                        MessageBox.Show("Assumption accpeted");
                    }
                }
                ispressed = true;
            }
        }

        private void Finish_button_Click(object sender, EventArgs e)
        {
            if (common() == true)
            {
                total_ressources_table.ReadOnly = true;
                available_ressources_table.ReadOnly = true;
                current_allocated_table.ReadOnly = true;
                maximum_need_table.ReadOnly = true;
                remain_need();
                assume_label.Visible = false;
                requests_label.Visible = false;
                ressources_of_type_label.Visible = false;
                optional_label.Visible = false;
                processes_combobox.Visible = false;
                ressources_combobox.Visible = false;
                enter_button.Visible = false;
                request_ressources_txt.Visible = false;
                Finish_button.Visible = false;
                safe_unsafe_label.Visible = true;
                sequence_label.Visible = true;
                filling_table_label.Visible = false;
                steps_button.Visible = true;
                logic();
            }
        }

        public bool Total_Ressources_Constraints ()
        {
            int flag5 = 0;
            int flag6 = 0;
            for (int row = 0; row < total_ressources_table.Rows.Count; row++)
            {
                for (int col = 0; col < total_ressources_table.Columns.Count; col++)
                {
                    DataGridViewCell cell = total_ressources_table.Rows[row].Cells[col];

                    if (cell.Value == null || cell.Value.ToString() == "")
                    {
                        flag5 = 1;
                        flag6 = 1;
                    }
                    if (flag6 == 0)
                    {
                        int cellValue;
                        bool isInteger = int.TryParse(cell.Value.ToString(), out cellValue);
                        if (isInteger == false)
                        {
                            flag5 = 2;
                        }
                    }
                }
            }
            if (flag5 == 1)
            {
                MessageBox.Show("Please fill all the cells in total ressources table");
                return false;
            }
            if (flag5 == 2)
            {
                MessageBox.Show("only integers values allowed in total ressources table");
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool available_ressources_Constraints()
        {
            int flag7 = 0;
            int flag8 = 0;
            for (int row = 0; row < available_ressources_table.Rows.Count; row++)
            {
                for (int col = 0; col < available_ressources_table.Columns.Count; col++)
                {
                    DataGridViewCell cell = available_ressources_table.Rows[row].Cells[col];

                    if (cell.Value == null || cell.Value.ToString() == "")
                    {
                        flag7 = 1;
                        flag8 = 1;
                    }
                    if (flag8 == 0)
                    {
                        int cellValue;
                        bool isInteger = int.TryParse(cell.Value.ToString(), out cellValue);
                        if (isInteger == false)
                        {
                            flag7 = 2;
                        }
                    }
                }
            }
            if (flag7 == 1)
            {
                MessageBox.Show("Please fill all the cells in available ressources table");
                return false;
            }
            if (flag7 == 2)
            {
                MessageBox.Show("only integers values allowed in available ressources table");
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool current_allocated_Constraints()
        {
            int flag = 0;
            int flag2 = 0;
            for (int row = 0; row < current_allocated_table.Rows.Count; row++)
            {
                for (int col = 0; col < current_allocated_table.Columns.Count; col++)
                {
                    DataGridViewCell cell = current_allocated_table.Rows[row].Cells[col];

                    if (cell.Value == null || cell.Value.ToString() == "")
                    {
                        flag = 1;
                        flag2 = 1;
                    }
                    if (flag2 == 0)
                    {
                        int cellValue;
                        bool isInteger = int.TryParse(cell.Value.ToString(), out cellValue);
                        if (isInteger == false)
                        {
                            flag = 2;
                        }
                    }
                }
            }
            if (flag == 1)
            {
                MessageBox.Show("Please fill all the cells in current allocated table");
                return false; ;
            }
            if (flag == 2)
            {
                MessageBox.Show("only integers values allowed in current allocated table");
                return false;
            }
            else
            {
                return true;
            }

        }

        public bool Max_need_constraints()
        {
            int flag3 = 0;
            int flag4 = 0;
            for (int row = 0; row < maximum_need_table.Rows.Count; row++)
            {
                for (int col = 0; col < maximum_need_table.Columns.Count; col++)
                {
                    DataGridViewCell cell = maximum_need_table.Rows[row].Cells[col];

                    if (cell.Value == null || cell.Value.ToString() == "")
                    {
                        flag3 = 1;
                        flag4 = 1;
                    }
                    if (flag4 == 0)
                    {
                        int cellValue;
                        bool isInteger = int.TryParse(cell.Value.ToString(), out cellValue);
                        if (isInteger == false)
                        {
                            flag3 = 2;
                        }
                    }
                }
            }
            if (flag3 == 1)
            {
                MessageBox.Show("Please fill all the cells in maximum need table");
                return false;
                
            }
            if (flag3 == 2)
            {
                MessageBox.Show("only integers values allowed in maximum need table");
                return false;
            }
            else
            {
                return true;
            }


        }

        public void logic ()
        {
            Form3 form3 = new Form3();
            x = true;
            int y = 0;    
            int[] myarr = new int[available_ressources_arr.Length];
            int[] mytest = new int[available_ressources_arr.Length];  

            while ( x==true)
            { 
                for (int i=0;i<available_ressources_arr.Length;i++)
                {
                    myarr[i] = available_ressources_arr[i];
                }


                for (int i = 0; i < remain_need_table.Rows.Count; i++)
                {
                    bool matchFound = false; 
                    foreach (string x in mylist)
                    {
                        if (x == remain_need_table.Rows[i].HeaderCell.Value.ToString())
                        {
                            matchFound = true; 
                            break;
                        }
                    }
                    if (matchFound)
                    {
                        continue; 
                    }
                    for (int j = 0; j < remain_need_table.Columns.Count; j++)
                    {
                        if (available_ressources_arr[j] >= remain_need_arr[i, j])
                        {
                            y++;
                            s = remain_need_table.Rows[i].HeaderCell.Value.ToString();
                            mytest[j] = current_allocated_arr[i,j];
                        }
                        if (y== remain_need_table.Columns.Count)
                        {
                            enter = 1;
                            mylist.Add(s);              
                            y =0;
                            for (int  k=0;k< available_ressources_arr.Length;k++)
                            {
                                available_ressources_arr[k] += mytest[k];
                            }
                            steps_list.Add( Environment.NewLine+ "Available >= remain"+ Environment.NewLine  +remain_need_table.Rows[i].HeaderCell.Value.ToString() + " kept in safe state" + Environment.NewLine + printavailable()+ Environment.NewLine);
                        }
                    }
                    if (enter !=1 )
                    {
                        steps_list.Add(Environment.NewLine +" Available < remain" + Environment.NewLine + remain_need_table.Rows[i].HeaderCell.Value.ToString() + " waits" + Environment.NewLine + printavailable()+ Environment.NewLine);
                    }
                    Array.Clear(mytest, 0, mytest.Length);
                    y = 0;
                    enter = 0;
                }
               

                for (int i=0; i< myarr.Length;i++)
                {
                    if (myarr[i]== available_ressources_arr[i] )
                    {
                        count++;
                    }
                }
               if (count == available_ressources_arr.Length  )
               {
                    x = false;
               }
               else
               {
                    count = 0;
               }
            }
            for (int i = 0; i < available_ressources_arr.Length; i++)
            {
                available_ressources_table.Rows[0].Cells[i].Value = available_ressources_arr[i];
            }
            if (mylist.Count == Form1.nb_of_processes)
            {
                safe_unsafe_label.Text = "The system is safe ";
            }
            else
            {
                safe_unsafe_label.Text = "The system is unsafe !";
            }

            foreach(string x in mylist)
            {
                sequence_label.Text += (x +  "   ");
            }
        }

        public string printavailable()
        {
            available_s = "";
            for (int i=0;i<available_ressources_arr.Length;i++)
            {
                available_s +=( available_ressources_arr[i].ToString()+ "  ");
            }

            return ("Available = " + available_s);
            
        }

        private void steps_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 form3 = new Form3();
            form3.Show();
        }

    }
}
    

