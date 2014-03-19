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

        private void textBox1_Load(object sender, EventArgs e)
        {
            FormLoad.SetAutoComplete(textBox1, DBManager.datacontext.Assets);
        }
        private void SelectAsset_TextChanged(object sender, EventArgs e)
        {

        }

        private void SelectAsset_Enter(object sender, EventArgs e)
        {

            
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            FormLoad.Refresh(RmAssetCombox, ((AssetNode)treeView1.SelectedNode).asset.subAssets.ToArray());
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
                var assets = Asset.GetByName(SelectAsset.Text).ToArray();
                if (assets.Length > 0)
                    asset = assets[0];
                MakeTreeView();
                
            }
        }
        private void  MakeTreeView()
        {
            treeView1.Nodes.Clear();
            if (asset != null)
            {
                var temp = new AssetNode(asset);
                temp.MakeTree();
                treeView1.Nodes.Add(temp);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            var selected_subasset = (Asset)RmAssetCombox.SelectedItem;
            var tempasset = ((AssetNode)treeView1.SelectedNode);
          
            if (selected_subasset != null && tempasset != null)
            {
                tempasset.asset.RemoveSubAsset(selected_subasset);
                DBManager.datacontext.SaveChanges();
                MakeTreeView();
            }
            
            
            
        }

        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            (((AssetNode)e.Node.Parent).asset).RemoveSubAsset(((AssetNode)e.Node).asset);
            DBManager.datacontext.SaveChanges();
            MakeTreeView();
        }

        private void AddSubasset_Click(object sender, EventArgs e)
        {
            var assets = Asset.GetByName(textBox1.Text).ToArray();
            Asset childasset;
            if (assets.Length == 0)
                return;
            childasset = assets[0];
            var parentasset = ((AssetNode)treeView1.SelectedNode);
            if (parentasset != null) 
            {
                
                parentasset.asset.AddSubAsset(childasset);
                DBManager.datacontext.SaveChanges();
                MakeTreeView();
            }



        }

       
    }
}
