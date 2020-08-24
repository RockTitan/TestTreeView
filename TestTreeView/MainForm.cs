using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestTreeView
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_FillTreeView_Click(object sender, EventArgs e)
        {
            try
            {
                treeView_Main.Nodes.Clear();

                //root Nodes(Level 1)
                TreeNode rootNodeTuan = treeView_Main.Nodes.Add("Tuan", "段小G");
                TreeNode rootNodeRay = treeView_Main.Nodes.Add("Ray", "劉GG");
                TreeNode rootNodeRoger = treeView_Main.Nodes.Add("Roger", "楊TT");

                //Level 2
                TreeNode tuanChild2_1 = rootNodeTuan.Nodes.Add("小GG");
                TreeNode tuanChild2_2 = rootNodeTuan.Nodes.Add("小小G");
                TreeNode tuanChild2_3 = rootNodeTuan.Nodes.Add("微小G");
                TreeNode tuanChild2_4 = rootNodeTuan.Nodes.Add("奈米G");

                TreeNode rayChild2_1 = rootNodeRay.Nodes.Add("有GG");
                TreeNode rayChild2_2 = rootNodeRay.Nodes.Add("消失G");
                TreeNode rRayChild2_3 = rootNodeRay.Nodes.Add("爆炸G");

                TreeNode rogerChild2_1 = rootNodeRoger.Nodes.Add("TestNode1");
                TreeNode rogerChild2_2 = rootNodeRoger.Nodes.Add("TestNode2");
                TreeNode rogerChild2_3 = rootNodeRoger.Nodes.Add("TestNode3");
                TreeNode rogerChild2_4 = rootNodeRoger.Nodes.Add("TestNode4");
                TreeNode rogerChild2_5 = rootNodeRoger.Nodes.Add("TestNode5");

                //Level 3
                tuanChild2_1.Nodes.Add("小GG-1");
                tuanChild2_1.Nodes.Add("小GG-2");
                tuanChild2_1.Nodes.Add("小GG-3");

                tuanChild2_2.Nodes.Add("小小G-1");
                tuanChild2_2.Nodes.Add("小小G-2");
                tuanChild2_2.Nodes.Add("小小G-3");

                tuanChild2_3.Nodes.Add("微小G-1");
                tuanChild2_3.Nodes.Add("微小G-2");
                tuanChild2_3.Nodes.Add("微小G-3");

                tuanChild2_4.Nodes.Add("奈米G-1");
                tuanChild2_4.Nodes.Add("奈米G-2");

                rRayChild2_3.Nodes.Add("爆炸G-1");
                rRayChild2_3.Nodes.Add("爆炸G-2");
                rRayChild2_3.Nodes.Add("爆炸G-3");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_ExpandAll_Click(object sender, EventArgs e)
        {
            try
            {
                treeView_Main.ExpandAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_CollapseAll_Click(object sender, EventArgs e)
        {
            try
            {
                treeView_Main.CollapseAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_CheckedAll_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (TreeNode rootNode in treeView_Main.Nodes)
                {
                    rootNode.Checked = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_UncheckedAll_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (TreeNode rootNode in treeView_Main.Nodes)
                {
                    rootNode.Checked = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void treeView_Main_AfterCheck(object sender, TreeViewEventArgs e)
        {
            try
            {
                TreeNodeUtils.SetParentChildNodesCheckedStatus(e.Node);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
