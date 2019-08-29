using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ListView
{
    public partial class Form1 : Form
    {
        private System.Collections.Specialized.StringCollection folderCol;

        private void CreateHeadersAndFillListView()
        {
            ColumnHeader colHead;
            colHead = new ColumnHeader();
            colHead.Text = "Filename";
            listView1.Columns.Add(colHead); // Insert the header
            colHead = new ColumnHeader();
            colHead.Text = "Size";
            listView1.Columns.Add(colHead); // Insert the header
            colHead = new ColumnHeader();
            colHead.Text = "Last accessed";
            listView1.Columns.Add(colHead); // Insert the header
        }

        private void PaintListView(string root)
        {
            try
            {
                ListViewItem lvi;
                ListViewItem.ListViewSubItem lvsi;
                if (string.IsNullOrEmpty(root))
                    return;
                DirectoryInfo dir = new DirectoryInfo(root);
                DirectoryInfo[] dirs = dir.GetDirectories(); // Folders
                FileInfo[] files = dir.GetFiles(); // Files
                listView1.Items.Clear();
                label1.Text = root;
                listView1.BeginUpdate();
                foreach (DirectoryInfo di in dirs)
                {
                    lvi = new ListViewItem();
                    lvi.Text = di.Name; // Folder name
                    lvi.ImageIndex = 0; // The folder icon has index 0
                    lvi.Tag = di.FullName; // Set the tag to the qualified path of the folder
                    lvsi = new ListViewItem.ListViewSubItem();
                    lvsi.Text = ""; // Size—a folder has no size and so this column is empty
                    lvi.SubItems.Add(lvsi); // Add the subitem to the ListViewItem
                    lvsi = new ListViewItem.ListViewSubItem();
                    lvsi.Text = di.LastAccessTime.ToString(); // Last accessed column
                    lvi.SubItems.Add(lvsi); // Add the subitem to the ListViewItem.
                    listView1.Items.Add(lvi);
                }
                foreach (FileInfo fi in files)
                {
                    lvi = new ListViewItem();
                    lvi.Text = fi.Name; // Filename
                    lvi.ImageIndex = 1; // The icon we use to represent a folder has index 1.
                    lvi.Tag = fi.FullName; // Set the tag to the qualified path of the file.
                    lvsi = new ListViewItem.ListViewSubItem();
                    lvsi.Text = fi.Length.ToString(); // Length of the file
                    lvi.SubItems.Add(lvsi); // Add to the SubItems collection
                    lvsi = new ListViewItem.ListViewSubItem();
                    lvsi.Text = fi.LastAccessTime.ToString(); // Last Accessed Column
                    lvi.SubItems.Add(lvsi); // Add to the SubItems collection
                    listView1.Items.Add(lvi);
                }
                listView1.EndUpdate();
            }
            catch (System.Exception err)
            {
                MessageBox.Show("Error: " + err.Message);
            }
        }

        public Form1()
        {
            
            InitializeComponent();
            folderCol = new System.Collections.Specialized.StringCollection();
            CreateHeadersAndFillListView();
            PaintListView(@"d:\");
            folderCol.Add(@"d:\");
        }

        private void listViewFilesAndFolders_ItemActivate(object sender, EventArgs e)
        {
            System.Windows.Forms.ListView lw = (System.Windows.Forms.ListView)sender;
            string filename = lw.SelectedItems[0].Tag.ToString();
            if (lw.SelectedItems[0].ImageIndex != 0)
            {
                try
                {
                    System.Diagnostics.Process.Start(filename);
                }
                catch { return; }
            }
            else
            {
                PaintListView(filename);
                folderCol.Add(filename);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (folderCol.Count > 1)
            {
                PaintListView(folderCol[folderCol.Count - 2].ToString());
                folderCol.RemoveAt(folderCol.Count - 1);
            }
            else
                PaintListView(folderCol[0].ToString());
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rdb = (RadioButton)sender;
            if (rdb.Checked)
                this.listView1.View = View.LargeIcon;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
                RadioButton rdb = (RadioButton)sender;
                if (rdb.Checked)
                    this.listView1.View = View.SmallIcon;
            
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rdb = (RadioButton)sender;
            if (rdb.Checked)
                this.listView1.View = View.List;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rdb = (RadioButton)sender;
            if (rdb.Checked)
                this.listView1.View = View.Details;

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rdb = (RadioButton)sender;
            if (rdb.Checked)
                this.listView1.View = View.Tile;
        }
    }
}
