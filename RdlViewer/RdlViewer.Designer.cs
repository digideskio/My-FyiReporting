using System;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using System.Collections;

namespace fyiReporting.RdlViewer
{
	public partial class RdlViewer
	{
		#region Windows Form Designer generated code

private ToolTip _vScrollToolTip;
private PageDrawing _DrawPanel;
private Button _RunButton;
private PictureBox _WarningButton;
private ScrollableControl _ParameterPanel;
private RdlViewerFind _FindCtl;

		
		#endregion
private HScrollBar _hScroll;
private VScrollBar _vScroll;


private void InitializeComponent()
{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RdlViewer));
            this._RunButton = new System.Windows.Forms.Button();
            this._hScroll = new System.Windows.Forms.HScrollBar();
            this._vScroll = new System.Windows.Forms.VScrollBar();
            this._DrawPanel = new fyiReporting.RdlViewer.PageDrawing();
            this.SuspendLayout();
            // 
            // _RunButton
            // 
            resources.ApplyResources(this._RunButton, "_RunButton");
            this._RunButton.Name = "_RunButton";
            this._RunButton.UseVisualStyleBackColor = true;
            this._RunButton.Click += new System.EventHandler(this.ParametersViewClick);
            // 
            // _hScroll
            // 
            resources.ApplyResources(this._hScroll, "_hScroll");
            this._hScroll.Name = "_hScroll";
            this._hScroll.Scroll += new System.Windows.Forms.ScrollEventHandler(this.HorizontalScroll);
            // 
            // _vScroll
            // 
            resources.ApplyResources(this._vScroll, "_vScroll");
            this._vScroll.Name = "_vScroll";
            this._vScroll.Scroll += new System.Windows.Forms.ScrollEventHandler(this.VerticalScroll);
            // 
            // _DrawPanel
            // 
            this._DrawPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this._DrawPanel, "_DrawPanel");
            this._DrawPanel.Name = "_DrawPanel";
            this._DrawPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawPanelPaint);
            this._DrawPanel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DrawPanelKeyDown);
            this._DrawPanel.Resize += new System.EventHandler(this.DrawPanelResize);
            // 
            // RdlViewer
            // 
            this.Controls.Add(this._vScroll);
            this.Controls.Add(this._hScroll);
            this.Controls.Add(this._RunButton);
            this.Controls.Add(this._DrawPanel);
            this.Name = "RdlViewer";
            resources.ApplyResources(this, "$this");
            this.ResumeLayout(false);

}
private IContainer components;
		
	}
}
