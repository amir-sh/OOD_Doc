using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.model.label;

namespace WindowsFormsApplication1.forms.elsagh
{  
    class AssignedLabelNode : TreeNode
    {

        public AssignedLabel label { get; set; }
        public AssignedLabelNode(AssignedLabel label)
        {
            if (label != null)
            {
                this.Text = label.ToString(); //Or FriendlyName
                this.label = label;
            }
            else
                this.Text = "";
        }
        public void MakeTree()
        {
            foreach (AssignedLabel a in label.children)
            {
                var temp = new AssignedLabelNode(a);
                temp.MakeTree();
                this.Nodes.Add(temp);
            }
        }

    }
}


