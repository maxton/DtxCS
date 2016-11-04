namespace DTAView
{
  partial class MainForm
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.replInput = new System.Windows.Forms.TextBox();
      this.replOutput = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // textBox1
      // 
      this.textBox1.AllowDrop = true;
      this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.textBox1.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.textBox1.Location = new System.Drawing.Point(12, 12);
      this.textBox1.Multiline = true;
      this.textBox1.Name = "textBox1";
      this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.textBox1.Size = new System.Drawing.Size(489, 336);
      this.textBox1.TabIndex = 0;
      this.textBox1.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBox1_DragDrop);
      this.textBox1.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
      // 
      // replInput
      // 
      this.replInput.Location = new System.Drawing.Point(12, 641);
      this.replInput.Name = "replInput";
      this.replInput.Size = new System.Drawing.Size(489, 20);
      this.replInput.TabIndex = 1;
      this.replInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.replInput_KeyPress);
      // 
      // replOutput
      // 
      this.replOutput.AllowDrop = true;
      this.replOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.replOutput.Location = new System.Drawing.Point(12, 428);
      this.replOutput.Multiline = true;
      this.replOutput.Name = "replOutput";
      this.replOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.replOutput.Size = new System.Drawing.Size(489, 207);
      this.replOutput.TabIndex = 2;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(13, 409);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(35, 13);
      this.label1.TabIndex = 3;
      this.label1.Text = "REPL";
      // 
      // MainForm
      // 
      this.AllowDrop = true;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(513, 700);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.replOutput);
      this.Controls.Add(this.replInput);
      this.Controls.Add(this.textBox1);
      this.Name = "MainForm";
      this.Text = "Form1";
      this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.TextBox replInput;
    private System.Windows.Forms.TextBox replOutput;
    private System.Windows.Forms.Label label1;
  }
}

