using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using ShaniSoft.Drawing;

namespace PGMTester
{
	/// <summary>
	/// Summary description for frmPNM.
	/// </summary>
	public class frmPNM : System.Windows.Forms.Form
	{
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem miFileOpen;
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.MenuItem menuItem5;
		private System.Windows.Forms.MenuItem miViewStreched;
		private System.Windows.Forms.MenuItem miViewNormal;
		private System.Windows.Forms.MenuItem miViewAuto;
		private System.Windows.Forms.MenuItem miViewCenter;
		private System.Windows.Forms.MenuItem miFileExit;
		private System.Windows.Forms.MenuItem miFileSaveAs;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmPNM()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.miFileOpen = new System.Windows.Forms.MenuItem();
			this.miFileSaveAs = new System.Windows.Forms.MenuItem();
			this.menuItem3 = new System.Windows.Forms.MenuItem();
			this.miFileExit = new System.Windows.Forms.MenuItem();
			this.menuItem5 = new System.Windows.Forms.MenuItem();
			this.miViewCenter = new System.Windows.Forms.MenuItem();
			this.miViewAuto = new System.Windows.Forms.MenuItem();
			this.miViewStreched = new System.Windows.Forms.MenuItem();
			this.miViewNormal = new System.Windows.Forms.MenuItem();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.SuspendLayout();
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.Filter = "PNM Files|*.p?m|Windows Bitmap|*.bmp|Graphics Interchange Format|*.gif|JPEG|*.jp*" +
				"|Portable Network Graphics|*. png";
			this.openFileDialog1.FilterIndex = 0;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox1.Location = new System.Drawing.Point(0, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(288, 277);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// mainMenu1
			// 
			this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem1,
																					  this.menuItem5});
			// 
			// menuItem1
			// 
			this.menuItem1.Index = 0;
			this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.miFileOpen,
																					  this.miFileSaveAs,
																					  this.menuItem3,
																					  this.miFileExit});
			this.menuItem1.Text = "&File";
			// 
			// miFileOpen
			// 
			this.miFileOpen.Index = 0;
			this.miFileOpen.Text = "&Open";
			this.miFileOpen.Click += new System.EventHandler(this.miFileOpen_Click);
			// 
			// miFileSaveAs
			// 
			this.miFileSaveAs.Index = 1;
			this.miFileSaveAs.Text = "&Save As";
			this.miFileSaveAs.Click += new System.EventHandler(this.miFileSaveAs_Click);
			// 
			// menuItem3
			// 
			this.menuItem3.Index = 2;
			this.menuItem3.Text = "-";
			// 
			// miFileExit
			// 
			this.miFileExit.Index = 3;
			this.miFileExit.Text = "E&xit";
			this.miFileExit.Click += new System.EventHandler(this.miFileExit_Click);
			// 
			// menuItem5
			// 
			this.menuItem5.Index = 1;
			this.menuItem5.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.miViewCenter,
																					  this.miViewAuto,
																					  this.miViewStreched,
																					  this.miViewNormal});
			this.menuItem5.Text = "&View";
			// 
			// miViewCenter
			// 
			this.miViewCenter.Index = 0;
			this.miViewCenter.RadioCheck = true;
			this.miViewCenter.Text = "&Center";
			this.miViewCenter.Click += new System.EventHandler(this.miViewCenter_Click);
			// 
			// miViewAuto
			// 
			this.miViewAuto.Index = 1;
			this.miViewAuto.RadioCheck = true;
			this.miViewAuto.Text = "&Auto Size";
			this.miViewAuto.Click += new System.EventHandler(this.miViewAuto_Click);
			// 
			// miViewStreched
			// 
			this.miViewStreched.Checked = true;
			this.miViewStreched.Index = 2;
			this.miViewStreched.RadioCheck = true;
			this.miViewStreched.Text = "&Streched";
			this.miViewStreched.Click += new System.EventHandler(this.miViewStreched_Click);
			// 
			// miViewNormal
			// 
			this.miViewNormal.Index = 3;
			this.miViewNormal.RadioCheck = true;
			this.miViewNormal.Text = "&Normal";
			this.miViewNormal.Click += new System.EventHandler(this.miViewNormal_Click);
			// 
			// saveFileDialog1
			// 
			this.saveFileDialog1.DefaultExt = "bmp";
			this.saveFileDialog1.Filter = "PGM Files|*.pgm|PBM Files|*.pbm|PPM Files|*.ppm|Windows Bitmap|*.bmp|Graphics Int" +
				"erchange Format|*.gif|JPEG|*.jp*|Portable Network Graphics|*. png";
			// 
			// frmPGM
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(288, 277);
			this.Controls.Add(this.pictureBox1);
			this.Menu = this.mainMenu1;
			this.Name = "frmPGM";
			this.Text = "PGM Reader [TEST]";
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new frmPNM());
		}

		private void miFileOpen_Click(object sender, System.EventArgs e)
		{
			if(openFileDialog1.ShowDialog()==DialogResult.OK)
			{
				if(pictureBox1.Image!=null) pictureBox1.Image.Dispose();
				
				if(openFileDialog1.FilterIndex==1)
					pictureBox1.Image = ShaniSoft.Drawing.PNM.ReadPNM(openFileDialog1.FileName);
				else
					pictureBox1.Image = new Bitmap(openFileDialog1.FileName);

				pictureBox1.Refresh();
			}
		}

		private void miFileExit_Click(object sender, System.EventArgs e)
		{
			Application.Exit();
		}

		private void UnCheckAll()
		{
			miViewAuto.Checked = false;
			miViewCenter.Checked = false;
			miViewNormal.Checked = false;
			miViewStreched.Checked = false;
		}

		private void miViewStreched_Click(object sender, System.EventArgs e)
		{
			UnCheckAll();
			miViewStreched.Checked = true;
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;			
		}

		private void miViewCenter_Click(object sender, System.EventArgs e)
		{
			UnCheckAll();
			miViewCenter.Checked = true;
			pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
		}

		private void miViewAuto_Click(object sender, System.EventArgs e)
		{
			UnCheckAll();
			miViewAuto.Checked = true;
			pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;		
		}

		private void miViewNormal_Click(object sender, System.EventArgs e)
		{
			UnCheckAll();
			miViewNormal.Checked = true;
			pictureBox1.SizeMode = PictureBoxSizeMode.Normal;		
		}

		private void miFileSaveAs_Click(object sender, System.EventArgs e)
		{
			if(pictureBox1.Image==null) return;

			if(saveFileDialog1.ShowDialog()==DialogResult.OK)
			{
				if(saveFileDialog1.FilterIndex<4)
				{					
					ShaniSoft.Drawing.PNM.WritePNM(saveFileDialog1.FileName, pictureBox1.Image);
				}
				else
				{
					pictureBox1.Image.Save(saveFileDialog1.FileName);
				}
			}
		}	
	}
}


