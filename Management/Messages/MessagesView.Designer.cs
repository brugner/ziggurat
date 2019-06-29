namespace Management.Messages
{
   partial class MessagesView
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
			this.components = new System.ComponentModel.Container();
			DevExpress.Utils.SuperToolTip superToolTip3 = new DevExpress.Utils.SuperToolTip();
			DevExpress.Utils.ToolTipTitleItem toolTipTitleItem3 = new DevExpress.Utils.ToolTipTitleItem();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessagesView));
			DevExpress.Utils.ToolTipItem toolTipItem3 = new DevExpress.Utils.ToolTipItem();
			this.gridControlMessages = new DevExpress.XtraGrid.GridControl();
			this.gridViewMessages = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.gridColumnMessageId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumnMessageRecipientsNames = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumnMessageBody = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumnMessageDateTime = new DevExpress.XtraGrid.Columns.GridColumn();
			this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
			this.bbiPrintPreview = new DevExpress.XtraBars.BarButtonItem();
			this.barButtonNewMessage = new DevExpress.XtraBars.BarButtonItem();
			this.lbCopyright = new DevExpress.XtraBars.BarStaticItem();
			this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
			this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
			this.defaultLookAndFeel = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
			((System.ComponentModel.ISupportInitialize)(this.gridControlMessages)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridViewMessages)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
			this.SuspendLayout();
			// 
			// gridControlMessages
			// 
			this.gridControlMessages.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gridControlMessages.Location = new System.Drawing.Point(0, 146);
			this.gridControlMessages.MainView = this.gridViewMessages;
			this.gridControlMessages.MenuManager = this.ribbonControl;
			this.gridControlMessages.Name = "gridControlMessages";
			this.gridControlMessages.Size = new System.Drawing.Size(790, 453);
			this.gridControlMessages.TabIndex = 2;
			this.gridControlMessages.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewMessages});
			// 
			// gridViewMessages
			// 
			this.gridViewMessages.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.gridViewMessages.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnMessageId,
            this.gridColumnMessageRecipientsNames,
            this.gridColumnMessageBody,
            this.gridColumnMessageDateTime});
			this.gridViewMessages.GridControl = this.gridControlMessages;
			this.gridViewMessages.Name = "gridViewMessages";
			this.gridViewMessages.OptionsBehavior.Editable = false;
			this.gridViewMessages.OptionsBehavior.ReadOnly = true;
			this.gridViewMessages.OptionsFind.AlwaysVisible = true;
			this.gridViewMessages.OptionsFind.FindNullPrompt = "Escribe para buscar..";
			this.gridViewMessages.OptionsFind.ShowClearButton = false;
			this.gridViewMessages.OptionsFind.ShowCloseButton = false;
			this.gridViewMessages.OptionsFind.ShowFindButton = false;
			this.gridViewMessages.DoubleClick += new System.EventHandler(this.gridViewMessages_DoubleClick);
			// 
			// gridColumnMessageId
			// 
			this.gridColumnMessageId.Caption = "Id";
			this.gridColumnMessageId.FieldName = "Id";
			this.gridColumnMessageId.Name = "gridColumnMessageId";
			// 
			// gridColumnMessageRecipientsNames
			// 
			this.gridColumnMessageRecipientsNames.Caption = "Destinatarios";
			this.gridColumnMessageRecipientsNames.FieldName = "RecipientsNames";
			this.gridColumnMessageRecipientsNames.Name = "gridColumnMessageRecipientsNames";
			this.gridColumnMessageRecipientsNames.OptionsColumn.AllowEdit = false;
			this.gridColumnMessageRecipientsNames.OptionsColumn.AllowFocus = false;
			this.gridColumnMessageRecipientsNames.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
			this.gridColumnMessageRecipientsNames.OptionsColumn.ReadOnly = true;
			this.gridColumnMessageRecipientsNames.Visible = true;
			this.gridColumnMessageRecipientsNames.VisibleIndex = 0;
			// 
			// gridColumnMessageBody
			// 
			this.gridColumnMessageBody.Caption = "Mensaje";
			this.gridColumnMessageBody.FieldName = "Body";
			this.gridColumnMessageBody.Name = "gridColumnMessageBody";
			this.gridColumnMessageBody.OptionsColumn.AllowEdit = false;
			this.gridColumnMessageBody.OptionsColumn.AllowFocus = false;
			this.gridColumnMessageBody.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
			this.gridColumnMessageBody.OptionsColumn.ReadOnly = true;
			this.gridColumnMessageBody.Visible = true;
			this.gridColumnMessageBody.VisibleIndex = 1;
			// 
			// gridColumnMessageDateTime
			// 
			this.gridColumnMessageDateTime.Caption = "Enviado";
			this.gridColumnMessageDateTime.DisplayFormat.FormatString = "dd/MM/yyyy hh:mm";
			this.gridColumnMessageDateTime.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
			this.gridColumnMessageDateTime.FieldName = "Date";
			this.gridColumnMessageDateTime.Name = "gridColumnMessageDateTime";
			this.gridColumnMessageDateTime.OptionsColumn.AllowEdit = false;
			this.gridColumnMessageDateTime.OptionsColumn.AllowFocus = false;
			this.gridColumnMessageDateTime.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
			this.gridColumnMessageDateTime.OptionsColumn.ReadOnly = true;
			this.gridColumnMessageDateTime.Visible = true;
			this.gridColumnMessageDateTime.VisibleIndex = 2;
			// 
			// ribbonControl
			// 
			this.ribbonControl.ExpandCollapseItem.Id = 0;
			this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl.ExpandCollapseItem,
            this.bbiPrintPreview,
            this.barButtonNewMessage,
            this.lbCopyright});
			this.ribbonControl.Location = new System.Drawing.Point(0, 0);
			this.ribbonControl.MaxItemId = 21;
			this.ribbonControl.Name = "ribbonControl";
			this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
			this.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
			this.ribbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
			this.ribbonControl.Size = new System.Drawing.Size(790, 146);
			this.ribbonControl.StatusBar = this.ribbonStatusBar;
			this.ribbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
			// 
			// bbiPrintPreview
			// 
			this.bbiPrintPreview.Caption = "Print Preview";
			this.bbiPrintPreview.Id = 14;
			this.bbiPrintPreview.ImageOptions.ImageUri.Uri = "Preview";
			this.bbiPrintPreview.Name = "bbiPrintPreview";
			// 
			// barButtonNewMessage
			// 
			this.barButtonNewMessage.Caption = "Nuevo mensaje";
			this.barButtonNewMessage.Id = 16;
			this.barButtonNewMessage.ImageOptions.Image = global::Management.Properties.Resources.mail_32x321;
			this.barButtonNewMessage.Name = "barButtonNewMessage";
			this.barButtonNewMessage.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
			toolTipTitleItem3.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
			toolTipTitleItem3.Appearance.Options.UseImage = true;
			toolTipTitleItem3.Image = ((System.Drawing.Image)(resources.GetObject("toolTipTitleItem3.Image")));
			toolTipTitleItem3.Text = "Nuevo mensaje";
			toolTipItem3.LeftIndent = 6;
			toolTipItem3.Text = "Envía un mensaje a uno o más miembros.";
			superToolTip3.Items.Add(toolTipTitleItem3);
			superToolTip3.Items.Add(toolTipItem3);
			this.barButtonNewMessage.SuperTip = superToolTip3;
			this.barButtonNewMessage.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonNewMessage_ItemClick);
			// 
			// lbCopyright
			// 
			this.lbCopyright.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
			this.lbCopyright.Caption = "copyright";
			this.lbCopyright.Id = 20;
			this.lbCopyright.Name = "lbCopyright";
			// 
			// ribbonPage1
			// 
			this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
			this.ribbonPage1.KeyTip = "G";
			this.ribbonPage1.MergeOrder = 0;
			this.ribbonPage1.Name = "ribbonPage1";
			this.ribbonPage1.Text = "GENERAL";
			// 
			// ribbonPageGroup1
			// 
			this.ribbonPageGroup1.AllowTextClipping = false;
			this.ribbonPageGroup1.ItemLinks.Add(this.barButtonNewMessage, "N");
			this.ribbonPageGroup1.Name = "ribbonPageGroup1";
			this.ribbonPageGroup1.ShowCaptionButton = false;
			// 
			// ribbonStatusBar
			// 
			this.ribbonStatusBar.ItemLinks.Add(this.lbCopyright);
			this.ribbonStatusBar.Location = new System.Drawing.Point(0, 578);
			this.ribbonStatusBar.Name = "ribbonStatusBar";
			this.ribbonStatusBar.Ribbon = this.ribbonControl;
			this.ribbonStatusBar.Size = new System.Drawing.Size(790, 21);
			// 
			// defaultLookAndFeel
			// 
			this.defaultLookAndFeel.LookAndFeel.SkinName = "Office 2016 Colorful";
			// 
			// MessagesView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(790, 599);
			this.Controls.Add(this.ribbonStatusBar);
			this.Controls.Add(this.gridControlMessages);
			this.Controls.Add(this.ribbonControl);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MessagesView";
			this.Ribbon = this.ribbonControl;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.StatusBar = this.ribbonStatusBar;
			this.Text = "Mensajes";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.MessagesView_Load);
			((System.ComponentModel.ISupportInitialize)(this.gridControlMessages)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridViewMessages)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

      }

      #endregion
      private DevExpress.XtraGrid.GridControl gridControlMessages;
      private DevExpress.XtraGrid.Views.Grid.GridView gridViewMessages;
      private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
      private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
      private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
      private DevExpress.XtraBars.BarButtonItem bbiPrintPreview;
      private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
      private DevExpress.XtraBars.BarButtonItem barButtonNewMessage;
      private DevExpress.XtraBars.BarStaticItem lbCopyright;
      private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel;
      private DevExpress.XtraGrid.Columns.GridColumn gridColumnMessageId;
      private DevExpress.XtraGrid.Columns.GridColumn gridColumnMessageRecipientsNames;
      private DevExpress.XtraGrid.Columns.GridColumn gridColumnMessageBody;
      private DevExpress.XtraGrid.Columns.GridColumn gridColumnMessageDateTime;
   }
}