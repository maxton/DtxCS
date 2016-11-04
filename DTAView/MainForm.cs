using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DtxCS.DataTypes;
using System.IO;

namespace DTAView
{
  public partial class MainForm : Form
  {
    public MainForm()
    {
      InitializeComponent();
    }

    private void textBox1_DragDrop(object sender, DragEventArgs e)
    {
      DataArray d;
      string filename = ((string[])e.Data.GetData(DataFormats.FileDrop))[0];
      using (var s = new FileStream(filename, FileMode.Open))
      {
        d = DtxCS.DTX.FromDtb(s);
        s.Position = 0;
        var sb = new StringBuilder();
        foreach (var x in d.Children)
        {
          sb.AppendLine(x.ToString(0));
        }
        textBox1.Text = sb.ToString();
      }
    }

    private void Form1_DragEnter(object sender, DragEventArgs e)
    {
      if (e.Data.GetDataPresent(DataFormats.FileDrop))
        e.Effect = DragDropEffects.Copy; // Okay
      else
        e.Effect = DragDropEffects.None; // Unknown data, ignore it
    }

    private void replInput_KeyPress(object sender, KeyPressEventArgs e)
    {
      if(e.KeyChar == (char)Keys.Enter)
      {
        replOutput.AppendText(">>> " + replInput.Text + Environment.NewLine);
        try {
          var input = DtxCS.DTX.FromDtaString(replInput.Text);
          foreach (DtxCS.DataTypes.DataNode c in input.Children)
          {
            replOutput.AppendText(c.Evaluate().ToString() + Environment.NewLine);
          }
        }
        catch(Exception ex)
        {
          replOutput.AppendText(ex.Message + Environment.NewLine);
        }
        replOutput.ScrollToCaret();
        replInput.Clear();
      }
    }
  }
}