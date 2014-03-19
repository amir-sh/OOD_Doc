using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.forms.Utility;
using WindowsFormsApplication1.model.DB;
using WindowsFormsApplication1.model.asset ;
using System.Runtime.InteropServices;

namespace WindowsFormsApplication1.forms.darayi
{
    public partial class ComplexDarayiManagement : UserControl
    {
        private class AssetNode : TreeNode
        {
            private Asset asset { get; set; }
            public AssetNode(Asset asset)
            {
                this.Text = asset.ToString(); //Or FriendlyName
                this.asset = asset;
                
            }       
            public void MakeTree ()
            {
                foreach (Asset a in asset.subAssets)
                {
                    var temp = new AssetNode(a);
                    temp.MakeTree();
                    this.Nodes.Add(temp);
                }
            }
        };
        private Asset asset { get; set; } 
        public ComplexDarayiManagement()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void SelectAsset_Load(object sender, EventArgs e) 
        {
            FormLoad.SetAutoComplete(SelectAsset, DBManager.datacontext.Assets);
        }

        private void SelectAsset_TextChanged(object sender, EventArgs e)
        {

        }

        private void SelectAsset_Enter(object sender, EventArgs e)
        {

            
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void SelectAsset_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (e.KeyChar == 32)
            {
                string message = "کیر";
                //MessageBox.Show(message, "اطلاع", MessageBoxButtons.OK, MessageBoxIcon.Asterisk,
                //   MessageBoxDefaultButton.Button1,
                //    MessageBoxOptions.RtlReading);
                var db = DBManager.datacontext;
                var assets = Asset.getByName(SelectAsset.Text).ToArray();
                if (assets.Length > 0)
                    asset = assets[0];
                treeView1.Nodes.Clear();
                var temp = new AssetNode(asset);
                temp.MakeTree();
                treeView1.Nodes.Add(temp);
                
            }
        }

       
    }
}
