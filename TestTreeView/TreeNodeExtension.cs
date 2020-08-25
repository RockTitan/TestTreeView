using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TestTreeView
{
    public static class TreeNodeExtension
    {
        public static void SetParentChildNodesCheckedStatus(this TreeNode node)
        {
            SetChildNodesCheckedStatus(node);
            SetParentNodeCheckedStatus(node);
        }

        public static void SetChildNodesCheckedStatus(this TreeNode node)
        {
            bool checkStatus = node.Checked;
            TreeNodeCollection childNodes = node.Nodes;
            if (childNodes.Count > 0)
            {
                foreach (TreeNode childNode in childNodes)
                {
                    childNode.Checked = checkStatus;
                    SetChildNodesCheckedStatus(childNode);
                }
            }
        }

        public static void SetParentNodeCheckedStatus(this TreeNode node)
        {
            if (!(node.Parent is null))
            {
                bool currentParentNodeCheckedStatus = node.Parent.Checked;
                TreeNodeCollection sameLevelNodes = node.Parent.Nodes;
                Dictionary<string, bool> checkedStatus = new Dictionary<string, bool>();
                foreach (TreeNode sameLevelNode in sameLevelNodes)
                {
                    checkedStatus.Add(sameLevelNode.Text, sameLevelNode.Checked);
                }
                var statusList = checkedStatus.Select(x => x.Value).Distinct(EqualityComparer<bool>.Default);
                if (statusList.Count() == 1 && currentParentNodeCheckedStatus != statusList.First())
                {
                    if (statusList.First() == false)
                        node.Parent.Checked = false;
                    else
                        node.Parent.Checked = true;
                }
            }
        }
    }
}
