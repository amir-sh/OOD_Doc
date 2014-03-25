using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.model.asset;

namespace WindowsFormsApplication1.forms.darayi
{
    public class AssetNode : TreeNode
    {
        public Asset asset { get; set; }
        public AssetNode(Asset asset)
        {
            if (asset != null)
            {
                this.Text = asset.ToString(); //Or FriendlyName
                this.asset = asset;
            }
            else
                this.Text = "";
        }
        public void MakeTree()
        {
            foreach (Asset a in asset.subAssets)
            {
                var temp = new AssetNode(a);
                temp.MakeTree();
                this.Nodes.Add(temp);
            }
        }
    }
}
