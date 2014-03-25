using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyLabel = WindowsFormsApplication1.model.label.Label;
namespace WindowsFormsApplication1.forms.barchasb
{
    class LabelNode : TreeNode
    {
        
        public MyLabel label { get; set; }
        public LabelNode(MyLabel label)
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
            foreach (MyLabel a in label.subLabels)
            {
                var temp = new LabelNode(a);
                temp.MakeTree();
                this.Nodes.Add(temp);
            }
        }
        
    }
}
